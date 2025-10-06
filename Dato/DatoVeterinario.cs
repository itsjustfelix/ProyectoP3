using System.Collections.Generic;
using System.IO;
using System.Linq;
using Entidad;

namespace Dato
{
    public class DatoVeterinario : FileRepository<Veterinario>
    {
        DatoEspecializacion datoEspecializacion = new DatoEspecializacion(NombreArchivo.ARCHIVO_ESPECIALIZACION);
        public DatoVeterinario(string filePath) : base(filePath)
        {
            this.filePath = filePath;
        }
        public override List<Veterinario> Consultar()
        {
            List<Veterinario> lista = new List<Veterinario>();
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {
                    lista.Add(MappyingType(sr.ReadLine()));
                }
            }
            return lista;
        }
        public override Veterinario MappyingType(string line)
        {
            Veterinario veterinario = new Veterinario();
            veterinario.Cedula = int.Parse(line.Split(';')[0]);
            veterinario.Nombres = line.Split(';')[1];
            veterinario.ApellidoPaterno = line.Split(';')[2];
            veterinario.ApellidoMaterno = line.Split(';')[3];
            veterinario.Sexo = line.Split(';')[4];
            veterinario.TelefonoPrimario = line.Split(';')[5];
            veterinario.TelefonoSecundario = line.Split(';')[6];
            veterinario.Especializacion = datoEspecializacion.BuscarPorId(int.Parse(line.Split(';')[7]));
            return veterinario;
        }
        public Veterinario BuscarPorId(int id)
        {
            return Consultar().FirstOrDefault(p => p.Cedula == id);
        }
    }

}
