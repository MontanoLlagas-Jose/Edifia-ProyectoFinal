using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Edifia_BE;
using Edifia_BL;

namespace Edifia_GUI 
{ 
    public partial class VisitaMan03 : Form
    {
        VisitaBL objVisitaBL = new VisitaBL();
        VisitaBE objVisitaBE = new VisitaBE();
        TipoVisitaBL objTipoVisitaBL = new TipoVisitaBL();
        DepartamentoBL objDepartamentoBL = new DepartamentoBL();
        AreaComunBL objAreaComunBL = new AreaComunBL();

        public int id { get; set; }  

        public VisitaMan03()
        {
            InitializeComponent();
        }

        private void VisitaMan03_Load(object sender, EventArgs e)
        {
            if (id <= 0)
            {
                MessageBox.Show("ID inválido. No se puede cargar la visita.");
                this.Close();
                return;
            }

            try
            {
                CargarCombos();
                CargarHorasMinutos();
                CargarDatosVisita();

                VisitaBE visitaActual = objVisitaBL.ObtenerVisitaPorId(id);
                if (visitaActual != null && visitaActual.fecha_salida.HasValue)
                {
                    MessageBox.Show("La visita ya se encuentra retirada. No puede modificarse.",
                                    "Visita finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnGrabar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message);
            }
        }

        private void CargarCombos()
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
        }

        private void CargarHorasMinutos()
        {
            // Cargar horas y minutos para entrada
            for (int i = 0; i < 24; i++)
            {
                cboHoraEntrada.Items.Add(i.ToString("D2"));
            }

            for (int i = 0; i < 60; i++)
            {
                cboMinutoEntrada.Items.Add(i.ToString("D2"));
            }

            // Cargar horas y minutos para salida
            for (int i = 0; i < 24; i++)
            {
                cboHoraSalida.Items.Add(i.ToString("D2"));
            }

            for (int i = 0; i < 60; i++)
            {
                cboMinutoSalida.Items.Add(i.ToString("D2"));
            }

            // Establecer fecha y hora por defecto
            DateTime now = DateTime.Now;
            cboHoraEntrada.SelectedItem = now.Hour.ToString("D2");
            cboMinutoEntrada.SelectedItem = now.Minute.ToString("D2");
            mcCalendarioEntrada.SelectionStart = now.Date;
        }

        private void CargarDatosVisita()
        {
            try
            {
                VisitaBE visita = objVisitaBL.ObtenerVisitaPorId(id);
                if (visita != null)
                {
                    txtid.Text = visita.id.ToString();
                    txtNom.Text = visita.nombre.Trim();
                    txtApe.Text = visita.apellido.Trim();
                    mtboxDoc.Text = visita.documento;
                    cboDerpartamento.SelectedValue = visita.departamento_id;
                    mcCalendarioEntrada.SelectionStart = visita.fecha_entrada ?? DateTime.Now;
                    cboHoraEntrada.SelectedItem = visita.hora_entrada?.Hours.ToString("D2");
                    cboMinutoEntrada.SelectedItem = visita.hora_entrada?.Minutes.ToString("D2");
                    mcCalendarioSalida.SelectionStart = visita.fecha_salida ?? DateTime.Now;
                    cboHoraSalida.SelectedItem = visita.hora_salida?.Hours.ToString("D2");
                    cboMinutoSalida.SelectedItem = visita.hora_salida?.Minutes.ToString("D2");
                    cbbox1.SelectedValue = visita.tipo_id;
                    cbbox2.SelectedValue = visita.area_comun_id;
                }
                else
                {
                    MessageBox.Show("No se encontró la visita con el ID proporcionado.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar los datos de la visita: " + ex.Message);
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

                // Crear los DateTime completos para entrada y salida
                DateTime fechaHoraEntrada = mcCalendarioEntrada.SelectionStart.Date.Add(
                    new TimeSpan(
                        int.Parse(cboHoraEntrada.SelectedItem.ToString()),
                        int.Parse(cboMinutoEntrada.SelectedItem.ToString()),
                        0)
                );

                //Jose
                // Validar que se haya seleccionado una hora de salida
                if (cboHoraSalida.SelectedItem == null || cboMinutoSalida.SelectedItem == null)
                    {throw new Exception("Debe ingresar la hora de salida.");}
                //Jose

                DateTime fechaHoraSalida = mcCalendarioSalida.SelectionStart.Date.Add(
                    new TimeSpan(
                        int.Parse(cboHoraSalida.SelectedItem.ToString()),
                        int.Parse(cboMinutoSalida.SelectedItem.ToString()),
                        0)
                );

                // Validar que la fecha/hora de salida no sea menor que la de entrada
                if (fechaHoraSalida < fechaHoraEntrada)
                {
                    throw new Exception("La fecha y hora de salida no puede ser menor que la fecha y hora de entrada.");
                }

                // Cargar el objeto VisitaBE con los valores ingresados
                objVisitaBE.id = Convert.ToInt16(txtid.Text);
                objVisitaBE.nombre = txtNom.Text.Trim();
                objVisitaBE.apellido = apellidoLimpio; // Usamos el apellido ya limpio
                objVisitaBE.documento = mtboxDoc.Text.Trim();
                objVisitaBE.departamento_id = Convert.ToInt32(cboDerpartamento.SelectedValue);

                // Configurar fecha y hora de entrada
                objVisitaBE.fecha_entrada = fechaHoraEntrada.Date;
                objVisitaBE.hora_entrada = fechaHoraEntrada.TimeOfDay;

                // Configurar fecha y hora de salida
                objVisitaBE.fecha_salida = fechaHoraSalida.Date;
                objVisitaBE.hora_salida = fechaHoraSalida.TimeOfDay;

                // Establecer IDs de tipo y área común usando las variables ya validadas
                objVisitaBE.tipo_id = Convert.ToInt16(drv["id"]);
                objVisitaBE.area_comun_id = Convert.ToInt16(drvArea["id"]);
                objVisitaBE.proposito = drv["nombre"].ToString();

                // Establecer campos de auditoría
                objVisitaBE.Fec_Ult_Mod = DateTime.Now;
                objVisitaBE.Usu_Ult_Mod = clsCredenciales.Usuario;

                // Actualizar la visita
                if (objVisitaBL.ActualizarVisita(objVisitaBE))
                {
                    string nombreCompleto = $"{objVisitaBE.nombre} {objVisitaBE.apellido}";
                    string departamentoNombre = cboDerpartamento.Text;          
                    DateTime entradaCompleta = fechaHoraEntrada;               
                    DateTime salidaCompleta = fechaHoraSalida;                
                    TimeSpan permanencia = salidaCompleta - entradaCompleta;

                    string mensaje = $"Salida registrada con éxito\n\n" +
                                     $"Nombre: {nombreCompleto}\n" +
                                     $"Departamento: {departamentoNombre}\n" +
                                     $"Fecha de salida: {salidaCompleta:dd/MM/yyyy}\n" +
                                     $"Hora de salida: {salidaCompleta:HH:mm}\n" +
                                     $"Tiempo de permanencia: {Math.Floor(permanencia.TotalHours)}h " +
                                     $"{permanencia.Minutes}min";

                    MessageBox.Show(mensaje,
                                    "Visita finalizada",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    
                    if (this.Owner is VisitaMan01 frmLista)
                        frmLista.CargarDatosVisita();

                    this.Close();
                }
                else
                {
                    throw new Exception("No se pudo actualizar la visita. Contacte con el administrador.");
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