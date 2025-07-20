using System;
using System.Data;
using System.Data.SqlClient;
using Edifia_BE;

namespace Edifia_ADO
{
    public class VisitaADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarVisita()
        {
            using (SqlConnection cnx = new SqlConnection(MiConexion.GetCnx()))
            using (SqlCommand cmd = new SqlCommand("usp_Tb_Visita_Listar", cnx))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();

                try
                {
                    cnx.Open();
                    ada.Fill(dts, "Visitas");
                    return dts.Tables[0];
                }
                catch (SqlException sqlEx)
                {
                    throw new Exception("Error en la base de datos: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al listar visitas: " + ex.Message);
                }
            }
        }

        public VisitaBE ConsultarVisita(string strCodigo)
        {
            VisitaBE objVisitaBE = null; 
            using (SqlConnection cnx = new SqlConnection(MiConexion.GetCnx()))
            using (SqlCommand cmd = new SqlCommand("usp_Tb_Visita_Consultar", cnx))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", strCodigo);

                cnx.Open();
                using (SqlDataReader dtr = cmd.ExecuteReader())
                {
                    if (dtr.HasRows && dtr.Read())
                    {
                        objVisitaBE = new VisitaBE
                        {
                            id = Convert.ToInt32(dtr["id"]),
                            nombre = dtr["nombre"].ToString(),
                            apellido = dtr["apellido"].ToString(),
                            documento = dtr["documento"].ToString(),
                            departamento_id = Convert.ToInt32(dtr["departamento_id"]),
                            area_comun_id = dtr["area_comun_id"] != DBNull.Value ? Convert.ToInt16(dtr["area_comun_id"]) : (short?)null,
                            proposito = dtr["proposito"].ToString(),
                            fecha_entrada = dtr["fecha_entrada"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(dtr["fecha_entrada"]) : null,
                            hora_entrada = dtr["hora_entrada"] != DBNull.Value ? (TimeSpan?)TimeSpan.Parse(dtr["hora_entrada"].ToString()) : null,
                            fecha_salida = dtr["fecha_salida"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(dtr["fecha_salida"]) : null,
                            hora_salida = dtr["hora_salida"] != DBNull.Value ? (TimeSpan?)TimeSpan.Parse(dtr["hora_salida"].ToString()) : null,
                            tipo_id = Convert.ToInt16(dtr["tipo_id"]),
                            Fec_reg = Convert.ToDateTime(dtr["Fec_reg"]),
                            Usu_Registro = dtr["Usu_Registro"].ToString(),
                            Fec_Ult_Mod = dtr["Fec_Ult_Mod"] != DBNull.Value ? Convert.ToDateTime(dtr["Fec_Ult_Mod"]) : DateTime.MinValue,
                            Usu_Ult_Mod = dtr["Usu_Ult_Mod"] != DBNull.Value ? dtr["Usu_Ult_Mod"].ToString() : string.Empty
                        };
                    }
                }
            }
            return objVisitaBE;
        }

        public bool InsertarVisita(VisitaBE objVisitaBE)
        {
            using (SqlConnection cnx = new SqlConnection(MiConexion.GetCnx()))
            using (SqlCommand cmd = new SqlCommand("usp_Tb_Visita_Insertar", cnx))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", objVisitaBE.nombre);
                cmd.Parameters.AddWithValue("@apellido", objVisitaBE.apellido);
                cmd.Parameters.AddWithValue("@documento", objVisitaBE.documento);
                cmd.Parameters.AddWithValue("@departamento_id", objVisitaBE.departamento_id);
                cmd.Parameters.AddWithValue("@area_comun_id", objVisitaBE.area_comun_id);
                cmd.Parameters.AddWithValue("@proposito", objVisitaBE.proposito);
                cmd.Parameters.AddWithValue("@fecha_entrada", objVisitaBE.fecha_entrada.HasValue ? (object)objVisitaBE.fecha_entrada.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@hora_entrada", objVisitaBE.hora_entrada.HasValue ? (object)objVisitaBE.hora_entrada.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@fecha_salida", objVisitaBE.fecha_salida.HasValue ? (object)objVisitaBE.fecha_salida.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@hora_salida", objVisitaBE.hora_salida.HasValue ? (object)objVisitaBE.hora_salida.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@tipo_id", objVisitaBE.tipo_id);
                cmd.Parameters.AddWithValue("@Fec_reg", objVisitaBE.Fec_reg);
                cmd.Parameters.AddWithValue("@Usu_Registro", objVisitaBE.Usu_Registro);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
        }

        public bool ActualizarVisita(VisitaBE objVisitaBE)
        {
            using (SqlConnection cnx = new SqlConnection(MiConexion.GetCnx()))
            using (SqlCommand cmd = new SqlCommand("usp_Tb_Visita_Actualizar", cnx))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", objVisitaBE.id);
                cmd.Parameters.AddWithValue("@nombre", objVisitaBE.nombre);
                cmd.Parameters.AddWithValue("@apellido", objVisitaBE.apellido);
                cmd.Parameters.AddWithValue("@documento", objVisitaBE.documento);
                cmd.Parameters.AddWithValue("@departamento_id", objVisitaBE.departamento_id);
                cmd.Parameters.AddWithValue("@area_comun_id", objVisitaBE.area_comun_id);
                cmd.Parameters.AddWithValue("@proposito", objVisitaBE.proposito);
                cmd.Parameters.AddWithValue("@fecha_entrada", objVisitaBE.fecha_entrada);
                cmd.Parameters.AddWithValue("@hora_entrada", objVisitaBE.hora_entrada);
                cmd.Parameters.AddWithValue("@fecha_salida", objVisitaBE.fecha_salida);
                cmd.Parameters.AddWithValue("@hora_salida", objVisitaBE.hora_salida);
                cmd.Parameters.AddWithValue("@tipo_id", objVisitaBE.tipo_id);
                cmd.Parameters.AddWithValue("@Usu_Ult_Mod", objVisitaBE.Usu_Ult_Mod);
                cmd.Parameters.AddWithValue("@Fec_Ult_Mod", DateTime.Now);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
        }

        //Jose
        public bool EliminarVisita(string strCodigo, DateTime fecUltMod, string usuUltMod)
        {
            using (SqlConnection cnx = new SqlConnection(MiConexion.GetCnx()))
            using (SqlCommand cmd = new SqlCommand("usp_Tb_Visita_Eliminar", cnx))
            {
                cmd.CommandType = CommandType.StoredProcedure; 
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(strCodigo);
                cmd.Parameters.Add("@Fec_Ult_Mod", SqlDbType.DateTime).Value = fecUltMod;
                cmd.Parameters.Add("@Usu_Ult_Mod", SqlDbType.NVarChar, 50).Value = usuUltMod;

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
        }
        //Jose

        public VisitaBE ObtenerVisitaPorId(int id)
        {
            VisitaBE visita = null;

            try
            {
                using (SqlConnection cnx = new SqlConnection(MiConexion.GetCnx()))
                using (SqlCommand cmd = new SqlCommand("usp_Tb_Visita_Consultar", cnx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", id);

                    cnx.Open();
                    using (SqlDataReader dtr = cmd.ExecuteReader())
                    {
                        if (dtr.Read())
                        {
                            visita = new VisitaBE
                            {
                                id = Convert.ToInt32(dtr["id"]),
                                nombre = dtr["nombre"].ToString(),
                                apellido = dtr["apellido"].ToString(),
                                documento = dtr["documento"].ToString(),
                                departamento_id = Convert.ToInt32(dtr["departamento_id"]),
                                fecha_entrada = dtr["fecha_entrada"] != DBNull.Value ?
                                    (DateTime?)Convert.ToDateTime(dtr["fecha_entrada"]) : null,
                                hora_entrada = dtr["hora_entrada"] != DBNull.Value ?
                                    (TimeSpan?)TimeSpan.Parse(dtr["hora_entrada"].ToString()) : null,
                                fecha_salida = dtr["fecha_salida"] != DBNull.Value ?
                                    (DateTime?)Convert.ToDateTime(dtr["fecha_salida"]) : null,
                                hora_salida = dtr["hora_salida"] != DBNull.Value ?
                                    (TimeSpan?)TimeSpan.Parse(dtr["hora_salida"].ToString()) : null,
                                tipo_id = Convert.ToInt16(dtr["tipo_id"]),
                                area_comun_id = dtr["area_comun_id"] != DBNull.Value ?
                                    Convert.ToInt16(dtr["area_comun_id"]) : (short?)null,
                                proposito = dtr["proposito"].ToString(),
                                Fec_reg = Convert.ToDateTime(dtr["Fec_reg"]),
                                Usu_Registro = dtr["Usu_Registro"].ToString(),
                                Fec_Ult_Mod = dtr["Fec_Ult_Mod"] != DBNull.Value ?
                                    Convert.ToDateTime(dtr["Fec_Ult_Mod"]) : DateTime.MinValue,
                                Usu_Ult_Mod = dtr["Usu_Ult_Mod"] != DBNull.Value ?
                                    dtr["Usu_Ult_Mod"].ToString() : string.Empty
                            };
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error de base de datos al obtener la visita: {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener la visita: {ex.Message}", ex);
            }

            return visita;
        }

        public DataTable ListarVisitasReporteExcel()
        {
            DataTable dtVisitas = new DataTable();
            SqlConnection cnx = new SqlConnection(MiConexion.GetCnx());
            SqlCommand cmd = new SqlCommand("usp_Tb_Visita_Listar_reporte_excel", cnx);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                // Limpiamos parámetros en caso de que haya alguno previo
                cmd.Parameters.Clear();

                // Creamos un DataAdapter para ejecutar el comando y llenar el DataTable
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtVisitas);

                return dtVisitas;
            }
            catch (SqlException ex)
            {
                // Manejo de excepciones
                throw new Exception("Error al ejecutar el procedimiento almacenado: " + ex.Message);
            }
            finally
            {
                // Aseguramos que la conexión se cierre, aunque ocurra un error
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

    }
}