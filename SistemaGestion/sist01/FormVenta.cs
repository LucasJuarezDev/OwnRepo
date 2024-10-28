using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace sist01
{
    public partial class FormVenta : Form
    {
        /////////////////////////////////    PROPIEDADES   ////////////////////////////////

        private Venta Venta = new Venta();  
        private VentaNegocio ventaNegocio = new VentaNegocio();
        private ArticuloVendidoNegocio articuloVendido = new ArticuloVendidoNegocio();
        private ArticuloNegocio articuloNegocio = new ArticuloNegocio();
        private DataGridViewRow row;

        /////////////////////////////////    VALIDACIONES   ////////////////////////////////

        private bool ElementosCargados()
        {
            if(CB_MedioPago.SelectedIndex != 0 && DGV_Ventas.Rows.Count > 0)
            {
                return false;
            }else
            {
                return true;
            }
        }

        private void DGVvacio()
        {
            if (DGV_Ventas.Rows.Count == 1)
            {
                BTN_SumarArt.Enabled = false;
                BTN_RestarArt.Enabled = false;
                BTN_EliminarProducto.Enabled = false;
                BTN_FinalizarCompra.Enabled = false;
                btn_Descuento.Enabled = false;
                btn_AplicarTodos.Enabled = false;
                txtbox_Descuento.Enabled = false;
            }
            else
            {
                BTN_SumarArt.Enabled = true;
                BTN_RestarArt.Enabled = true;
                BTN_EliminarProducto.Enabled = true;
                BTN_FinalizarCompra.Enabled = true;
                btn_Descuento.Enabled = true;
                btn_AplicarTodos.Enabled = true;
                txtbox_Descuento.Enabled = true;
                DGV_Ventas.Columns[5].DefaultCellStyle.Format = "C2";
                DGV_Ventas.Columns[6].DefaultCellStyle.Format = "C2";
            }
        }

        /////////////////////////////////    INICIO/CIERRE FORM   ////////////////////////////////
        public FormVenta()
        {
            InitializeComponent();
            DGVvacio();

        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            VentaNegocio ventaNegocio = new VentaNegocio();
            DGVvacio();
            txtbox_IDventa.Text = ventaNegocio.LastID().ToString();
            txtbox_Fecha.Text = Venta.FechaVenta.ToShortDateString();
            CB_MedioPago.SelectedIndex = 0;
            ActualizarPrecioTXT();
        }

        private void FormVenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            articuloVendido.ClearTable();
        }

        /////////////////////////////////    TEXTBOXS   ////////////////////////////////

        private void ActualizarPrecioTXT()
        {
            float total = 0;
            try
            {
                foreach (DataGridViewRow row in DGV_Ventas.Rows)
                {
                    if (row.Cells[6].Value != null && (float)row.Cells[6].Value != 0)
                    {
                        total += (float)row.Cells[6].Value;
                    }
                }
                txtBox_Total.Text = total.ToString("C");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txtbox_Descuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /////////////////////////////////    BOTONES   ////////////////////////////////

        private void btn_AgregarArticulo_Click(object sender, EventArgs e)
        {
            FormSelecArtVenta formSelecArtVenta = new FormSelecArtVenta();
            AddOwnedForm(formSelecArtVenta);
            formSelecArtVenta.ShowDialog();
           
        }

        private void BTN_SumarArt_Click(object sender, EventArgs e)
        {
            int CantidadArticulo, CantidadConsulta, CodigoConsulta = 0;
            bool HayStock;
            float PrecioT, Precio;

            try
            {
                row = DGV_Ventas.CurrentRow;
                if (DGV_Ventas != null && row.Cells[0].Value != null)
                {
                    CodigoConsulta = (int)row.Cells[0].Value;
                    CantidadConsulta = (int)row.Cells[4].Value + 1;
                    HayStock = articuloNegocio.SituacionDeStock(CodigoConsulta, CantidadConsulta);
                    if(HayStock)
                    {
                        CantidadArticulo = (int)row.Cells[4].Value;
                        Precio = (float)row.Cells[5].Value;
                        PrecioT = (float)row.Cells[6].Value;
                        CantidadArticulo++;
                        row.Cells[4].Value = CantidadArticulo;
                        PrecioT = CantidadArticulo * Precio;
                        row.Cells[6].Value = PrecioT;
                        ActualizarPrecioTXT();
                        DGVvacio();

                        BTN_SumarArt.Enabled = articuloNegocio.SituacionDeStock(CodigoConsulta, CantidadArticulo);
                    }else
                    {
                        BTN_SumarArt.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void BTN_RestarArt_Click(object sender, EventArgs e)
        {
            int CantidadArticulo;
            float PrecioT, Precio;
            try
            {
                row = DGV_Ventas.CurrentRow;
                if (DGV_Ventas != null && row.Cells[0].Value != null && (int)row.Cells[4].Value > 1)
                {
                    CantidadArticulo = (int)row.Cells[4].Value;
                    Precio = (float)row.Cells[5].Value;
                    PrecioT = (float)row.Cells[6].Value;
                    CantidadArticulo--;
                    row.Cells[4].Value = CantidadArticulo;
                    PrecioT -= Precio;
                    row.Cells[6].Value = PrecioT;
                    ActualizarPrecioTXT();
                    DGVvacio();

                    int codigo = (int)row.Cells[0].Value;
                    BTN_RestarArt.Enabled = articuloNegocio.SituacionDeStock(codigo, CantidadArticulo);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void BTN_EliminarProducto_Click(object sender, EventArgs e)
        {
            int CodigoEliminado;
            try
            {
                row = DGV_Ventas.CurrentRow;
                if (row.Cells[0].Value != null) //Evita un error en capturar el valor de una fila con valores nulos
                {
                    CodigoEliminado = (int)row.Cells[0].Value;
                    Articulo seleccionado;
                    seleccionado = (Articulo)DGV_Ventas.CurrentRow.DataBoundItem;
                    DGV_Ventas.Rows.Remove(DGV_Ventas.CurrentRow);
                    articuloVendido.ClearTable(CodigoEliminado);
                    ActualizarPrecioTXT();
                    DGVvacio();
                }
                CodigoEliminado = 0;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void btn_Descuento_Click(object sender, EventArgs e)
        {
            float PrecioConDescuento, PrecioCapturado;
            double Porcentaje;
            try
            {
                row = DGV_Ventas.CurrentRow;
                if(txtbox_Descuento.Text != "" && row.Cells[0].Value != null)
                {
                    Porcentaje = float.Parse(txtbox_Descuento.Text);
                    if (Porcentaje <= 100)
                    {
                        PrecioCapturado = (float)row.Cells[5].Value;
                        PrecioConDescuento = ConversionDePorcentaje(Porcentaje, PrecioCapturado);
                        row.Cells[5].Value = PrecioConDescuento;
                        int Cantidad = (int)row.Cells[4].Value;
                        row.Cells[6].Value = PrecioConDescuento * Cantidad;
                    }
                    txtbox_Descuento.Clear();
                    ActualizarPrecioTXT();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btn_AplicarTodos_Click(object sender, EventArgs e)
        {
            float PrecioConDescuento, PrecioCapturado;
            double Porcentaje;
            try
            {
                if (txtbox_Descuento.Text != "" )
                {
                    Porcentaje = float.Parse(txtbox_Descuento.Text);
                    if(Porcentaje <= 100)
                    {
                        foreach (DataGridViewRow Rows in DGV_Ventas.Rows)
                        {
                            if (Rows.Cells[0].Value != null && Rows.Cells[5].Value != null && Rows.Cells[4].Value != null)
                            {
                                PrecioCapturado = (float)Rows.Cells[5].Value;
                                PrecioConDescuento = ConversionDePorcentaje(Porcentaje, PrecioCapturado);
                                Rows.Cells[5].Value = PrecioConDescuento;
                                int Cantidad = (int)Rows.Cells[4].Value;
                                Rows.Cells[6].Value = PrecioConDescuento * Cantidad;
                            }
                        }

                    }
                    txtbox_Descuento.Clear();
                    ActualizarPrecioTXT();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /////////////////////////////////   OTROS METODOS  ////////////////////////////////

        private float ConversionDePorcentaje(double Porcentaje, float PrecioCapturado)
        {
            float aux, PrecioConDescuento;
            try
            {
                Porcentaje *= 0.01;
                aux = PrecioCapturado * (float)Porcentaje;
                PrecioConDescuento = PrecioCapturado - aux;
                return PrecioConDescuento;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private bool TipoDePago()
        {
            if(CB_MedioPago.SelectedIndex == 1 && CB_MedioPago.SelectedIndex != 0)
            {
                return true;
            }else
            {
                return false;
            }
        }

        /////////////////////////////////   METODOS DEL DGV  ////////////////////////////////

        public void AgregarArticuloDGV(Articulo articulo)
        {
            int IDR = 0;

            try
            {
                if(articulo != null)
                {
                    foreach (DataGridViewRow row in DGV_Ventas.Rows)
                    {
                        IDR = Convert.ToInt32(row.Cells[0].Value);
                        if(IDR == articulo.CodigoArticulo)
                        {
                            MessageBox.Show("Articulo repetido, elija uno distinto");
                            return;
                        }
                    }
                    int RowINDEX = DGV_Ventas.Rows.Add();
                    DataGridViewRow Row = DGV_Ventas.Rows[RowINDEX];
                    Row.Cells[0].Value = articulo.CodigoArticulo;
                    Row.Cells[1].Value = articulo.Marcas.Descripcion;
                    Row.Cells[2].Value = articulo.Articulos;
                    Row.Cells[3].Value = articulo.TipoDeArticulo;
                    Row.Cells[4].Value = articulo.CantidadDeArticulos;
                    Row.Cells[5].Value = articulo.PrecioVenta;
                    Row.Cells[6].Value = articulo.PrecioVenta;
                    ActualizarPrecioTXT();
                    DGVvacio();
                }else
                {
                    return;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void DGV_Ventas_SelectionChanged(object sender, EventArgs e)
        {
            row = DGV_Ventas.CurrentRow;
            int CantidadArticulo = 0, Codigo = 0;
            bool HayStock;
            try
            {
                if (row != null && row.Cells[0].Value != null)
                {
                    CantidadArticulo = (int)row.Cells[4].Value;
                    Codigo = (int)row.Cells[0].Value;
                    HayStock = articuloNegocio.SituacionDeStock(Codigo, CantidadArticulo);
                    BTN_SumarArt.Enabled = HayStock;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /////////////////////////////////   FINALIZAR COMPRA  ////////////////////////////////

        private void BTN_FinalizarCompra_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            int Codigo, Cantidad, StockActualizado;

            if(!(ElementosCargados()))
            {
                try
                {
                    int ID = int.Parse(txtbox_IDventa.Text);
                    foreach (DataGridViewRow row in DGV_Ventas.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            Articulo articulo = new Articulo();
                            articulo.CodigoArticulo = (int)row.Cells[0].Value;
                            Codigo = (int)row.Cells[0].Value;
                            articulo.CantidadDeArticulos = (int)row.Cells[4].Value;
                            Cantidad = (int)row.Cells[4].Value;
                            articulo.PrecioCompra = (float)row.Cells[6].Value; 
                            venta.ArticulosVendidos.Add(articulo);
                            StockActualizado = articuloVendido.StockDB(Codigo, Cantidad);
                            articuloNegocio.ActualizarDatosDB(Codigo, StockActualizado);
                        }
                        Codigo = StockActualizado = Cantidad = 0;
                    }
                    venta.MetodoDePago = TipoDePago();
                    venta.IDGlobalVentas = ID;
                    ventaNegocio.CargarVenta(venta);
                    articuloVendido.ClearTable();
                    MessageBox.Show("Usted Ha Realizado Una Venta", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString());
                }
            }else
            {
                MessageBox.Show("Cargue Correctamente Los Campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
