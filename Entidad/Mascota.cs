using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Mascota
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string EspecieCodigo { get; set; }
        public string RazaCodigo { get; set; }
        public string PropietarioCedula { get; set; }
        public Mascota() { }
        public override string ToString()
        {
            return $"{Codigo}";
        }

    }
}
