using System.Collections.Generic;
using Entidad;
namespace Logica
{
    public interface IEspecieService : IReadService<Especie>,IWriteService<Especie>
    {
        List<Especie> BuscarPorNombre(string nombre);
    }
}
