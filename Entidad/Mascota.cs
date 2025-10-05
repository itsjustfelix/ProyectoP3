using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Mascota
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public Especie Especie { get; set; }
        public Raza Raza { get; set; }
        public Propietario Propietario { get; set; }
        public Mascota() { }
        public override string ToString()
        {
            return $"{Codigo};{Nombre};{Especie.Codigo};{Raza.Codigo};{Propietario.Cedula}";
        }

    }
}
