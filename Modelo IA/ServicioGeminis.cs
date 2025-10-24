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


namespace Modelo_IA
{
    public class ServicioGeminis
    {
        private readonly GenerativeModel _modelo;
        private readonly List<Content> _historial = new List<Content>();

        public ServicioGeminis()
        {
            // Usa tu clase Constantes para definir el modelo y la API key
            _modelo = new GenerativeModel(Constantes.MODEL_NAME, Constantes.API_KEY);
        }

        public string GetRole()
{
    return Role.ToString();
}

        /// <summary>
        /// Envía un mensaje al modelo Gemini, guarda el historial y devuelve la respuesta.
        /// </summary>
        public async Task<string> EnviarMensajeAsync(string textoUsuario, string role)
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
                // Enviar la conversación completa al modelo
                var respuesta = await _modelo.GenerateContentAsync(new List<Content>
                {
                   {
                   Role = "user",   // <- CORRECCIÓN: Role con mayúscula
                     Parts = new List<Part>
                   {
                    new Part { Text = textoUsuario }
             }
               }
                });

                // Extraer texto de la respuesta
                string textoRespuesta = respuesta?.Candidates?.FirstOrDefault()?.Content?.Parts?.FirstOrDefault()?.Text
                    ?? "No se recibió respuesta del modelo.";

                // Guardar la respuesta del modelo en el historial
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

        /// <summary>
        /// Retorna el historial completo de conversación.
        /// </summary>
        public List<Content> GetHistorial() => _historial;

        /// <summary>
        /// Obtiene la respuesta del modelo usando una lista de mensajes (prompt).
        /// </summary>
        public async Task<string> GetResponseAsync(List<Mensaje> prompt)
        {
            try
            {
                var ultimoMensaje = prompt.LastOrDefault(m => m.Role == role.User)?.Content;

                if (string.IsNullOrWhiteSpace(ultimoMensaje))
                    return "No se encontró un mensaje de usuario válido.";

                // Espera el resultado de manera sincrónica
                var respuesta = EnviarMensajeAsync(ultimoMensaje, GetRole()).Result;

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
    }
}

