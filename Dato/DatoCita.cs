using System;
using System.Collections.Generic;
using System.Globalization;
using Entidad;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace Dato
{
    public class DatoCita : IRepository<Cita>
    {
        IRepository<Mascota> datoMascota;
        IRepository<Veterinario> datoVeterinario;
        public DatoCita()
        {
            datoMascota = new DatoMascota();
            datoVeterinario = new DatoVeterinario();
        }
        public bool Actualizar(Cita cita)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_CITAS.PRC_actualizar", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_codigo", OracleDbType.Int64).Value = cita.Codigo;
                        cmd.Parameters.Add("v_fecha", OracleDbType.Varchar2).Value = cita.Fecha;
                        cmd.Parameters.Add("v_hora", OracleDbType.Varchar2).Value = cita.Hora;
                        cmd.Parameters.Add("v_codigo_mascota", OracleDbType.Int64).Value = cita.Mascota.Codigo;
                        cmd.Parameters.Add("v_cedula_veterinario", OracleDbType.Int64).Value = cita.Veterinario.Cedula;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return true; //"Cita actualizada correctamente.";
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar cita: {ex.Message}", ex);
            }
        }

        public Cita BuscarPorId(int id)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_CITAS.FN_buscar_por_codigo", conn))
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
                throw new Exception($"Error al buscar cita: {ex.Message}", ex);
            }
        }

        public List<Cita> Consultar()
        {
            List<Cita> lista = new List<Cita>();

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

        public bool Eliminar(int id)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_CITAS.PRC_eliminar", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_codigo", OracleDbType.Int64).Value = id;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return true;  //;
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
                        cmd.Parameters.Add("v_codigo_mascota", OracleDbType.Int64).Value = cita.Mascota.Codigo;
                        cmd.Parameters.Add("v_cedula_veterinario", OracleDbType.Int64).Value = cita.Veterinario.Cedula;

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
            //esto lo tengo que arreglar despues
            try
            {
                List<citasPorFechas> datos = new List<citasPorFechas>();

                string query = "SELECT COUNT(*) as TOTAL, FECHA FROM citas GROUP BY FECHA ORDER BY FECHA";

                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {

                    OracleCommand cmd = new OracleCommand(query, conn);
                    conn.Open();
                    OracleDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        datos.Add(new citasPorFechas
                        {
                            cantidad = Convert.ToInt32(reader["TOTAL"]),
                            fecha = reader["FECHA"].ToString()
                        });
                    }

                    reader.Close();
                }

                return datos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las citas por fecha: " + ex.Message);
            }

        }

        public Cita MappyingType(OracleDataReader linea)
        {
            Cita cita = new Cita();
            cita.Codigo = Convert.ToInt32(linea["CODIGO"]);
            cita.Fecha = linea["FECHA"].ToString();
            cita.Hora = linea["HORA"].ToString();
            cita.Mascota = datoMascota.BuscarPorId(int.Parse(linea["CODIGO_MASCOTA"].ToString()));
            cita.Veterinario = datoVeterinario.BuscarPorId(int.Parse(linea["CEDULA_VETERINARIO"].ToString()));
            return cita;
        }
    }
}
