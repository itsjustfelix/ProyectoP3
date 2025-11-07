using System;
using System.Data;
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

        public static bool TestConnection()
        {
            try
            {
                using (OracleConnection conn = GetConnection())
                {
                    conn.Open();
                    return conn.State == ConnectionState.Open;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexión: " + ex.Message);
                return false;
            }
        }
    }
}
