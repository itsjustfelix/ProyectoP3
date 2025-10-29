using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Dato;
namespace Logica
{
    public class LogRaza : IServiceRaza
    {
        private readonly DatoRaza datoRaza;
        Random random;
        public LogRaza()
        {
            datoRaza = new DatoRaza(NombreArchivo.ARC_RAZA);
            random = new Random();
        }
        public string Guardar(Raza entidad)
        {
            try
            {
                string mensaje = string.Empty;
                if (Validar(entidad, out mensaje))
                {
                    entidad.Codigo = GenerarIdUnico();
                    mensaje = datoRaza.Guardar(entidad);
                }
                return mensaje;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Raza> Consultar()
        {
            return datoRaza.Consultar();
        }
        public string Actualizar(Raza NuevaEntidad)
        {
            try
            {
                string mensaje = string.Empty;
                if (Validar(NuevaEntidad, out mensaje))
                {
                    var listaRazas = Consultar();
                    int index = listaRazas.FindIndex(r => r.Codigo == NuevaEntidad.Codigo);
                    if (index == -1) throw new KeyNotFoundException("Raza no encontrada");
                    listaRazas[index] = NuevaEntidad;
                    mensaje = datoRaza.SobrescribirArchivo(listaRazas);
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
            var listaRazas = Consultar();
            int index = listaRazas.FindIndex(r => r.Codigo.Equals(id));
            if (index == -1) throw new KeyNotFoundException("Raza no encontrada");
            listaRazas.RemoveAt(index);
            return datoRaza.SobrescribirArchivo(listaRazas);
        }
        public string GenerarIdUnico()
        {
            string id;
            List<Raza> listRaza = Consultar();
            HashSet<string> idsExistentes = new HashSet<string>(listRaza.Select(m => m.Codigo));
            do
            {
                id = random.Next(1, 10000).ToString();
            } while (idsExistentes.Contains(id));
            return id;
        }
        public Raza BuscarPorId(string id)
        {
            return datoRaza.BuscarPorId(id);
        }
        public List<Raza> ConsultarPorEspecie(string idEspecie)
        {
            return Consultar().Where(r => r.Especie.Codigo.Equals(idEspecie)).ToList();
        }
        public bool Validar(Raza entidad, out string mensaje)
        {
            mensaje = string.Empty;
            if (entidad == null)
            {
                mensaje = "Raza nula";
                return false;
            }
            if (entidad.Especie == null)
            {
                mensaje = "Especie nula";
                return false;
            }
            if (entidad.Nombre.Any(char.IsDigit))
            {
                mensaje = "El nombre no puede contener numeros";
                return false;
            }
            //if (Consultar().Any(r => r.nombre.Equals(entidad.nombre) && r.especie.id.Equals(entidad.especie.id)))
            //    throw new ArgumentException("El nombre de la raza ya existe para la especie seleccionada");
            return true;
        }
    }
}
