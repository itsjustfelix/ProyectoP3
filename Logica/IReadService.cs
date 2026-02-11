using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface IReadService<T>
    {
        List<T> Consultar();
        T buscar(string id);
    }
}
