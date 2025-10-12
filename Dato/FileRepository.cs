using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Dato
{
    public abstract class FileRepository<T> : IDatos<T>
    {
        protected string filePath;
        public FileRepository(string filePath)
        {
            this.filePath = filePath;
        }
        public string Guardar(T objeto)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine(objeto.ToString());
                }
                return "Guardado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public abstract List<T> Consultar();
        public abstract T MappyingType(string line);
        public string SobrescribirArchivo(List<T> list)
        {
            string rutaTemporal = "temp.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(rutaTemporal, false))
                {
                    foreach (var item in list)
                    {
                        sw.WriteLine(item.ToString());
                    }
                }

                File.Delete(filePath);
                File.Move(rutaTemporal, filePath);
                return "Cambios hecho correctamente";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public abstract T BuscarPorId(int id);
        
    }
}
