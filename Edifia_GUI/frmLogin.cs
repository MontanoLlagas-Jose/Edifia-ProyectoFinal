using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Edifia_BE;
using Edifia_BL;

namespace Edifia_GUI
{
    public partial class frmLogin : Form
    {

        private UsuarioBL _usuarioBL;

        public frmLogin()
        {
            InitializeComponent();
            _usuarioBL = new UsuarioBL();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtUsuario.Text;
            string password = txtContra.Text;


            try
            {
                Usuario usuario = _usuarioBL.Login(login, password);
               

                clsCredenciales.Usuario = usuario.LoginUsuario;
                clsCredenciales.Password = usuario.PassUsuario;
                clsCredenciales.Nivel = usuario.NivelUsuario;

                // Aquí redireccionas a la siguiente pantalla de tu aplicación
                MDIPrincipal mDIPrincipal = new MDIPrincipal();
                mDIPrincipal.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                // Mostramos el mensaje de error
                MessageBox.Show("Credenciales incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Preguntamos si la tecla pulsada fue enter
            if (e.KeyChar == 13)
            {
                //Si se pulso enter mandar el mensaje de saludo
                btnLogin.PerformClick();
                //Limpiamos el textBOx
                txtContra.Text = String.Empty;
                txtUsuario.Text = String.Empty;
                txtUsuario.Focus();
            }
        }
    }
}
