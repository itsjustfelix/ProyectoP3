using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class RegistroVenta
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public decimal total { get; set; }

        public RegistroVenta(int id, decimal total)
        {
            this.id = id;
            this.fecha = DateTime.Now.Date;
            this.total = total;
        }
       

        public RegistroVenta() 
        {
            this.fecha = DateTime.Now.Date;
            this.total = 0;
        }


        public override string ToString()
        {
            return $"{id};{fecha.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)};{total}";
        }

        public void ActualizarTotal(List<Venta> listVenta)
        {
            this.total = 0;
            this.total = listVenta.Sum(v => v.total);
        }

    }
}
