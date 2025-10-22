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
            // Usa la clave y modelo desde tu clase Constantes
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
                Parts = { new Part { Text = textoUsuario } }
            };
            _historial.Add(userMessage);

            // Enviar la conversación completa al modelo
            var respuesta = await _modelo.GenerateContentAsync((IEnumerable<Part>)_historial);

            // Extraer texto de la respuesta
            string textoRespuesta = respuesta?.Candidates?.FirstOrDefault()?.Content?.Parts?.FirstOrDefault()?.Text
                ?? "No se recibió respuesta del modelo.";

            // Guardar la respuesta en el historial
            var assistantMessage = new Content
            {
                Role = "model",
                Parts = { new Part { Text = textoRespuesta } }
            };
            _historial.Add(assistantMessage);

            return textoRespuesta;
        }

        /// <summary>
        /// Devuelve todo el historial de mensajes (opcional).
        /// </summary>
        public List<Content> GetHistorial() => _historial;

        public string GetResponse(List<Mensaje> prompt)
        {
            throw new NotImplementedException();
        }
    }
}
