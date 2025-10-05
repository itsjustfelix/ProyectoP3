using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Cita
    {
        public int Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public Mascota Mascota { get; set; }

        public Cita() { }

        public override string ToString()
        {
            return $"{Codigo};{Fecha.ToString("dd/MM/yyyy")};{Hora.ToString("hh:mm tt", CultureInfo.InvariantCulture)};{Mascota.Codigo}";
        }
    }
}
