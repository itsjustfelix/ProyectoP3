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
        private DatoMascota datoMascota = new DatoMascota(NombreArchivo.ARCHIVO_MASCOTA);
        private DatoVeterinario datoVeterinario = new DatoVeterinario(NombreArchivo.ARCHIVO_VETERINARIO);
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
            consulta.id = int.Parse(line.Split(';')[0]);
            consulta.fecha = DateTime.ParseExact(line.Split(';')[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);
            consulta.diagnostico = line.Split(';')[2];
            consulta.tratamiento = line.Split(';')[3];
            consulta.mascota = datoMascota.BuscarPorId(int.Parse(line.Split(';')[4]));
            consulta.veterinario = datoVeterinario.BuscarPorId(int.Parse(line.Split(';')[5]));
            return consulta;
        }
        public Consulta BuscarPorId(int id)
        {
            return Consultar().FirstOrDefault(c => c.id == id);
        }
    }
}
