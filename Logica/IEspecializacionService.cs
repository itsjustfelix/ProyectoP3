using System.Collections.Generic;
using Entidad;
namespace Logica
{
    public interface IEspecializacionService : ICrud<Especializacion>
    {
        List<Especializacion> BuscarPorNombre(string nombre);
    }
}
