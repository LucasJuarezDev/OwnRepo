using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using Dominio;
using Negocio;

namespace sist01
{
    public partial class VerArticulos : Form
    {
        ///////////////////////////////////  PROPIEDADES   ////////////////////////////////////
        
        private List <Articulo> ListadoArticulos;

        ///////////////////////////////////  INICIO FORM   ////////////////////////////////////
        public VerArticulos()
        {
            InitializeComponent();
        }

        private void VerArticulos_Load(object sender, EventArgs e)
        {
            CargarDGV();
        }

        private void DGV_VerArticulos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Color Inminente = Color.Red, Advertencia = Color.Yellow, Normal = Color.White;
            ColorRows(Inminente, Advertencia, Normal);
        }

        ///////////////////////////////////  VALIDACIONES   ////////////////////////////////////

        private void HiddenColumns() // OCULTA COLUMNAS MOMENTANEAMENTE INNECESARIAS
        {
            DGV_VerArticulos.Columns["Marcas"].DisplayIndex = 1;
            DGV_VerArticulos.Columns["PrecioVenta"].DefaultCellStyle.Format = "C2";
            DGV_VerArticulos.Columns["PrecioCompra"].Visible = false;
            DGV_VerArticulos.Columns["CantidadMinima"].Visible = false;
            DGV_VerArticulos.Columns["IDMarca"].Visible = false;
            DGV_VerArticulos.Columns["IDCategoria"].Visible = false;
        }

        ///////////////////////////////////  METODOS COMPLEMENTARIOS   ////////////////////////////////////
        private void Eliminar()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            Articulo seleccionado;

            try
            {
                
                seleccionado = (Articulo)DGV_VerArticulos.CurrentRow.DataBoundItem;
                DialogResult Resultado = MessageBox.Show("¿Quiere Usted Proceder?", "Baja De Articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if(Resultado == DialogResult.Yes)
                {
                    articuloNegocio.EliminarArticuloLogico(seleccionado.CodigoArticulo);
                    CargarDGV();
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void CargarDGV()
        {
            ArticuloNegocio articuloDB = new ArticuloNegocio();
            try
            {
                ListadoArticulos = articuloDB.ListarArticulos();
                DGV_VerArticulos.DataSource = ListadoArticulos;
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
                foreach (DataGridViewRow row in DGV_VerArticulos.Rows)
                {
                    if ((int)row.Cells["CantidadDeArticulos"].Value < (int)row.Cells["CantidadMinima"].Value)
                    {
                        row.DefaultCellStyle.BackColor = R;
                    }
                    else if((int)row.Cells["CantidadDeArticulos"].Value == (int)row.Cells["CantidadMinima"].Value)
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

        ///////////////////////////////////  BOTONERA  ////////////////////////////////////

        private void BTN_Close_Art_Click(object sender, EventArgs e)
        {
            VerArticulos.ActiveForm.Close();
        }

        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            Articulo Seleccionado;
            try
            {
                Seleccionado = (Articulo)DGV_VerArticulos.CurrentRow.DataBoundItem;
                FormModificar formModificar = new FormModificar(Seleccionado);
                formModificar.ShowDialog();
                CargarDGV(); // EVITAMOS UN DELAY EN LA ACTUALIZACION DEL DGV

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BTN_BajaLogica_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        ///////////////////////////////////  FILTROS DE BUSQUEDA  ////////////////////////////////////

        private void txtbox_Filtro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> ListaFiltro;
            String Filtro = txtbox_Filtro.Text;

            if(DGV_VerArticulos != null)
            {
                ListaFiltro = ListadoArticulos.FindAll( x => x.Articulos.ToUpper().Contains( Filtro.ToUpper() ) || x.TipoDeArticulo.ToUpper().Contains( Filtro.ToUpper() ) ); 
                //CONTAINS --> METODO QUE PERMITE AL BUSCADOR SER MAS EFECTIVO EVITANDO LA BUSQUEDA ESPECIFICA
            }
            else
            {
                ListaFiltro = ListadoArticulos;
            }
            DGV_VerArticulos.DataSource = ListaFiltro;
            HiddenColumns();

            if(ListaFiltro.Count == 0) // EVITA QUE SE PUEDA CLICKEAR EN LOS BOTONES CUANDO EL DGV ESTE VACIO
            {
                BTN_Modificar.Enabled = false;
                BTN_BajaLogica.Enabled = false;
            }else
            {
                BTN_Modificar.Enabled = true;
                BTN_BajaLogica.Enabled = true;
            }
        }

        private void TXTBOX_FiltroMarca_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> FiltroMarca;
            string Filtro = TXTBOX_FiltroMarca.Text;

            if(DGV_VerArticulos != null)
            {
                FiltroMarca = ListadoArticulos.FindAll(x => x.Marcas.Descripcion.ToUpper().Contains(Filtro.ToUpper()));
            }
            else
            {
                FiltroMarca = ListadoArticulos;
            }
            DGV_VerArticulos.DataSource = FiltroMarca;
            HiddenColumns();

            if(FiltroMarca.Count == 0)
            {
                BTN_Modificar.Enabled = false;
                BTN_BajaLogica.Enabled = false;
            }
            else
            {
                BTN_Modificar.Enabled = true;
                BTN_BajaLogica.Enabled = true;
            }
        }
    }
}
