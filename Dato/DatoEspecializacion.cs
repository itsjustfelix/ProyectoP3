using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Dato
{
    public class DatoEspecializacion : FileRepository<Especializacion>
    {
        public DatoEspecializacion(string filePath) : base(filePath)
        {
            this.filePath = filePath;
        }

        public override List<Especializacion> Consultar()
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                List<Especializacion> lista = new List<Especializacion>();

                while (!sr.EndOfStream)
                {
                    lista.Add(MappyingType(sr.ReadLine()));
                }
                return lista;
            }
        }

        public override Especializacion MappyingType(string line)
        {
            Especializacion especializacion = new Especializacion();
            especializacion.Codigo = int.Parse(line.Split(';')[0]);
            especializacion.Nombre = line.Split(';')[1];
            return especializacion;
        }

        public Especializacion BuscarPorId(int codigo)
        {
            return Consultar().FirstOrDefault(e => e.Codigo == codigo);
        }
    }
}
