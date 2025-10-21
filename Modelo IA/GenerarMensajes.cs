using System;
using GenerativeAI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_IA
{
    public class GenerarMensajes
    {

        private const string SystemPrompt = @"Eres veterinario, un asistente veterinario virtual que brinda información general sobre medicamentos y salud de los animales. Responde de forma clara, empática y profesional. Nunca reemplaces el consejo de un veterpnario.";

        public static List<Mensaje> BuildPrompt(List<Mensaje> history, string userInput)
        {
            var prompt = new List<Mensaje>
        {
            new Mensaje { Role = Role.System, Content = SystemPrompt
           }
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

