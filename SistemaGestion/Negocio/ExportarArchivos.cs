using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Windows.Forms;
using Dominio;

namespace Negocio
{
    public class ExportarArchivos
    {
        private XLWorkbook Archivo;

        public void SeleccionVentaEspecifica(List<Venta> Lista, int CeldaSeleccionada)
        {
            try
            {
                var DetalleVenta = Lista.Where(v => v.IDGlobalVentas == CeldaSeleccionada).Select(v => new
                {
                    IDVentaGlobal = v.IDGlobalVentas,
                    IDArticulo = v.VentaArticulo.CodigoArticulo,
                    Articulo = v.VentaArticulo.Articulos,
                    Descripcion = v.VentaArticulo.TipoDeArticulo,
                    Marca = v.VentaArticulo.Marcas.Descripcion,
                    CantidadVendida = v.VentaArticulo.CantidadDeArticulos,
                    VentaTotal = v.VentaArticulo.PrecioCompra,
                    Pago = v.DescripcionDePago
                }).ToList<dynamic>();

                float Total = DetalleVenta.Sum(v => (int)v.VentaTotal);
                ExportarVentaExcel(DetalleVenta, Total);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ExportarVentaExcel(List<dynamic> detalleVenta, float TotalVenta)
        {
            Archivo = null;
            try
            {
                Archivo = new XLWorkbook();
                var Hoja = Archivo.Worksheets.Add("VentaEspecifica");
                int FilaInicial = 1, FilaActual = 0;

                Hoja.Cell(FilaInicial, 1).Value = "ID Venta";
                Hoja.Cell(FilaInicial, 2).Value = "ID Artículo";
                Hoja.Cell(FilaInicial, 3).Value = "Artículo";
                Hoja.Cell(FilaInicial, 4).Value = "Descripción";
                Hoja.Cell(FilaInicial, 5).Value = "Marca";
                Hoja.Cell(FilaInicial, 6).Value = "Cantidad Vendida";
                Hoja.Cell(FilaInicial, 7).Value = "Total Articulo";
                Hoja.Cell(FilaInicial, 8).Value = "Forma de Pago";

                FilaActual = FilaInicial + 1;

                foreach (var detalle in detalleVenta)
                {
                    Hoja.Cell(FilaActual, 1).Value = detalle.IDVentaGlobal;
                    Hoja.Cell(FilaActual, 2).Value = detalle.IDArticulo;
                    Hoja.Cell(FilaActual, 3).Value = detalle.Articulo;
                    Hoja.Cell(FilaActual, 4).Value = detalle.Descripcion;
                    Hoja.Cell(FilaActual, 5).Value = detalle.Marca;
                    Hoja.Cell(FilaActual, 6).Value = detalle.CantidadVendida;
                    Hoja.Cell(FilaActual, 7).Value = detalle.VentaTotal;
                    Hoja.Cell(FilaActual, 8).Value = detalle.Pago;
                    FilaActual++;
                }

                Hoja.Cell(FilaActual, 6).Value = "Total:";
                Hoja.Cell(FilaActual, 7).Value = TotalVenta;
                string fechaActual = DateTime.Now.ToString("dd-MM-yy");
                string nombreArchivo = $"Venta_{fechaActual}.xlsx";

                SaveFileDialog CuadroGuardado = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    Title = "Guardar archivo Excel",
                    FileName = nombreArchivo
                };

                if (CuadroGuardado.ShowDialog() == DialogResult.OK)
                {
                    Archivo.SaveAs(CuadroGuardado.FileName);
                    MessageBox.Show("Archivo exportado exitosamente", "Exportar a Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (Archivo != null)
                {
                    Archivo.Dispose();
                }
            }
        }

        public void ExportarArchivoExcel(DataGridView DGV_Dia, string NombreArchivo)
        {
            Archivo = null; //iniciamos el archivo en nulo
            try
            {
                Archivo = new XLWorkbook(); //instanciado
                var Hoja = Archivo.Worksheets.Add("VentasEmitidas");
                int ColumnasDGV = DGV_Dia.Columns.Count;
                int FilasDGV = DGV_Dia.Rows.Count;

                for (int x = 0; x < ColumnasDGV; x++)
                {
                    Hoja.Cell(1, x + 1).Value = DGV_Dia.Columns[x].HeaderText; //Captura los encabezados del dgv y los coloca en el excel
                }

                for (int x = 0; x < FilasDGV; x++) //recorre fila por fila, +2 debido a que la fila del encabezado ya fue cargada
                {
                    for (int y = 0; y < ColumnasDGV; y++) //recorre columnas, +1 por el desfazaje de c#
                    {
                        Hoja.Cell(x + 2, y + 1).Value = DGV_Dia.Rows[x].Cells[y].Value?.ToString() ?? string.Empty;
                    }
                }

                string fechaActual = DateTime.Now.ToString("dd-MM-yy");
                if (NombreArchivo == "VentasDeSemana")
                {
                    NombreArchivo = $"VentasDeSemana_{fechaActual}.xlsx";
                }
                else if(NombreArchivo == "VentasDelDia")
                {
                    NombreArchivo = $"VentasDelDia_{fechaActual}.xlsx";
                }

                SaveFileDialog CuadroGuardado = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    Title = "Guardar archivo Excel",
                    FileName = NombreArchivo
                };

                if (CuadroGuardado.ShowDialog() == DialogResult.OK)
                {
                    Archivo.SaveAs(CuadroGuardado.FileName);
                    MessageBox.Show("Archivo exportado exitosamente", "Exportar a Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (Archivo != null)
                {
                    Archivo.Dispose(); //cerramos la conexion del archivo
                }
            }
        }
    }
}
