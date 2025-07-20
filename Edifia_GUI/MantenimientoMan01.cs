using Edifia_BL;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Edifia_GUI
{
    public partial class MantenimientoMan01 : Form
    {
        MantenimientoBL objMantenimientoBL = new MantenimientoBL();
        DataView dtv;

        public MantenimientoMan01()
        {
            InitializeComponent();
        }

        private void MantenimientoMan01_Load(object sender, EventArgs e)
        {
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dtgDatos.AutoGenerateColumns = false;

            CargarDatosMantenimiento("");

        }

        private void CargarDatosMantenimiento(String strFiltro)
        {
            try
            {
                DataTable dt = objMantenimientoBL.ListarMantenimiento();

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos disponibles.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Configurar las columnas del DataGridView si no están configuradas
                if (dtgDatos.Columns.Count == 0)
                {
                    dtgDatos.Columns.Add("id", "id");
                    dtgDatos.Columns.Add("fecha_programada", "Fecha Programada");
                    dtgDatos.Columns.Add("fecha_realizacion", "Fecha Realización");
                    dtgDatos.Columns.Add("responsable", "Responsable");
                    dtgDatos.Columns.Add("edificio_nombre", "Edificio");
                    dtgDatos.Columns.Add("actividad_id", "Actividad");
                }

                // Crear vista de datos
                dtv = new DataView(dt);

                // Asegurarse de que el filtro no cause error si es nulo
                if (!string.IsNullOrEmpty(strFiltro))
                {
                    // Realizar el filtro pero con protección de nulos
                    dtv.RowFilter = $"responsable LIKE '%{strFiltro}%' OR edificio_nombre LIKE '%{strFiltro}%'";
                }

                // Asignar la DataView al DataGridView
                dtgDatos.DataSource = dtv;

                // Formatear las fechas con un valor por defecto si son nulas
                dtgDatos.Columns["fecha_programada"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dtgDatos.Columns["fecha_realizacion"].DefaultCellStyle.Format = "dd/MM/yyyy";

                // Actualizar el contador de registros
                lblRegistros.Text = dtv.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatosMantenimiento(txtFiltro.Text.Trim());
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
                frmMantenimiento objFrmMantiniento = new frmMantenimiento();
                objFrmMantiniento.ShowDialog();

                // al cerrar el objDepartamento02 se actualiza el dtgdatos
                CargarDatosMantenimiento(txtFiltro.Text.Trim());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si hay una fila seleccionada
                if (dtgDatos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor seleccione un registro para actualizar",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener el valor de la celda 'id'
                var currentRow = dtgDatos.SelectedRows[0];
                var idValue = currentRow.Cells["id"].Value;

                // Verificar si el valor es nulo o DBNull
                if (idValue == null || idValue == DBNull.Value)
                {
                    MessageBox.Show("El registro seleccionado no tiene un ID válido",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Convertir el 'id' a entero con manejo de excepciones
                int id;
                if (!int.TryParse(idValue.ToString(), out id) || id <= 0)
                {
                    MessageBox.Show("ID inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Proceder con la actualización
                frmMantenimiento02 objMantenimientoMan02 = new frmMantenimiento02();
                objMantenimientoMan02.id = id;  // Usar el setter de la propiedad
                objMantenimientoMan02.ShowDialog();

                // Después de la actualización, recargar los datos
                CargarDatosMantenimiento(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar: {ex.Message}\n\n" +
                                $"Detalles: {ex.StackTrace}",
                                "Error Detallado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult vrpta = MessageBox.Show("¿Seguro de eliminar el registro?", "Mensaje", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (vrpta == DialogResult.Yes)
                {
                    String codigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                    if (objMantenimientoBL.EliminarMantenimiento(codigo) == true)
                    {
                        CargarDatosMantenimiento(txtFiltro.Text.Trim());
                    }
                    else
                    {
                        throw new Exception("No se logró ejecutar la acción. Consulte con IT");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
