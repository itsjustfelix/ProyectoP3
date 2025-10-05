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
        private readonly DatoRaza datoRaza = new DatoRaza(NombreArchivo.ARCHIVO_RAZA);
        Random random = new Random();
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
        public string Borrar(int id)
        {
            var listaRazas = Consultar();
            int index = listaRazas.FindIndex(r => r.Codigo == id);
            if (index == -1) throw new KeyNotFoundException("Raza no encontrada");
            listaRazas.RemoveAt(index);
            return datoRaza.SobrescribirArchivo(listaRazas);
        }
        public int GenerarIdUnico()
        {
            int id;
            List<Raza> listRaza = Consultar();
            HashSet<int> idsExistentes = new HashSet<int>(listRaza.Select(m => m.Codigo));
            do
            {
                id = random.Next(1, 10000);
            } while (idsExistentes.Contains(id));
            return id;
        }
        public Raza BuscarPorId(int id)
        {
            return Consultar().FirstOrDefault(r => r.Codigo == id);
        }
        public List<Raza> ConsultarPorEspecie(int idEspecie)
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
