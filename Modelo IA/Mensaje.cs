using System;
using GenerativeAI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_IA
{
    public enum role { System, User, Assistant, Model}

    public class Mensaje
    {
        public string content;
        public role Role { get; set; }
        public string Content { get; set; }
        public object Constante { get; }
        public Mensaje() { }    
        public Mensaje(role role, string contenido)
        {
            Role = role;
            Content = contenido ?? string.Empty;
        }
        public override string ToString()
        {
            return $"[{Role}] {Content}";
        }
       

    }
}