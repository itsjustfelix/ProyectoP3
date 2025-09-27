using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Venta
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public int cantidad { get; set; }
        public decimal total { get; set; }
        public Producto producto { get; set; }

        public Venta()
        {
        }

        public Venta(int id,DateTime fecha,int cantidad, decimal precio, Producto producto)
        {
            this.id = id;
            this.fecha = fecha;
            this.cantidad = cantidad;
            this.total = precio;
            this.producto = producto;
        }
        public Venta(int cantidad, decimal precio, Producto producto)
        { 
            this.fecha = DateTime.Now.Date;
            this.cantidad = cantidad;
            this.total = precio;
            this.producto = producto;
        }
        public override string ToString()
        {
            return $"{id};{fecha.ToString("dd/MM/yyyy")};{cantidad};{total};{producto.id}";
        }
    }
}
