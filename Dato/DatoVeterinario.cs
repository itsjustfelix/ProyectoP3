using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Entidad;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace Dato
{
    public class DatoVeterinario : IRepository<Veterinario>
    {
        public IRepository<Especializacion> DatoEspecializacion;
        public DatoVeterinario()
        {
            DatoEspecializacion = new DatoEspecializacion();
        }
        public bool Guardar(Veterinario veterinario)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_VETERINARIOS.PRC_guardar", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_cedula", OracleDbType.Int64).Value = veterinario.Cedula;
                        cmd.Parameters.Add("v_nombres", OracleDbType.Varchar2).Value = veterinario.Nombres;
                        cmd.Parameters.Add("v_apellido_paterno", OracleDbType.Varchar2).Value = veterinario.ApellidoPaterno;
                        cmd.Parameters.Add("v_apellido_materno", OracleDbType.Varchar2).Value = veterinario.ApellidoMaterno;
                        cmd.Parameters.Add("v_sexo", OracleDbType.Varchar2).Value = veterinario.Sexo;
                        cmd.Parameters.Add("v_telefono", OracleDbType.Varchar2).Value = veterinario.Telefono;
                        cmd.Parameters.Add("v_codigo_especializacion", OracleDbType.Int64).Value = veterinario.Especializacion.Codigo;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return true;// "Veterinario guardado correctamente.";
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al insertar veterinario: {ex.Message}", ex);
            }
        }
        public List<Veterinario> Consultar()
        {
            List<Veterinario> lista = new List<Veterinario>();

            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_VETERINARIOS.FN_consultar", conn))
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
                throw new Exception($"Error al obtener veterinarios: {ex.Message}", ex);
            }
        }
        public bool Actualizar(Veterinario veterinario)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_VETERINARIOS.PRC_actualizar", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_cedula", OracleDbType.Int64).Value = veterinario.Cedula;
                        cmd.Parameters.Add("v_nombres", OracleDbType.Varchar2).Value = veterinario.Nombres;
                        cmd.Parameters.Add("v_apellido_paterno", OracleDbType.Varchar2).Value = veterinario.ApellidoPaterno;
                        cmd.Parameters.Add("v_apellido_materno", OracleDbType.Varchar2).Value = veterinario.ApellidoMaterno;
                        cmd.Parameters.Add("v_sexo", OracleDbType.Varchar2).Value = veterinario.Sexo;
                        cmd.Parameters.Add("v_telefono", OracleDbType.Varchar2).Value = veterinario.Telefono;
                        cmd.Parameters.Add("v_codigo_especializacion", OracleDbType.Int64).Value = veterinario.Especializacion.Codigo;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return true;// "Veterinario actulizado correctamente.";
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar veterinario: {ex.Message}", ex);
            }
        }
        public Veterinario BuscarPorId(int id)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_VETERINARIOS.FN_buscar_por_cedula", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("return_value", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.ReturnValue;
                        cmd.Parameters.Add("v_cedula", OracleDbType.Varchar2).Value = id;

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
                throw new Exception($"Error al buscar veterinario: {ex.Message}", ex);
            }
        }
        public bool Eliminar(int id)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_VETERINARIOS.PRC_eliminar", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_cedula", OracleDbType.Int64).Value = id;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return true;// "Veterinario eliminado correctamente.";
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar veterinario: {ex.Message}", ex);
            }
        }
        public Veterinario MappyingType(OracleDataReader linea)
        {
            Veterinario veterinario = new Veterinario();
            veterinario.Cedula = int.Parse(linea["CEDULA"].ToString());
            veterinario.Nombres = linea["NOMBRES"].ToString();
            veterinario.ApellidoPaterno = linea["APELLIDO_PATERNO"].ToString();
            veterinario.ApellidoMaterno = linea["APELLIDO_MATERNO"].ToString();
            veterinario.Sexo = linea["SEXO"].ToString();
            veterinario.Telefono = linea["TELEFONO"].ToString();
            veterinario.Especializacion = DatoEspecializacion.BuscarPorId(int.Parse(linea["CODIGO_ESPECIALIZACION"].ToString()));
            return veterinario;
        }
    }
}


