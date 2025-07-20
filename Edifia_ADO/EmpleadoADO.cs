using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edifia_BE;
using System.Data.SqlClient;
using System.Data;


namespace Edifia_ADO
{

    public class EmpleadoADO
    {

        private readonly ConexionADO _conexion;

        public EmpleadoADO()
        {
            _conexion = new ConexionADO();
        }

        // Instancias.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarEmpleado()
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_Tb_Empleado_Listar";
            try
            {

                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Empleados");
                return dts.Tables["Empleados"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public DataTable ListarEmpleadoEmpleado()
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_Empleados";
            try
            {

                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Empleados");
                return dts.Tables["Empleados"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public EmpleadoBE ConsultarEmpleado(String strdocumento)
        {

            try
            {
                //Codifique
                EmpleadoBE objEmpleadoBE = new EmpleadoBE();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Tb_Empleado_Consultar";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@documento", strdocumento);

                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {


                    dtr.Read();
                    objEmpleadoBE.documento = dtr["documento"].ToString();
                    objEmpleadoBE.nombre = dtr["Nombre"].ToString();
                    objEmpleadoBE.apellido = dtr["Apellido"].ToString();
                    objEmpleadoBE.fecha_de_nacimiento = (DateTime)dtr["fecha_de_nacimiento"];
                    objEmpleadoBE.tipo_id = Convert.ToInt16(dtr["tipo_id"]);
                    objEmpleadoBE.sexo = Convert.ToBoolean(dtr["sexo"]);
                    objEmpleadoBE.telefono = dtr["Telefono"].ToString();
                    objEmpleadoBE.correo = dtr["Correo"].ToString();
                    objEmpleadoBE.horario_id = Convert.ToInt16(dtr["horario_id"]);
                    objEmpleadoBE.fecha_inicio = (DateTime)dtr["fecha_inicio"];

                    if (dtr["foto"] != DBNull.Value)
                    {
                        objEmpleadoBE.foto = (byte[])dtr["foto"];
                    }
                    else
                    {
                        objEmpleadoBE.foto = null; // O un array vacío si prefieres
                    }



                }
                dtr.Close();
                return objEmpleadoBE;
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

        public Boolean InsertarEmpleado(EmpleadoBE objEmpleadoBE)
        {

            try
            {

           
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_tb_Empleado_Insertar";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@documento", objEmpleadoBE.documento);
                cmd.Parameters.AddWithValue("@nombre", objEmpleadoBE.nombre);
                cmd.Parameters.AddWithValue("@apellido", objEmpleadoBE.apellido);
                cmd.Parameters.AddWithValue("@sexo", objEmpleadoBE.sexo);
                cmd.Parameters.AddWithValue("fecha_de_nacimiento", objEmpleadoBE.fecha_de_nacimiento);
                cmd.Parameters.AddWithValue("@tipo_id", objEmpleadoBE.tipo_id);
                cmd.Parameters.AddWithValue("telefono", objEmpleadoBE.telefono);
                cmd.Parameters.AddWithValue("correo", objEmpleadoBE.correo);
                cmd.Parameters.AddWithValue("foto", objEmpleadoBE.foto);
                cmd.Parameters.AddWithValue("@horario_id", objEmpleadoBE.horario_id);
                cmd.Parameters.AddWithValue("@Usu_Registro", objEmpleadoBE.usu_reg);
        

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
               
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }
        }

        public Boolean ActualizarEmpleado(EmpleadoBE objEmpleadoBE)
        {


            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Tb_Empleado_Actualizar";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@documento", objEmpleadoBE.documento);
                cmd.Parameters.AddWithValue("@nombre", objEmpleadoBE.nombre);
                cmd.Parameters.AddWithValue("@apellido", objEmpleadoBE.apellido);
                cmd.Parameters.AddWithValue("@sexo", objEmpleadoBE.sexo);
                cmd.Parameters.AddWithValue("@fecha_de_nacimiento", objEmpleadoBE.fecha_de_nacimiento);
                cmd.Parameters.AddWithValue("@telefono", objEmpleadoBE.telefono);
                cmd.Parameters.AddWithValue("@correo", objEmpleadoBE.correo);
                cmd.Parameters.AddWithValue("@tipo_id", objEmpleadoBE.tipo_id);
                cmd.Parameters.AddWithValue("@horario_id", objEmpleadoBE.horario_id);
                cmd.Parameters.AddWithValue("foto", objEmpleadoBE.foto);
                cmd.Parameters.AddWithValue("@fecha_inicio", objEmpleadoBE.fecha_inicio);
                cmd.Parameters.AddWithValue("@Usu_Ult_Mod", objEmpleadoBE.usu_ult_mod);
              

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

        public Boolean EliminarEmpleado(String strDNI)
        {


            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Tb_Empleado_Eliminar";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@documento", strDNI);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                return false; //al retornar primero el falso, se arregla el error de mostrar el error detallado
                throw new Exception(x.Message);

            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }
        }

        public DataTable ListarEmpleadoReporteExcel()
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_Tb_Empleado_Listar_repote_excel"; // Procedimiento almacenado

            try
            {
                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "EmpleadosReporte");

                // Devuelve el DataTable con los resultados
                return dts.Tables["EmpleadosReporte"];
            }
            catch (SqlException ex)
            {
                // Manejo de errores: si ocurre un error, lo lanzamos como una excepción
                throw new Exception(ex.Message);
            }
        }

    }
}
