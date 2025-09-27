using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Mascota
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public Especie especie { get; set; }
        public Raza raza { get; set; }
        public Propietario propietario { get; set; }
        public Mascota(int id, string nombre, Especie especie, Raza raza, Propietario propietario)
        {
            this.id = id;
            this.nombre = nombre;
            this.especie = especie;
            this.raza = raza;
            this.propietario = propietario;
        }
        public Mascota(string nombre, Especie especie, Raza raza, Propietario propietario)
        {
            this.nombre = nombre;
            this.especie = especie;
            this.raza = raza;
            this.propietario = propietario;
        }
        public Mascota() { }
        public override string ToString()
        {
            return $"{id};{nombre};{especie.id};{raza.id};{propietario.Cedula}";
        }

    }
}
