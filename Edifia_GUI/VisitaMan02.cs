using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Edifia_BE;
using Edifia_BL;

namespace Edifia_GUI
{
    public partial class VisitaMan02 : Form
    {
        VisitaBL objVisitaBL = new VisitaBL();
        VisitaBE objVisitaBE = new VisitaBE();
        TipoVisitaBL objTipoVisitaBL = new TipoVisitaBL();
        DepartamentoBL objDepartamentoBL = new DepartamentoBL();
        AreaComunBL objAreaComunBL = new AreaComunBL();

        public VisitaMan02()
        {
            InitializeComponent();
        }

        private void VisitaMan02_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargar tipos de visita
                DataTable dtTipoVisita = objTipoVisitaBL.ListarTipoVisita();
                DataRow drTipoVisita = dtTipoVisita.NewRow();
                drTipoVisita["id"] = 0;
                drTipoVisita["nombre"] = "-Seleccione-";
                dtTipoVisita.Rows.InsertAt(drTipoVisita, 0);
                cbbox1.DataSource = dtTipoVisita;
                cbbox1.ValueMember = "id";
                cbbox1.DisplayMember = "nombre";

                // Cargar áreas comunes
                DataTable dtAreaComun = objAreaComunBL.ListarAreaComun();
                DataRow drAreaComun = dtAreaComun.NewRow();
                drAreaComun["id"] = 0;
                drAreaComun["nombre"] = "-Seleccione-";
                dtAreaComun.Rows.InsertAt(drAreaComun, 0);
                cbbox2.DataSource = dtAreaComun;
                cbbox2.ValueMember = "id";
                cbbox2.DisplayMember = "nombre";

                // Cargar departamentos
                DataTable dtDepartamento = objDepartamentoBL.ListarDepartamentosVisita();
                DataRow drDepartamento = dtDepartamento.NewRow();
                drDepartamento["id"] = 0;
                drDepartamento["DepartamentoEdificio"] = "-Seleccione-";
                dtDepartamento.Rows.InsertAt(drDepartamento, 0);
                cboDerpartamento.DataSource = dtDepartamento;
                cboDerpartamento.ValueMember = "id";
                cboDerpartamento.DisplayMember = "DepartamentoEdificio";

                // Cargar horas y minutos para entrada
                for (int i = 0; i < 24; i++)
                {
                    cboHoraEntrada.Items.Add(i.ToString("D2"));
                }

                for (int i = 0; i < 60; i += 1)
                {
                    cboMinutoEntrada.Items.Add(i.ToString("D2"));
                }

                DateTime now = DateTime.Now;
                cboHoraEntrada.SelectedItem = now.Hour.ToString("D2");
                cboMinutoEntrada.SelectedItem = now.Minute.ToString("D2");
                mcCalendarioEntrada.SelectionStart = now.Date;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones de entrada
                if (string.IsNullOrWhiteSpace(txtNom.Text))
                    throw new Exception("Introduzca el nombre del visitante.");
                if (string.IsNullOrWhiteSpace(txtApe.Text))
                    throw new Exception("Introduzca el apellido del visitante.");
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtNom.Text, @"^[a-zA-Z]+$"))
                    throw new Exception("El nombre solo debe contener letras.");

                // Nueva validación de apellido que permite múltiples palabras
                string apellidoLimpio = txtApe.Text.Trim();
                if (!System.Text.RegularExpressions.Regex.IsMatch(apellidoLimpio, @"^[a-zA-Z]+(?:\s[a-zA-Z]+)*$"))
                    throw new Exception("El apellido solo debe contener letras y palabras separadas por un espacio.");

                if (string.IsNullOrWhiteSpace(mtboxDoc.Text))
                    throw new Exception("Introduzca el documento del visitante.");
                if (cbbox1.SelectedItem == null || !(cbbox1.SelectedItem is DataRowView drv) || Convert.ToInt32(drv["id"]) == 0)
                    throw new Exception("Por favor, selecciona un valor válido para el propósito de la visita.");
                if (cbbox2.SelectedItem == null || !(cbbox2.SelectedItem is DataRowView drvArea) || Convert.ToInt32(drvArea["id"]) == 0)
                    throw new Exception("Por favor, selecciona un valor válido para el área común.");

                //Jose
                if (cboDerpartamento.SelectedItem == null || !(cboDerpartamento.SelectedItem is DataRowView drvDepartamento) || Convert.ToInt32(drvDepartamento["id"]) == 0)
                    throw new Exception("Por favor, selecciona un valor válido para el departamento.");
                //Jose

                // Cargar el objeto VisitaBE con los valores ingresados
                objVisitaBE.nombre = txtNom.Text.Trim();
                objVisitaBE.apellido = apellidoLimpio; // Usamos el apellido ya limpio
                objVisitaBE.documento = mtboxDoc.Text.Trim();
                objVisitaBE.departamento_id = Convert.ToInt32(cboDerpartamento.SelectedValue);

                // Configurar fecha y hora de entrada
                objVisitaBE.fecha_entrada = mcCalendarioEntrada.SelectionStart.Date;
                int horaEntrada = int.Parse(cboHoraEntrada.SelectedItem.ToString());
                int minutoEntrada = int.Parse(cboMinutoEntrada.SelectedItem.ToString());
                objVisitaBE.hora_entrada = new TimeSpan(horaEntrada, minutoEntrada, 0);
                objVisitaBE.fecha_salida = null;
                objVisitaBE.hora_salida = null;

                // Establecer IDs de tipo y área común
                objVisitaBE.tipo_id = Convert.ToInt16(drv["id"]);
                objVisitaBE.area_comun_id = Convert.ToInt16(drvArea["id"]);
                objVisitaBE.proposito = drv["nombre"].ToString();

                // Establecer campos de auditoría
                objVisitaBE.Fec_reg = DateTime.Now;
                objVisitaBE.Usu_Registro = clsCredenciales.Usuario;

                // Insertar la visita
                if (objVisitaBL.InsertarVisita(objVisitaBE))
                {
                    string mensaje = $"Invitado agregado con éxito\n\n" +
                     $"Nombre: {objVisitaBE.nombre} {objVisitaBE.apellido}\n" +
                     $"Documento: {objVisitaBE.documento}\n" +
                     $"Departamento: {objVisitaBE.departamento_id}\n" +
                     $"Propósito: {objVisitaBE.proposito}\n" +
                     $"Hora de entrada: {objVisitaBE.hora_entrada?.ToString(@"hh\:mm")}";

                    MessageBox.Show(mensaje, "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar al visitante. Intente nuevamente o contacte al administrador.",
                    "Error al registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Error SQL: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al grabar: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
