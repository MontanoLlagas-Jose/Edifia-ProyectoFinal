using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregar....
using System.Data;
using System.Data.SqlClient;
using Edifia_BE;
using System.Configuration;

namespace Edifia_ADO
{
    public class DepartamentoADO
    {
        ConexionADO _conexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarDepartamento()
        {
            try
            {
                cnx.ConnectionString = _conexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Tb_Departamento_Listar";
                cmd.Parameters.Clear();

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();

                ada.Fill(dts, "Departamentos");
                return dts.Tables[0];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DepartamentoBE ConsultarDepartamento(String strDepartamento)
        {
            try
            {
                DepartamentoBE objDepartamentoBE = new DepartamentoBE();
                cnx.ConnectionString = _conexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Tb_Departamento_Consultar";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID", strDepartamento);

                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows)
                {
                    dtr.Read();
                    objDepartamentoBE.id = Convert.ToInt16(dtr["id"]);
                    objDepartamentoBE.numero = Convert.ToInt16(dtr["numero"]);
                    objDepartamentoBE.piso = Convert.ToInt16(dtr["piso"]);
                    objDepartamentoBE.edificio_id = Convert.ToInt16(dtr["edificio_id"]);
                    objDepartamentoBE.habitado = dtr["habitado"] != DBNull.Value && Convert.ToBoolean(dtr["habitado"]);

                    // Manejo de DBNull para el campo plano
                    objDepartamentoBE.plano = dtr["plano"] != DBNull.Value ? (byte[])dtr["plano"] : null;
                }
                dtr.Close();
                return objDepartamentoBE;
            }
            catch (Exception ex)
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


        public Boolean InsertarDepartamento(DepartamentoBE objDepartamentoBE)
        {
            try
            {
                cnx.ConnectionString = _conexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Tb_Departamento_Insertar";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@numero", objDepartamentoBE.numero);
                cmd.Parameters.AddWithValue("@piso", objDepartamentoBE.piso);
                cmd.Parameters.AddWithValue("@habitado", objDepartamentoBE.habitado);
                cmd.Parameters.AddWithValue("@edificio_id", objDepartamentoBE.edificio_id);
                cmd.Parameters.AddWithValue("@usu_registro", objDepartamentoBE.Usu_registro);

                SqlParameter paramPlano = new SqlParameter("@plano", SqlDbType.Image);
                if (objDepartamentoBE.plano == null || objDepartamentoBE.plano.Length == 0)
                {
                    paramPlano.Value = DBNull.Value;
                }
                else
                {
                    paramPlano.Value = objDepartamentoBE.plano;
                }
                cmd.Parameters.Add(paramPlano);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                // 2627 y 2601 son los códigos de error para violación de restricción única
                if (x.Number == 2627 || x.Number == 2601)
                    throw new ApplicationException("Ya existe un departamento con ese número en ese piso y edificio.");
                else
                    throw;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        public Boolean ActualizarDepartamento(DepartamentoBE objDepartamentoBE)
        {
            try
            {
                cnx.ConnectionString = _conexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Tb_Departamento_Actualizar";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", objDepartamentoBE.id);
                cmd.Parameters.AddWithValue("@numero", objDepartamentoBE.numero);
                cmd.Parameters.AddWithValue("@piso", objDepartamentoBE.piso);
                cmd.Parameters.AddWithValue("@edificio_id", objDepartamentoBE.edificio_id);
                cmd.Parameters.AddWithValue("@Fec_ult_mod", objDepartamentoBE.Fec_ult_mod);
                cmd.Parameters.AddWithValue("@Usu_ult_mod", objDepartamentoBE.Usu_ult_mod);
                cmd.Parameters.AddWithValue("@habitado", objDepartamentoBE.habitado);

                SqlParameter paramPlano = new SqlParameter("@plano", SqlDbType.Image);
                if (objDepartamentoBE.plano == null || objDepartamentoBE.plano.Length == 0)
                {
                    paramPlano.Value = DBNull.Value;
                }
                else
                {
                    paramPlano.Value = objDepartamentoBE.plano;
                }
                cmd.Parameters.Add(paramPlano);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                // 2627 y 2601 son los códigos de error para violación de restricción única
                if (x.Number == 2627 || x.Number == 2601)
                    throw new ApplicationException("Ya existe un departamento con ese número en ese piso y edificio.");
                else
                    throw;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }


        public Boolean EliminarDepartamento(int numero)
        {
            try
            {
                cnx.ConnectionString = _conexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Tb_Departamento_Eliminar";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", numero); 

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

        public DataTable ListarDepartamentosVisita()
        {
            DataTable dtDepartamentos = new DataTable();
            string connectionString = ConfigurationManager.ConnectionStrings["Edifia"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT d.id, 
                   CONCAT(d.numero, ' - ', e.nombre) AS DepartamentoEdificio,
                   d.numero  -- Mantener el número original
            FROM Tb_Departamento d
            INNER JOIN Tb_Edificio e ON d.edificio_id = e.id";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtDepartamentos);
            }
            return dtDepartamentos;
        }

    }
}
