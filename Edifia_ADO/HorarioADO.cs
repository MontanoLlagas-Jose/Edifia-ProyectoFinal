using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edifia_ADO
{

    public class HorarioADO
    {

        // Instancias.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarHorario()
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarHorarios";
            try
            {

                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Horarios");
                return dts.Tables["Horarios"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public string ObtenerDescripcionHorario(int horarioId)
        {
            try
            {
                // Construimos la cadena de conexión
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT nombre FROM Tb_Horario WHERE id = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", horarioId);

                // Abrimos la conexión
                cnx.Open();
                string descripcion = cmd.ExecuteScalar()?.ToString();
                return descripcion ?? "No encontrado";
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la descripcion del horario: " + ex.Message);
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

