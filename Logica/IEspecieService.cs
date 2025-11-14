using System.Collections.Generic;
using Entidad;
namespace Logica
{
    public interface IEspecieService : ICrud<Especie>
    {
        List<Especie> BuscarPorNombre(string nombre);
    }
}
