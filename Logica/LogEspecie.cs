using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Dato;
namespace Logica
{
    public class LogEspecie : IService<Especie> , IGenerarIdUnico
    {
        Random random = new Random();
        private readonly DatoEspecie datoEspecie = new DatoEspecie(NombreArchivo.ARCHIVO_ESPECIE);
        public string Guardar(Especie entidad)
        {
            try
            {
                string mensaje = string.Empty;
                if (Validar(entidad, out mensaje))
                {
                    entidad.id = GenerarIdUnico();
                    datoEspecie.Guardar(entidad);
                    mensaje = "Especie guardada correctamente";
                }
                return mensaje;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public List<Especie> Consultar()
        {
            return datoEspecie.Consultar();
        }
        public string Actualizar(Especie NuevaEntidad)
        {
            try
            {
                string mensaje = string.Empty;
                if (Validar(NuevaEntidad, out mensaje))
                {
                    var listaEspecies = Consultar();
                    int index = listaEspecies.FindIndex(e => e.id == NuevaEntidad.id);
                    if (index == -1) throw new KeyNotFoundException("Especie no encontrada");
                    listaEspecies[index] = NuevaEntidad;
                    mensaje = datoEspecie.SobrescribirArchivo(listaEspecies);
                }
                return mensaje;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public string Borrar(int id)
        {
            var listaEspecies = Consultar();
            int index = listaEspecies.FindIndex(e => e.id == id);
            if (index == -1) throw new KeyNotFoundException("Especie no encontrada");
            listaEspecies.RemoveAt(index);
            return datoEspecie.SobrescribirArchivo(listaEspecies);
        }
        public Especie BuscarPorId(int id)
        {
            return Consultar().FirstOrDefault(e => e.id == id);
        }
        public int GenerarIdUnico()
        {
            int id;
            List<Especie> especiesExistentes = Consultar();
            HashSet<int> idsExistentes = new HashSet<int>(especiesExistentes.Select(m => m.id));
            do
            {
                id = random.Next(1, 10000);
            } while (idsExistentes.Contains(id));
            return id;
        }
        public bool Validar(Especie entidad, out string mensaje)
        {
            mensaje = string.Empty;
            if (entidad == null)
            {
                mensaje = "Especie nula";
                return false;
            }
            if (entidad.nombre.Any(char.IsDigit))
            {
                mensaje = "El nombre no puede contener numeros";
                return false;
            }
            //if (Consultar().Any(e => e.nombre.Equals(entidad.nombre, StringComparison.OrdinalIgnoreCase))) throw new ArgumentException("El nombre de la especie ya existe");
            return true;
        }
    }
}
