using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Dato;

namespace Logica
{
    public class LogMascota : IServiceEntidad<Mascota>
    {
        Random random = new Random();
        private readonly DatoMascota datoMascota = new DatoMascota(NombreArchivo.ARCHIVO_MASCOTA);
        public string Guardar(Mascota entidad)
        {
            try
            {
                string mensaje = string.Empty;
                if (Validar(entidad, out mensaje))
                {
                    entidad.id = GenerarIdUnico();
                    mensaje = datoMascota.Guardar(entidad);
                }
                return mensaje;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }



        }
        public List<Mascota> Consultar()
        {
            return datoMascota.Consultar();
        }
        public string Actualizar(Mascota NuevaEntidad)
        {
            try
            {
                string mensaje = string.Empty;
                if (Validar(NuevaEntidad, out mensaje))
                {
                    var listMascotas = Consultar();
                    int index = listMascotas.FindIndex(m => m.id == NuevaEntidad.id);
                    if (index == -1) throw new ArgumentException("Mascota no encontrada para actualizar.");
                    listMascotas[index] = NuevaEntidad;
                    mensaje = datoMascota.SobrescribirArchivo(listMascotas);
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
            var listMascotas = Consultar();
            int index = listMascotas.FindIndex(m => m.id == id);
            if (index == -1) throw new ArgumentException("Mascota no encontrada.");
            listMascotas.RemoveAt(index);
            return datoMascota.SobrescribirArchivo(listMascotas);
        }
        public Mascota BuscarPorId(int id)
        {
            return Consultar().FirstOrDefault(m => m.id == id);
        }
        public int GenerarIdUnico()
        {
            int id;
            List<Mascota> mascotasExistentes = Consultar();
            HashSet<int> idsExistentes = new HashSet<int>(mascotasExistentes.Select(m => m.id));
            do
            {
                id = random.Next(1, 10000);
            } while (idsExistentes.Contains(id));
            return id;
        }
        public bool Validar(Mascota entidad, out string mensaje)
        {
            mensaje = string.Empty;
            if (entidad == null)
            {
                mensaje = "Mascota nula";
                return false;
            } 
            if (entidad.propietario == null)
            {
                mensaje = "Propietario nulo";
                return false;
            }   
            if (entidad.especie == null)
            {
                mensaje = "Especie nula";
                return false;
            }   
            if (entidad.raza == null) 
            {
                mensaje = "Raza nula";
                return false;
            }   
            if (entidad.nombre.Any(char.IsDigit))
            {
                mensaje = "El nombre de la mascota no puede contener numeros";
                return false;
            }
            return true;
        }

    }
}
