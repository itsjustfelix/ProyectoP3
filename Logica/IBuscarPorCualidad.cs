using System.Collections.Generic;

namespace Logica
{
    public interface IBuscarPorCualidad<T>
    {
        List<T> BuscarPorCualidad(int cualidad);
    }
}
