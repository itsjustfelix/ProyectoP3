using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class TipoProducto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public TipoProducto() {}
        public TipoProducto(string nombre)
        {
            this.nombre = nombre;
        }
        public TipoProducto(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        public override string ToString()
        {
            return $"{id};{nombre}";
        }
    }
}
