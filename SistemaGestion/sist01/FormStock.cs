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
    public partial class FormStock : Form
    {
        //////////////////////////////////   PROPIEDADES   ///////////////////////////////////

        private List<Articulo> StockListado;
        private List<Articulo> AuxiliarStock;
        private ArticuloNegocio articuloNegocio = new ArticuloNegocio();
        private Color Inminente = Color.Red, Advertencia = Color.Yellow, Normal = Color.White;

        /////////////////////////////////   INICIO FORM    /////////////////////////////////////////
        public FormStock()
        {
            InitializeComponent();
        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            CargarDGV();
        }

        private void DGV_Stock_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ColorRows(Inminente, Advertencia, Normal);
        }



        /////////////////////////////////   METODOS COMPLEMENTARIOS    /////////////////////////////////////////

        private void CargarDGV()
        {
            try
            {
                StockListado = articuloNegocio.VisualizarStock();
                DGV_Stock.DataSource = StockListado;
                HiddenColumns();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ColorRows(Color R, Color Y, Color W)
        {
            try
            {
                foreach (DataGridViewRow row in DGV_Stock.Rows)
                {
                    if ((int)row.Cells["CantidadDeArticulos"].Value < (int)row.Cells["CantidadMinima"].Value)
                    {
                        row.DefaultCellStyle.BackColor = R;
                    }
                    else if ((int)row.Cells["CantidadDeArticulos"].Value == (int)row.Cells["CantidadMinima"].Value)
                    {
                        row.DefaultCellStyle.BackColor = Y;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = W;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void HiddenColumns()
        {
            DGV_Stock.Columns["Marcas"].DisplayIndex = 0;
            DGV_Stock.Columns.Remove("CodigoArticulo");
            DGV_Stock.Columns.Remove("PrecioVenta");
            DGV_Stock.Columns.Remove("PrecioCompra");
            DGV_Stock.Columns.Remove("Categoria");
            DGV_Stock.Columns.Remove("IDMarca");
            DGV_Stock.Columns.Remove("IDCategoria");
        }

        private List<Articulo> FiltrosDeBusqueda(bool Flag = false)
        {
            List<Articulo> ListFiltro = new List<Articulo>();
            try
            {
                string FiltroNombre = txtbox_FiltroStock.Text;
                string FiltroMarca = txt_Marca.Text;

                if (!Flag)
                {
                    if (DGV_Stock != null)
                    {
                        ListFiltro = StockListado.FindAll(x => x.Articulos.ToUpper().Contains(FiltroNombre.ToUpper()) || x.TipoDeArticulo.ToUpper().Contains(FiltroNombre.ToUpper()));
                    }
                    else
                    {
                        ListFiltro = StockListado;
                    }
                }
                else
                {
                    if (DGV_Stock != null)
                    {
                        ListFiltro = StockListado.FindAll(x => x.Marcas.Descripcion.ToUpper().Contains(FiltroMarca.ToUpper()));
                    }
                    else
                    {
                        ListFiltro = StockListado;
                    }
                }

                if(ListFiltro.Count == 0)
                {
                    BTN_StockPlus.Enabled = false;
                }
                else
                {
                    BTN_StockPlus.Enabled = true;
                }
                return ListFiltro;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /////////////////////////////////   FILTROS DE BUSQUEDA    /////////////////////////////////////////

        private void txtbox_FiltroStock_TextChanged(object sender, EventArgs e)
        {
            AuxiliarStock = FiltrosDeBusqueda();
            DGV_Stock.DataSource = AuxiliarStock;
            HiddenColumns();
        }

        private void txt_Marca_TextChanged(object sender, EventArgs e)
        {
            AuxiliarStock = FiltrosDeBusqueda(true);
            DGV_Stock.DataSource = AuxiliarStock;
            HiddenColumns();
        }

        /////////////////////////////////   BOTONERA    /////////////////////////////////////////

        private void BTN_StockPlus_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            try
            {
                seleccionado = (Articulo)DGV_Stock.CurrentRow.DataBoundItem;
                FormAñadirStockBTN FormSTK = new FormAñadirStockBTN(seleccionado);
                FormSTK.ShowDialog();
                CargarDGV();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
