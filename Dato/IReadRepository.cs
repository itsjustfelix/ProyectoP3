using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dato
{
    public interface IReadRepository<T>
    {
        List<T> Consultar();
        T BuscarPorId(string id);
        T MappyingType(OracleDataReader line);
    }
}
