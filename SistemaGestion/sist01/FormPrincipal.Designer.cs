namespace sist01
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.articuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VerTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enEsteDíaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enEstaSemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enEsteMesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BTNcargar_venta = new System.Windows.Forms.Button();
            this.BTNver_ventas = new System.Windows.Forms.Button();
            this.BTNver_articulos = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articuloToolStripMenuItem,
            this.ventaToolStripMenuItem,
            this.cajaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // articuloToolStripMenuItem
            // 
            this.articuloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarToolStripMenuItem,
            this.VerTodoToolStripMenuItem,
            this.verStockToolStripMenuItem});
            this.articuloToolStripMenuItem.Name = "articuloToolStripMenuItem";
            this.articuloToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.articuloToolStripMenuItem.Text = "Articulo";
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F1)));
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.cargarToolStripMenuItem.Text = "Añadir";
            this.cargarToolStripMenuItem.Click += new System.EventHandler(this.cargarToolStripMenuItem_Click);
            // 
            // VerTodoToolStripMenuItem
            // 
            this.VerTodoToolStripMenuItem.Name = "VerTodoToolStripMenuItem";
            this.VerTodoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F2)));
            this.VerTodoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.VerTodoToolStripMenuItem.Text = "Ver Todos";
            this.VerTodoToolStripMenuItem.Click += new System.EventHandler(this.VerTodoToolStripMenuItem_Click);
            // 
            // verStockToolStripMenuItem
            // 
            this.verStockToolStripMenuItem.Name = "verStockToolStripMenuItem";
            this.verStockToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F3)));
            this.verStockToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.verStockToolStripMenuItem.Text = "Ver Stock";
            this.verStockToolStripMenuItem.Click += new System.EventHandler(this.verStockToolStripMenuItem_Click);
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarToolStripMenuItem1});
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ventaToolStripMenuItem.Text = "Venta";
            // 
            // cargarToolStripMenuItem1
            // 
            this.cargarToolStripMenuItem1.Name = "cargarToolStripMenuItem1";
            this.cargarToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F5)));
            this.cargarToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.cargarToolStripMenuItem1.Text = "Cargar";
            this.cargarToolStripMenuItem1.Click += new System.EventHandler(this.cargarToolStripMenuItem1_Click);
            // 
            // cajaToolStripMenuItem
            // 
            this.cajaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enEsteDíaToolStripMenuItem,
            this.enEstaSemToolStripMenuItem,
            this.enEsteMesToolStripMenuItem1});
            this.cajaToolStripMenuItem.Name = "cajaToolStripMenuItem";
            this.cajaToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.cajaToolStripMenuItem.Text = "Reportes";
            // 
            // enEsteDíaToolStripMenuItem
            // 
            this.enEsteDíaToolStripMenuItem.Name = "enEsteDíaToolStripMenuItem";
            this.enEsteDíaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.enEsteDíaToolStripMenuItem.Text = "En Este Día";
            this.enEsteDíaToolStripMenuItem.Click += new System.EventHandler(this.enEsteDíaToolStripMenuItem_Click);
            // 
            // enEstaSemToolStripMenuItem
            // 
            this.enEstaSemToolStripMenuItem.Name = "enEstaSemToolStripMenuItem";
            this.enEstaSemToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.enEstaSemToolStripMenuItem.Text = "En Esta Semana";
            this.enEstaSemToolStripMenuItem.Click += new System.EventHandler(this.enEstaSemToolStripMenuItem_Click);
            // 
            // enEsteMesToolStripMenuItem1
            // 
            this.enEsteMesToolStripMenuItem1.Name = "enEsteMesToolStripMenuItem1";
            this.enEsteMesToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.enEsteMesToolStripMenuItem1.Text = "En Este Mes";
            this.enEsteMesToolStripMenuItem1.Click += new System.EventHandler(this.enEsteMesToolStripMenuItem1_Click);
            // 
            // BTNcargar_venta
            // 
            this.BTNcargar_venta.Location = new System.Drawing.Point(12, 43);
            this.BTNcargar_venta.Name = "BTNcargar_venta";
            this.BTNcargar_venta.Size = new System.Drawing.Size(106, 91);
            this.BTNcargar_venta.TabIndex = 0;
            this.BTNcargar_venta.Text = "NUEVA VENTA";
            this.BTNcargar_venta.UseVisualStyleBackColor = true;
            this.BTNcargar_venta.Click += new System.EventHandler(this.BTNcargar_venta_Click);
            // 
            // BTNver_ventas
            // 
            this.BTNver_ventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTNver_ventas.Location = new System.Drawing.Point(12, 170);
            this.BTNver_ventas.Name = "BTNver_ventas";
            this.BTNver_ventas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BTNver_ventas.Size = new System.Drawing.Size(106, 91);
            this.BTNver_ventas.TabIndex = 1;
            this.BTNver_ventas.Text = "CAJA (EN ESTE DÍA)";
            this.BTNver_ventas.UseVisualStyleBackColor = true;
            this.BTNver_ventas.Click += new System.EventHandler(this.BTNver_ventas_Click);
            // 
            // BTNver_articulos
            // 
            this.BTNver_articulos.Location = new System.Drawing.Point(12, 293);
            this.BTNver_articulos.Name = "BTNver_articulos";
            this.BTNver_articulos.Size = new System.Drawing.Size(106, 91);
            this.BTNver_articulos.TabIndex = 2;
            this.BTNver_articulos.Text = "VER ARTICULOS";
            this.BTNver_articulos.UseVisualStyleBackColor = true;
            this.BTNver_articulos.Click += new System.EventHandler(this.BTNver_articulos_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 396);
            this.Controls.Add(this.BTNver_articulos);
            this.Controls.Add(this.BTNver_ventas);
            this.Controls.Add(this.BTNcargar_venta);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(768, 539);
            this.MinimumSize = new System.Drawing.Size(550, 435);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JLSystem Ventas";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem articuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VerTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem1;
        private System.Windows.Forms.Button BTNcargar_venta;
        private System.Windows.Forms.Button BTNver_ventas;
        private System.Windows.Forms.Button BTNver_articulos;
        private System.Windows.Forms.ToolStripMenuItem cajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enEsteDíaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enEstaSemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enEsteMesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verStockToolStripMenuItem;
    }
}

