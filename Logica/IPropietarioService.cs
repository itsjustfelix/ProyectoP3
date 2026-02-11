using System.Collections.Generic;
using Entidad;

namespace Logica
{
    public interface IPropietarioService : IWriteService<Propietario>,IReadService<Propietario>
    {
        List<Propietario> BuscarPorCedula(string cedula);
        bool IdUnico(string id);
        List<Propietario> BuscarPorNombreApellido(string nombre);
    }
}
