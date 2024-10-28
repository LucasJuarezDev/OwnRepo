using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sist01
{
    public partial class FormRepHoy : Form
    {

        //////////////////////////////////////////////   PROPIEDADES   /////////////////////////////////////////////

        private List<Venta> ListarVentasDia;
        private ReportesNegocio ReportesNegocio = new ReportesNegocio();
        private int CeldaSeleccionada = 0;
        private ExportarArchivos ExportFiles = new ExportarArchivos();

        //////////////////////////////////////////////   INICIALIZACION   /////////////////////////////////////////////

        public FormRepHoy()
        {
            InitializeComponent();
            DGVacio();
        }

        private void CargarDGV()
        {
            try
            {
                ListarVentasDia = ReportesNegocio.ListarVentasDelDia();

                var datosParaMostrar = ListarVentasDia.Select(v => new
                {
                    IDVentaGlobal = v.IDGlobalVentas,
                    IDArticulo = v.VentaArticulo.CodigoArticulo,
                    Articulo = v.VentaArticulo.Articulos,
                    Descripcion = v.VentaArticulo.TipoDeArticulo,
                    Marca = v.VentaArticulo.Marcas.Descripcion,
                    CantidadVendida = v.VentaArticulo.CantidadDeArticulos,
                    VentaTotal = v.VentaArticulo.PrecioCompra,
                    Pago = v.DescripcionDePago
                }).OrderBy(v => v.IDVentaGlobal).ToList();

                DGV_VentasDia.DataSource = datosParaMostrar;
                RenameColumns(DGV_VentasDia);
                DGVacio();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        //////////////////////////////////////////////   VALIDACIONES   /////////////////////////////////////////////

        private void RenameColumns(DataGridView DGV)
        {
            DGV.Columns["IDVentaGlobal"].HeaderText = "Número de Venta";
            DGV.Columns["IDArticulo"].HeaderText = "Código";
            DGV.Columns["Articulo"].HeaderText = "Nombre";
            DGV.Columns["Descripcion"].HeaderText = "Descripción";
            DGV.Columns["Marca"].HeaderText = "Marca";
            DGV.Columns["CantidadVendida"].HeaderText = "Art. Vendidos";
            DGV.Columns["VentaTotal"].HeaderText = "En Esta Venta";
            DGV.Columns["Pago"].HeaderText = "Metodo De Pago";
            DGV.Columns["VentaTotal"].DefaultCellStyle.Format = "C2";
        }

        private void DGVacio()
        {
            if(DGV_VentasDia.Rows.Count >= 1)
            {
                CB_OrdenPago.Enabled = true;
                CB_OrdenVentas.Enabled = true;
                btn_ExportarFile.Enabled = true;
                btn_ExportarVenta.Enabled = false;
            }else
            {
                CB_OrdenPago.Enabled = false;
                CB_OrdenVentas.Enabled = false;
                btn_ExportarFile.Enabled = false;
                btn_ExportarVenta.Enabled = false;
            }
        }

        //////////////////////////////////////////////   METODOS INTERNOS   /////////////////////////////////////////////



        //////////////////////////////////////////////   METODOS EXTERNOS   /////////////////////////////////////////////

        private void FormRepHoy_Load(object sender, EventArgs e)
        {
            CargarDGV();
        }

        private void btn_ExportarFile_Click(object sender, EventArgs e)
        {
            string FileName = "VentasDelDia";
            ExportFiles.ExportarArchivoExcel(DGV_VentasDia, FileName);
        }

        private void CB_OrdenVentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReportesNegocio.AscdDescDGV(ListarVentasDia, DGV_VentasDia, CB_OrdenVentas);
        }

        private void cmBox_Pago_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReportesNegocio.OrdenarPorPagos(ListarVentasDia, DGV_VentasDia, CB_OrdenPago);
        }

        private void DGV_VentasDia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex >= 0)
                {
                    CeldaSeleccionada = (int)DGV_VentasDia.Rows[e.RowIndex].Cells["IDVentaGlobal"].Value;
                    btn_ExportarVenta.Enabled = true;
                }else
                {
                    btn_ExportarVenta.Enabled = false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btn_ExportarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if(CeldaSeleccionada > 0)
                {
                    ExportFiles.SeleccionVentaEspecifica(ListarVentasDia, CeldaSeleccionada);

                }else
                {
                    MessageBox.Show("Seleccione una venta válida antes de exportar.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
