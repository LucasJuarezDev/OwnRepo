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
using static sist01.FormVenta;

namespace sist01
{
    public partial class FormSelecArtVenta : Form
    {
        ///////////////////////////////////  PROPIEDADES   ////////////////////////////////////

        private ArticuloVendidoNegocio vendidoNegocio = new ArticuloVendidoNegocio();
        private List<Articulo> ListadoArticulos;
        private List<ArticuloVendido> ListadoLocalArticulos = new List<ArticuloVendido>();

        ///////////////////////////////////  INICIO FORM   ////////////////////////////////////
        public FormSelecArtVenta()
        {
            InitializeComponent();
        }

        private void FormSelecArtVenta_Load(object sender, EventArgs e)
        {
            CargaDGV();
        }

        private void FormSelecArtVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            CargaDGV();
        }

        private void DGV_VentaArt_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Color Inminente = Color.Red, Advertencia = Color.Yellow, Normal = Color.White;
            ColorRows(Inminente, Advertencia, Normal);
        }

        //////////////////////////////////   COMPLEMENTARIOS   ///////////////////////////////////////

        private void CargaDGV()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                ListadoArticulos = articuloNegocio.ListarArticulos();
                ListadoLocalArticulos = vendidoNegocio.CopiarArticulos(ListadoArticulos);
                DGV_VentaArt.DataSource = ListadoLocalArticulos;
                HiddenColumns();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void HiddenColumns()
        {
            DGV_VentaArt.Columns["Marca"].DisplayIndex = 1;
            DGV_VentaArt.Columns[0].HeaderText = "Código";
            DGV_VentaArt.Columns["PU"].DefaultCellStyle.Format = "C2";
            DGV_VentaArt.Columns["StockMinimo"].Visible = false;
        }

        private Articulo ObjetosAfilas(DataGridViewRow Fila)
        {
            int CantidadActual = (int)Fila.Cells["Stock"].Value;
            int CodigoActual = (int)Fila.Cells["CodArt"].Value;
            int CantidadSeleccionada = 1;

            if (CantidadActual >= CantidadSeleccionada)
            {
                vendidoNegocio.RestarStockLocal(CodigoActual, CantidadSeleccionada, ListadoLocalArticulos);


                return new Articulo //retorno un articulo cargado con los datos del seleccionado en el dgv de SelectArtVenta
                {               //el nombre de las celdas es el nombre original de la variable en el dominio
                    CodigoArticulo = Convert.ToInt32(Fila.Cells["CodArt"].Value),
                    Marcas = new Marca
                    {
                        Descripcion = Fila.Cells["Marca"].Value.ToString(),
                    },
                    Articulos = Fila.Cells["Nombre"].Value.ToString(),
                    TipoDeArticulo = Fila.Cells["Descripcion"].Value.ToString(),
                    CantidadDeArticulos = CantidadSeleccionada,
                    PrecioVenta = Convert.ToSingle(Fila.Cells["PU"].Value.ToString()),
                    Categoria = new Categoria
                    {
                        Descripcion = "x",
                    },

                };

            }
            else
            {
                MessageBox.Show("Stock No Disponible");
                return null;
            }

        }

        private List<ArticuloVendido> Filtros(bool Flag = false)
        {
            List<ArticuloVendido> ListFiltro = new List<ArticuloVendido>();
            try
            {
                string FiltroNombre = txtBox_Filtro.Text;
                string FiltroMarca = txtBox_Marca.Text;

                if(!Flag)
                {
                    if (DGV_VentaArt != null)
                    {
                        ListFiltro = ListadoLocalArticulos.FindAll(x => x.Nombre.ToUpper().Contains(FiltroNombre.ToUpper()) || x.Descripcion.ToUpper().Contains(FiltroNombre.ToUpper()));
                    }
                    else
                    {
                        ListFiltro = ListadoLocalArticulos;
                    }
                }
                else
                {
                    if (DGV_VentaArt != null)
                    {
                        ListFiltro = ListadoLocalArticulos.FindAll(x => x.Marca.ToUpper().Contains(FiltroMarca.ToUpper()));
                    }
                    else
                    {
                        ListFiltro = ListadoLocalArticulos;
                    }
                }
                return ListFiltro;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ColorRows(Color R, Color Y, Color W)
        {
            try
            {
                foreach (DataGridViewRow row in DGV_VentaArt.Rows)
                {
                    if ((int)row.Cells["Stock"].Value < (int)row.Cells["StockMinimo"].Value)
                    {
                        row.DefaultCellStyle.BackColor = R;
                    }
                    else if ((int)row.Cells["Stock"].Value == (int)row.Cells["StockMinimo"].Value)
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


        //////////////////////////////////   FILTROS DE BUSQUEDA   //////////////////////////////////////

        private void txtBox_Filtro_TextChanged(object sender, EventArgs e)
        {
            List <ArticuloVendido> ListFiltro = new List <ArticuloVendido>();
            ListFiltro = Filtros();
            DGV_VentaArt.DataSource = ListFiltro;
            HiddenColumns();
        }

        private void txtBox_Marca_TextChanged(object sender, EventArgs e)
        {
            List<ArticuloVendido> FiltroMarca = new List<ArticuloVendido>();
            bool Flag = true;
            FiltroMarca = Filtros(Flag);
            DGV_VentaArt.DataSource = FiltroMarca;
            HiddenColumns();
        }


        //////////////////////////////   BOTONERA   //////////////////////////////////////////

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            CargaDGV();
            Close();
        }

        private void DGV_VentaArt_DoubleClick(object sender, EventArgs e)
        {
            FormVenta formVenta = Owner as FormVenta;
            bool ArticuloExistente;
            try
            {
                if(DGV_VentaArt.SelectedRows.Count > 0 && formVenta != null) //Preguntamos si el form esta vacio
                {
                    DataGridViewRow RowSeleccionado = DGV_VentaArt.SelectedRows[0];//El inddice 0 se refiere al unico objeto a agarrar con el doble click
                    Articulo Seleccionado = ObjetosAfilas(RowSeleccionado);

                    if(Seleccionado != null)
                    {
                        int CodigoSeleccionado = Seleccionado.CodigoArticulo;
                        ArticuloExistente = vendidoNegocio.SearchArticuloDuplicado(CodigoSeleccionado);

                        if(ArticuloExistente)
                        {
                            vendidoNegocio.CasteoDeObjeto(Seleccionado);
                            formVenta.AgregarArticuloDGV(Seleccionado); //Me lo llevo al form de venta para mostrarlo en el dgv principal
                        }
                        else
                        {
                            MessageBox.Show("Articulo repetido, elija uno distinto");

                        }
                    }
                }
                    this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
