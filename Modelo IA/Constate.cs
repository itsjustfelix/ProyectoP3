using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo_IA
{
    internal static class Constantes
    {
        // Si existe variable de entorno, úsala; si no, usa la de respaldo.
        public static string API_KEY => Environment.GetEnvironmentVariable("GEMINI_API_KEY") ?? "AIzaSyCE9FZh1MvE4b39xfJ1-LisUNaHKKQwiX8";

        public const string MODEL_NAME = "models/gemini-2.5-flash";
    }
}
