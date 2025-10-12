using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Dato
{
    public class DatoCita : FileRepository<Cita>
    {
        public DatoCita(string filePath) : base(filePath)
        {
            this.filePath = filePath;
        }

        public override Cita BuscarPorId(int id)
        {
            return Consultar().FirstOrDefault(c => c.Codigo == id);
        }

        public override List<Cita> Consultar()
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                List<Cita> lista = new List<Cita>();
                while (!sr.EndOfStream)
                {
                    lista.Add(MappyingType(sr.ReadLine()));
                }
                return lista;
            }
        }

        public override Cita MappyingType(string line)
        {
            Cita cita = new Cita();
            cita.Codigo = int.Parse(line.Split(';')[0]);
            cita.Fecha = DateTime.ParseExact(line.Split(';')[1], "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            cita.Hora = DateTime.ParseExact(line.Split(';')[2], "hh:mm tt", System.Globalization.CultureInfo.InvariantCulture);
            cita.Mascota = new DatoMascota(NombreArchivo.ARC_MASCOTA).BuscarPorId(int.Parse(line.Split(';')[3]));
            return cita;
        }
    }
}
