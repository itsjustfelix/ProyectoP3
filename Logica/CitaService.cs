using Dato;
using Entidad;
using System;
using System.Collections.Generic;

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
        public List<CitaDTO> Consultar()
        {
            return citaRepository.Consultar();
        }
        public bool Borrar(string codigo)
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
            if (entidad.MascotaCodigo == null) throw new Exception("La mascota no puede ser nula.");
            if (entidad.Fecha == null) throw new Exception("La fecha no puede ser nula.");
            if (entidad.Hora == null) throw new Exception("La hora no puede ser nula.");
            if (entidad.VeterinarioCedula == null) throw new Exception("El veterinario no puede ser nulo");
            DateTime horaDeseada = DateTime.Parse(entidad.Hora);
            //esta funcion debe esatar en base de datos
            //if (Consultar().Any(c =>
            //    c.Veterinario.Cedula.Equals(entidad.Veterinario.Cedula) &&
            //    c.Fecha.Equals(entidad.Fecha) &&
            //    DateTime.Parse(c.Hora) >= horaDeseada.AddMinutes(-15) &&
            //    DateTime.Parse(c.Hora) <= horaDeseada.AddMinutes(15))) throw new Exception("Ya existe una cita con ese veterinario en ese rango de horario (±15 minutos).");
            //if (Consultar().Any(c => c.Mascota.Codigo.Equals(entidad.Mascota.Codigo) &&
            //DateTime.Parse(c.Hora) >= horaDeseada.AddMinutes(-15) &&
            //    DateTime.Parse(c.Hora) <= horaDeseada.AddMinutes(15))) throw new Exception("La mascota ya tiene una cita en ese rango de horario (±15 minutos).");
            return true;
        }
        public CitaDTO buscar(string id)
        {
            return citaRepository.BuscarPorId(id);
        }
        public List<citasPorFechas> ObtenerCitasPorFechas()
        {
            return citaRepository.obtenerCitasPorFechas();
        }
        public List<CitaDTO> buscarPorVeterinarioMascota(string texto)
        {
            return Consultar().FindAll(c => c.NombreVeterinario.Trim().ToLower().Contains(texto) || c.NombreMascota.Trim().ToLower().Contains(texto));
        }
        public List<CitaDTO> buscarPorFecha(string fecha)
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
        public CitaEdicionDTO ObtenerDatosEdicion(string id)
        {
            return citaRepository.ObtenerDatosParaEdicion(id);
        }
        public string ObtenerCodigoMascotaPorCita(string codigoCita)
        {
            return citaRepository.ObtenerCodigoMascotaPorCita(codigoCita);
        }
        public string ObtenerCedulaVeterinarioPorCita(string codigoCita)
        {
            return citaRepository.ObtenerCedulaVeterinarioPorCita(codigoCita);
        }
    }
}
