using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Consulta
    {
        public string Codigo { get; set; }
        public string Fecha { get; set; }
        public string Descripcion { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public string MascotaCodigo { get; set; }
        public string VeterinarioCedula { get; set; }
        public Consulta(){ }
    }
}
