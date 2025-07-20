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

namespace Edifia_GUI
{
    public partial class frmEmpleado : Form
    {

        EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        DataView dtv;
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            dtgDatos.AutoGenerateColumns = false;
            CargarDatos("");
        }

        private void CargarDatos(String strFiltro)
        {
            dtv = new DataView(objEmpleadoBL.ListarEmpleadoEmpleado());
            dtv.RowFilter = "Apellido like '%" + strFiltro + "%'";
            dtgDatos.DataSource = dtv;
            lblRegistros.Text = dtgDatos.Rows.Count.ToString();
        }

        private void lblFiltro_Click(object sender, EventArgs e)
        {

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.Message);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                EmpleadoMan01 objEmpleadoMan01 = new EmpleadoMan01();
                objEmpleadoMan01.ShowDialog();

                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                EmpleadoMan02 objEmpleadoMan02 = new EmpleadoMan02();
                objEmpleadoMan02.documento = Convert.ToString(dtgDatos.CurrentRow.Cells[0].Value);
                objEmpleadoMan02.ShowDialog();

                CargarDatos(txtFiltro.Text.Trim()); // 
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult vrpta = MessageBox.Show("¿Seguro de eliminar el registro?", "Menesaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (vrpta == DialogResult.Yes)
                {
                    String documento = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                    if (objEmpleadoBL.EliminarEmpleado(documento) == true)
                    {
                        CargarDatos(txtFiltro.Text.Trim());
                    }
                    else
                    {
                        throw new Exception("No se logro ejectuar la accion. Consulte con IT");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
