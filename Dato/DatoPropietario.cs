using System;
using System.Collections.Generic;
using Entidad;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace Dato
{
    public class DatoPropietario : IRepository<Propietario>
    {

        public bool Guardar(Propietario propietario)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_PROPIETARIOS.PRC_guardar", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.Add("v_cedula", OracleDbType.Int64).Value = propietario.Cedula;
                        cmd.Parameters.Add("v_nombres", OracleDbType.Varchar2).Value = propietario.Nombres;
                        cmd.Parameters.Add("v_apellido_paterno", OracleDbType.Varchar2).Value = propietario.ApellidoPaterno;
                        cmd.Parameters.Add("v_apellido_materno", OracleDbType.Varchar2).Value = propietario.ApellidoMaterno;
                        cmd.Parameters.Add("v_sexo", OracleDbType.Varchar2).Value = propietario.Sexo;
                        cmd.Parameters.Add("v_telefono", OracleDbType.Varchar2).Value = propietario.Telefono;
                        cmd.Parameters.Add("v_email", OracleDbType.Varchar2).Value = propietario.Email;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al insertar propietario: {ex.Message}", ex);
            }
        }
        public List<Propietario> Consultar()
        {
            List<Propietario> lista = new List<Propietario>();

            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_PROPIETARIOS.FN_consultar", conn))
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
                throw new Exception($"Error al obtener propietarios: {ex.Message}", ex);
            }
        }

        public bool Actualizar(Propietario propietario)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_PROPIETARIOS.PRC_actualizar", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.Add("v_cedula", OracleDbType.Int64).Value = propietario.Cedula;
                        cmd.Parameters.Add("v_nombres", OracleDbType.Varchar2).Value = propietario.Nombres;
                        cmd.Parameters.Add("v_apellido_paterno", OracleDbType.Varchar2).Value = propietario.ApellidoPaterno;
                        cmd.Parameters.Add("v_apellido_materno", OracleDbType.Varchar2).Value = propietario.ApellidoMaterno;
                        cmd.Parameters.Add("v_sexo", OracleDbType.Varchar2).Value = propietario.Sexo;
                        cmd.Parameters.Add("v_telefono", OracleDbType.Varchar2).Value = propietario.Telefono;
                        cmd.Parameters.Add("v_email", OracleDbType.Varchar2).Value = propietario.Email;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return true;// "Propietario actualizado correctamente";
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar propietario: {ex.Message}", ex);
            }
        }

        public Propietario MappyingType(OracleDataReader linea)
        {
            Propietario propietario = new Propietario();
            propietario.Cedula = int.Parse(linea["CEDULA"].ToString());
            propietario.Nombres = linea["NOMBRES"].ToString();
            propietario.ApellidoPaterno = linea["APELLIDO_PATERNO"].ToString();
            propietario.ApellidoMaterno = linea["APELLIDO_MATERNO"].ToString();
            propietario.Sexo = linea["SEXO"].ToString();
            propietario.Telefono = linea["TELEFONO"].ToString();
            propietario.Email = linea["EMAIL"].ToString();
            return propietario;
        }

        public Propietario BuscarPorId(int id)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_PROPIETARIOS.FN_buscar_por_cedula", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        // Parámetro de retorno
                        cmd.Parameters.Add("return_value", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.ReturnValue;
                        cmd.Parameters.Add("v_cedula", OracleDbType.Int64).Value = id;

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
                throw new Exception($"Error al buscar propietario: {ex.Message}", ex);
            }
        }

        public bool Eliminar(int id)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_PROPIETARIOS.PRC_eliminar", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_cedula", OracleDbType.Int64).Value = id;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return true;// "Propietario eliminado con exito.";
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar propietario: {ex.Message}", ex);
            }
        }
    }
}
