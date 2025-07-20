using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Edifia_BE;

namespace Edifia_ADO
{
    public class MantenimientoADO
    {
        ConexionADO _conexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;


        public DataTable ListarMantenimiento()
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(_conexion.GetCnx()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Tb_Mantenimiento_Responsable", cnx))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter ada = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            ada.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error en la base de datos: {ex.Message}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error general: {ex.Message}");
            }
        }


        public MantenimientoBE ConsultarMantenimiento(Int32 Codigo)
        {
            try
            {
                using (cnx)
                {
                    MantenimientoBE objMantenimientoBE = null;
                    cnx.ConnectionString = _conexion.GetCnx();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "usp_Tb_Mantenimiento_Consultar";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", Codigo);

                    cnx.Open();
                    using (dtr = cmd.ExecuteReader())
                    {
                        if (dtr.HasRows && dtr.Read())
                        {
                            objMantenimientoBE = new MantenimientoBE
                            {
                                id = Convert.ToInt16(dtr["id"]),
                                actividad_id = Convert.ToInt16(dtr["actividad_id"]),
                                edificio_id = Convert.ToInt16(dtr["edificio_id"]),
                                responsable = dtr["responsable"].ToString(),
                                fecha_programada = dtr["fecha_programada"] != DBNull.Value ?
                                    Convert.ToDateTime(dtr["fecha_programada"]) : null,
                                fecha_realizacion = dtr["fecha_realizacion"] != DBNull.Value ?
                                    Convert.ToDateTime(dtr["fecha_realizacion"]) : null,
                                Usu_Registro = dtr["Usu_Registro"]?.ToString(),
                                Fec_Ult_Mod = dtr["Fec_Ult_Mod"] != DBNull.Value ?
                                    Convert.ToDateTime(dtr["Fec_Ult_Mod"]) : DateTime.MinValue,
                                Usu_Ult_Mod = dtr["Usu_Ult_Mod"]?.ToString()
                            };
                        }
                    }
                    return objMantenimientoBE;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error al consultar mantenimiento: {ex.Message}", ex);
            }
        }

        public Boolean InsertarMantenimiento(MantenimientoBE objMantenimientoBE)
        {

            try
            {
                cnx.ConnectionString = _conexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Tb_Mantenimiento_Insertar";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@actividad_id", objMantenimientoBE.actividad_id);
                cmd.Parameters.AddWithValue("@fecha_programada", objMantenimientoBE.fecha_programada.HasValue ? (object)objMantenimientoBE.fecha_programada.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@fecha_realizacion", objMantenimientoBE.fecha_realizacion.HasValue ? (object)objMantenimientoBE.fecha_realizacion.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@responsable", objMantenimientoBE.responsable);
                cmd.Parameters.AddWithValue("@edificio_id", objMantenimientoBE.edificio_id);
                cmd.Parameters.AddWithValue("@Usu_Registro", objMantenimientoBE.Usu_Registro);
      

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }


        public Boolean ActualizarMantenimiento(MantenimientoBE objMantenimientoBE)
        {
            try
            {
                if (objMantenimientoBE == null)
                    throw new ArgumentNullException(nameof(objMantenimientoBE));

                using (cnx)
                {
                    cnx.ConnectionString = _conexion.GetCnx();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "usp_Tb_Mantenimiento_Actualizar";
                    cmd.Parameters.Clear();

                    // Parámetros principales
                    cmd.Parameters.AddWithValue("@ID", objMantenimientoBE.id);
                    cmd.Parameters.AddWithValue("@actividad_id", objMantenimientoBE.actividad_id);
                    cmd.Parameters.AddWithValue("@edificio_id", objMantenimientoBE.edificio_id);
                    cmd.Parameters.AddWithValue("@responsable", objMantenimientoBE.responsable ?? (object)DBNull.Value);

                    // Manejo de fechas
                    cmd.Parameters.AddWithValue("@fecha_programada",
                        objMantenimientoBE.fecha_programada ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@fecha_realizacion",
                        objMantenimientoBE.fecha_realizacion ?? (object)DBNull.Value);

                    // Campos de auditoría
                    cmd.Parameters.AddWithValue("@Fec_ult_mod", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Usu_ult_mod",
                        string.IsNullOrEmpty(objMantenimientoBE.Usu_Ult_Mod) ?
                        DBNull.Value : (object)objMantenimientoBE.Usu_Ult_Mod);

                    cnx.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error al actualizar mantenimiento: {ex.Message}", ex);
            }
        }


        public Boolean EliminarMantenimiento(String strCodigo)
        {
            try
            {
                //Codifique
                cnx.ConnectionString = _conexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Tb_Mantenimiento_eliminar";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id", strCodigo);
                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }
        }

        public List<MantenimientoBE> ListarMantenimientosProximos24Horas()
        {
            List<MantenimientoBE> lista = new List<MantenimientoBE>();

            try
            {
                cnx.ConnectionString = _conexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Tb_Mantenimiento_Proximos24H";
                cmd.Parameters.Clear();

                cnx.Open();

                dtr = cmd.ExecuteReader();

                while (dtr.Read())
                {
                    MantenimientoBE obj = new MantenimientoBE
                    {
                        id = dtr.GetInt32(dtr.GetOrdinal("id")),
                        actividad_id = Convert.ToInt16(dtr.GetInt32(dtr.GetOrdinal("actividad_id"))),
                        fecha_programada = dtr.IsDBNull(dtr.GetOrdinal("fecha_programada")) ? (DateTime?)null : dtr.GetDateTime(dtr.GetOrdinal("fecha_programada")),
                        fecha_realizacion = dtr.IsDBNull(dtr.GetOrdinal("fecha_realizacion")) ? (DateTime?)null : dtr.GetDateTime(dtr.GetOrdinal("fecha_realizacion")),
                        responsable = dtr["responsable"].ToString(),
                        edificio_id = Convert.ToInt16(dtr.GetInt32(dtr.GetOrdinal("edificio_id"))),
                        actividad_nombre = dtr["actividad_nombre"].ToString(),
                        edificio_nombre = dtr["edificio_nombre"].ToString(),
                        responsable_nombre = dtr["responsable_nombre"].ToString()
                    };

                    lista.Add(obj);
                }

                dtr.Close();
                return lista;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();
            }
        }


    }
}