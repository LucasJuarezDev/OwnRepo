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
    public partial class FormAñadirStockBTN : Form
    {
        //////////////////////////   PROPIEDADES   ////////////////////////////////
        private Articulo art = null;

        //////////////////////////   VALIDACIONES   ////////////////////////////////
        
        private bool TodoEnOrden()
        {
            if(DUP_Stock.Text != "" && DUP_MinStock.Text != "")
            {
                return true;
            }else
            {
                return false;
            }
        }

        private void SoloNumeros(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ConfigurarDUP()
        {
            for (int x = 1; x <= 500; x++)
            {
                DUP_Stock.Items.Add(x);
                DUP_MinStock.Items.Add(x);
            }
            DUP_Stock.Wrap = false;
            DUP_MinStock.Wrap = false;
        }

        //////////////////////////   INICIO FORM   ////////////////////////////////
        public FormAñadirStockBTN(Articulo articulo)
        {
            InitializeComponent();
            this.art = articulo;
        }

        private void FormAñadirStockBTN_Load(object sender, EventArgs e)
        {
            string DenominacionArticulo = art.Marcas.Descripcion.ToString() + " " + art.Articulos.ToString() + " " + art.TipoDeArticulo.ToString();
            ConfigurarDUP();
            try
            {
                if(art != null)
                {
                    lbl_Titulo.Text = DenominacionArticulo;
                    DUP_Stock.Text = art.CantidadDeArticulos.ToString();
                    DUP_MinStock.Text = art.CantidadMinima.ToString();
                    DUP_MinStock.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        //////////////////////////   CONTROLES OTROS   ////////////////////////////////

        private void CHBox_ModStkMin_CheckedChanged(object sender, EventArgs e)
        {
            if (!(CHBox_ModStkMin.Checked))
            {
                DUP_MinStock.Enabled = false;
            }
            else
            {
                DUP_MinStock.Enabled = true;
            }
        }

        private void txtBox_Stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtBox_StkMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        //////////////////////////   ACEPTAR Y CANCELAR   ////////////////////////////////

        private void BTN_StockCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_ModStock_Click(object sender, EventArgs e)
        {
            ArticuloNegocio ArtNeg = new ArticuloNegocio();
            try
            {
                if(TodoEnOrden())
                {
                    art.CantidadDeArticulos = int.Parse(DUP_Stock.Text);
                    art.CantidadMinima = int.Parse(DUP_MinStock.Text);
                    ArtNeg.ModificarStock(art);
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

        private void DUP_Stock_SelectedItemChanged(object sender, EventArgs e)
        {
            ConfigurarDUP();
            int Input;
            if(int.TryParse(DUP_Stock.Text, out Input))
            {
                if(Input < 1)
                {
                    DUP_Stock.Text = "1";
                }
                else if(Input > 500)
                {
                    DUP_Stock.Text = "500";
                }
            }else
            {
                DUP_Stock.Text = art.CantidadDeArticulos.ToString();
            }
        }

        private void DUP_MinStock_SelectedItemChanged(object sender, EventArgs e)
        {
            ConfigurarDUP();
            int Input;
            if (int.TryParse(DUP_Stock.Text, out Input))
            {
                if (Input < 1)
                {
                    DUP_MinStock.Text = "1";
                }
                else if (Input > 500)
                {
                    DUP_MinStock.Text = "500";
                }
            }
            else
            {
                DUP_MinStock.Text = art.CantidadDeArticulos.ToString();
            }
        }
    }
}
