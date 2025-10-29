using System;
using System.Collections.Generic;
using System.Linq;
using Dato;
using Entidad;

namespace Logica
{
    public class LogCita : IServiceEntidad<Cita>
    {
        private Random random = new Random();
        private readonly DatoCita datoCita = new DatoCita(NombreArchivo.ARC_CITA);
        public string Guardar(Cita entidad)
        {
            try
            {
                string mensaje = string.Empty;
                if (Validar(entidad, out mensaje))
                {
                    entidad.Codigo = GenerarIdUnico();
                    mensaje = datoCita.Guardar(entidad);
                }
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
        public string Borrar(string id)
        {
            int index = Consultar().FindIndex(c => c.Codigo.Equals(id));
            if (index == -1) throw new KeyNotFoundException("Cita no encontrada");
            List<Cita> citas = Consultar();
            citas.RemoveAt(index);
            return datoCita.SobrescribirArchivo(citas);
        }

        public string Actualizar(Cita NuevaEntidad)
        {
            try
            {
                string mensaje = string.Empty;
                if (Validar(NuevaEntidad, out mensaje))
                {
                    int index = Consultar().FindIndex(c => c.Codigo == NuevaEntidad.Codigo);
                    if (index == -1) throw new KeyNotFoundException("Cita no encontrada");
                    List<Cita> citas = Consultar();
                    citas[index] = NuevaEntidad;
                    mensaje = datoCita.SobrescribirArchivo(citas);
                }
                return mensaje;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string GenerarIdUnico()
        {
            string id;
            List<Cita> consultasExistentes = Consultar();
            HashSet<string> idsExistentes = new HashSet<string>(consultasExistentes.Select(m => m.Codigo));
            do
            {
                id = random.Next(1000, 10000).ToString();
            }
            while (idsExistentes.Contains(id));
            return id;
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

        public Cita BuscarPorId(string id)
        {
            return datoCita.BuscarPorId(id);
        }
    }
}
