using System;
using System.Collections.Generic;
using System.Linq;
using Dato;
using Entidad;

namespace Logica
{
    public class CitaService : ICitaService
    {
        private readonly ICitaRepository citaRepository;
        public CitaService()
        {
            citaRepository = new DatoCita();
        }
        public bool Guardar(Cita entidad)
        {
            try
            {

                if (Validar(entidad))
                    return citaRepository.Guardar(entidad);
                else return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Cita> Consultar()
        {
            return citaRepository.Consultar();
        }
        public bool Borrar(int codigo)
        {
            return citaRepository.Eliminar(codigo);
        }
        public bool Actualizar(Cita NuevaEntidad)
        {
            try
            {
                if (Validar(NuevaEntidad))
                    return citaRepository.Actualizar(NuevaEntidad);
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
            if (entidad.Hora == null) throw new Exception("La hora no puede ser nula.");
            if (entidad.Veterinario == null) throw new Exception("El veterinario no puede ser nulo");
            DateTime horaDeseada = DateTime.Parse(entidad.Hora);
            bool hayConflicto = Consultar().Any(c =>
                c.Veterinario.Cedula.Equals(entidad.Veterinario.Cedula) &&
                c.Fecha.Equals(entidad.Fecha) &&
                DateTime.Parse(c.Hora) >= horaDeseada.AddMinutes(-15) && 
                DateTime.Parse(c.Hora) <= horaDeseada.AddMinutes(15)
            );
            if (hayConflicto)throw new Exception("Ya existe una cita con ese veterinario en ese rango de horario (±15 minutos).");
            
            return true;
        }
        public Cita buscar(int id)
        {
            return citaRepository.BuscarPorId(id);
        }
        public List<citasPorFechas> ObtenerCitasPorFechas()
        {
            return citaRepository.obtenerCitasPorFechas();
        }
        public List<Cita> buscarPorVeterinarioMascota(string texto)
        {
            return Consultar().FindAll(c => c.Veterinario.Nombres.Trim().ToLower().Contains(texto) || c.Mascota.Nombre.Trim().ToLower().Contains(texto));
        }
        public List<Cita> buscarPorFecha(string fecha)
        {
            return Consultar().FindAll(c => c.Fecha.Equals(fecha, StringComparison.OrdinalIgnoreCase));
        }
        public int totalCitasHoy(string fecha)
        {
            return Consultar().FindAll(c => c.Fecha.Equals(fecha, StringComparison.OrdinalIgnoreCase)).Count;
        }
        public int totalCitas()
        {
            return Consultar().Count;
        }
    }
}
