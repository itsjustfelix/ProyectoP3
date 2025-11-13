using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Persona
    {
        public int Cedula { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }

        public Persona() { }
        public override string ToString()
        {
            return $"{Cedula};{Nombres};{ApellidoPaterno};{ApellidoMaterno};{Sexo};{Telefono}";
        }
    }
}
