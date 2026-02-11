using Entidad;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
namespace Dato
{
    public class DatoConsulta :IDatoConsultaRepository
    {
        public bool Actualizar(Consulta consulta)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_CONSULTAS.PRC_actualizar", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_codigo", OracleDbType.Varchar2).Value = consulta.Codigo;
                        cmd.Parameters.Add("v_descripcion", OracleDbType.Varchar2).Value = consulta.Descripcion;
                        cmd.Parameters.Add("v_diagnostico", OracleDbType.Varchar2).Value = consulta.Diagnostico;
                        cmd.Parameters.Add("v_tratamiento", OracleDbType.Varchar2).Value = consulta.Tratamiento;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar consulta: {ex.Message}", ex);
            }
        }
        public ConsultaDTO BuscarPorId(string id)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_CONSULTAS.FN_buscar_por_codigo", conn))
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
                throw new Exception($"Error al buscar consulta: {ex.Message}", ex);
            }
        }
        public List<ConsultaDTO> Consultar()
        {
            List<ConsultaDTO> lista = new List<ConsultaDTO>();

            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_CONSULTAS.FN_consultar", conn))
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
                throw new Exception($"Error al obtener consultas: {ex.Message}", ex);
            }
        }
        public bool Eliminar(string id)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_CONSULTAS.PRC_eliminar", conn))
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
                throw new Exception($"Error al eliminar consulta: {ex.Message}", ex);
            }
        }
        public bool Guardar(Consulta consulta)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_CONSULTAS.PRC_guardar", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_fecha", OracleDbType.Varchar2).Value = consulta.Fecha;
                        cmd.Parameters.Add("v_descripcion", OracleDbType.Varchar2).Value = consulta.Descripcion;
                        cmd.Parameters.Add("v_diagnostico", OracleDbType.Varchar2).Value = consulta.Diagnostico;
                        cmd.Parameters.Add("v_tratamiento", OracleDbType.Varchar2).Value = consulta.Tratamiento;
                        cmd.Parameters.Add("v_codigo_mascota", OracleDbType.Varchar2).Value = consulta.MascotaCodigo;
                        cmd.Parameters.Add("v_cedula_veterinario", OracleDbType.Varchar2).Value = consulta.VeterinarioCedula;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al insertar consulta: {ex.Message}", ex);
            }
        }
        public ConsultaDTO MappyingType(OracleDataReader linea)
        {
            ConsultaDTO consultaDTO = new ConsultaDTO();
            consultaDTO.Codigo = linea["CODIGO"].ToString();
            consultaDTO.Fecha = linea["FECHA"].ToString();
            consultaDTO.Descripcion = linea["DESCRIPCION"].ToString();
            consultaDTO.Diagnostico = linea["DIAGNOSTICO"].ToString();
            consultaDTO.Tratamiento = linea["TRATAMIENTO"].ToString();
            consultaDTO.NombreMascota = linea["nombre_mascota"].ToString();
            consultaDTO.NombreVeterinario = linea["nombre_veterinario"].ToString();
            return consultaDTO;
        }
        public ConsultaEdicionDTO ObtenerDatosParaEdicion(string id)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_CONSULTAS.FN_consultar_consulta_edicion", conn))
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
                throw new Exception($"Error al obtener consultas: {ex.Message}", ex);
            }
        }
        public ConsultaEdicionDTO MappyingTypeEdicion(OracleDataReader reader)
        {
            return new ConsultaEdicionDTO
            {
                Codigo = reader["CODIGO"].ToString(),
                Descripcion = reader["DESCRIPCION"].ToString(),
                Diagnostico = reader["DIAGNOSTICO"].ToString(),
                Tratamiento = reader["TRATAMIENTO"].ToString(),
                NombreMascota = reader["nombre_mascota"].ToString(),
                NombreVeterinario = reader["nombre_veterinario"].ToString(),
                especializacionVeterinario = reader["nombre_especializacion"].ToString()
            };
        }

        public string ObtenerEmailPropietaio(string codigo)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_CONSULTAS.FN_Obtener_email_propietario", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("return_value", OracleDbType.Varchar2,200).Direction = System.Data.ParameterDirection.ReturnValue;
                        cmd.Parameters.Add("v_codigo", OracleDbType.Varchar2).Value = codigo;

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        return cmd.Parameters["return_value"].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al buscar consulta: {ex.Message}", ex);
            }
        }
    }
}
