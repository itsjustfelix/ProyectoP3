using GenerativeAI;
using Google.AI.GenerativeLanguage.V1Beta2;
using Google.Apis.Auth.OAuth2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Modelo_IA
{
    public class GeminiService
    {
        private string aPI_KEY;

        public GeminiService(string aPI_KEY)
        {
            this.aPI_KEY = aPI_KEY;
        }
    }

    var gemini = new GeminiService(Constantes.API_KEY);
    {
        private readonly GenerativeModel _modelo;
        private readonly List<Content> _historial = new List<Content>();

        public GeminiService()
        {
            // Usa la clave y modelo desde tu clase Constantes
            _modelo = new GenerativeModel(Constante.MODEL_NAME, Constante.API_KEY);
        }

        public object Constante { get; }

        /// <summary>
        /// Envía un mensaje al modelo, guarda el historial y devuelve la respuesta.
        /// </summary>
        public async Task<string> EnviarMensajeAsync(string textoUsuario)
        {
            if (string.IsNullOrWhiteSpace(textoUsuario))
                return "Por favor, escribe una pregunta válida.";

            // Agregar el mensaje del usuario al historial
            _historial.Add(new Content
            {
                Role = "user",
                Parts = { new Part { Text = textoUsuario } }
            });

            // Enviar al modelo el historial completo (para mantener el contexto)
            var respuesta = await _modelo.GenerateContentAsync(_historial);

            // Obtener texto de respuesta
            string textoRespuesta = respuesta?.Candidates?.FirstOrDefault()?
                                        .Content?.Parts?.FirstOrDefault()?.Text
                                    ?? "No se recibió respuesta del modelo.";

            // Guardar respuesta del modelo en el historial
            _historial.Add(new Content
            {
                Role = "model",
                Parts = { new Part { Text = textoRespuesta } }
            });

            return textoRespuesta;
        }
    }
}
