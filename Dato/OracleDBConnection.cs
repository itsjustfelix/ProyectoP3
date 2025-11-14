using System;
using Oracle.ManagedDataAccess.Client;

namespace Dato
{
    public class OracleDBConnection
    {
        public static OracleConnection GetConnection()
        {
            try
            {
                OracleConnection conn = new OracleConnection(configuracion.connectionString);
                return conn;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear la conexión: " + ex.Message);
            }
        }
    }
}
