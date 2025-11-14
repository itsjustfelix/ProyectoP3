using System.Collections.Generic;
using Entidad;
namespace Logica
{
    public interface IVeterinarioService : ICrud<Veterinario>
    {
        List<Veterinario> bsucarPorNombreEspecializacion(string nombreEspecializacion);
        int totalVeterinarios();
        List<Veterinario> buscarPorEspecializacion(int codigo);
        bool IdUnico(int id);
    }
}
