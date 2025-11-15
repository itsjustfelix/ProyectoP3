using System.Collections.Generic;

namespace Logica
{
    public interface ICrud<T>
    {
        bool Guardar(T entidad);
        List<T> Consultar();
        bool Actualizar(T NuevaEntidad);
        bool Borrar(int Id);
        bool Validar(T entidad);
        T BuscarPorId(int id);
    }
}
