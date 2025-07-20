using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using Edifia_BL;
using System.Globalization;
using OfficeOpenXml.Table;

namespace Edifia_GUI
{
    public partial class frmListadosExcel : Form
    {
        HabitanteBL objHabitanteBL = new HabitanteBL();
        EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        VisitaBL objVisitaBL = new VisitaBL();

        // Definimos la ubicación del archivo plantilla
        string strRuta = @"C:\Users\setco\OneDrive\Desktop\EF_04\Solucion_windows\plantilla.xlsx";

        public frmListadosExcel()
        {
            InitializeComponent();
        }

        private void btnHabitantes_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtenemos la data a visualizar
                DataTable dtHabitantes = objHabitanteBL.ListarHabitantesReporteExcel();

                // Creamos instancia de ExcelPackage en base a la plantilla
                using (var pck = new ExcelPackage(new FileInfo(strRuta)))
                {
                    // Intentamos obtener la hoja llamada "Sheet1"
                    ExcelWorksheet ws = pck.Workbook.Worksheets["Sheet1"];
                    if (ws == null)
                    {
                        MessageBox.Show("No se encontró la hoja 'Sheet1'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Determinamos las posiciones iniciales para los encabezados y datos
                    int startRow = 5; // Cambiar si los encabezados deben ir en otra fila
                    int startCol = 1;

                    // Escribimos el usuario que genero el reporte
                    ws.Cells[2, 8].Value = clsCredenciales.Usuario;

                    // Escribimos las cabeceras dinámicamente desde el DataTable
                    for (int colIndex = 0; colIndex < dtHabitantes.Columns.Count; colIndex++)
                    {
                        ws.Cells[startRow, startCol + colIndex].Value = dtHabitantes.Columns[colIndex].ColumnName;
                        ws.Cells[startRow, startCol + colIndex].Style.Font.Bold = true; // Resalta en negrita las cabeceras
                        ws.Cells[startRow, startCol + colIndex].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center; // Centra el texto
                    }

                    // Insertamos los datos debajo de las cabeceras
                    for (int rowIndex = 0; rowIndex < dtHabitantes.Rows.Count; rowIndex++)
                    {
                        for (int colIndex = 0; colIndex < dtHabitantes.Columns.Count; colIndex++)
                        {
                            var cell = ws.Cells[startRow + 1 + rowIndex, startCol + colIndex];
                            var cellValue = dtHabitantes.Rows[rowIndex][colIndex];

                            // Si la celda tiene un valor de tipo DateTime, la formateamos como fecha
                            if (cellValue is DateTime)
                            {
                                cell.Value = (DateTime)cellValue;
                                cell.Style.Numberformat.Format = "yyyy-mm-dd"; // Establece el formato de fecha
                            }
                            else
                            {
                                cell.Value = cellValue;
                            }
                        }
                    }

                    // Determinamos el rango de datos
                    int endRow = startRow + dtHabitantes.Rows.Count; // Última fila (incluye los datos)
                    int endCol = startCol + dtHabitantes.Columns.Count - 1; // Última columna
                    var dataRange = ws.Cells[startRow, startCol, endRow, endCol];

                    // Eliminamos la tabla existente si hay una
                    var existingTable = ws.Tables.FirstOrDefault(t => t.Name == "tb_habitantes");
                    if (existingTable != null)
                    {
                        ws.Tables.Delete(existingTable);
                    }

                    // Creamos una nueva tabla para el rango
                    var table = ws.Tables.Add(dataRange, "tb_habitantes");
                    table.ShowHeader = true;
                    table.TableStyle = TableStyles.Medium8;

                    // Ajuste automático de columnas
                    for (int col = startCol; col <= endCol; col++)
                    {
                        ws.Column(col).AutoFit();
                    }

                    // Guardar el archivo en la carpeta Descargas
                    string downloadsFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                    string strfilename = "ListadoHabitantes_" + DateTime.Now.ToString("dd.MM.yy__HH.mm") + ".xlsx";
                    string filePath = Path.Combine(downloadsFolder, strfilename);

                    using (FileStream fs = new FileStream(filePath, FileMode.Create))
                    {
                        pck.SaveAs(fs);
                    }

                    // Mensaje de éxito
                    MessageBox.Show($"El reporte se ha generado con éxito en la carpeta: {filePath}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Mensaje");
            }
        }


        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtenemos la data a visualizar
                DataTable dtEmpleados = objEmpleadoBL.ListarEmpleadoReporteExcel();

                // Creamos instancia de ExcelPackage en base a la plantilla
                using (var pck = new ExcelPackage(new FileInfo(strRuta)))
                {
                    // Intentamos obtener la hoja llamada "Sheet1"
                    ExcelWorksheet ws = pck.Workbook.Worksheets["Sheet1"];
                    if (ws == null)
                    {
                        MessageBox.Show("No se encontró la hoja 'Sheet1'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Determinamos las posiciones iniciales para los encabezados y datos
                    int startRow = 5; // Cambiar si los encabezados deben ir en otra fila
                    int startCol = 1;

                    // Escribimos el usuario que genero el reporte
                    ws.Cells[2, 8].Value = clsCredenciales.Usuario;

                    // Escribimos las cabeceras dinámicamente desde el DataTable
                    for (int colIndex = 0; colIndex < dtEmpleados.Columns.Count; colIndex++)
                    {
                        ws.Cells[startRow, startCol + colIndex].Value = dtEmpleados.Columns[colIndex].ColumnName;
                        ws.Cells[startRow, startCol + colIndex].Style.Font.Bold = true; // Resalta en negrita las cabeceras
                        ws.Cells[startRow, startCol + colIndex].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center; // Centra el texto
                    }

                    // Insertamos los datos debajo de las cabeceras
                    for (int rowIndex = 0; rowIndex < dtEmpleados.Rows.Count; rowIndex++)
                    {
                        for (int colIndex = 0; colIndex < dtEmpleados.Columns.Count; colIndex++)
                        {
                            var cell = ws.Cells[startRow + 1 + rowIndex, startCol + colIndex];
                            var cellValue = dtEmpleados.Rows[rowIndex][colIndex];

                            // Si la celda tiene un valor de tipo DateTime, la formateamos como fecha
                            if (cellValue is DateTime)
                            {
                                cell.Value = (DateTime)cellValue;
                                cell.Style.Numberformat.Format = "yyyy-mm-dd"; // Establece el formato de fecha
                            }
                            else
                            {
                                cell.Value = cellValue;
                            }
                        }
                    }

                    // Determinamos el rango de datos
                    int endRow = startRow + dtEmpleados.Rows.Count; // Última fila (incluye los datos)
                    int endCol = startCol + dtEmpleados.Columns.Count - 1; // Última columna
                    var dataRange = ws.Cells[startRow, startCol, endRow, endCol];

                    // Eliminamos la tabla existente si hay una
                    var existingTable = ws.Tables.FirstOrDefault(t => t.Name == "tb_empleados");
                    if (existingTable != null)
                    {
                        ws.Tables.Delete(existingTable);
                    }

                    // Creamos una nueva tabla para el rango
                    var table = ws.Tables.Add(dataRange, "tb_empleados");
                    table.ShowHeader = true;
                    table.TableStyle = TableStyles.Medium8;

                    // Ajuste automático de columnas
                    for (int col = startCol; col <= endCol; col++)
                    {
                        ws.Column(col).AutoFit();
                    }

                    // Guardar el archivo en la carpeta Descargas
                    string downloadsFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                    string strfilename = "ListadoEmpleados_" + DateTime.Now.ToString("dd.MM.yy__HH.mm") + ".xlsx";
                    string filePath = Path.Combine(downloadsFolder, strfilename);

                    using (FileStream fs = new FileStream(filePath, FileMode.Create))
                    {
                        pck.SaveAs(fs);
                    }

                    // Mensaje de éxito
                    MessageBox.Show($"El reporte se ha generado con éxito en la carpeta: {filePath}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Mensaje");
            }
        }


        private void btnVisitas_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtenemos la data a visualizar
                DataTable dtVisitas = objVisitaBL.ListarVisitasReporteExcel();

                // Creamos instancia de ExcelPackage en base a la plantilla
                using (var pck = new ExcelPackage(new FileInfo(strRuta)))
                {
                    // Intentamos obtener la hoja llamada "Sheet1"
                    ExcelWorksheet ws = pck.Workbook.Worksheets["Sheet1"];
                    if (ws == null)
                    {
                        MessageBox.Show("No se encontró la hoja 'Sheet1'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Determinamos las posiciones iniciales para los encabezados y datos
                    int startRow = 5; // Cambiar si los encabezados deben ir en otra fila
                    int startCol = 1;

                    // Escribimos el usuario que genero el reporte
                    ws.Cells[2, 8].Value = clsCredenciales.Usuario;

                    // Escribimos las cabeceras dinámicamente desde el DataTable
                    for (int colIndex = 0; colIndex < dtVisitas.Columns.Count; colIndex++)
                    {
                        ws.Cells[startRow, startCol + colIndex].Value = dtVisitas.Columns[colIndex].ColumnName;
                        ws.Cells[startRow, startCol + colIndex].Style.Font.Bold = true; // Resalta en negrita las cabeceras
                        ws.Cells[startRow, startCol + colIndex].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center; // Centra el texto
                    }

                    // Insertamos los datos debajo de las cabeceras
                    for (int rowIndex = 0; rowIndex < dtVisitas.Rows.Count; rowIndex++)
                    {
                        for (int colIndex = 0; colIndex < dtVisitas.Columns.Count; colIndex++)
                        {
                            var cell = ws.Cells[startRow + 1 + rowIndex, startCol + colIndex];
                            var cellValue = dtVisitas.Rows[rowIndex][colIndex];

                            // Si la celda tiene un valor de tipo DateTime, la formateamos como fecha
                            if (cellValue is DateTime)
                            {
                                cell.Value = (DateTime)cellValue;
                                cell.Style.Numberformat.Format = "yyyy-mm-dd"; // Establece el formato de fecha
                            }
                            // Si la celda contiene hora (tipo TimeSpan), la formateamos como hora y minuto
                            else if (cellValue is TimeSpan)
                            {
                                cell.Value = (TimeSpan)cellValue;
                                cell.Style.Numberformat.Format = @"[hh]:mm"; // Formato de hora y minuto
                            }
                            else
                            {
                                cell.Value = cellValue;
                            }
                        }
                    }

                    // Determinamos el rango de datos
                    int endRow = startRow + dtVisitas.Rows.Count; // Última fila (incluye los datos)
                    int endCol = startCol + dtVisitas.Columns.Count - 1; // Última columna
                    var dataRange = ws.Cells[startRow, startCol, endRow, endCol];

                    // Eliminamos la tabla existente si hay una
                    var existingTable = ws.Tables.FirstOrDefault(t => t.Name == "tb_visitas");
                    if (existingTable != null)
                    {
                        ws.Tables.Delete(existingTable);
                    }

                    // Creamos una nueva tabla para el rango
                    var table = ws.Tables.Add(dataRange, "tb_visitas");
                    table.ShowHeader = true;
                    table.TableStyle = TableStyles.Medium8;

                    // Ajuste automático de columnas
                    for (int col = startCol; col <= endCol; col++)
                    {
                        ws.Column(col).AutoFit();
                    }

                    // Guardar el archivo en la carpeta Descargas
                    string downloadsFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                    string strfilename = "ListadoVisitas_" + DateTime.Now.ToString("dd.MM.yy__HH.mm") + ".xlsx";
                    string filePath = Path.Combine(downloadsFolder, strfilename);

                    using (FileStream fs = new FileStream(filePath, FileMode.Create))
                    {
                        pck.SaveAs(fs);
                    }

                    // Mensaje de éxito
                    MessageBox.Show($"El reporte se ha generado con éxito en la carpeta: {filePath}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Mensaje");
            }
        }






        private void frmListadosExcel_Load(object sender, EventArgs e)
        {
            // Definir el contexto de la licencia de EpPlus
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
        }
    }

}

