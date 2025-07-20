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
using Edifia_BE;
using Edifia_BL;

namespace Edifia_GUI
{
    public partial class HabitanteMan03 : Form
    {
        // Instancias...
        HabitanteBL objHabitanteBL = new HabitanteBL();
        HabitanteBE objHabitanteBE = new HabitanteBE();
        DepartamentoBL objDepartamentoBL = new DepartamentoBL();

        // Variables para la foto
        private byte[] fotoOriginal;
        private bool fotoModificada = false;
        private int habitanteId;

        // Constructor que recibe el código del habitante
        public HabitanteMan03(int id)
        {
            InitializeComponent();
            habitanteId = id;
        }

        public int Codigo { get; set; }
        Boolean flag = false;

        private void HabitanteMan03_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargar departamentos
                CargarCombo();

                // Cargar los datos del habitante
                CargarDatos();

                // Configurar los MonthCalendar
                mcCalendarioIngreso.MaxSelectionCount = 1;
                mcCalendarioEgreso.MaxSelectionCount = 1;

                
                //Cargar la foto si existe
                if (objHabitanteBE.foto != null)
                {
                    using (var ms = new System.IO.MemoryStream(objHabitanteBE.foto))
                    {
                        pbFoto.Image = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void CargarCombo()
        {
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

        private void CargarDatos()
        {
            try
            {
                // Obtener los datos del habitante
                objHabitanteBE = objHabitanteBL.ConsultarHabitante(habitanteId);

                // Cargar los datos en los controles
                mtboxDoc.Text = objHabitanteBE.documento;
                txtNom.Text = objHabitanteBE.nombre;
                txtApe.Text = objHabitanteBE.apellido;
                mcCalendarioIngreso.SelectionStart = objHabitanteBE.fecha_ingreso ?? DateTime.Now;
                mcCalendarioEgreso.SelectionStart = objHabitanteBE.fecha_egreso ?? DateTime.Now;
                chkbPropietario.Checked = objHabitanteBE.es_propietario;
                cboDepartamento.SelectedValue = objHabitanteBE.departamento_id;

                // Cargar fechas
                if (objHabitanteBE.fecha_ingreso.HasValue)
                {
                    mcCalendarioIngreso.SetDate(objHabitanteBE.fecha_ingreso.Value);
                }

                if (objHabitanteBE.fecha_egreso.HasValue)
                {
                    mcCalendarioEgreso.SetDate(objHabitanteBE.fecha_egreso.Value);
                }

                // Cargar la foto si existe
                if (objHabitanteBE.foto != null && objHabitanteBE.foto.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(objHabitanteBE.foto))
                    {
                        pbFoto.Image = Image.FromStream(ms);
                    }
                    fotoOriginal = objHabitanteBE.foto;
                }

                
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar los datos: " + ex.Message);
            }
        }

        private int departamentoOriginalId;

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones
                if (txtNom.Text.Trim() == "")
                    throw new Exception("El nombre es obligatorio.");
                if (txtApe.Text.Trim() == "")
                    throw new Exception("El apellido es obligatorio.");
                if (mtboxDoc.Text.Trim().Length < 8)
                    throw new Exception("El DNI debe tener 8 dígitos.");
                if (pbFoto.Image == null)
                    throw new Exception("Debe cargar una foto.");
                if (cboDepartamento.SelectedValue == null || (int)cboDepartamento.SelectedValue == 0)
                    throw new Exception("Debe seleccionar un número de departamento válido.");

                int nuevoDepartamentoId = (int)cboDepartamento.SelectedValue;

                // Actualizar datos del objeto
                objHabitanteBE.id = habitanteId;
                objHabitanteBE.nombre = txtNom.Text.Trim();
                objHabitanteBE.apellido = txtApe.Text.Trim();
                objHabitanteBE.documento = mtboxDoc.Text.Trim();
                objHabitanteBE.departamento_id = Convert.ToInt32(cboDepartamento.SelectedValue);
                objHabitanteBE.fecha_ingreso = mcCalendarioIngreso.SelectionStart.Date;
                objHabitanteBE.fecha_egreso = mcCalendarioEgreso.SelectionStart;
                objHabitanteBE.es_propietario = chkbPropietario.Checked;
                objHabitanteBE.Usu_Ult_Mod = clsCredenciales.Usuario;
                objHabitanteBE.Fec_reg = DateTime.Now;
                

                // Actualizar foto solo si se modificó
                if (fotoModificada)
                {
                    objHabitanteBE.foto = File.ReadAllBytes(openFileDialog1.FileName);
                }
                // Auditoría
                objHabitanteBE.Usu_Ult_Mod = clsCredenciales.Usuario; // Asignar el usuario actual

                // Actualizar
                ResultadoOperacion r = objHabitanteBL.ActualizarHabitante(objHabitanteBE);

                if (nuevoDepartamentoId != departamentoOriginalId)
                {
                    // HU017 - Cambiar departamento con historial y validación
                    r = objHabitanteBL.CambiarDepartamento(
                            objHabitanteBE.id,
                            nuevoDepartamentoId,
                            clsCredenciales.Usuario);
                }
                else
                {
                    // HU011 / HU012 - Solo actualizar datos personales
                    r = objHabitanteBL.ActualizarHabitante(objHabitanteBE);
                }

                switch (r.Tipo)
                {
                    case "OK":
                        MessageBox.Show(r.Mensaje,               // “Habitante actualizado correctamente.”
                                        "Actualización exitosa",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        // Si quieres refrescar la lista:
                        if (this.Owner is HabitanteMan01 frm)
                            frm.CargarDatosHabitante("");   // ahora compila
                                                          // usa el método que tengas

                        this.Close();                            // cierra el editor
                        break;

                    case "RECUPERABLE":
                        // Por ejemplo: “El departamento ya tiene un propietario registrado…”
                        MessageBox.Show(r.Mensaje,
                                        "Advertencia",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.FileName = String.Empty;
                openFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pbFoto.Image = Image.FromFile(openFileDialog1.FileName);
                    fotoModificada = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la foto: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir números y tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Limitar a 3 dígitos
            TextBox txt = (TextBox)sender;
            if (txt.Text.Length >= 3 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}