using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface IServicePersonas<T> : ICrud<T>
    {
        bool IdUnico(string id);
    }

}
