using System.Collections.Generic;
using Entidad;
namespace Logica
{
    public interface IVeterinarioService : IWriteService<Veterinario>,IReadService<VeterinarioDTO>, IDataEditService<VeterinarioEdicionDTO>
    {
        List<VeterinarioDTO> bsucarPorNombreEspecializacion(string nombreEspecializacion);
        int totalVeterinarios();
        List<VeterinarioDTO> buscarPorEspecializacion(string codigo);
        bool IdUnico(string id);
    }
}
