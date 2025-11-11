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
        public bool Guardar(Cita entidad)
        {
            try
            {

                if (Validar(entidad))
                    return datoCita.Guardar(entidad);
                else return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Cita> Consultar()
        {
            return datoCita.Consultar();
        }
        public bool Borrar(int codigo)
        {
            return datoCita.Eliminar(codigo);
        }
        public bool Actualizar(Cita NuevaEntidad)
        {
            try
            {
                if (Validar(NuevaEntidad))
                    return datoCita.Actualizar(NuevaEntidad);
                else 
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Validar(Cita entidad)
        {
            if (entidad == null) throw new Exception("La cita no puede ser nula.");
            if (entidad.Mascota == null) throw new Exception("La mascota no puede ser nula.");
            if (entidad.Fecha == null) throw new Exception("La fecha no puede ser nula.");
            if (entidad.Hora == default) throw new Exception("La hora no puede ser nula.");
            return true;
        }
        public Cita BuscarPorId(int id)
        {
            return datoCita.BuscarPorId(id);
        }

        public List<citasPorFechas> ObtenerCitasPorFechas()
        {
            //esto lo tengo que arreglar despues
            DatoCita datoCita = new DatoCita();
            return datoCita.obtenerCitasPorFechas();
        }
    }
}
