using GenerativeAI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_IA
{
     class TestGemini
    {
        static async Task Main()
        {
            var model = new GenerativeModel("AIzaSyDJavZdEQWX82YhMyYhoLj6ABKYFRVK7yU", "gemini-2.0-flash");
            var result = await model.GenerateContentAsync("Hola, ¿cómo estás?");
            Console.WriteLine(result.Text);
        }
    }

}
