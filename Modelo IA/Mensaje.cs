using System;
using GenerativeAI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_IA
{
    public enum Role { System, User, Assistant }

    public class Mensaje
    {
        private string content;

        public Role Role { get; set; }
        public string Content { get; set; }
        public object Constante { get; }

        public Mensaje(Role role, string contenido)
        {
            Role = role;
            
            Content = content ?? string.Empty;

        }
        public override string ToString()
        {
            return $"[{Role}] {Content}";
        }
       

    }
}