using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Dato;

namespace Logica
{
    public class LogMascota : ICrud<Mascota>, IGenerarIdUnico
    {
        Random random;
        private readonly DatoMascota datoMascota;
        public LogMascota()
        {
            datoMascota = new DatoMascota(NombreArchivo.ARC_MASCOTA);
            random = new Random();
        }
        public string Guardar(Mascota entidad)
        {
            try
            {
                string mensaje = string.Empty;
                if (Validar(entidad, out mensaje))
                {
                    entidad.Codigo = GenerarIdUnico();
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
                    int index = listMascotas.FindIndex(m => m.Codigo == NuevaEntidad.Codigo);
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
        public string Borrar(string id)
        {
            var listMascotas = Consultar();
            int index = listMascotas.FindIndex(m => m.Codigo.Equals(id));
            if (index == -1) throw new ArgumentException("Mascota no encontrada.");
            listMascotas.RemoveAt(index);
            return datoMascota.SobrescribirArchivo(listMascotas);
        }
        public Mascota BuscarPorId(string id)
        {
            return datoMascota.BuscarPorId(id);
        }
        public string GenerarIdUnico()
        {
            string id;
            List<Mascota> mascotasExistentes = Consultar();
            HashSet<string> idsExistentes = new HashSet<string>(mascotasExistentes.Select(m => m.Codigo));
            do
            {
                id = random.Next(1, 10000).ToString();
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
            if (entidad.Propietario == null)
            {
                mensaje = "Propietario nulo";
                return false;
            }
            if (entidad.Especie == null)
            {
                mensaje = "Especie nula";
                return false;
            }
            if (entidad.Raza == null)
            {
                mensaje = "Raza nula";
                return false;
            }
            if (entidad.Nombre.Any(char.IsDigit))
            {
                mensaje = "El nombre de la mascota no puede contener numeros";
                return false;
            }
            return true;
        }

    }
}
