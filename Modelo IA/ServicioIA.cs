
using System;
using System.Collections.Generic;

using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Text.Json;


namespace Modelo_IA
{
    public class ServicioIA
    {
        private readonly string _apiKey;
        private readonly string _endpoint;
        private readonly string _deploymentName;
        private readonly HttpClient _httpClient;
        private readonly List<ChatMensaje> _historial = new List<ChatMensaje>();

        public ServicioIA()
        {
            _apiKey = Constante.API_KEY;
            _endpoint = Constante.ENDPOINT;
            _deploymentName = Constante.DEPLOYMENT;

            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("api-key", _apiKey);
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<string> EnviarMensajeAsync(string textoUsuario)
        {
            if (string.IsNullOrWhiteSpace(textoUsuario))
                return "Por favor, escribe una pregunta válida.";

            _historial.Add(new ChatMensaje("user", textoUsuario));

            try
            {
                var url = $"{_endpoint}openai/deployments/{_deploymentName}/chat/completions?api-version=2024-02-15-preview";

                var requestBody = new
                {
                    messages = _historial.Select(h => new { role = h.Role, content = h.Content }).ToList(),
                    temperature = 0.7
                };

                string json = JsonSerializer.Serialize(requestBody);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync(url, content);
                var responseText = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                    return $"Error: {response.StatusCode} - {responseText}";

                using (var doc = JsonDocument.Parse(responseText))
                {
                    var textoRespuesta = doc.RootElement
                        .GetProperty("choices")[0]
                        .GetProperty("message")
                        .GetProperty("content")
                        .GetString();

                    _historial.Add(new ChatMensaje("assistant", textoRespuesta));

                    return textoRespuesta ?? "No se recibió respuesta del modelo.";
                }
            }
            catch (Exception ex)
            {
                string detalle = ex.Message;
                if (ex.InnerException != null)
                    detalle += "\nDetalle interno: " + ex.InnerException.Message;
                return "Error al comunicarse con Azure OpenAI: " + detalle;
            }
        }

        public List<ChatMensaje> GetHistorial() => _historial;

        public async Task<string> GetResponseAsync(List<Mensaje> prompt)
        {
            if (prompt == null || prompt.Count == 0)
                return "No se recibió ningún mensaje para procesar.";

            var ultimoMensaje = prompt.LastOrDefault(m => m.Role == role.User)?.Content;
            if (string.IsNullOrWhiteSpace(ultimoMensaje))
                return "No se encontró un mensaje de usuario válido.";

            return await EnviarMensajeAsync(ultimoMensaje);
        }
    }

}
