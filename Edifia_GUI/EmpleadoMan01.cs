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
    public partial class EmpleadoMan01 : Form
    {
        EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        EmpleadoBE objEmpleadoBE = new EmpleadoBE();
        TipoEmpleadoBL objTipoEmpleadoBL = new TipoEmpleadoBL();
        HorarioBL objHorarioBL = new HorarioBL();

        
        public EmpleadoMan01()
        {
            InitializeComponent();
        }

        private void EmpleadoMan01_Load(object sender, EventArgs e)
        {


            DataTable dt = objTipoEmpleadoBL.ListarCargo();
            DataRow dr;
            dr = dt.NewRow();
            dr["id"] = 0;
            dr["nombre"] = "--Seleccione--";
            dt.Rows.InsertAt(dr, 0);
            cboCargo.DataSource = dt;
            cboCargo.ValueMember = "id";
            cboCargo.DisplayMember = "nombre";


            dt = objHorarioBL.ListarHorario();
            dr = dt.NewRow();
            dr["id"] = 0;
            dr["descripcion"] = "--Seleccione--";
            dt.Rows.InsertAt(dr, 0);
            cboHorario.DataSource = dt;
            cboHorario.ValueMember = "id";
            cboHorario.DisplayMember = "descripcion";

            // Inicializamos la imagen como vacía
            pcbFoto.Image = null;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                //Codifique
                //Validamos...
                if (txtNombre.Text.Trim() == String.Empty)
                {
                    throw new Exception("El nombre es obligatorio");
                }
                if (cboCargo.SelectedIndex == 0 || cboHorario.SelectedIndex == 0)
                {
                    throw new Exception("El cargo y el horario son obligatorios");
                }



                //si todo esta OK....cargamos el objEmpleadoBe
                objEmpleadoBE.documento = txtDNI.Text.Trim();
                objEmpleadoBE.nombre = txtNombre.Text.Trim();
                objEmpleadoBE.apellido = txtApellido.Text.Trim();
                objEmpleadoBE.tipo_id = Convert.ToInt16(cboCargo.SelectedValue);
                objEmpleadoBE.sexo = optMasculino.Checked;
                objEmpleadoBE.sexo = optFemenino.Checked;
                objEmpleadoBE.fecha_de_nacimiento = dtpFnac.Value;
                objEmpleadoBE.horario_id = Convert.ToInt16(cboHorario.SelectedValue);
                objEmpleadoBE.telefono = txtTelefono.Text.Trim();
                objEmpleadoBE.correo = txtCorreo.Text.Trim();
                objEmpleadoBE.fecha_inicio = DateTime.Now;
                objEmpleadoBE.usu_reg = clsCredenciales.Usuario.ToString();

                // Convertir la imagen a bytes
                if (pcbFoto.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pcbFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        objEmpleadoBE.foto = ms.ToArray();
                    }
                }
                else
                {
                    // Si no hay imagen, asignamos un array vacío
                    objEmpleadoBE.foto = null;
                }


                //Invocamos el metodo insertar
                if (objEmpleadoBL.InsertarEmpleado(objEmpleadoBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se realizo la accion, contactar con IT");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
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
    }
}
