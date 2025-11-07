using System;
using System.Collections.Generic;
using System.Linq;
using Dato;
using Entidad;

namespace Logica
{
    public class MascotaService : ICrud<Mascota>
    {
        private readonly IRepository<Mascota> datoMascota;
        public MascotaService()
        {
            datoMascota = new DatoMascota();
        }
        public string Guardar(Mascota entidad)
        {
            try
            {
                string mensaje = string.Empty;
                if (Validar(entidad, out mensaje))
                    mensaje = datoMascota.Guardar(entidad);

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
                    mensaje = datoMascota.Actualizar(NuevaEntidad);

                return mensaje;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Borrar(int codigo)
        {
            return datoMascota.Eliminar(codigo);
        }
        public Mascota BuscarPorId(int id)
        {
            return datoMascota.BuscarPorId(id);
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
