using System.Data.SqlClient;
using System.Data;
using Edifia_BE;

namespace Edifia_ADO
{
    public class UsuarioADO
    {
        private readonly ConexionADO _conexion;

        public UsuarioADO()
        {
            _conexion = new ConexionADO();
        }

        public Usuario Login(string login, string password)
        {
            Usuario usuario = null;

            using (SqlConnection con = new SqlConnection(_conexion.GetCnx())) // Usamos GetCnx para obtener la cadena
            {
                string query = "EXEC sp_IniciarSesion @login_Usuario, @pass_Usuario"; // Llamando al procedimiento almacenado
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@login_Usuario", login);
                cmd.Parameters.AddWithValue("@pass_Usuario", password); // Considera encriptar la contraseña

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    usuario = new Usuario
                    {
                        Id = Convert.ToInt32(reader["id_Usuario"]),
                        NivelUsuario = Convert.ToInt32(reader["nivel_Usuario"]),
                        LoginUsuario = login // Asignamos el login al objeto usuario
                    };
                }
                else
                {
                    throw new Exception("Credenciales incorrectas o usuario inactivo.");
                }
            }

            return usuario;
        }
    }
}
