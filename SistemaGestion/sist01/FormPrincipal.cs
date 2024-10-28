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
    public partial class FormPrincipal : Form
    {
        ///////////////////////////////////////////// INICIALIZACION //////////////////////////////////////////////////
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        ///////////////////////////////////////////// BOTONES PRINCIPALES //////////////////////////////////////////////////
        private void BTNver_articulos_Click(object sender, EventArgs e)
        {
            VerArticulos verArticulos = new VerArticulos();
            verArticulos.ShowDialog();
        }

        private void BTNcargar_venta_Click(object sender, EventArgs e)
        {
            try
            {
                FormVenta formVenta = new FormVenta();
                formVenta.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void BTNver_ventas_Click(object sender, EventArgs e)
        {
            try
            {
                FormRepHoy formHoy = new FormRepHoy();
                formHoy.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        ///////////////////////////////////////////// TOOLBAR ARTICULO //////////////////////////////////////////////////

        private void verStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormStock stockear = new FormStock();
                stockear.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        private void VerTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                VerArticulos verArticulos = new VerArticulos();
                verArticulos.ShowDialog();
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.ToString());
            }
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormCargarArt formCargarArt = new FormCargarArt();
                formCargarArt.ShowDialog();
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.ToString());
            }

        }

        ///////////////////////////////////////////// TOOLBAR VENTA //////////////////////////////////////////////////

        private void cargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                FormVenta formVenta = new FormVenta();
                formVenta.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        ///////////////////////////////////////////// TOOLBAR REPORTES //////////////////////////////////////////////////

        private void enEsteDíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormRepHoy formHoy = new FormRepHoy();
                formHoy.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void enEstaSemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormRepSem formSem = new FormRepSem();
                formSem.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void enEsteMesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                ReporteMes reporteMes = new ReporteMes();
                reporteMes.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }

}
