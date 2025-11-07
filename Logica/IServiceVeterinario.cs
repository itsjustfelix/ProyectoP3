using Entidad;
namespace Logica
{
    public interface IServiceVeterinario : ICrud<Veterinario>, IBuscarPorCualidad<Veterinario>
    {
    }
}
