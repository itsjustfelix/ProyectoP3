using Entidad;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dato
{
    public interface IDataEditRepository<T>
    {
        T ObtenerDatosParaEdicion(string id);
        T MappyingTypeEdicion(OracleDataReader linea);
    }
}
