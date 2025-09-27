using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Especie
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public Especie(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        public Especie(string nombre)
        {
            this.nombre = nombre;
        }
        public Especie() { }
        public override string ToString()
        {
            return $"{id};{nombre}";
        }
    }
}
