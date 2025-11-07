using System;
using System.Collections.Generic;
using Entidad;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace Dato
{
    public class DatoEspecializacion : IRepository<Especializacion>
    {
        public string Guardar(Especializacion especializacion)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_ESPECIALIZACIONES.PRC_guardar", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_nombre", OracleDbType.Varchar2).Value = especializacion.Nombre;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return "Especializacion guardada correctamente.";
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al insertar especialización: {ex.Message}", ex);
            }
        }

        public List<Especializacion> Consultar()
        {
            List<Especializacion> lista = new List<Especializacion>();

            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_ESPECIALIZACIONES.FN_consultar", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("return_value", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.ReturnValue;

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        OracleRefCursor refCursor = (OracleRefCursor)cmd.Parameters["return_value"].Value;
                        using (OracleDataReader reader = refCursor.GetDataReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(MappyingType(reader));
                            }
                        }
                    }
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener especializaciones: {ex.Message}", ex);
            }
        }

        public string Actualizar(Especializacion especializacion)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_ESPECIALIZACIONES.PRC_actualizar", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_codigo", OracleDbType.Int64).Value = especializacion.Codigo;
                        cmd.Parameters.Add("v_nombre", OracleDbType.Varchar2).Value = especializacion.Nombre;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return "Especializacion actualizada correctamente.";
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar especialización: {ex.Message}", ex);
            }
        }

        public string Eliminar(int id)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_ESPECIALIZACIONES.PRC_eliminar", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_codigo", OracleDbType.Int32).Value = id;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return "Especializacion eliminada correctamente.";
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar especialización: {ex.Message}", ex);
            }
        }
        public Especializacion BuscarPorId(int id)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_ESPECIALIZACIONES.FN_buscar_por_codigo", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("return_value", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.ReturnValue;
                        cmd.Parameters.Add("v_codigo", OracleDbType.Int64).Value = id;

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        OracleRefCursor refCursor = (OracleRefCursor)cmd.Parameters["return_value"].Value;
                        using (OracleDataReader reader = refCursor.GetDataReader())
                        {
                            if (reader.Read())
                            {
                                return MappyingType(reader);
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al buscar especialización: {ex.Message}", ex);
            }
        }

        public Especializacion MappyingType(OracleDataReader linea)
        {
            Especializacion especializacion = new Especializacion();
            especializacion.Codigo = int.Parse(linea["CODIGO"].ToString());
            especializacion.Nombre = linea["NOMBRE"].ToString();
            return especializacion;
        }
    }
}
