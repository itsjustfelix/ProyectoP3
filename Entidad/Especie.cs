using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Especie
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; } 
        public Especie() { }
        public override string ToString()
        {
            return $"{Codigo}";
        }
    }
}
