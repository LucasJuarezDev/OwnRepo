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
    public partial class FormModificar : Form
    {
        /////////////////////////    PROPIEDADES   /////////////////////////////////
        
        private Articulo Articulo = null;

        /////////////////////////    INICIO FORM   ///////////////////////////////////

        public FormModificar(Articulo articulo)
        {
            InitializeComponent();
            this.Articulo = articulo; //indicamos que el articulo traido es igual al articulo que es propiedad private
        }

        /////////////////////////////  VALIDACIONES   ////////////////////////////////

        private bool TodoEnOrden()
        {
            if(TBOX_MODNAME.Text != "" && TBOX_MODESC.Text != "" && TBOX_MODPU.Text != "")
            {
                if((CB_MODMARCA.SelectedIndex != -1 && CB_MODCLASF.SelectedIndex != -1) || (CB_MODMARCA.SelectedIndex != 0 && CB_MODCLASF.SelectedIndex != 0))
                {
                    return true;
                }
            }
            return false;
        }

        private void TBOX_MODPU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        ///////////////////////   FORMULARIO DE CARGA  ////////////////////////////////////
        private void FormModificar_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                CB_MODMARCA.DataSource = marcaNegocio.ListarMarcas();
                CB_MODMARCA.ValueMember = "CodigoMarca"; //     ID DE LOS OBJETOS QUE SE MUESTRAN
                CB_MODMARCA.DisplayMember = "Descripcion"; //     VALOR QUE SE MOSTRARA EN EL COMBOBOX
                CB_MODCLASF.DataSource = categoriaNegocio.ListarCategorias();
                CB_MODCLASF.ValueMember = "CodigoCategoria";
                CB_MODCLASF.DisplayMember = "Descripcion";

                if (Articulo != null)
                {
                    TBOX_MODNAME.Text = Articulo.Articulos;
                    TBOX_MODESC.Text = Articulo.TipoDeArticulo;
                    TBOX_MODPU.Text = Articulo.PrecioVenta.ToString(); //toString por ser flotante
                    CB_MODMARCA.SelectedValue = Articulo.Marcas.CodigoMarca;
                    CB_MODCLASF.SelectedValue = Articulo.Categoria.CodigoCategoria;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        /////////////////////////////   ACEPTAR Y CANCELAR    /////////////////////////////////////

        private void BTN_ACEPTAR_MOD_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                if(TodoEnOrden())
                {
                    Articulo.Articulos = TBOX_MODNAME.Text;
                    Articulo.TipoDeArticulo = TBOX_MODESC.Text;
                    Articulo.PrecioVenta = float.Parse(TBOX_MODPU.Text);
                    Articulo.Marcas = (Marca)CB_MODMARCA.SelectedItem;
                    Articulo.Categoria = (Categoria)CB_MODCLASF.SelectedItem;

                    articuloNegocio.ModificarArticulo(Articulo);
                    MessageBox.Show("Articulo Modificado", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Close();
                }else
                {
                    MessageBox.Show("Cargue Correctamente Los Campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        private void BTN_CANCELAR_MOD_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
