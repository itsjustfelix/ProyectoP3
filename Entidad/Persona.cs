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
        public string Nombre { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }

        public Persona() { }

        public Persona(int Cedula, string Nombre, string Sexo, string Telefono)
        {
            this.Cedula = Cedula;
            this.Nombre = Nombre;
            this.Sexo = Sexo;
            this.Telefono = Telefono;
        }

        public override string ToString()
        {
            return $"{Cedula};{Nombre};{Sexo};{Telefono}";
        }
    }
}
