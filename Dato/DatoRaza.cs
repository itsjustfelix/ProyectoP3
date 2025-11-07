using System;
using System.Collections.Generic;
using Entidad;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace Dato
{
    public class DatoRaza : IRepository<Raza>
    {
        IRepository<Especie> datoEspecie;
        public DatoRaza()
        {
            datoEspecie = new DatoEspecie();
        }

        public bool Guardar(Raza raza)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_RAZAS.PRC_guardar", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_nombre", OracleDbType.Varchar2).Value = raza.Nombre;
                        cmd.Parameters.Add("v_codigo_especie", OracleDbType.Int64).Value = raza.Especie.Codigo;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return true;// "Raza guardada correctamente.";
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al insertar raza: {ex.Message}", ex);
            }
        }

        public List<Raza> Consultar()
        {
            List<Raza> lista = new List<Raza>();

            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_RAZAS.FN_consultar", conn))
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
                throw new Exception($"Error al obtener razas: {ex.Message}", ex);
            }

        }

        public bool Actualizar(Raza raza)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_RAZAS.PRC_actualizar", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_codigo", OracleDbType.Int64).Value = raza.Codigo;
                        cmd.Parameters.Add("v_nombre", OracleDbType.Varchar2).Value = raza.Nombre;
                        cmd.Parameters.Add("v_codigo_especie", OracleDbType.Int64).Value = raza.Especie.Codigo;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return true;// "Raza actualizada correctamente.";
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar raza: {ex.Message}", ex);
            }
        }

        public bool Eliminar(int id)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_RAZAS.PRC_eliminar", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_codigo", OracleDbType.Int32).Value = id;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return true;//"Raza aliminada correctamente";
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar raza: {ex.Message}", ex);
            }
        }

        public Raza BuscarPorId(int id)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_RAZAS.FN_buscar_por_codigo", conn))
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
                throw new Exception($"Error al buscar raza: {ex.Message}", ex);
            }
        }

        public Raza MappyingType(OracleDataReader line)
        {
            Raza raza = new Raza();
            raza.Codigo = int.Parse(line["CODIGO"].ToString());
            raza.Nombre = line["NOMBRE"].ToString();
            raza.Especie = datoEspecie.BuscarPorId(int.Parse(line["CODIGO_ESPECIE"].ToString()));
            return raza;
        }

    }
}
