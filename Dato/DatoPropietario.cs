using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Dato
{
    public class DatoPropietario : FileRepository<Propietario>
    {
        public DatoPropietario(string filePath) : base(filePath)
        {
            this.filePath = filePath;
        }
        public override List<Propietario> Consultar()
        {
            List<Propietario> lista = new List<Propietario>();
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {
                    lista.Add(MappyingType(sr.ReadLine()));
                }
            }
            return lista;
        }
        public override Propietario MappyingType(string line)
        {
            Propietario propietario = new Propietario();
            propietario.Cedula = int.Parse(line.Split(';')[0]);
            propietario.Nombres = line.Split(';')[1];
            propietario.Sexo = line.Split(';')[2];
            propietario.TelefonoPrimario = line.Split(';')[3];
            return propietario;
        }
        public Propietario BuscarPorId(int id)
        {
           return Consultar().FirstOrDefault(p => p.Cedula == id);
        }
    }
}
