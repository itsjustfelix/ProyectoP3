using System;
using System.IO;
using System.Net.Mail;

namespace GeneradorDeDocumento
{
    public class ServicioEmail
    {
        private readonly string correoOrigen;
        private readonly string contaseñaOrigen;
        private readonly SmtpClient _smtpClient;

        public ServicioEmail(string correoOrigen, string contaseñaOrigen)
        {
            if (string.IsNullOrWhiteSpace(correoOrigen)) throw new ArgumentException("El correo emisor no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(contaseñaOrigen)) throw new ArgumentException("La contraseña no puede estar vacía.");
            this.correoOrigen = correoOrigen;
            this.contaseñaOrigen = contaseñaOrigen;
            _smtpClient = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new System.Net.NetworkCredential(correoOrigen, contaseñaOrigen),
                EnableSsl = true
            };
        }
        public string EnviarEmail(string asunto, string cuerpo, string correoDestino, string rutaArchivoAdjunto)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(rutaArchivoAdjunto)) throw new ArgumentException("El path del archivo no puede estar vacío.");
                if (!File.Exists(rutaArchivoAdjunto)) throw new FileNotFoundException("El archivo no existe en la ruta especificada.");
                if (string.IsNullOrWhiteSpace(correoDestino)) throw new ArgumentException("El correo destino no puede estar vacío.");
                MailMessage mail = new MailMessage(correoOrigen, correoDestino, asunto, cuerpo);
                Attachment attachment = new Attachment(rutaArchivoAdjunto);
                mail.Attachments.Add(attachment);
                mail.IsBodyHtml = true;
                _smtpClient.EnableSsl = true;
                _smtpClient.UseDefaultCredentials = false;
                _smtpClient.Credentials = new System.Net.NetworkCredential(correoOrigen, contaseñaOrigen);
                _smtpClient.Send(mail);
                return "Correo enviado correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

    }
}
