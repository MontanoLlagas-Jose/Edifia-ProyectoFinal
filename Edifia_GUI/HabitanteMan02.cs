using Edifia_BE;
using Edifia_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edifia_GUI
{

    public partial class HabitanteMan02 : Form
    {
        // Instancias...
        HabitanteBL objHabitanteBL = new HabitanteBL();
        HabitanteBE objHabitanteBE = new HabitanteBE();
        DepartamentoBL objDepartamentoBL = new DepartamentoBL();
        DepartamentoBE objDepartamentoBE = new DepartamentoBE();

        public HabitanteMan02()
        {
            InitializeComponent();
        }

        private void HabitanteMan02_Load(object sender, EventArgs e)
        {
            mcCalendarioIngreso.SelectionStart = DateTime.Now;
            // Cargar departamentos
            DataTable dtDepartamento = objDepartamentoBL.ListarDepartamentosVisita();
            DataRow drDepartamento = dtDepartamento.NewRow();
            drDepartamento["id"] = 0;
            drDepartamento["DepartamentoEdificio"] = "-Seleccione-";
            dtDepartamento.Rows.InsertAt(drDepartamento, 0);
            cboDepartamento.DataSource = dtDepartamento;
            cboDepartamento.ValueMember = "id";
            cboDepartamento.DisplayMember = "DepartamentoEdificio";
        }

        // Función general para detectar números
        private void DetectarNumeros(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
            {
                if (char.IsDigit(e.KeyChar) == false)
                {
                    e.Handled = true;
                }
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones...
                ValidarCampoTexto(txtNom, "El nombre es obligatorio.", @"^[a-zA-Z\s]+$", "El nombre solo debe contener letras y espacios.");
                ValidarCampoTexto(txtApe, "El apellido es obligatorio.", @"^[a-zA-Z\s]+$", "El apellido solo debe contener letras y espacios.");
                ValidarDNI(mtboxDoc);
                ValidarFoto(pbFoto);
                ValidarFecha(mcCalendarioIngreso.SelectionStart.Date, "La fecha de ingreso no es válida.");

                if (cboDepartamento.SelectedValue == null ||
                (int)cboDepartamento.SelectedValue == 0)
                    throw new Exception("Debe seleccionar un departamento.");
            }
            catch (Exception ex)   // error de entrada → mostrar y salir
            {
                MessageBox.Show(ex.Message, "Dato inválido",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;            // no continúa al BL
            }
            // RECONSTRUIMOS objeto limpio
            HabitanteBE objHabitanteBE = new HabitanteBE
                {
                    nombre = txtNom.Text.Trim(),
                    apellido = txtApe.Text.Trim(),
                    documento = mtboxDoc.Text.Trim(),
                    departamento_id = Convert.ToInt32(cboDepartamento.SelectedValue),
                    Fec_reg = DateTime.Now,
                    foto = File.ReadAllBytes(openFileDialog1.FileName),
                    fecha_ingreso = mcCalendarioIngreso.SelectionStart.Date,
                    es_propietario = chkPropietario.Checked,
                    Usu_Registro = clsCredenciales.Usuario
                };
            try 
            { 
                ResultadoOperacion resultado = objHabitanteBL.InsertarHabitante(objHabitanteBE, clsCredenciales.Usuario);

                switch (resultado.Tipo)
                {
                    case "OK":
                        MessageBox.Show(resultado.Mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); // o LimpiarFormulario()
                        break;

                    case "RECUPERABLE":
                        MessageBox.Show(resultado.Mensaje + "\nPuede reintentar sin perder los datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado al intentar registrar el habitante. Contacte con soporte.", "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void ValidarCampoTexto(TextBox textBox, string mensajeVacio, string patron, string mensajePatron)
        {
            if (textBox.Text.Trim() == String.Empty)
            {
                throw new Exception(mensajeVacio);
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, patron))
            {
                throw new Exception(mensajePatron);
            }
        }

        private void ValidarDNI(MaskedTextBox mtboxDoc)
        {
            if (mtboxDoc.Text.Trim() == String.Empty)
            {
                throw new Exception("El número de DNI es obligatorio.");
            }
            if (mtboxDoc.Text.Trim().Length < 8)
            {
                throw new Exception("El número de DNI debe tener 8 dígitos.");
            }
        }

       
        private void ValidarFoto(PictureBox pbFoto)
        {
            if (pbFoto.Image == null)
            {
                throw new Exception("La foto es obligatoria.");
            }
        }

        private void ValidarFecha(DateTime fecha, string mensajeError)
        {
            if (fecha < new DateTime(1753, 1, 1) || fecha > new DateTime(9999, 12, 31))
            {
                throw new Exception(mensajeError);
            }
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.FileName = String.Empty;
                openFileDialog1.Multiselect = false;
                openFileDialog1.Filter = "Archivos de imagen (*.jpg, *.png) | *.jpg; *.png";
                openFileDialog1.ShowDialog();

                if (openFileDialog1.FileName != String.Empty)
                {
                    pbFoto.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
