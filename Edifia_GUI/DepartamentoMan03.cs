using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Edifia_BE;
using Edifia_BL;

namespace Edifia_GUI
{
    public partial class DepartamentoMan03 : Form
    {
        DepartamentoBL objDepartamentoBL = new DepartamentoBL();
        DepartamentoBE objDepartamentoBE = new DepartamentoBE();
        EdificioBL objEdificioBL = new EdificioBL();

        // Array de Bytes para conservar la foto original
        Byte[] FotoOriginal = null;
        // Flag para saber si se cargó una nueva foto
        private bool fotoModificada = false;

        public DepartamentoMan03()
        {
            InitializeComponent();
            this.Load += DepartamentoMan03_Load;
        }

        public Int16 id { get; set; }

        private void DepartamentoMan03_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargamos el combo de edificios
                DataTable dt = objEdificioBL.ListarEdificios();
                DataRow dr = dt.NewRow();
                dr["id"] = 0;
                dr["nombre"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboEdificio.DataSource = dt;
                cboEdificio.ValueMember = "id";
                cboEdificio.DisplayMember = "nombre";

                // Consultar departamento
                objDepartamentoBE = objDepartamentoBL.ConsultarDepartamento(this.id.ToString());

                lblid.Text = objDepartamentoBE.id.ToString();
                txtNumero.Text = objDepartamentoBE.numero.ToString();
                txtPiso.Text = objDepartamentoBE.piso.ToString();
                cboEdificio.SelectedValue = objDepartamentoBE.edificio_id;

                if (objDepartamentoBE.habitado)
                {
                    optHabitado.Checked = true;
                }
                else
                {
                    optDeshabitado.Checked = true;
                }

                // Cargar foto si existe
                if (objDepartamentoBE.plano != null && objDepartamentoBE.plano.Length > 0)
                {
                    using (MemoryStream fotoStream = new MemoryStream(objDepartamentoBE.plano))
                    {
                        pcbFoto.Image = Image.FromStream(fotoStream);
                    }
                    FotoOriginal = objDepartamentoBE.plano;
                }
                else
                {
                    pcbFoto.Image = null;
                    FotoOriginal = null;
                }

                // Inicializamos el flag de foto modificada
                fotoModificada = false;
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
                // Validaciones necesarias
                if (string.IsNullOrWhiteSpace(txtNumero.Text))
                {
                    throw new Exception("Introduzca un número de departamento.");
                }
                if (string.IsNullOrWhiteSpace(txtPiso.Text))
                {
                    throw new Exception("Introduzca un piso del edificio.");
                }
                if (cboEdificio.SelectedIndex == 0)
                {
                    throw new Exception("Elige un edificio.");
                }

                // Cargar datos en objDepartamentoBE
                objDepartamentoBE.numero = Convert.ToInt16(txtNumero.Text);
                objDepartamentoBE.piso = Convert.ToInt16(txtPiso.Text);
                objDepartamentoBE.edificio_id = Convert.ToInt16(cboEdificio.SelectedValue);
                objDepartamentoBE.Fec_ult_mod = DateTime.Now;
                objDepartamentoBE.habitado = optHabitado.Checked;
                objDepartamentoBE.Usu_ult_mod = clsCredenciales.Usuario.ToString();

                // Manejar la foto solo si se ha modificado
                if (fotoModificada)
                {
                    if (pcbFoto.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            pcbFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            objDepartamentoBE.plano = ms.ToArray();
                        }
                    }
                    else
                    {
                        objDepartamentoBE.plano = new byte[0];
                    }
                }
                // Si no se modificó la foto, mantener la original que ya está en objDepartamentoBE

                // Invocar al método ActualizarDepartamento
                if (objDepartamentoBL.ActualizarDepartamento(objDepartamentoBE))
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se realizó la acción, contacte con el administrador de la red.");
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
                        FotoOriginal = File.ReadAllBytes(openFileDialog1.FileName);
                        fotoModificada = true; // Marcamos que la foto ha sido modificada
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