using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Dato
{
    public class DatoRaza: FileRepository<Raza>
    {
        private DatoEspecie datoEspecie = new DatoEspecie(NombreArchivo.ARCHIVO_ESPECIE);
        public DatoRaza(string filePath) : base(filePath)
        {
            this.filePath = filePath;
        }
        public override List<Raza> Consultar()
        {
            List<Raza> lista = new List<Raza>();
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {
                    lista.Add(MappyingType(sr.ReadLine()));
                }
            }
            return lista;
        }
        public override Raza MappyingType(string line)
        {
            Raza raza = new Raza();
            raza.Codigo = int.Parse(line.Split(';')[0]);
            raza.Nombre = line.Split(';')[1];
            raza.Especie = datoEspecie.BuscarPorId(int.Parse(line.Split(';')[2]));
            return raza;
        }
        public Raza BuscarPorId(int id)
        {
            return Consultar().FirstOrDefault(r => r.Codigo == id);
        }
    }
}
