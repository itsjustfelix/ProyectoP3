using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dato;
using Entidad;
namespace Logica
{
    public class LogEspecie : ICrud<Especie>, IGenerarIdUnico
    {
        Random random;
        private readonly FileRepository<Especie> datoEspecie;
        public LogEspecie()
        {
            datoEspecie = new DatoEspecie(NombreArchivo.ARC_ESPECIE);
            random = new Random();
        }
        public string Guardar(Especie entidad)
        {
            try
            {
                string mensaje = string.Empty;
                if (Validar(entidad, out mensaje))
                {
                    entidad.Codigo = GenerarIdUnico();
                    mensaje = datoEspecie.Guardar(entidad);
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
                    int index = listaEspecies.FindIndex(e => e.Codigo == NuevaEntidad.Codigo);
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
        public string Borrar(string id)
        {
            var listaEspecies = Consultar();
            int index = listaEspecies.FindIndex(e => e.Codigo.Equals(id));
            if (index == -1) throw new KeyNotFoundException("Especie no encontrada");
            listaEspecies.RemoveAt(index);
            return datoEspecie.SobrescribirArchivo(listaEspecies);
        }
        public Especie BuscarPorId(string id)
        {
            return datoEspecie.BuscarPorId(id);
        }
        public string GenerarIdUnico()
        {
            string id;
            var especiesExistentes = Consultar();
            HashSet<string> idsExistentes = new HashSet<string>(especiesExistentes.Select(m => m.Codigo));
            do
            {
                id = random.Next(1, 10000).ToString();
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
            if (entidad.Nombre.Any(char.IsDigit))
            {
                mensaje = "El nombre no puede contener numeros";
                return false;
            }
            if (Consultar().Any(e => e.Nombre.Equals(entidad.Nombre, StringComparison.OrdinalIgnoreCase)
                    && e.Codigo != entidad.Codigo))
            {
                mensaje = "El nombre de la especie ya existe";
                return false;
            }
            return true;
        }
    }
}
