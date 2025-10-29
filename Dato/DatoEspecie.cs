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
            especie.Codigo = line.Split(';')[0];
            especie.Nombre = line.Split(';')[1];
            return especie;
        }
        public override Especie BuscarPorId(string id)
        {
            return Consultar().FirstOrDefault(e => e.Codigo.Equals(id));
        }
    }
    
}
