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
    public partial class DepartamentoMan01 : Form
    {
        DepartamentoBL objDepartamentoBL = new DepartamentoBL();
        DataView dtv;

        public DepartamentoMan01()
        {
            InitializeComponent();
        }

        private void DepartamentoMan01_Load(object sender, EventArgs e)
        {
            dtgDatos.AutoGenerateColumns = false;

            CargarDatosDepartamento("");
        }

        private void CargarDatosDepartamento(String strFiltro)
        {
            DataTable dt = objDepartamentoBL.ListarDepartamento();

            // Agregar una nueva columna como cadena
            dt.Columns.Add("numeroStr", typeof(string));

            // Llenar la nueva columna con los valores convertidos
            foreach (DataRow row in dt.Rows)
            {
                row["numeroStr"] = row["numero"].ToString();
            }

            dtv = new DataView(dt);

            // Si el filtro no es nulo o vacío, aplica un filtro a la vista de datos.
            if (!string.IsNullOrEmpty(strFiltro))
            {
                // Establece el filtro para mostrar solo las filas donde "numeroStr" comience con el texto de strFiltro.
                dtv.RowFilter = "numeroStr like '" + strFiltro + "%'";
            }

            dtgDatos.DataSource = dtv;
            lblRegistros.Text = dtv.Count.ToString();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatosDepartamento(txtFiltro.Text.Trim());
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
                DepartamentoMan02 objDepartamento02 = new DepartamentoMan02();
                objDepartamento02.ShowDialog();

                // al cerrar el objDepartamento02 se actualiza el dtgdatos
                CargarDatosDepartamento(txtFiltro.Text.Trim());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnACtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                DepartamentoMan03 objDepartamentoMan03 = new DepartamentoMan03();
                objDepartamentoMan03.id = Convert.ToInt16(dtgDatos.CurrentRow.Cells[0].Value);

                objDepartamentoMan03.ShowDialog();
                // al cerrar el productoman03 se actualiza el dtgdatos
                CargarDatosDepartamento(txtFiltro.Text.Trim());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult vrpta = MessageBox.Show("¿Estás seguro que quieres eliminar el registro?", "Mensaje", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (vrpta == DialogResult.Yes)
                {
                    int idDepartamento = Convert.ToInt32(dtgDatos.CurrentRow.Cells["id"].Value); 

                    if (objDepartamentoBL.EliminarDepartamento(idDepartamento))
                    {
                        CargarDatosDepartamento(txtFiltro.Text.Trim());
                    }
                    else
                    {
                        throw new Exception("No se logró ejecutar la acción. Consulte con el administrador de su red.");
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

        private void dtgDepartamentoFoto_DoubleClick(object sender, EventArgs e)
        {
            // promptea el form para actualizar imagen
            btnACtualizar.PerformClick();
        }

    }
}
