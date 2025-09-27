using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Raza
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public Especie especie { get; set; }

        public Raza(int id, string nombre, Especie especie)
        {
            this.id = id;
            this.nombre = nombre;
            this.especie = especie;
        }
        public Raza(string nombre, Especie especie)
        {
            this.nombre = nombre;
            this.especie = especie;
        }
        public Raza() { }
        public override string ToString()
        {
            return $"{id};{nombre};{especie.id}";
        }
    }
}
