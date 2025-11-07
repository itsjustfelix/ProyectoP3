using System;
using System.Collections.Generic;
using Entidad;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace Dato
{
    public class DatoMascota : IRepository<Mascota>
    {
        IRepository<Raza> datoRaza;
        IRepository<Propietario> datoPropietario;
        IRepository<Especie> datoEspecie;
        public DatoMascota()
        {
            datoRaza = new DatoRaza();
            datoPropietario = new DatoPropietario();
            datoEspecie = new DatoEspecie();
        }

        public string Actualizar(Mascota mascota)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_MASCOTAS.PRC_actualizar", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_codigo", OracleDbType.Int64).Value = mascota.Codigo;
                        cmd.Parameters.Add("v_nombre", OracleDbType.Varchar2).Value = mascota.Nombre;
                        cmd.Parameters.Add("v_codigo_especie", OracleDbType.Int64).Value = mascota.Especie.Codigo;
                        cmd.Parameters.Add("v_codigo_raza", OracleDbType.Int64).Value = mascota.Raza.Codigo;
                        cmd.Parameters.Add("v_cedula_propietario", OracleDbType.Int64).Value = mascota.Propietario.Cedula;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return "Mascota actualizada correctamente.";
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar mascota: {ex.Message}", ex);
            }
        }

        public Mascota BuscarPorId(int id)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_MASCOTAS.FN_buscar_por_codigo", conn))
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
                throw new Exception($"Error al buscar mascota: {ex.Message}", ex);
            }
        }

        public List<Mascota> Consultar()
        {
            List<Mascota> lista = new List<Mascota>();

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

        public string Eliminar(int id)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_MASCOTAS.PRC_eliminar", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_codigo", OracleDbType.Int64).Value = id;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return "Mascota eliminada correctamente.";
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar mascota: {ex.Message}", ex);
            }
        }

        public string Guardar(Mascota mascota)
        {
            try
            {
                using (OracleConnection conn = OracleDBConnection.GetConnection())
                {
                    using (OracleCommand cmd = new OracleCommand("PKG_MASCOTAS.PRC_guardar", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_nombre", OracleDbType.Varchar2).Value = mascota.Nombre;
                        cmd.Parameters.Add("v_codigo_especie", OracleDbType.Int64).Value = mascota.Especie.Codigo;
                        cmd.Parameters.Add("v_codigo_raza", OracleDbType.Int64).Value = mascota.Raza.Codigo;
                        cmd.Parameters.Add("v_cedula_propietario", OracleDbType.Int64).Value = mascota.Propietario.Cedula;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return "Mascota guardada correctamente.";
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al insertar mascota: {ex.Message}", ex);
            }
        }

        public Mascota MappyingType(OracleDataReader line)
        {
            Mascota mascota = new Mascota();
            mascota.Codigo = int.Parse(line["CODIGO"].ToString());
            mascota.Nombre = line["NOMBRE"].ToString();
            mascota.Especie = datoEspecie.BuscarPorId(int.Parse(line["CODIGO_ESPECIE"].ToString()));
            mascota.Raza = datoRaza.BuscarPorId(int.Parse(line["CODIGO_RAZA"].ToString()));
            mascota.Propietario = datoPropietario.BuscarPorId(int.Parse(line["CEDULA_PROPIETARIO"].ToString()));
            return mascota;
        }
    }

}
