using Edifia_BE;
using Edifia_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edifia_GUI
{
    public partial class frmMantenimiento02 : Form

    {
        // Instancias...
        MantenimientoBL objMantenimientoBL = new MantenimientoBL();
        MantenimientoBE objMantenimientoBE = new MantenimientoBE();
        EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        ActividadMantenimientoBL objActividadMantenimientoBL = new ActividadMantenimientoBL();
        EdificioBL objEdificioBL = new EdificioBL();
        TipoEmpleadoBL objTipoEmpleadoBL = new TipoEmpleadoBL();


        public frmMantenimiento02()
        {
            InitializeComponent();
        }

        // Propiedad que recibe el codigo del Mantenimiento que se actualizara, enviado
        // desde el MantenimientoMan01
        public Int32 id { get; set; }


        private void frmMantenimiento02_Load(object sender, EventArgs e)
        {
            try
            {
                // Validar ID
                if (id <= 0)
                {
                    MessageBox.Show("ID de mantenimiento inválido",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                // Cargamos los combos...
                DataTable dt = objActividadMantenimientoBL.ListarActividadMantenimiento();
                DataRow dr;

                dr = dt.NewRow();
                dr["id"] = 0;
                dr["descripcion"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboActividad.DataSource = dt;
                cboActividad.ValueMember = "id";
                cboActividad.DisplayMember = "descripcion";

                dt = objEdificioBL.ListarEdificios();
                dr = dt.NewRow();
                dr["id"] = 0;
                dr["nombre"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboEdificio.DataSource = dt;
                cboEdificio.ValueMember = "id";
                cboEdificio.DisplayMember = "nombre";

                dt = objEmpleadoBL.ListarEmpleado();
                dr = dt.NewRow();
                dr["id"] = 0;
                dr["nombre"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboEmpleado.DataSource = dt;
                cboEmpleado.ValueMember = "id";
                cboEmpleado.DisplayMember = "nombre";

                dt = objTipoEmpleadoBL.ListarTipoEmpleado();
                dr = dt.NewRow();
                dr["id"] = 0;
                dr["nombre"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboTipoEmpleado.DataSource = dt;
                cboTipoEmpleado.ValueMember = "id";
                cboTipoEmpleado.DisplayMember = "nombre";

                DateTime now = DateTime.Now;
                dtpFecPro.SelectionStart = now.Date;
                dtpFecRea.SelectionStart = now.Date;


                try
                {
                    MantenimientoBE mantenimiento = objMantenimientoBL.ConsultarMantenimiento(id);

                    if (mantenimiento == null)
                    {
                        MessageBox.Show($"No se encontró mantenimiento con ID {id}",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        return;
                    }

                    // Cargar datos con validaciones adicionales
                    lblCodigo.Text = mantenimiento.id.ToString();

                    // Validaciones antes de asignar valores
                    if (mantenimiento.actividad_id > 0)
                        cboActividad.SelectedValue = mantenimiento.actividad_id;

                    if (mantenimiento.edificio_id > 0)
                        cboEdificio.SelectedValue = mantenimiento.edificio_id;

                    if (!string.IsNullOrEmpty(mantenimiento.responsable))
                        cboEmpleado.SelectedValue = mantenimiento.responsable;

                    if (!string.IsNullOrEmpty(mantenimiento.tipoEmpleado))
                        cboTipoEmpleado.SelectedValue = mantenimiento.tipoEmpleado;

                    if (mantenimiento.fecha_programada.HasValue)
                        dtpFecPro.SelectionStart = mantenimiento.fecha_programada.Value;

                    if (mantenimiento.fecha_realizacion.HasValue)
                        dtpFecRea.SelectionStart = mantenimiento.fecha_realizacion.Value;
                }
                catch (Exception consultaEx)
                {
                    MessageBox.Show($"Error al consultar mantenimiento: {consultaEx.Message}",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el mantenimiento: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cboActividad.SelectedIndex == 0 || cboEmpleado.SelectedIndex == 0)
            {
                throw new Exception("La Actividad y el Empleado son obligatorios");
            }

          
            //si todo esta OK....cargamos el objDepartamentoBe
            objMantenimientoBE.id = Convert.ToInt32(lblCodigo.Text);
            objMantenimientoBE.actividad_id = Convert.ToInt16(cboActividad.SelectedValue);
            objMantenimientoBE.fecha_programada = dtpFecPro.SelectionStart.Date;
            objMantenimientoBE.fecha_realizacion = dtpFecRea.SelectionStart.Date;
            objMantenimientoBE.edificio_id = Convert.ToInt16(cboEdificio.SelectedValue);
            objMantenimientoBE.responsable = cboEmpleado.SelectedValue.ToString();
            objMantenimientoBE.Fec_Ult_Mod = DateTime.Now;
            objMantenimientoBE.Usu_Ult_Mod = clsCredenciales.Usuario.ToString();

            // Establecer campos de auditoría
            objMantenimientoBE.Fec_Reg = DateTime.Now;
            objMantenimientoBE.Usu_Registro = clsCredenciales.Usuario;
            // invocamos al metodo insertar
            if (objMantenimientoBL.ActualizarMantenimiento(objMantenimientoBE))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el mantenimiento. Por favor contacte al administrador.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

