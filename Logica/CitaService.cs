using System;
using System.Collections.Generic;
using Dato;
using Entidad;

namespace Logica
{
    public class CitaService : ICrud<Cita>
    {
        private readonly IRepository<Cita> datoCita = new DatoCita();
        public CitaService()
        {
            datoCita = new DatoCita();
        }
        public string Guardar(Cita entidad)
        {
            try
            {
                string mensaje = string.Empty;
                if (Validar(entidad, out mensaje))
                    mensaje = datoCita.Guardar(entidad);
                return mensaje;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Cita> Consultar()
        {
            return datoCita.Consultar();
        }
        public string Borrar(int codigo)
        {
            return datoCita.Eliminar(codigo);
        }
        public string Actualizar(Cita NuevaEntidad)
        {
            try
            {
                string mensaje = string.Empty;
                if (Validar(NuevaEntidad, out mensaje))
                    mensaje = datoCita.Actualizar(NuevaEntidad);
                return mensaje;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public bool Validar(Cita entidad, out string mensaje)
        {
            mensaje = string.Empty;
            if (entidad == null)
            {
                mensaje = "La entidad no puede ser nula.";
                return false;
            }
            if (entidad.Mascota == null)
            {
                mensaje = "La mascota no puede ser nula.";
                return false;
            }
            if (entidad.Fecha == default)
            {
                mensaje = "La fecha no puede ser vacía.";
                return false;
            }
            if (entidad.Hora == default)
            {
                mensaje = "La hora no puede ser vacía.";
                return false;
            }
            return true;
        }
        public Cita BuscarPorId(int id)
        {
            return datoCita.BuscarPorId(id);
        }
    }
}
