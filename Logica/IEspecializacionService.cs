using System.Collections.Generic;
using Entidad;
namespace Logica
{
    public interface IEspecializacionService : IWriteService<Especializacion>, IReadService<Especializacion>
    {
        List<Especializacion> BuscarPorNombre(string nombre);
    }
}
