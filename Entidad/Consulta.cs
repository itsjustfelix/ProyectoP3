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
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public Mascota Mascota { get; set; }
        public Veterinario Veterinario { get; set; }
        public Consulta(){ }
        public override string ToString()
        {
            return $"{Codigo};{Fecha.ToString("dd/MM/yyyy")};{Descripcion};{Diagnostico};{Tratamiento};{Mascota.Codigo};{Veterinario.Cedula}";
        }
    }
}
