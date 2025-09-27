using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Propietario:Persona
    {
        public Propietario() { }
        public Propietario(int Cedula, string Nombre, string Sexo, string Telefono): base(Cedula,Nombre, Sexo, Telefono)
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
