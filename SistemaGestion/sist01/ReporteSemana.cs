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
    public partial class FormRepSem : Form
    {
        //////////////////////////////////////////////   PROPIEDADES   /////////////////////////////////////////////
        private DateTime ContenedorDTP1;
        private DateTime ContenedorDTP2;
        private List<Venta> ListaVentasSemanal;
        private ReportesNegocio ReportesNegocio = new ReportesNegocio();
        private bool FechaSeleccionada = false;
        private ExportarArchivos ExportFiles = new ExportarArchivos();
        private int CeldaSeleccionada = 0;

        //////////////////////////////////////////////   INICIALIZACION   /////////////////////////////////////////////
        public FormRepSem()
        {
            InitializeComponent();
        }

        private void FormRepSem_Load(object sender, EventArgs e)
        {
            try
            {
                ConfiguracionDTP();
                DGVacio();
                DTPInicial();
                DTP_SelecDia1.Value = DateTime.Now;
                DTP_SelecDia2.Value = DateTime.Now;
                DTP_SelecDia2.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void CargarDGV(List<Venta> ListaSemanal)
        {
            try
            {
                var datosParaMostrar = ListaSemanal.Select(v => new
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

                DGV_VentasSem.DataSource = datosParaMostrar;
                RenameColumns(DGV_VentasSem);
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
            if (DGV_VentasSem.Rows.Count < 1)
            {
                btn_ExportarFileSem.Enabled = false;
                btn_ExportarVentaSem.Enabled = false;
                CB_OrdenPagoSem.Enabled = false;
                CB_OrdenVentasSem.Enabled = false;
            }
            else
            {
                btn_ExportarFileSem.Enabled = true;
                btn_ExportarVentaSem.Enabled = true;
                CB_OrdenPagoSem.Enabled = true;
                CB_OrdenVentasSem.Enabled = true;
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

        private void ConfiguracionDTP()
        {
            int MesActual = DateTime.Now.Month;
            int AñoActual= DateTime.Now.Year;

            DateTime PrimerDiaMes = new DateTime(AñoActual, MesActual, 1);
            DateTime UltimoDiaMes = PrimerDiaMes.AddMonths(1).AddDays(-1);
            
            DTP_SelecDia1.MinDate = PrimerDiaMes;
            DTP_SelecDia1.MaxDate = UltimoDiaMes;

        }

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

        //////////////////////////////////////////////   BOTONERA   /////////////////////////////////////////////

        private void btn_BuscarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                DTPInicial();
                ContenedorDTP1 = DTP_SelecDia1.Value;
                ContenedorDTP2 = DTP_SelecDia2.Value;
                ListaVentasSemanal = ReportesNegocio.ListarVentasMes(ContenedorDTP1, ContenedorDTP2);
                CargarDGV(ListaVentasSemanal);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_ExportarFileSem_Click(object sender, EventArgs e)
        {
            string FileName = "VentasDeSemana";
            ExportFiles.ExportarArchivoExcel(DGV_VentasSem, FileName);
        }

        private void btn_ExportarVentaSem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CeldaSeleccionada > 0)
                {
                    ExportFiles.SeleccionVentaEspecifica(ListaVentasSemanal, CeldaSeleccionada);

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

        //////////////////////////////////////////////   COMBO BOX   /////////////////////////////////////////////

        private void CB_OrdenVentasSem_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool flag = true;
            ReportesNegocio.AscdDescDGV(ListaVentasSemanal, DGV_VentasSem, CB_OrdenVentasSem, flag);
        }

        private void CB_OrdenPagoSem_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool flag = true;
            ReportesNegocio.OrdenarPorPagos(ListaVentasSemanal, DGV_VentasSem, CB_OrdenPagoSem, flag);
        }

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

        //////////////////////////////////////////////   OTROS EVENTOS   /////////////////////////////////////////////

        private void DGV_VentasSem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    CeldaSeleccionada = (int)DGV_VentasSem.Rows[e.RowIndex].Cells["IDVentaGlobal"].Value;
                    btn_ExportarVentaSem.Enabled = true;
                }
                else
                {
                    btn_ExportarVentaSem.Enabled = false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
