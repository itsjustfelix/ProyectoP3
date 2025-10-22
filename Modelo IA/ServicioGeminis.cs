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
        private string API_KEY;

        public ServicioGeminis(string API_KEY)
        {
            this.API_KEY = API_KEY;
        }
    }

    var gemini = new ServicioGeminis(Constantes.API_KEY);
    {
        private readonly GenerativeModel _modelo;
        private readonly List<Content> _historial = new List<Content>();

        public ServicioGeminis()
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
            string textoRespuesta = respuesta?.Candidates?.FirstOrDefault()? .Content?.Parts?.FirstOrDefault()?.Text ?? "No se recibió respuesta del modelo.";

            // Guardar respuesta del modelo en el historial
            _historial.Add(new Content
            {
                Role = "model",
                Parts = { new Part { Text = textoRespuesta } }
            });

            return textoRespuesta;
        }

        public async Task<string> GetResponseAsync(List<Mensaje> prompt)
        {
            throw new NotImplementedException();
        }
    }
}
