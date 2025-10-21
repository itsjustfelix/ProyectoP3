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

        public Role Role { get; set; }
        public string Content { get; set; }
        public object Constante { get; }
        public Mensaje(string role, string contenido)
        {
            Role = role;
            Contenido = contenido;
        }

    }
}