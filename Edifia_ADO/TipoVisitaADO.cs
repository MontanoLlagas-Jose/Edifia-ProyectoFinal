using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Edifia_ADO
{ 
    public class TipoVisitaADO
{

    ConexionADO MiConexion = new ConexionADO();
    SqlConnection cnx = new SqlConnection();
    SqlCommand cmd = new SqlCommand();
    SqlDataReader dtr;

    public DataTable ListarTipoVisita()
    {

        try
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_Tb_TipoVisita_Listar";

            cmd.Parameters.Clear();
            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            ada.Fill(dts, "TiposVisitas");
            return dts.Tables["TiposVisitas"];
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message);
        }

    }
}
}

