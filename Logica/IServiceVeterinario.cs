using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
namespace Logica
{
    public interface IServiceVeterinario : ICrud<Veterinario>,IBuscarPorCualidad<Veterinario>
    {
    }
}
