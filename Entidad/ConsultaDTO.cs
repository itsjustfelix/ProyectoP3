using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class ConsultaDTO
    {
        public string Codigo { get; set; }
        public string Fecha { get; set; }
        public string Descripcion { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public string NombreMascota { get; set; }
        public string NombreVeterinario { get; set; }

        public ConsultaDTO() { }
    }
}
