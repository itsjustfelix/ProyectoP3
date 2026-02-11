using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class MascotaEdicionDTO
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string CodigoEspecie { get; set; }
        public string NombreEspecie { get; set; }
        public string CodigoRaza { get; set; }
        public string NombreRaza { get; set; }
        public string CedulaPropietario { get; set; }
        public string NombrePropietario { get; set; }
    }
}
