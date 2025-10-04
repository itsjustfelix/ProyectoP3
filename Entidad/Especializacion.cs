using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Especializacion
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }

        public Especializacion() { } 
        public override string ToString()
        {
            return $"{Codigo};{Nombre}";
        }
    }
}
