using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;

namespace Dato
{
    public interface IRepository<T>
    {
        string Guardar(T objeto);
        List<T> Consultar();
        string Eliminar(int id);
        string Actualizar(T objeto);
        T BuscarPorId(int id);
        T MappyingType(OracleDataReader line);

    }
}
