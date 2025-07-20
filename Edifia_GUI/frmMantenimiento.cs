using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Edifia_BL;
using Edifia_BE;
using Edifia_ADO;
using System.Data.SqlTypes;

namespace Edifia_GUI
{
    public partial class frmMantenimiento : Form
    {
        // Instancias...
        MantenimientoBL objMantenimientoBL = new MantenimientoBL();
        MantenimientoBE objMantenimientoBE = new MantenimientoBE();
        EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        ActividadMantenimientoBL objActividadMantenimientoBL = new ActividadMantenimientoBL();
        EdificioBL objEdificioBL = new EdificioBL();
        TipoEmpleadoBL objTipoEmpleadoBL = new TipoEmpleadoBL();

        public frmMantenimiento()
        {
            InitializeComponent();
        }

        private void frmMantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                DataTable dt = objEmpleadoBL.ListarEmpleado();
                DataRow dr;

                dt = objActividadMantenimientoBL.ListarActividadMantenimiento();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try { 

                if (cboActividad.SelectedIndex == 0)
                {
                    throw new Exception("Elige una actividad.");
                }
                

                if (cboEdificio.SelectedIndex == 0)
                {
                    throw new Exception("Elige un edificio.");
                }

                if (cboEmpleado.SelectedIndex == 0)
                {
                    throw new Exception("Elige un empleado.");
                }



                //si todo esta OK....cargamos el 
                objMantenimientoBE.actividad_id = Convert.ToInt16(cboActividad.SelectedValue);
                objMantenimientoBE.fecha_programada = dtpFecPro.SelectionStart;
                objMantenimientoBE.edificio_id = Convert.ToInt16(cboEdificio.SelectedValue);
                objMantenimientoBE.responsable = cboEmpleado.SelectedValue.ToString();
                objMantenimientoBE.Usu_Registro = clsCredenciales.Usuario.ToString();

                // invocamos al metodo insertar
                if (objMantenimientoBL.InsertarMantenimiento(objMantenimientoBE) == true)
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
    }
}

