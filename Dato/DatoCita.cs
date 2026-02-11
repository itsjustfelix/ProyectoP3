using Entidad;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.Data;

namespace Dato
{
    public class DatoCita : ICitaRepository
    {
        public bool Actualizar(Cita cita)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_CITAS.PRC_actualizar", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_codigo", OracleDbType.Varchar2).Value = cita.Codigo;
                        cmd.Parameters.Add("v_fecha", OracleDbType.Varchar2).Value = cita.Fecha;
                        cmd.Parameters.Add("v_hora", OracleDbType.Varchar2).Value = cita.Hora;
                        cmd.Parameters.Add("v_codigo_mascota", OracleDbType.Varchar2).Value = cita.MascotaCodigo;
                        cmd.Parameters.Add("v_cedula_veterinario", OracleDbType.Varchar2).Value = cita.VeterinarioCedula;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar cita: {ex.Message}", ex);
            }
        }
        public CitaDTO BuscarPorId(string id)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_CITAS.FN_buscar_por_codigo", conn))
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
                throw new Exception($"Error al buscar cita: {ex.Message}", ex);
            }
        }
        public List<CitaDTO> Consultar()
        {
            List<CitaDTO> lista = new List<CitaDTO>();

            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_CITAS.FN_consultar", conn))
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
                throw new Exception($"Error al obtener citas: {ex.Message}", ex);
            }
        }
        public bool Eliminar(string id)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_CITAS.PRC_eliminar", conn))
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
                throw new Exception($"Error al eliminar cita: {ex.Message}", ex);
            }
        }
        public bool Guardar(Cita cita)
        {

            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_CITAS.PRC_guardar", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_fecha", OracleDbType.Varchar2).Value = cita.Fecha;
                        cmd.Parameters.Add("v_hora", OracleDbType.Varchar2).Value = cita.Hora;
                        cmd.Parameters.Add("v_codigo_mascota", OracleDbType.Varchar2).Value = cita.MascotaCodigo;
                        cmd.Parameters.Add("v_cedula_veterinario", OracleDbType.Varchar2).Value = cita.VeterinarioCedula;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al insertar cita: {ex.Message}", ex);
            }
        }
        public List<citasPorFechas> obtenerCitasPorFechas()
        {
            try
            {
                List<citasPorFechas> datos = new List<citasPorFechas>();

                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand("PKG_CITAS.FN_contar_citas_por_fecha", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("RETURN_VALUE", OracleDbType.RefCursor)
                                       .Direction = ParameterDirection.ReturnValue;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                datos.Add(new citasPorFechas
                                {
                                    cantidad = reader.GetInt32(reader.GetOrdinal("TOTAL")),
                                    fecha = reader["FECHA"].ToString()
                                });
                            }
                        }
                    }
                }

                return datos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las citas por fecha: " + ex.Message);
            }
        }
        public CitaDTO MappyingType(OracleDataReader linea)
        {
            CitaDTO citaDTO = new CitaDTO();
            citaDTO.Codigo = linea["CODIGO"].ToString();
            citaDTO.Fecha = linea["FECHA"].ToString();
            citaDTO.Hora = linea["HORA"].ToString();
            citaDTO.NombreMascota = linea["nombre_mascota"].ToString();
            citaDTO.NombreVeterinario = linea["nombre_veterinario"].ToString();
            return citaDTO;
        }

        public CitaEdicionDTO ObtenerDatosParaEdicion(string id)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_CITAS.FN_Consultar_cita_edicion", conn))
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
                                return MappyingTypeEdicion(reader);
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener datos para edición de cita: {ex.Message}", ex);
            }
        }

        public CitaEdicionDTO MappyingTypeEdicion(OracleDataReader linea)
        {
            return new CitaEdicionDTO
            {
                Codigo = linea["CODIGO"].ToString(),
                Fecha = linea["FECHA"].ToString(),
                Hora = linea["HORA"].ToString(),
                CodigoMascota = linea["CODIGO_MASCOTA"].ToString(),
                NombreMascota = linea["NOMBRE_MASCOTA"].ToString(),
                CedulaVeterinario = linea["CEDULA_VETERINARIO"].ToString(),
                NombreVeterinario = linea["NOMBRE_VETERINARIO"].ToString(),
                CodigoEspecializacion = linea["CODIGO_ESPECIALIZACION"].ToString()
            };
        }

        public string ObtenerCodigoMascotaPorCita(string codigoCita)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_CITAS.FN_codigo_mascota_por_cita", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("return_value", OracleDbType.Varchar2).Direction = System.Data.ParameterDirection.ReturnValue;
                        cmd.Parameters.Add("v_codigo", OracleDbType.Varchar2).Value = codigoCita;

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        OracleRefCursor refCursor = (OracleRefCursor)cmd.Parameters["return_value"].Value;
                        using (OracleDataReader reader = refCursor.GetDataReader())
                        {
                            if (reader.Read())
                            {
                                return reader["CODIGO_MASCOTA"].ToString();
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al buscar cita: {ex.Message}", ex);
            }
        }

        public string ObtenerCedulaVeterinarioPorCita(string codigoCita)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_CITAS.FN_cedula_veterinario_por_cita", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("return_value", OracleDbType.Varchar2).Direction = System.Data.ParameterDirection.ReturnValue;
                        cmd.Parameters.Add("v_codigo", OracleDbType.Varchar2).Value = codigoCita;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        OracleRefCursor refCursor = (OracleRefCursor)cmd.Parameters["return_value"].Value;
                        using (OracleDataReader reader = refCursor.GetDataReader())
                        {
                            if (reader.Read())
                            {
                                return reader["CEDULA_VETERINARIO"].ToString();
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al buscar cita: {ex.Message}", ex);
            }
        }

    }
}
