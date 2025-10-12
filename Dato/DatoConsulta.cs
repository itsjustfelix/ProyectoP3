using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
namespace Dato
{
    public class DatoConsulta : FileRepository<Consulta>
    {
        private FileRepository<Mascota> datoMascota = new DatoMascota(NombreArchivo.ARC_MASCOTA);
        private FileRepository<Veterinario> datoVeterinario = new DatoVeterinario(NombreArchivo.ARC_VETERINARIO);
        public DatoConsulta(string filePath) : base(filePath)
        {
            this.filePath = filePath;
        }
        public override List<Consulta> Consultar()
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                List<Consulta> lista = new List<Consulta>();

                while (!sr.EndOfStream)
                {
                    lista.Add(MappyingType(sr.ReadLine()));
                }
                return lista;
            }
        }
        public override Consulta MappyingType(string line)
        {
            Consulta consulta = new Consulta();
            consulta.Codigo = int.Parse(line.Split(';')[0]);
            consulta.Fecha = DateTime.ParseExact(line.Split(';')[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);
            consulta.Diagnostico = line.Split(';')[2];
            consulta.Tratamiento = line.Split(';')[3];
            consulta.Mascota = datoMascota.BuscarPorId(int.Parse(line.Split(';')[4]));
            consulta.Veterinario = datoVeterinario.BuscarPorId(int.Parse(line.Split(';')[5]));
            return consulta;
        }
        public override Consulta BuscarPorId(int id)
        {
            return Consultar().FirstOrDefault(c => c.Codigo == id);
        }

        
    }
}
