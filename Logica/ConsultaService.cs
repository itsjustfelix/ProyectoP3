using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Dato;
using Entidad;
using GeneradorDeDocumento;
using QuestPDF.Infrastructure;

namespace Logica
{
    public class ConsultaService : IConsultaService
    {
        private readonly IDatoConsultaRepository datoConsulta;
        private GeneradorDePDF<Consulta> generadorPDF;
        private ServicioEmail servicioEmail;
        public ConsultaService()
        {
            datoConsulta = new DatoConsulta();
            servicioEmail = new ServicioEmail("vet.vida03@gmail.com", "wyjv vikl acif boti");
            QuestPDF.Settings.License = LicenseType.Community;
        }

        public bool Guardar(Consulta entidad)
        {
            try
            {
                if (Validar(entidad))
                    return datoConsulta.Guardar(entidad);
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<ConsultaDTO> Consultar()
        {
            return datoConsulta.Consultar();
        }
        public bool Actualizar(Consulta NuevaEntidad)
        {
            try
            {
                //if (Validar(NuevaEntidad))
                    return datoConsulta.Actualizar(NuevaEntidad);
                //else
                //    return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool Borrar(string codigo)
        {
            return datoConsulta.Eliminar(codigo);
        }
        public ConsultaDTO buscar(string codigo)
        {
            return datoConsulta.BuscarPorId(codigo);
        }
        public bool Validar(Consulta entidad)
        {
            if (entidad == null) throw new Exception("La consulta no puede ser nula.");
            if (entidad.MascotaCodigo == null) throw new Exception("La mascota no puede ser nula.");
            if (entidad.VeterinarioCedula == null) throw new Exception("El veterinario no puede ser nulo.");
            if (entidad.Fecha == default) throw new Exception("La fecha no puede ser nula.");
            if (entidad.Descripcion.Length == 0) throw new Exception("La descripcion debe ser rellenada.");
            if (entidad.Diagnostico.Length == 0) throw new Exception("El diagnostico debe ser rellenado.");
            if (entidad.Tratamiento.Length == 0) throw new Exception("El tratamiento debe ser rellenado.");
            return true;
        }
        public string GenerarDocumento(ConsultaDTO entidad, byte[] logo)
        {
            try
            {
                if (entidad == null) throw new ArgumentNullException("La entidad no puede ser nula.");
                generadorPDF = new GeneradorDePDFConsultas("PDFGeneradorConsulta", entidad,logo);
                var ruta = generadorPDF.GenerarPDF();
                return ruta;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string enviarEmail(string email, string rutaDocumento)
        {
            try
            {
                if (string.IsNullOrEmpty(email)) throw new ArgumentNullException("El email no puede ser nulo o vacio.");
                if (string.IsNullOrEmpty(rutaDocumento)) throw new ArgumentNullException("La ruta del documento no puede ser nula o vacia.");
                return servicioEmail.EnviarEmail("Veterinaria MY VETAPP", "Se le adjuta el archivo de la consulta de su mascota", email, rutaDocumento);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public List<ConsultaDTO> buscarPorFecha(string fecha)
        {
            return Consultar().FindAll(c => c.Fecha.Equals(fecha, StringComparison.OrdinalIgnoreCase));
        }
        public List<ConsultaDTO> buscarPorVeterinarioMascota(string texto)
        {
            return Consultar().FindAll(c => c.NombreVeterinario.Trim().ToLower().Contains(texto) || c.NombreMascota.Trim().ToLower().Contains(texto));
        }
        public int totalConsultasAsistdas(string fecha)
        {
            return buscarPorFecha(fecha).Count;
        }

        public string ObtenerEmailPropietaio(string codigo)
        {
            return datoConsulta.ObtenerEmailPropietaio(codigo);
        }
    }
}
