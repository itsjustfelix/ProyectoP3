using System.Collections.Generic;
using Entidad;

namespace Logica
{
    public interface IPropietarioService : ICrud<Propietario>
    {
        List<Propietario> BuscarPorCedula(int cedula);
        bool IdUnico(int id);
    }
}
