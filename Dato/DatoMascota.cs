using System;
using System.Collections.Generic;
using Entidad;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace Dato
{
    public class DatoMascota : IWriteReapository<Mascota>, IReadRepository<MascotaDTO>,IDataEditRepository<MascotaEdicionDTO>
    {

        public bool Actualizar(Mascota mascota)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_MASCOTAS.PRC_actualizar", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_codigo", OracleDbType.Varchar2).Value = mascota.Codigo;
                        cmd.Parameters.Add("v_nombre", OracleDbType.Varchar2).Value = mascota.Nombre;
                        cmd.Parameters.Add("v_codigo_especie", OracleDbType.Varchar2).Value = mascota.EspecieCodigo;
                        cmd.Parameters.Add("v_codigo_raza", OracleDbType.Varchar2).Value = mascota.RazaCodigo;
                        cmd.Parameters.Add("v_cedula_propietario", OracleDbType.Varchar2).Value = mascota.PropietarioCedula;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar mascota: {ex.Message}", ex);
            }
        }
        public MascotaDTO BuscarPorId(string id)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_MASCOTAS.FN_buscar_por_codigo", conn))
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
                throw new Exception($"Error al buscar mascota: {ex.Message}", ex);
            }
        }
        public List<MascotaDTO> Consultar()
        {
            List<MascotaDTO> lista = new List<MascotaDTO>();

            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_MASCOTAS.FN_consultar", conn))
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
                throw new Exception($"Error al obtener mascotas: {ex.Message}", ex);
            }
        }
        public bool Eliminar(string id)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_MASCOTAS.PRC_eliminar", conn))
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
                throw new Exception($"Error al eliminar mascota: {ex.Message}", ex);
            }
        }
        public bool Guardar(Mascota mascota)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_MASCOTAS.PRC_guardar", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_nombre", OracleDbType.Varchar2).Value = mascota.Nombre;
                        cmd.Parameters.Add("v_codigo_especie", OracleDbType.Varchar2).Value = mascota.EspecieCodigo;
                        cmd.Parameters.Add("v_codigo_raza", OracleDbType.Varchar2).Value = mascota.RazaCodigo;
                        cmd.Parameters.Add("v_cedula_propietario", OracleDbType.Varchar2).Value = mascota.PropietarioCedula;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al insertar mascota: {ex.Message}", ex);
            }
        }
        public MascotaDTO MappyingType(OracleDataReader line)
        {
            MascotaDTO mascotaDTO = new MascotaDTO();
            mascotaDTO.Codigo = line["CODIGO"].ToString();
            mascotaDTO.Nombre = line["NOMBRE"].ToString();
            mascotaDTO.NombreEspecie = line["nombre_especie"].ToString();
            mascotaDTO.NombreRaza = line["nombre_raza"].ToString();
            mascotaDTO.NombrePropietario = line["nombre_propietario"].ToString();
            return mascotaDTO;
        }
        public MascotaEdicionDTO ObtenerDatosParaEdicion(string id)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_MASCOTAS.FN_Consultar_mascota_edicion", conn))
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
                throw new Exception($"Error al buscar mascota: {ex.Message}", ex);
            }
        }
        public MascotaEdicionDTO MappyingTypeEdicion(OracleDataReader reader)
        {
            return new MascotaEdicionDTO
            {
                Codigo = reader["CODIGO"].ToString(),
                Nombre = reader["NOMBRE"].ToString(),
                CodigoEspecie = reader["CODIGO_ESPECIE"].ToString(),
                NombreEspecie = reader["NOMBRE_ESPECIE"].ToString(),
                CodigoRaza = reader["CODIGO_RAZA"].ToString(),
                NombreRaza = reader["NOMBRE_RAZA"].ToString(),
                CedulaPropietario = reader["CEDULA_PROPIETARIO"].ToString(),
                NombrePropietario = reader["NOMBRE_PROPIETARIO"].ToString()
            };
        }
    }
}
