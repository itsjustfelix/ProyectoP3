using System;
using GenerativeAI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo_IA;


namespace Modelo_IA
{
    public class GenerarMensajes
    {

        private const string SystemPrompt = @"Eres veterinario, un asistente veterinario virtual que brinda información general sobre medicamentos y salud de los animales. Responde de forma clara, empática y profesional. Nunca reemplaces el consejo de un veterinario.";

        public static List<Mensaje> BuildPrompt(List<Mensaje> history, string userInput)
        {
            Mensaje Mensajes = new Mensaje
            {
                Role = Role.System,
                Content = SystemPrompt
            };
            var prompt = new List<Mensaje>
        {
            Mensajes
        };

            prompt.AddRange(history);
            prompt.Add(NewMethod(userInput));

            return prompt;
        }

        private static Mensaje NewMethod(string userInput)
        {
            return new Mensaje { Role = Role.User, Content = userInput };
        }
    }
    

}

