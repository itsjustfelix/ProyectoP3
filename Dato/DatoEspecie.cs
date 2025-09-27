using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
namespace Dato
{
    public class DatoEspecie: FileRepository<Especie>
    {
        public DatoEspecie(string filePath) : base(filePath)
        {
            this.filePath = filePath;
        }
        public override List<Especie> Consultar()
        {
            List<Especie> lista = new List<Especie>();
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {
                    lista.Add(MappyingType(sr.ReadLine()));
                }
            }
            return lista;
        }
        public override Especie MappyingType(string line)
        {
            Especie especie = new Especie();
            especie.id = int.Parse(line.Split(';')[0]);
            especie.nombre = line.Split(';')[1];
            return especie;
        }
        public Especie BuscarPorId(int id)
        {
            return Consultar().FirstOrDefault(e => e.id == id);
        }
    }
    
}
