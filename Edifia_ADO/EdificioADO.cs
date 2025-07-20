using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Edifia_ADO
{
    public class EdificioADO
    {
        ConexionADO _conexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarEdificios()
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = _conexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarEdificios";
            try
            {

                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Edificios");
                return dts.Tables["Edificios"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public string ObtenerNombreEdificio(int edificioId)
        {
            try
            {
                // Construimos la cadena de conexión
                cnx.ConnectionString = _conexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT nombre FROM Tb_edificio WHERE id = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", edificioId);

                // Abrimos la conexión
                cnx.Open();
                string nombre = cmd.ExecuteScalar()?.ToString();
                return nombre ?? "No encontrado";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el nombre del edificio: " + ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }
    }
}
