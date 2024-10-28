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
    public partial class ReporteMes : Form
    {
        //////////////////////////////////////////////   PROPIEDADES   /////////////////////////////////////////////

        private List<Venta> ListadoHistorialVentas;
        private ReportesNegocio ReportesNegocio = new ReportesNegocio();
        private bool FechaSeleccionada = false;
        private ExportarArchivos ExportFiles = new ExportarArchivos();
        private int CeldaSeleccionada = 0;

        //////////////////////////////////////////////   INICIALIZACION   /////////////////////////////////////////////
        public ReporteMes()
        {
            InitializeComponent();
        }

        private void ReporteMes_Load(object sender, EventArgs e)
        {
            DTP_SelecDia1.Value = DateTime.Now;
            DTP_SelecDia2.Value = DateTime.Now;
            DTP_SelecDia2.Enabled = false;
            DGVacio();
        }

        private void CargarDGV(List<Venta> ventas)
        {
            try
            {
                var datosParaMostrar = ventas.Select(v => new
                {
                    IDVentaGlobal = v.IDGlobalVentas,
                    IDArticulo = v.VentaArticulo.CodigoArticulo,
                    Articulo = v.VentaArticulo.Articulos,
                    Descripcion = v.VentaArticulo.TipoDeArticulo,
                    Marca = v.VentaArticulo.Marcas.Descripcion,
                    CantidadVendida = v.VentaArticulo.CantidadDeArticulos,
                    VentaTotal = v.VentaArticulo.PrecioCompra,
                    Pago = v.DescripcionDePago,
                    Fecha = v.FechaReporte
                }).OrderBy(v => v.IDVentaGlobal).ToList();

                DGV_VentasMes.DataSource = datosParaMostrar;
                RenameColumns(DGV_VentasMes);
                DGVacio();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //////////////////////////////////////////////   VALIDACIONES   /////////////////////////////////////////////

        private void DGVacio()
        {
            if (DGV_VentasMes.Rows.Count < 1)
            {
                btn_ExportarFileMes.Enabled = false;
                btn_ExportarVentaMes.Enabled = false;
                CB_OrdenPagoMes.Enabled = false;
                CB_OrdenVentasMes.Enabled = false;
            }
            else
            {
                btn_ExportarFileMes.Enabled = true;
                btn_ExportarVentaMes.Enabled = true;
                CB_OrdenPagoMes.Enabled = true;
                CB_OrdenVentasMes.Enabled = true;
            }
        }

        private void DTPInicial()
        {
            if (DTP_SelecDia1.Value == DTP_SelecDia2.Value || DTP_SelecDia1.Value >= DTP_SelecDia2.Value || !(FechaSeleccionada))
            {
                btn_BuscarVenta.Enabled = false;
            }
            else
            {
                btn_BuscarVenta.Enabled = true;
            }
        }

        //////////////////////////////////////////////   METODOS INTERNOS   /////////////////////////////////////////////

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
            DGV.Columns["Fecha"].HeaderText = "Emisión De Venta";
            DGV.Columns["VentaTotal"].DefaultCellStyle.Format = "C2";
        }

        //////////////////////////////////////////////   EVENTOS   /////////////////////////////////////////////

        //////////////////////////////////////////////   DATETIMEPICKER   /////////////////////////////////////////////

        private void DTP_SelecDia1_ValueChanged(object sender, EventArgs e)
        {
            FechaSeleccionada = true;
            DTP_SelecDia2.Enabled = true;
            DTPInicial();
        }

        private void DTP_SelecDia2_ValueChanged(object sender, EventArgs e)
        {
            DTPInicial();
        }

        //////////////////////////////////////////////   COMBO BOX   /////////////////////////////////////////////

        private void CB_OrdenVentasMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool flag = true;
            ReportesNegocio.AscdDescDGV(ListadoHistorialVentas, DGV_VentasMes, CB_OrdenVentasMes, flag);
        }

        private void CB_OrdenPagoMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool flag = true;
            ReportesNegocio.OrdenarPorPagos(ListadoHistorialVentas, DGV_VentasMes, CB_OrdenPagoMes, flag);
        }

        //////////////////////////////////////////////   BOTONERA   /////////////////////////////////////////////


        private void btn_BuscarVenta_Click(object sender, EventArgs e)
        {
            DTPInicial();
            DateTime ContenedorDTP1 = DTP_SelecDia1.Value;
            DateTime ContenedorDTP2 = DTP_SelecDia2.Value;
            ListadoHistorialVentas = ReportesNegocio.ListarVentasMes(ContenedorDTP1, ContenedorDTP2);
            CargarDGV(ListadoHistorialVentas);
        }

        private void btn_ExportarFileMes_Click(object sender, EventArgs e)
        {
            string FileName = "VentasDeSemana";
            ExportFiles.ExportarArchivoExcel(DGV_VentasMes, FileName);
        }

        private void btn_ExportarVentaMes_Click(object sender, EventArgs e)
        {
            try
            {
                if (CeldaSeleccionada > 0)
                {
                    ExportFiles.SeleccionVentaEspecifica(ListadoHistorialVentas, CeldaSeleccionada);
                }
                else
                {
                    MessageBox.Show("Seleccione una venta válida antes de exportar.");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //////////////////////////////////////////////   OTROS EVENTOS   /////////////////////////////////////////////

        private void DGV_VentasMes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex >= 0)
                {
                    CeldaSeleccionada = (int)DGV_VentasMes.Rows[e.RowIndex].Cells["IDVentaGlobal"].Value;
                    btn_ExportarVentaMes.Enabled = true;
                }
                else
                {
                    btn_ExportarVentaMes.Enabled = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
