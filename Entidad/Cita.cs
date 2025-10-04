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
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public DateTime hora { get; set; }
        public Mascota mascota { get; set; }

        public Cita() { }

        public override string ToString()
        {
            return $"{id};{fecha.ToString("dd/MM/yyyy")};{hora.ToString("hh:mm tt", CultureInfo.InvariantCulture)};{mascota.id}";
        }
    }
}
