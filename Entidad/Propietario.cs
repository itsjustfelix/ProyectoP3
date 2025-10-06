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
        public override string ToString()
        {
            return $"{Cedula};{Nombres};{ApellidoPaterno};{ApellidoMaterno};{Sexo};{TelefonoPrimario};{TelefonoSecundario}";
        }
    }
}
