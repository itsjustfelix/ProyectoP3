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
        public string Codigo { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string MascotaCodigo { get; set; }
        public string VeterinarioCedula { get; set; }

        public Cita() { }

    }
}
