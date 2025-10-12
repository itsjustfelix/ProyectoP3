using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Dato;
namespace Logica
{
    public class logEspecializacion : IServiceEntidad<Especializacion>
    {
        Random random = new Random();
        private readonly FileRepository<Especializacion> datoEspecializacion = new DatoEspecializacion(NombreArchivo.ARC_ESPECIALIZACION);
        public string Guardar(Especializacion entidad)
        {
            try
            {
                string mensaje = string.Empty;
                if (Validar(entidad, out mensaje))
                {
                    entidad.Codigo = GenerarIdUnico();
                    mensaje = datoEspecializacion.Guardar(entidad);

                }
                return mensaje;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Especializacion> Consultar()
        {
            return datoEspecializacion.Consultar();
        }

        public string Actualizar(Especializacion NuevaEntidad)
        {
            try
            {
                string mensaje = string.Empty;
                if (Validar(NuevaEntidad, out mensaje))
                {
                    var listaEspecializaciones = Consultar();
                    int index = listaEspecializaciones.FindIndex(e => e.Codigo == NuevaEntidad.Codigo);
                    if (index == -1) throw new KeyNotFoundException("Especializacion no encontrada");
                    listaEspecializaciones[index] = NuevaEntidad;
                    mensaje = datoEspecializacion.SobrescribirArchivo(listaEspecializaciones);
                }
                return mensaje;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Borrar(int Id)
        {
            var listaEspecializaciones = Consultar();
            int index = listaEspecializaciones.FindIndex(e => e.Codigo == Id);
            if (index == -1) throw new KeyNotFoundException("Especializacion no encontrada");
            listaEspecializaciones.RemoveAt(index);
            return datoEspecializacion.SobrescribirArchivo(listaEspecializaciones);
        }

        public Especializacion BuscarPorId(int codigo)
        {
            return datoEspecializacion.BuscarPorId(codigo);
        }



        public int GenerarIdUnico()
        {
            int codigo;
            var listaEspecializaciones = Consultar();
            HashSet<int> codigosExistentes = new HashSet<int>(listaEspecializaciones.Select(e => e.Codigo));
            do
            {
                codigo = random.Next(1, 10000);
            } while (codigosExistentes.Contains(codigo));
            return codigo;
        }



        public bool Validar(Especializacion entidad, out string mensaje)
        {
            mensaje = string.Empty;
            if (entidad == null)
            {
                mensaje = "La especializacion no puede ser nula";
            }
            if(entidad.Nombre.Any(char.IsDigit))
            {
                mensaje = "El nombre no puede contener numeros";
                return false;
            }
            if (Consultar().Any(e => e.Nombre.Equals(entidad.Nombre, StringComparison.OrdinalIgnoreCase)
                   && e.Codigo != entidad.Codigo))
            {
                mensaje = "El nombre de la especializacion ya existe";
                return false;
            }
            return true;
        }
    }
}
