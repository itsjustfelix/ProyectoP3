using Entidad;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Dato
{
    public class DatoRaza : IRazaRepository
    {

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
                        cmd.Parameters.Add("v_codigo_especie", OracleDbType.Varchar2).Value = raza.EspecieCodigo;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al insertar raza: {ex.Message}", ex);
            }
        }
        public List<RazaDTO> Consultar()
        {
            List<RazaDTO> lista = new List<RazaDTO>();

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
                        cmd.Parameters.Add("v_codigo", OracleDbType.Varchar2).Value = raza.Codigo;
                        cmd.Parameters.Add("v_nombre", OracleDbType.Varchar2).Value = raza.Nombre;
                        cmd.Parameters.Add("v_codigo_especie", OracleDbType.Varchar2).Value = raza.EspecieCodigo;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar raza: {ex.Message}", ex);
            }
        }
        public bool Eliminar(string id)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_RAZAS.PRC_eliminar", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_codigo", OracleDbType.Varchar2).Value = id;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar raza: {ex.Message}", ex);
            }
        }
        public RazaDTO BuscarPorId(string id)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_RAZAS.FN_buscar_por_codigo", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("return_value", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.ReturnValue;
                        cmd.Parameters.Add("v_codigo", OracleDbType.Varchar2).Value = id;

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
        public RazaDTO MappyingType(OracleDataReader line)
        {
            RazaDTO razaDTO = new RazaDTO();
            razaDTO.Codigo = line["CODIGO"].ToString();
            razaDTO.Nombre = line["NOMBRE"].ToString();
            razaDTO.NombreEspecie = line["nombre_especie"].ToString();
            return razaDTO;
        }
        public RazaEdicionDTO ObtenerDatosParaEdicion(string id)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_RAZAS.FN_Consultar_raza_edicion", conn))
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
                                return MappyingTypeEdicion(reader);
                            }
                        }
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener razas: {ex.Message}", ex);
            }
        }
        public RazaEdicionDTO MappyingTypeEdicion(OracleDataReader linea)
        {
            return new RazaEdicionDTO
            {
                Codigo = linea["CODIGO"].ToString(),
                Nombre = linea["NOMBRE"].ToString(),
                CodigoEspecie = linea["CODIGO_ESPECIE"].ToString(),
                NombreEspecie = linea["NOMBRE_ESPECIE"].ToString()
            };
        }

        public List<RazaDTO> consultarRazasPorEspecie(string id)
        {
            List<RazaDTO> lista = new List<RazaDTO>();
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_RAZAS.FN_consultar_razas_por_especie", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("return_value", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.ReturnValue;
                        cmd.Parameters.Add("v_codigo_especie", OracleDbType.Varchar2).Value = id;

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
    }
}
