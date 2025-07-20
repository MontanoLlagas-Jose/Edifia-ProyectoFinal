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
    public partial class EmpleadoMan02 : Form
    {
        EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        EmpleadoBE objEmpleadoBE = new EmpleadoBE();
        TipoEmpleadoBL objTipoEmpleadoBL = new TipoEmpleadoBL();
        HorarioBL objHorarioBL = new HorarioBL();

        Byte[] FotoOriginal = null;
        private bool fotoModificada = false;

        public EmpleadoMan02()
        {
            InitializeComponent();
        }

        public String documento { get; set; }


        private void EmpleadoMan02_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargamos los combos...
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

          

                // consultamos el empleado que se va a actualizar...
                objEmpleadoBE = objEmpleadoBL.ConsultarEmpleado(this.documento.ToString());

                //mostramos los datos del empleado....
                lblDNI.Text = objEmpleadoBE.documento;
                txtNombre.Text = objEmpleadoBE.nombre;
                txtApellido.Text = objEmpleadoBE.apellido;
                dtpFnac.Value = objEmpleadoBE.fecha_de_nacimiento;
                cboCargo.SelectedValue = objEmpleadoBE.tipo_id;
                cboHorario.SelectedValue = objEmpleadoBE.horario_id;
                txtTelefono.Text = objEmpleadoBE.telefono;
                txtCorreo.Text = objEmpleadoBE.correo;
                dtpFini.Value = objEmpleadoBE.fecha_inicio;

               
                bool sexo = objEmpleadoBE.sexo; 
                if (sexo) // 1 = Masculino
                {
                    optMasculino.Checked = true;
                    optFemenino.Checked = false;  
                }
                else // 0 = Femenino
                {
                    optFemenino.Checked = true;
                    optMasculino.Checked = false; 
                }



                if (objEmpleadoBE.foto != null && objEmpleadoBE.foto.Length > 0 )
                {
                    using (MemoryStream ms = new MemoryStream(objEmpleadoBE.foto))
                    {
                        pcbFoto.Image = Image.FromStream(ms);  // Convertimos el byte[] de la foto en una imagen y la asignamos al PictureBox
                    }
                }
                else
                {
                    FotoOriginal = objEmpleadoBE.foto; // O lo que prefieras en caso de que no tenga foto
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtNombre.Text.Trim() == String.Empty)
                {
                    throw new Exception("El nombre es obligatorio");
                }


                objEmpleadoBE.nombre = txtNombre.Text.Trim();
                objEmpleadoBE.apellido = txtApellido.Text.Trim();
                // Determinar el sexo basado en los RadioButton
                if (optMasculino.Checked)
                {
                    objEmpleadoBE.sexo = true; // Masculino
                }
                else if (optFemenino.Checked)
                {
                    objEmpleadoBE.sexo = false; // Femenino
                }
                else
                {
                    throw new Exception("Debe seleccionar un género para el empleado.");
                }

                objEmpleadoBE.fecha_de_nacimiento = dtpFnac.Value;
                objEmpleadoBE.tipo_id = Convert.ToInt16(cboCargo.SelectedValue);
                objEmpleadoBE.telefono = txtTelefono.Text.Trim();
                objEmpleadoBE.correo = txtCorreo.Text.Trim();
                objEmpleadoBE.horario_id = Convert.ToInt16(cboHorario.SelectedValue);
                objEmpleadoBE.fecha_inicio = dtpFini.Value;

                // Manejar la foto solo si se ha modificado
                if (fotoModificada)
                {
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
                        objEmpleadoBE.foto = new byte[0];
                    }
                }
                // Si no se modificó la foto, mantener la original que ya está en objDepartamentoBE


                //por ahora el usuario de ultima modificacion lo colorameros "en duro"
                objEmpleadoBE.usu_ult_mod = clsCredenciales.Usuario;

                //Invocamos el metodo actualizar
                if (objEmpleadoBL.ActualizarEmpleado(objEmpleadoBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se pudo realizar la accion contactar con el administrador");
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
                    openFileDialog1.Title = "Seleccionar foto";

                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        pcbFoto.Image = Image.FromFile(openFileDialog1.FileName);
                        FotoOriginal = File.ReadAllBytes(openFileDialog1.FileName);
                        fotoModificada = true;
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
