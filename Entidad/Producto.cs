using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Producto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int stock { get; set; }
        public int stockMin { get; set; }
        public decimal precio { get; set; }
        public bool estado { get; set; }
        public TipoProducto tipoProducto { get; set; }

        public Producto(int id, string nombre, int stock, int stockMin, decimal precio, bool estado, TipoProducto tipoProducto)
        {
            this.id = id;
            this.nombre = nombre;
            this.stock = stock;
            this.stockMin = stockMin;
            this.precio = precio;
            this.estado = estado;
            this.tipoProducto = tipoProducto;
        }
        public Producto(string nombre, int stock, int stockMin, decimal precio, TipoProducto tipoProducto)
        {
            this.nombre = nombre;
            this.stock = stock;
            this.stockMin = stockMin;
            this.precio = precio;
            this.estado = true;
            this.tipoProducto = tipoProducto;
        }
        public Producto() { }
        public override string ToString()
        {
            return $"{id};{nombre};{stock};{stockMin};{precio};{estado};{tipoProducto.id}";
        }

        public void restarStock(int cantidad)
        {
            if (cantidad <= stock)
            {
                stock -= cantidad;
                if (stock == 0) cambiarEstado(false);
            }
            else
            {
                throw new InvalidOperationException("No hay suficiente stock para realizar la operación.");
            }
        }
        public void agregarStock(int cantidad)
        {
            if (cantidad > 0)
            {
                stock += cantidad;
                if (stock >= 1) cambiarEstado(true);
            }
            else
            {
                throw new ArgumentException("La cantidad a agregar debe ser mayor que cero.");
            }
        }

        public bool hayStockMin()
        {
            return stock > stockMin;//devuelve true si el stock es mayor que el stock mínimo
        }
        private void cambiarEstado(bool nuevoEstado)
        {
            estado = nuevoEstado;
        }

        public void cambiarEstado()
        {
            estado = !estado; // Cambia el estado del producto
        }
    }
}
