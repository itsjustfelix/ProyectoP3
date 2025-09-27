using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Consulta
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public string diagnostico { get; set; }
        public string tratamiento { get; set; }
        public Mascota mascota { get; set; }
        public Veterinario veterinario { get; set; }
        public Consulta(int id ,DateTime fecha,string diagnostico, string tratamiento, Mascota mascota, Veterinario veterinario)
        {
            this.id = id;
            this.fecha = fecha;
            this.diagnostico = diagnostico;
            this.tratamiento = tratamiento;
            this.mascota = mascota;
            this.veterinario = veterinario;
        }
        public Consulta(string diagnostico, string tratamiento, Mascota mascota, Veterinario veterinario)
        {
            this.fecha = DateTime.Now.Date;
            this.diagnostico = diagnostico;
            this.tratamiento = tratamiento;
            this.mascota = mascota;
            this.veterinario = veterinario;
        }
        public Consulta(){ }
        public override string ToString()
        {
            return $"{id};{fecha.ToString("dd/MM/yyyy")};{diagnostico};{tratamiento};{mascota.id};{veterinario.Cedula}";
        }
    }
}
