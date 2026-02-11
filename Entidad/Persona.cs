using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Persona
    {
        public string Cedula { get; set; }
        public string NombreCompleto { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }

        public Persona() { }
        public override string ToString()
        {
            return $"{Cedula};{NombreCompleto};{Sexo};{Telefono}";
        }
    }
}
