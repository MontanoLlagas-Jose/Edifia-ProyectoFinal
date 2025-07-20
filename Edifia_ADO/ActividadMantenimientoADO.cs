using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edifia_ADO
{
    public class ActividadMantenimientoADO
    {
        private readonly ConexionADO _conexion;

        public ActividadMantenimientoADO()
        {
            _conexion = new ConexionADO();
        }


        // Instancias.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarActividadMantenimiento()
        {
            DataSet dts = new DataSet();
            try
            {
                cnx.ConnectionString = _conexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Tb_ActividadMantenimiento_Listar";
                cmd.Parameters.Clear();

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "ActividadMantenimiento");
                return dts.Tables["ActividadMantenimiento"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
