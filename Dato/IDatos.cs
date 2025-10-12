using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Dato
{
    public interface IDatos<T>
    {
        string Guardar(T objeto);
        List<T> Consultar();
        string SobrescribirArchivo(List<T> list);
        T BuscarPorId(int id);
       
    }
}
