using System;
using System.Collections.Generic;
using System.Globalization;
using Entidad;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
namespace Dato
{
    public class DatoConsulta : IRepository<Consulta>
    {

        IRepository<Mascota> datoMascota;
        IRepository<Veterinario> datoVeterinario;
        public DatoConsulta()
        {
            datoMascota = new DatoMascota();
            datoVeterinario = new DatoVeterinario();
        }
        public string Actualizar(Consulta consulta)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_CONSULTAS.PRC_actualizar", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_codigo", OracleDbType.Int64).Value = consulta.Codigo;
                        cmd.Parameters.Add("v_fecha", OracleDbType.Varchar2).Value = consulta.Fecha;
                        cmd.Parameters.Add("v_descripcion", OracleDbType.Varchar2).Value = consulta.Descripcion;
                        cmd.Parameters.Add("v_diagnostico", OracleDbType.Varchar2).Value = consulta.Diagnostico;
                        cmd.Parameters.Add("v_tratamiento", OracleDbType.Varchar2).Value = consulta.Tratamiento;
                        cmd.Parameters.Add("v_codigo_mascota", OracleDbType.Int64).Value = consulta.Mascota.Codigo;
                        cmd.Parameters.Add("v_cedula_veterinario", OracleDbType.Int64).Value = consulta.Mascota.Codigo;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return "Consulta actualizada correctamente.";
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar consulta: {ex.Message}", ex);
            }
        }

        public Consulta BuscarPorId(int id)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_CONSULTAS.FN_buscar_por_codigo", conn))
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
                throw new Exception($"Error al buscar consulta: {ex.Message}", ex);
            }
        }

        public List<Consulta> Consultar()
        {
            List<Consulta> lista = new List<Consulta>();

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

        public string Eliminar(int id)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_CONSULTAS.PRC_eliminar", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_codigo", OracleDbType.Int64).Value = id;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return "Consulta eliminada correctamente.";
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar consulta: {ex.Message}", ex);
            }
        }

        public string Guardar(Consulta consulta)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_CONSULTAS.PRC_guardar", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_fecha", OracleDbType.Varchar2).Value = consulta.Fecha.ToString("dd/MM/yyyy");
                        cmd.Parameters.Add("v_descripcion", OracleDbType.Varchar2).Value = consulta.Descripcion;
                        cmd.Parameters.Add("v_diagnostico", OracleDbType.Varchar2).Value = consulta.Diagnostico;
                        cmd.Parameters.Add("v_tratamiento", OracleDbType.Varchar2).Value = consulta.Tratamiento;
                        cmd.Parameters.Add("v_codigo_mascota", OracleDbType.Int64).Value = consulta.Mascota.Codigo;
                        cmd.Parameters.Add("v_cedula_veterinario", OracleDbType.Int64).Value = consulta.Veterinario.Cedula;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return "Consulta guardada correcctamente.";
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al insertar consulta: {ex.Message}", ex);
            }
        }

        public Consulta MappyingType(OracleDataReader linea)
        {
            Consulta consulta = new Consulta();
            consulta.Codigo = int.Parse(linea["CODIGO"].ToString());
            consulta.Fecha = DateTime.ParseExact(linea["FECHA"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            consulta.Descripcion = linea["DESCRIPCION"].ToString();
            consulta.Diagnostico = linea["DIAGNOSTICO"].ToString();
            consulta.Tratamiento = linea["TRATAMIENTO"].ToString();
            consulta.Mascota = datoMascota.BuscarPorId(int.Parse(linea["CODIGO_MASCOTA"].ToString()));
            consulta.Veterinario = datoVeterinario.BuscarPorId(int.Parse(linea["CEDULA_VETERINARIO"].ToString()));
            return consulta;
        }
    }
}
