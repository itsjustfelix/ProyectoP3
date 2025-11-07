using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;

namespace Dato
{
    public interface IRepository<T>
    {
        bool Guardar(T objeto);
        List<T> Consultar();
        bool Eliminar(int id);
        bool Actualizar(T objeto);
        T BuscarPorId(int id);
        T MappyingType(OracleDataReader line);

    }
}
