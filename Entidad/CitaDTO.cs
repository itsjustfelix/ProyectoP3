using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class CitaDTO
    {
        public string Codigo { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string NombreMascota { get; set; }
        public string NombreVeterinario { get; set; }

        public CitaDTO() { }
    }
}
