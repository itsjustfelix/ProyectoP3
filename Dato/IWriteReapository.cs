using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dato
{
    public interface IWriteReapository<T>
    {
        bool Guardar(T objeto);
        bool Eliminar(string id);
        bool Actualizar(T objeto);
    }
}
