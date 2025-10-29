using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Dato
{
    public class DatoMascota : FileRepository<Mascota>
    {
        private DatoEspecie datoEspecie = new DatoEspecie(NombreArchivo.ARC_ESPECIE);
        private DatoRaza datoRaza = new DatoRaza(NombreArchivo.ARC_RAZA);
        private DatoPropietario datoPropietario = new DatoPropietario(NombreArchivo.ARC_PROPIETARIO);
        public DatoMascota(string filePath) : base(filePath)
        {
            this.filePath = filePath;
        }
        public override List<Mascota> Consultar()
        {
            List<Mascota> lista = new List<Mascota>();
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {
                    lista.Add(MappyingType(sr.ReadLine()));
                }
            }
            return lista;
        }
        public override Mascota MappyingType(string line)
        {
            Mascota mascota = new Mascota();
            mascota.Codigo = line.Split(';')[0];
            mascota.Nombre = line.Split(';')[1];
            mascota.Especie = datoEspecie.BuscarPorId(line.Split(';')[2]);
            mascota.Raza = datoRaza.BuscarPorId(line.Split(';')[3]);
            mascota.Propietario = datoPropietario.BuscarPorId(line.Split(';')[4]);
            return mascota;
        }
        public override Mascota BuscarPorId(string id)
        {
            return Consultar().FirstOrDefault(m => m.Codigo.Equals(id));
        }
    }
    
}
