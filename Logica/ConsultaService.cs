using System;
using System.Collections.Generic;
using System.IO;
using Dato;
using Entidad;
using GeneradorDeDocumento;
using QuestPDF.Infrastructure;

namespace Logica
{
    public class ConsultaService : ICrud<Consulta>
    {
        private readonly IRepository<Consulta> datoConsulta;
        private GeneradorDePDF<Consulta> generadorPDF;
        private ServicioEmail servicioEmail;
        public ConsultaService()
        {
            datoConsulta = new DatoConsulta();
            servicioEmail = new ServicioEmail("vet.vida03@gmail.com", "wyjv vikl acif boti");
            QuestPDF.Settings.License = LicenseType.Community;
        }

        public string Guardar(Consulta entidad)
        {
            try
            {
                string mensaje = string.Empty;
                if (Validar(entidad, out mensaje))
                    mensaje = datoConsulta.Guardar(entidad);

                return mensaje;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<Consulta> Consultar()
        {
            return datoConsulta.Consultar();
        }
        public string Actualizar(Consulta NuevaEntidad)
        {
            try
            {
                string mensaje = string.Empty;
                if (Validar(NuevaEntidad, out mensaje))
                    mensaje = datoConsulta.Actualizar(NuevaEntidad);

                return mensaje;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Borrar(int codigo)
        {
            return datoConsulta.Eliminar(codigo);
        }
        public Consulta BuscarPorId(int codigo)
        {
            return datoConsulta.BuscarPorId(codigo);
        }
        public bool Validar(Consulta entidad, out string mensaje)
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
            if (entidad.Veterinario == null)
            {
                mensaje = "El veterinario no puede ser nulo.";
                return false;
            }
            if (entidad.Fecha == default)
            {
                mensaje = "La fecha no puede ser vacia.";
                return false;
            }
            if (entidad.Diagnostico.Length == 0)
            {
                mensaje = "El diagnostico debe ser rellenado";
                return false;
            }
            if (entidad.Tratamiento.Length == 0)
            {
                mensaje = "El tratamiento debe ser rellenado";
                return false;
            }
            return true;
        }
        public string GenerarDocumento(Consulta entidad)
        {
            try
            {
                if (entidad == null) throw new ArgumentNullException("La entidad no puede ser nula.");
                string rutaLogo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imagenes", "logoProyecto.png");
                generadorPDF = new GeneradorDePDFConsultas("PDFGeneradorConsulta", rutaLogo, entidad);
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
    }
}
