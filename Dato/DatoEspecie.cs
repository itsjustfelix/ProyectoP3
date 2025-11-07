using System;
using System.Collections.Generic;
using Entidad;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
namespace Dato
{
    public class DatoEspecie : IRepository<Especie>
    {
        public string Actualizar(Especie especie)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_ESPECIES.PRC_actualizar", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_codigo", OracleDbType.Int64).Value = especie.Codigo;
                        cmd.Parameters.Add("v_nombre", OracleDbType.Varchar2).Value = especie.Nombre;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return "Especie actualizada correctamente.";
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar especie: {ex.Message}", ex);
            }
        }

        public Especie BuscarPorId(int id)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_ESPECIES.FN_buscar_por_codigo", conn))
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
                throw new Exception($"Error al buscar especie: {ex.Message}", ex);
            }
        }

        public List<Especie> Consultar()
        {
            List<Especie> lista = new List<Especie>();

            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_ESPECIES.FN_consultar", conn))
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
                throw new Exception($"Error al obtener especies: {ex.Message}", ex);
            }
        }

        public string Eliminar(int id)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_ESPECIES.PRC_eliminar", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_codigo", OracleDbType.Int64).Value = id;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return "Especie eliminada correctamente.";
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar especie: {ex.Message}", ex);
            }
        }

        public string Guardar(Especie especie)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_ESPECIES.PRC_guardar", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_nombre", OracleDbType.Varchar2).Value = especie.Nombre;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return "Especie guardada correctamente.";
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al insertar especie: {ex.Message}", ex);


            }
        }

        public Especie MappyingType(OracleDataReader line)
        {
            Especie especie = new Especie();
            especie.Codigo = int.Parse(line["CODIGO"].ToString());
            especie.Nombre = line["NOMBRE"].ToString();
            return especie;
        }
    }

}
