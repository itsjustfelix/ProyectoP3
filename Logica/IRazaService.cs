using System.Collections.Generic;
using Entidad;

namespace Logica
{
    public interface IRazaService : ICrud<Raza>
    {
        List<Raza> BuscarPorNombre(string nombre);
        List<Raza> BuscarPorNombreEspecie(string nombre);
        List<Raza> BuscarPorEspecie(int codigo);
    }
}
