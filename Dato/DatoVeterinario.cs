using Entidad;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace Dato
{
    public class DatoVeterinario : IWriteReapository<Veterinario>,IReadRepository<VeterinarioDTO>,IDataEditRepository<VeterinarioEdicionDTO>  
    {
        public bool Guardar(Veterinario veterinario)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_VETERINARIOS.PRC_guardar", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_cedula", OracleDbType.Varchar2).Value = veterinario.Cedula;
                        cmd.Parameters.Add("v_nombre_completo", OracleDbType.Varchar2).Value = veterinario.NombreCompleto;
                        cmd.Parameters.Add("v_sexo", OracleDbType.Varchar2).Value = veterinario.Sexo;
                        cmd.Parameters.Add("v_telefono", OracleDbType.Varchar2).Value = veterinario.Telefono;
                        cmd.Parameters.Add("v_codigo_especializacion", OracleDbType.Varchar2).Value = veterinario.EspecializacionCodigo;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return true;// ;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al insertar veterinario: {ex.Message}", ex);
            }
        }
        public List<VeterinarioDTO> Consultar()
        {
            List<VeterinarioDTO> lista = new List<VeterinarioDTO>();

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
                        cmd.Parameters.Add("v_cedula", OracleDbType.Varchar2).Value = veterinario.Cedula;
                        cmd.Parameters.Add("v_nombre_completo", OracleDbType.Varchar2).Value = veterinario.NombreCompleto;
                        cmd.Parameters.Add("v_sexo", OracleDbType.Varchar2).Value = veterinario.Sexo;
                        cmd.Parameters.Add("v_telefono", OracleDbType.Varchar2).Value = veterinario.Telefono;
                        cmd.Parameters.Add("v_codigo_especializacion", OracleDbType.Varchar2).Value = veterinario.EspecializacionCodigo;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar veterinario: {ex.Message}", ex);
            }
        }
        public VeterinarioDTO BuscarPorId(string id)
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
        public bool Eliminar(string id)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_VETERINARIOS.PRC_eliminar", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_cedula", OracleDbType.Varchar2).Value = id;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar veterinario: {ex.Message}", ex);
            }
        }
        public VeterinarioDTO MappyingType(OracleDataReader linea)
        {
            VeterinarioDTO veterinarioDTO = new VeterinarioDTO();
            veterinarioDTO.Cedula = linea["CEDULA"].ToString();
            veterinarioDTO.NombreCompleto = linea["NOMBRE_COMPLETO"].ToString();
            veterinarioDTO.Sexo = linea["SEXO"].ToString();
            veterinarioDTO.Telefono = linea["TELEFONO"].ToString();
            veterinarioDTO.NombreEspecializacion = linea["nombre_especializacion"].ToString();
            return veterinarioDTO;
        }
        public VeterinarioEdicionDTO ObtenerDatosParaEdicion(string id)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_VETERINARIOS.FN_consultar_veterinario_edicion", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("return_value", OracleDbType.RefCursor).Direction = System.Data.ParameterDirection.ReturnValue;
                        cmd.Parameters.Add("v_cedula", OracleDbType.Varchar2).Value = id;

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
                throw new Exception($"Error al obtener veterinarios: {ex.Message}", ex);
            }
        }

        public VeterinarioEdicionDTO MappyingTypeEdicion(OracleDataReader linea)
        {
            return new VeterinarioEdicionDTO
            {
                Cedula = linea["CEDULA"].ToString(),
                NombreCompleto = linea["NOMBRE_COMPLETO"].ToString(),
                Sexo = linea["SEXO"].ToString(),
                Telefono = linea["TELEFONO"].ToString(),
                codigoEspecializacion = linea["codigo_especializacion"].ToString(),
            };
        }
    }
}


