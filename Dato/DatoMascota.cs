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
        private DatoEspecie datoEspecie = new DatoEspecie(NombreArchivo.ARCHIVO_ESPECIE);
        private DatoRaza datoRaza = new DatoRaza(NombreArchivo.ARCHIVO_RAZA);
        private DatoPropietario datoPropietario = new DatoPropietario(NombreArchivo.ARCHIVO_PROPIETARIO);
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
            mascota.Codigo = int.Parse(line.Split(';')[0]);
            mascota.Nombre = line.Split(';')[1];
            mascota.Especie = datoEspecie.BuscarPorId(int.Parse(line.Split(';')[2]));
            mascota.Raza = datoRaza.BuscarPorId(int.Parse(line.Split(';')[3]));
            mascota.Propietario = datoPropietario.BuscarPorId(int.Parse(line.Split(';')[4]));
            return mascota;
        }
        public Mascota BuscarPorId(int id)
        {
            return Consultar().FirstOrDefault(m => m.Codigo == id);
        }
    }
    
}
