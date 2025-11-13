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
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public Mascota Mascota { get; set; }
        public Veterinario Veterinario { get; set; }

        public Cita() { }

    }
}
