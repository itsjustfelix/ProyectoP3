using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Veterinario:Persona
    {
        public Especializacion Especializacion { get; set; }
        public Veterinario() { }
        public override string ToString()
        {
            return $"{Cedula}";
        }
    }
}
