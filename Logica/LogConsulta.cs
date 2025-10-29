using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Dato;
using Entidad;
using GeneradorDeDocumento;
using QuestPDF.Infrastructure;
using static System.Net.Mime.MediaTypeNames;

namespace Logica
{
    public class LogConsulta : IServiceEntidad<Consulta>
    {
        private readonly FileRepository<Consulta> datoConsulta;
        private GeneradorDePDF<Consulta> generadorPDF;
        private ServicioEmail servicioEmail;
        private Random random;

        public LogConsulta()
        {
            datoConsulta = new DatoConsulta(NombreArchivo.ARC_CONSULTA);
            servicioEmail = new ServicioEmail("vet.vida03@gmail.com", "wyjv vikl acif boti");
            random = new Random();
            QuestPDF.Settings.License = LicenseType.Community;
        }
        public string Guardar(Consulta entidad)
        {
            try
            {
                string mensaje = string.Empty;
                if (Validar(entidad, out mensaje))
                {
                    entidad.Codigo = GenerarIdUnico();
                    mensaje = datoConsulta.Guardar(entidad);

                }
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
                {
                    var listaConsultas = Consultar();
                    int index = listaConsultas.FindIndex(c => c.Codigo == NuevaEntidad.Codigo);
                    if (index == -1) throw new KeyNotFoundException("Consulta no encontrada");
                    listaConsultas[index] = NuevaEntidad;
                    mensaje = datoConsulta.SobrescribirArchivo(listaConsultas);
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
            var listaConsultas = Consultar();
            int index = listaConsultas.FindIndex(c => c.Codigo.Equals(id));
            if (index == -1) throw new KeyNotFoundException("Consulta no encontrada");
            listaConsultas.RemoveAt(index);
            return datoConsulta.SobrescribirArchivo(listaConsultas);
        }
        public string GenerarIdUnico()
        {
            string id;
            List<Consulta> consultasExistentes = Consultar();
            HashSet<string> idsExistentes = new HashSet<string>(consultasExistentes.Select(m => m.Codigo));
            do
            {
                id = random.Next(1000, 10000).ToString();
            }
            while (idsExistentes.Contains(id));
            return id;
        }
        public Consulta BuscarPorId(string id)
        {
            return datoConsulta.BuscarPorId(id);
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
