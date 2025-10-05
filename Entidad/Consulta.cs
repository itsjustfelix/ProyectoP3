using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Consulta
    {
        public int Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public Mascota Mascota { get; set; }
        public Veterinario Veterinario { get; set; }
        public Consulta(int id ,DateTime fecha,string diagnostico, string tratamiento, Mascota mascota, Veterinario veterinario)
        {
            this.Codigo = id;
            this.Fecha = fecha;
            this.Diagnostico = diagnostico;
            this.Tratamiento = tratamiento;
            this.Mascota = mascota;
            this.Veterinario = veterinario;
        }
        public Consulta(string diagnostico, string tratamiento, Mascota mascota, Veterinario veterinario)
        {
            this.Fecha = DateTime.Now.Date;
            this.Diagnostico = diagnostico;
            this.Tratamiento = tratamiento;
            this.Mascota = mascota;
            this.Veterinario = veterinario;
        }
        public Consulta(){ }
        public override string ToString()
        {
            return $"{Codigo};{Fecha.ToString("dd/MM/yyyy")};{Diagnostico};{Tratamiento};{Mascota.Codigo};{Veterinario.Cedula}";
        }
    }
}
