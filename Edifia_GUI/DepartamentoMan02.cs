using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Edifia_BE;
using Edifia_BL;

namespace Edifia_GUI
{
    public partial class DepartamentoMan02 : Form
    {
        DepartamentoBL objDepartamentoBL = new DepartamentoBL();
        DepartamentoBE objDepartamentoBE = new DepartamentoBE();
        EdificioBL objEdificioBL = new EdificioBL();

        public DepartamentoMan02()
        {
            InitializeComponent();
        }

        private void DepartamentoMan02_Load(object sender, EventArgs e)
        {
            try
            {
                //cargamos el combo
                DataTable dt = objEdificioBL.ListarEdificios();
                DataRow dr;
                dr = dt.NewRow();
                dr["id"] = 0;
                dr["nombre"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboEdificio.DataSource = dt;
                cboEdificio.ValueMember = "id";
                cboEdificio.DisplayMember = "nombre";

                // Inicializamos la imagen como vacía
                pcbFoto.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones de campos obligatorios
                if (txtNumero.Text.Trim() == String.Empty)
                {
                    throw new Exception("Introduzca un numero de departamento.");
                }
                if (txtPiso.Text.Trim() == String.Empty)
                {
                    throw new Exception("Introduzca un piso del edificio.");
                }
                if (cboEdificio.SelectedIndex == 0)
                {
                    throw new Exception("Elige un edificio.");
                }

                // Cargamos los datos básicos en el objDepartamentoBE
                objDepartamentoBE.numero = Convert.ToInt16(txtNumero.Text);
                objDepartamentoBE.piso = Convert.ToInt16(txtPiso.Text);
                objDepartamentoBE.edificio_id = Convert.ToInt16(cboEdificio.SelectedValue);
                objDepartamentoBE.Fec_reg = DateTime.Now;
                objDepartamentoBE.habitado = optHabitado.Checked;
                objDepartamentoBE.Usu_registro = clsCredenciales.Usuario.ToString();

                // Manejamos la foto (ahora opcional)
                if (pcbFoto.Image != null)
                {
                    // Si hay una imagen, la convertimos a bytes
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pcbFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        objDepartamentoBE.plano = ms.ToArray();
                    }
                }
                else
                {
                    // Si no hay imagen, asignamos un array vacío
                    objDepartamentoBE.plano = new byte[0];
                }

                // Invocamos al método insertar
                if (objDepartamentoBL.InsertarDepartamento(objDepartamentoBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se realizo la accion, contactar con el admministrador de la red.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
                {
                    openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                    openFileDialog1.Title = "Seleccionar Plano";

                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        pcbFoto.Image = Image.FromFile(openFileDialog1.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtPiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}