using System.Collections.Generic;
using Entidad;

namespace Logica
{
    public interface IRazaService : IWriteService<Raza>,IReadService<RazaDTO>,IDataEditService<RazaEdicionDTO>
    {
        List<RazaDTO> BuscarPorNombre(string nombre);
        List<RazaDTO> BuscarPorNombreEspecie(string nombre);
        List<RazaDTO> BuscarPorEspecie(string codigo);
    }
}
