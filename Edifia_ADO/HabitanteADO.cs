using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregar....
using Edifia_BE;
using System.Configuration;

namespace Edifia_ADO
{
    public class HabitanteADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarHabitantes()
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_Tb_Habitante_Listar";
            try
            {

                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Habitantes");
                return dts.Tables["Habitantes"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public HabitanteBE ConsultarHabitante(int id)
        {
            try
            {
                HabitanteBE objHabitanteBE = new HabitanteBE();

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Tb_Habitante_Consultar";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID", id);
                cnx.Open();

                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objHabitanteBE.id = Convert.ToInt32(dtr["id"]);
                    objHabitanteBE.nombre = dtr["nombre"].ToString();
                    objHabitanteBE.apellido = dtr["apellido"].ToString();
                    objHabitanteBE.documento = dtr["documento"].ToString();
                    objHabitanteBE.departamento_id = Convert.ToInt32(dtr["departamento_id"]);
                    objHabitanteBE.numero = Convert.ToInt16(dtr["numero"]);
                    objHabitanteBE.es_propietario = Convert.ToBoolean(dtr["es_propietario"]);
                    objHabitanteBE.fecha_ingreso = dtr["fecha_ingreso"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(dtr["fecha_ingreso"]) : null;
                    objHabitanteBE.fecha_egreso = dtr["fecha_egreso"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(dtr["fecha_egreso"]) : null;
                    objHabitanteBE.Fec_reg = Convert.ToDateTime(dtr["fec_reg"]);

                    // Asegúrate de que la columna foto existe antes de intentar leerla
                    if (dtr["foto"] != DBNull.Value)
                    {
                        objHabitanteBE.foto = (byte[])dtr["foto"];
                    }
                
            }
                dtr.Close();
                return objHabitanteBE;
            }

            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }


        public bool InsertarHabitante(HabitanteBE h)
        {
            try
            {
                ConexionADO conexion = new ConexionADO();
                using SqlConnection cn = new SqlConnection(conexion.GetCnx());

                using SqlCommand cmd = new SqlCommand(@"
                INSERT INTO Tb_Habitante (nombre, apellido, documento, departamento_id, Fec_reg, foto, fecha_ingreso, es_propietario, Usu_Registro)
                VALUES (@nombre, @apellido, @documento, @departamento_id, @Fec_reg, @foto, @fecha_ingreso, @es_propietario, @Usu_Registro)", cn);

                cmd.Parameters.AddWithValue("@nombre", h.nombre);
                cmd.Parameters.AddWithValue("@apellido", h.apellido);
                cmd.Parameters.AddWithValue("@documento", h.documento);
                cmd.Parameters.AddWithValue("@departamento_id", h.departamento_id);
                cmd.Parameters.AddWithValue("@Fec_reg", h.Fec_reg);
                cmd.Parameters.AddWithValue("@foto", h.foto);
                cmd.Parameters.AddWithValue("@fecha_ingreso", h.fecha_ingreso);
                cmd.Parameters.AddWithValue("@es_propietario", h.es_propietario);
                cmd.Parameters.AddWithValue("@Usu_Registro", h.Usu_Registro);

                cn.Open();
                int filas = cmd.ExecuteNonQuery();

                return filas > 0; // Este es el valor clave que se devuelve al BL
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR REAL EN ADO: " + ex.Message);
                throw new Exception("Error en InsertarHabitante ADO: " + ex.Message, ex);
            }

        }


        private void ValidarFecha(DateTime? fecha, string mensajeError)
        {
            if (fecha.HasValue && (fecha.Value < new DateTime(1753, 1, 1) || fecha.Value > new DateTime(9999, 12, 31)))
            {
                throw new Exception(mensajeError);
            }
        }




        public Boolean ActualizarHabitante(HabitanteBE objHabitanteBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Tb_Habitante_Actualizar";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@id", objHabitanteBE.id);
                cmd.Parameters.AddWithValue("@nombre", objHabitanteBE.nombre);
                cmd.Parameters.AddWithValue("@apellido", objHabitanteBE.apellido);
                cmd.Parameters.AddWithValue("@documento", objHabitanteBE.documento);
                cmd.Parameters.AddWithValue("@departamento_id", objHabitanteBE.departamento_id);
                cmd.Parameters.AddWithValue("@es_propietario", objHabitanteBE.es_propietario);
                cmd.Parameters.AddWithValue("@fecha_ingreso", objHabitanteBE.fecha_ingreso.HasValue ? (object)objHabitanteBE.fecha_ingreso.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@fecha_egreso", objHabitanteBE.fecha_egreso.HasValue ? (object)objHabitanteBE.fecha_egreso.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@foto", objHabitanteBE.foto ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@usuario_ult_mod", objHabitanteBE.Usu_Ult_Mod);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        public int ContarPropietariosDepartamento(int departamentoId, int idHabitanteActual)
        {
            using (SqlConnection cn = new SqlConnection(MiConexion.GetCnx()))
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT COUNT(*) 
                FROM Tb_Habitante 
                WHERE departamento_id = @departamento_id 
                AND es_propietario = 1 
                AND id <> @id", cn))
            {
                cmd.Parameters.AddWithValue("@departamento_id", departamentoId);
                cmd.Parameters.AddWithValue("@id", idHabitanteActual);

                cn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        public bool CambiarDepartamento(int habitanteId, int nuevoDepartamentoId, string usuario)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(new ConexionADO().GetCnx()))
                using (SqlCommand cmd = new SqlCommand("usp_Tb_Habitante_CambiarDepartamento", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@habitante_id", habitanteId);
                    cmd.Parameters.AddWithValue("@depto_destino", nuevoDepartamentoId);
                    cmd.Parameters.AddWithValue("@usuario", usuario);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al cambiar de departamento: " + ex.Message, ex);
            }
        }


        public Boolean EliminarHabitante(int idHabitante, DateTime fecUltMod, string usuUltMod)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Tb_Habitante_Eliminar";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@ID", idHabitante);               // ID correcto
                cmd.Parameters.AddWithValue("@Fec_Ult_Mod", fecUltMod);        // Fecha de modificación
                cmd.Parameters.AddWithValue("@Usu_Ult_Mod", usuUltMod);        // Usuario que modificó

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }


        public DataTable ListarHabitantesReporteExcel()
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_Tb_Habitante_Listar_reporte_excel";  // Aquí se usa el nuevo nombre del procedimiento almacenado
            try
            {
                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Habitantes");
                return dts.Tables["Habitantes"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

