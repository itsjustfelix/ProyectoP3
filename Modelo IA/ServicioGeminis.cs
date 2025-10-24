using GenerativeAI;
using GenerativeAI.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using Content = GenerativeAI.Types.Content;
using Part = GenerativeAI.Types.Part;
using UserRole= Modelo_IA.role;

namespace Modelo_IA
{
    public class ServicioGeminis
    {
        private readonly GenerativeModel _modelo;
        private readonly List<Content> _historial = new List<Content>();

        public ServicioGeminis()
        {
            // Usa la clave y modelo definidos en tu clase Constantes
            _modelo = new GenerativeModel(Constantes.MODEL_NAME, Constantes.API_KEY);
        }

        /// <summary>
        /// Envía un mensaje al modelo, guarda el historial y devuelve la respuesta.
        /// </summary>
        public async Task<string> EnviarMensajeAsync(string textoUsuario)
        {
            if (string.IsNullOrWhiteSpace(textoUsuario))
                return "Por favor, escribe una pregunta válida.";

            // Guardar el mensaje del usuario
            var userMessage = new Content
            {
                Role = "user",
                Parts = new List<Part>
                {
                    new Part { Text = textoUsuario }
                }
            };
            _historial.Add(userMessage);

            try
            {
                // Enviar mensaje al modelo
                // Enviar mensaje al modelo (usa una lista en lugar de un solo objeto)
                var request = new GenerateContentRequest
                {
                    Contents = new List<Content>
    {
        new Content
        {
            Role = "user",
            Parts = new List<Part>
            {
                new Part { Text = textoUsuario }
            }
        }
    }
                };

                var respuesta = await _modelo.GenerateContentAsync(request);



                // Extraer texto de la respuesta
                string textoRespuesta = respuesta?.Candidates?.FirstOrDefault()?.Content?.Parts?.FirstOrDefault()?.Text
                    ?? "No se recibió respuesta del modelo.";

                // Guardar respuesta en el historial
                var assistantMessage = new Content
                {
                    Role = "model",
                    Parts = new List<Part>
                    {
                        new Part { Text = textoRespuesta }
                    }
                };
                _historial.Add(assistantMessage);

                return textoRespuesta;
            }
            catch (Exception ex)
            {
                string detalle = ex.Message;
                if (ex.InnerException != null)
                    detalle += "\nDetalle interno: " + ex.InnerException.Message;
                return "Error al comunicarse con el modelo: " + detalle;
            }
        }

       
        /// Devuelve el historial de conversación.
        
        public List<Content> GetHistorial() => _historial;

        
        /// Versión sincronizada (usada por btnEnviar_Click)
        
        public string GetResponse(List<Mensaje> prompt)
        {
            try
            {
                if (prompt == null || prompt.Count == 0)
                    return "No se recibió ningún mensaje para procesar.";

                var ultimoMensaje = prompt.LastOrDefault(m => m.Role == role.User)?.Content;

                if (string.IsNullOrWhiteSpace(ultimoMensaje))
                    return "No se encontró un mensaje de usuario válido.";

                // Espera la respuesta sin bloquear
                var respuesta = EnviarMensajeAsync(ultimoMensaje).GetAwaiter().GetResult();

                return respuesta;
            }
            catch (Exception ex)
            {
                string detalle = ex.Message;
                if (ex.InnerException != null)
                    detalle += "\nDetalle interno: " + ex.InnerException.Message;
                return "Error al comunicarse con el modelo: " + detalle;
            }
        }

        public string GetResponse(object prompt)
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetResponseAsync(List<Mensaje> prompt)
        {
            try
            {
                if (prompt == null || prompt.Count == 0)
                    return "No se recibió ningún mensaje para procesar.";

                var ultimoMensaje = prompt.LastOrDefault(m => m.Role == role.User)?.Content;

                if (string.IsNullOrWhiteSpace(ultimoMensaje))
                    return "No se encontró un mensaje de usuario válido.";

                var respuesta = await EnviarMensajeAsync(ultimoMensaje);
                return respuesta;
            }
            catch (Exception ex)
            {
                string detalle = ex.Message;
                if (ex.InnerException != null)
                    detalle += "\nDetalle interno: " + ex.InnerException.Message;
                return "Error al comunicarse con el modelo: " + detalle;
            }
        }
    }
}

