using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Raza
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public Especie Especie { get; set; } 
        public Raza() { }
        public override string ToString()
        {
            return $"{Codigo};{Nombre};{Especie.Codigo}";
        }
    }
}
