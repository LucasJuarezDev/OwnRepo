using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace sist01
{
    public partial class FormCargarArt : Form
    {
        /////////////////////////// PROPIEDADES /////////////////////////////////

        MarcaNegocio marcaNegocio = new MarcaNegocio();
        CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
        ArticuloNegocio ArticuloNegocio = new ArticuloNegocio();

        /////////////////////////// INICIO FORM /////////////////////////////////

        public FormCargarArt()
        {
            InitializeComponent();
        }

        //////////////////////////  VALIDACIONES  ////////////////////////////

        private void SoloNumeros(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private bool TodoEnOrden()
        {
            if(TXT_Tipo.Text != "" && TXT_Cantidad.Text != "" && txtbox_StockMin.Text != "" && TXT_PrecioVenta.Text != "")
            {
                if(TXT_NewMarca.Text != "" || txt_NewClasf.Text != "" || txt_NewNombre.Text != "" || CB_Categoria.SelectedIndex >= 0 || CB_Marca.SelectedIndex >= 0 || cb_Articulos.SelectedIndex >= 0)
                {
                    return true;
                }
            }
            return false;
        }

        private bool MarcasRepetidas()
        {
            string MarcaEscrita;
            try
            {
                MarcaEscrita = TXT_NewMarca.Text;
                bool respuesta = marcaNegocio.CompararMarca(MarcaEscrita);
                return respuesta;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private bool CategoriasRepetidas()
        {
            string CategoriasEscrita;
            try
            {
                CategoriasEscrita = txt_NewClasf.Text;
                bool respuesta = categoriaNegocio.CompararCategoria(CategoriasEscrita);
                return respuesta;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private bool NombreRepetidos()
        {
            string NombreEscrito;
            try
            {
                NombreEscrito = txt_NewNombre.Text;
                bool respuesta = ArticuloNegocio.CompararNombres(NombreEscrito);
                return respuesta;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void TXT_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtbox_StockMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void TXT_PrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        //////////////////////////   NUEVAS MARCAS Y CAT   ////////////////////////////////

        private Marca ConvertirStringMarca(string descripcion)
        {
            Marca marca = new Marca();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            marca.Descripcion = descripcion;
            marca.CodigoMarca = (marcaNegocio.LastID() + 1);
            marcaNegocio.CargarMarca(marca);
            return marca;
        }

        private Categoria ConvertirStringCategoria(string descripcion)
        {
            Categoria categoria = new Categoria();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            categoria.Descripcion = descripcion;
            categoria.CodigoCategoria = (categoriaNegocio.LastID() + 1);
            categoriaNegocio.CargarCategoria(categoria);
            return categoria;
        }

        ///////////////////////  ACEPTAR Y CANCELAR   ///////////////////////////

        private void BTN_Cargar_Art_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloNegocio Negocio = new ArticuloNegocio();
            try
            {
                if(TodoEnOrden() && MarcasRepetidas() && CategoriasRepetidas() && NombreRepetidos())
                {

                    //articulo.Articulos = TXT_Nombre.Text;
                    articulo.TipoDeArticulo = TXT_Tipo.Text;
                    articulo.CantidadDeArticulos = int.Parse(TXT_Cantidad.Text);
                    articulo.CantidadMinima = int.Parse(txtbox_StockMin.Text);
                    articulo.PrecioVenta = float.Parse(TXT_PrecioVenta.Text);

                        if(!(cb_Articulos.Enabled))
                        {
                            articulo.Articulos = txt_NewNombre.Text;
                        }
                        else
                        { 
                            var nombreSelect = (Articulo)cb_Articulos.SelectedItem;
                            articulo.Articulos = nombreSelect.Articulos;
                        }
                        if(!(CB_Marca.Enabled))
                        {
                            Marca marca = ConvertirStringMarca(TXT_NewMarca.Text);
                            articulo.IDMarca = marca.CodigoMarca;
                            articulo.Marcas = marca;

                        }else
                        {
                            var marcaSelect = (Marca)CB_Marca.SelectedItem;// selectedItem devuelve un objeto, al castearlo afirmamos que tipo de objeto debe devolver
                            articulo.IDMarca = marcaSelect.CodigoMarca;
                            articulo.Marcas = marcaSelect;
                        }

                        if(!(CB_Categoria.Enabled))
                        {
                            Categoria categoria = ConvertirStringCategoria(txt_NewClasf.Text);
                            articulo.IDCategoria = categoria.CodigoCategoria;
                            articulo.Categoria = categoria;
                        }else
                        {
                            var catSelect = (Categoria)CB_Categoria.SelectedItem;
                            articulo.IDCategoria = catSelect.CodigoCategoria;   
                            articulo.Categoria = catSelect;
                        }

                    Negocio.CargarArticulo(articulo);
                    MessageBox.Show("Articulo Cargado", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Close();
                }else
                {
                    if(!(CategoriasRepetidas()) || !(MarcasRepetidas()) || !(NombreRepetidos()))
                    {
                        MessageBox.Show("Clasf / Marca / Nombre Repetido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Cargue Correctamente Los Campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Cargue Correctamente Los Campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BTN_Cancelar_Art_Click(object sender, EventArgs e)
        {
            Close();
        }

        ///////////////////////     INICIO DEL FORM     /////////////////////////////////

        private void FormCargarArt_Load(object sender, EventArgs e)
        {
            try
            {
                CB_Marca.SelectedItem = -1;
                CB_Categoria.SelectedItem = -1;
                cb_Articulos.SelectedItem = -1;

                var ListarMarcas = marcaNegocio.ListarMarcas();
                CB_Marca.DataSource = ListarMarcas;
                CB_Marca.ValueMember = "CodigoMarca";
                CB_Marca.DisplayMember = "Descripcion";
                MarcaColeccion(ListarMarcas);

                var ListarCategorias = categoriaNegocio.ListarCategorias();
                CB_Categoria.DataSource = ListarCategorias;
                CB_Categoria.ValueMember = "CodigoCategoria";
                CB_Categoria.DisplayMember = "Descripcion";
                CategoriaColeccion(ListarCategorias);

                var ListarNombres = ArticuloNegocio.ListarNombres();
                cb_Articulos.DataSource = ListarNombres;
                cb_Articulos.ValueMember = "CodigoArticulo";
                cb_Articulos.DisplayMember = "Articulos";
                NombreColeccion(ListarNombres);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        /////////////////////////   TEXT LABELS    ////////////////////////////////

        private void TXT_NewMarca_TextChanged(object sender, EventArgs e)
        {
            if(TXT_NewMarca.Text != "")
            {
                CB_Marca.Enabled = false;

            }
            else
            {
                CB_Marca.Enabled = true;

            }
        }

        private void txt_NewClasf_TextChanged(object sender, EventArgs e)
        {
            if(txt_NewClasf.Text != "")
            {
                CB_Categoria.Enabled = false;
            }
            else
            {
                CB_Categoria.Enabled=true;
            }
        }

        private void txt_NewNombre_TextChanged(object sender, EventArgs e)
        {
            if(txt_NewNombre.Text != "")
            {
                cb_Articulos.Enabled = false;
            }
            else
            {
                cb_Articulos.Enabled = true;
            }
        }

        /////////////////////////   COLECCIONES    ////////////////////////////////

        private void MarcaColeccion(List<Marca> Lista)
        {
            AutoCompleteStringCollection Collection = new AutoCompleteStringCollection();
            try
            {
                foreach (var marca in Lista)
                {
                    Collection.Add(marca.Descripcion);
                }
                CB_Marca.AutoCompleteCustomSource = Collection;
                CB_Marca.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                CB_Marca.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CategoriaColeccion(List<Categoria> Lista)
        {
            AutoCompleteStringCollection Collection = new AutoCompleteStringCollection();
            try
            {
                foreach (var cat in Lista)
                {
                    Collection.Add(cat.Descripcion);
                }
                CB_Categoria.AutoCompleteCustomSource = Collection;
                CB_Categoria.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                CB_Categoria.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void NombreColeccion(List<Articulo> Lista)
        {
            AutoCompleteStringCollection Collection = new AutoCompleteStringCollection();
            try
            {
                foreach (var name in Lista)
                {
                    Collection.Add(name.Articulos);
                }
                cb_Articulos.AutoCompleteCustomSource = Collection;
                cb_Articulos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cb_Articulos.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
