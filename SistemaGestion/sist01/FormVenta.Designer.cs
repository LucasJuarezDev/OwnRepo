namespace sist01
{
    partial class FormVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVenta));
            this.LB_TITULO = new System.Windows.Forms.Label();
            this.lbl_Idventas = new System.Windows.Forms.Label();
            this.lbl_fechas = new System.Windows.Forms.Label();
            this.txtbox_IDventa = new System.Windows.Forms.TextBox();
            this.txtbox_Fecha = new System.Windows.Forms.TextBox();
            this.BTN_SumarArt = new System.Windows.Forms.Button();
            this.btn_AgregarArticulo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbox_Ventas = new System.Windows.Forms.GroupBox();
            this.btn_AplicarTodos = new System.Windows.Forms.Button();
            this.btn_Descuento = new System.Windows.Forms.Button();
            this.txtbox_Descuento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CB_MedioPago = new System.Windows.Forms.ComboBox();
            this.lbl_Pagos = new System.Windows.Forms.Label();
            this.BTN_RestarArt = new System.Windows.Forms.Button();
            this.DGV_Ventas = new System.Windows.Forms.DataGridView();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBox_Total = new System.Windows.Forms.TextBox();
            this.BTN_EliminarProducto = new System.Windows.Forms.Button();
            this.BTN_FinalizarCompra = new System.Windows.Forms.Button();
            this.gbox_Ventas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_TITULO
            // 
            this.LB_TITULO.AutoSize = true;
            this.LB_TITULO.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TITULO.Location = new System.Drawing.Point(247, 9);
            this.LB_TITULO.Name = "LB_TITULO";
            this.LB_TITULO.Size = new System.Drawing.Size(195, 23);
            this.LB_TITULO.TabIndex = 0;
            this.LB_TITULO.Text = "VENTA DE ARTICULO";
            // 
            // lbl_Idventas
            // 
            this.lbl_Idventas.AutoSize = true;
            this.lbl_Idventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Idventas.Location = new System.Drawing.Point(21, 19);
            this.lbl_Idventas.Name = "lbl_Idventas";
            this.lbl_Idventas.Size = new System.Drawing.Size(65, 13);
            this.lbl_Idventas.TabIndex = 2;
            this.lbl_Idventas.Text = "ID Venta :";
            // 
            // lbl_fechas
            // 
            this.lbl_fechas.AutoSize = true;
            this.lbl_fechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechas.Location = new System.Drawing.Point(252, 26);
            this.lbl_fechas.Name = "lbl_fechas";
            this.lbl_fechas.Size = new System.Drawing.Size(50, 13);
            this.lbl_fechas.TabIndex = 3;
            this.lbl_fechas.Text = "Fecha :";
            // 
            // txtbox_IDventa
            // 
            this.txtbox_IDventa.Location = new System.Drawing.Point(92, 16);
            this.txtbox_IDventa.Name = "txtbox_IDventa";
            this.txtbox_IDventa.ReadOnly = true;
            this.txtbox_IDventa.Size = new System.Drawing.Size(81, 20);
            this.txtbox_IDventa.TabIndex = 4;
            this.txtbox_IDventa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbox_Fecha
            // 
            this.txtbox_Fecha.Location = new System.Drawing.Point(308, 19);
            this.txtbox_Fecha.Name = "txtbox_Fecha";
            this.txtbox_Fecha.ReadOnly = true;
            this.txtbox_Fecha.Size = new System.Drawing.Size(117, 20);
            this.txtbox_Fecha.TabIndex = 5;
            this.txtbox_Fecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTN_SumarArt
            // 
            this.BTN_SumarArt.BackColor = System.Drawing.Color.White;
            this.BTN_SumarArt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_SumarArt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_SumarArt.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SumarArt.ForeColor = System.Drawing.Color.Black;
            this.BTN_SumarArt.Location = new System.Drawing.Point(87, 125);
            this.BTN_SumarArt.Name = "BTN_SumarArt";
            this.BTN_SumarArt.Size = new System.Drawing.Size(23, 23);
            this.BTN_SumarArt.TabIndex = 6;
            this.BTN_SumarArt.Text = "+";
            this.BTN_SumarArt.UseVisualStyleBackColor = false;
            this.BTN_SumarArt.Click += new System.EventHandler(this.BTN_SumarArt_Click);
            // 
            // btn_AgregarArticulo
            // 
            this.btn_AgregarArticulo.Location = new System.Drawing.Point(24, 78);
            this.btn_AgregarArticulo.Name = "btn_AgregarArticulo";
            this.btn_AgregarArticulo.Size = new System.Drawing.Size(149, 23);
            this.btn_AgregarArticulo.TabIndex = 7;
            this.btn_AgregarArticulo.Text = "Agregar Articulo";
            this.btn_AgregarArticulo.UseVisualStyleBackColor = true;
            this.btn_AgregarArticulo.Click += new System.EventHandler(this.btn_AgregarArticulo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sumar Otro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sacar";
            // 
            // gbox_Ventas
            // 
            this.gbox_Ventas.Controls.Add(this.btn_AplicarTodos);
            this.gbox_Ventas.Controls.Add(this.btn_Descuento);
            this.gbox_Ventas.Controls.Add(this.txtbox_Descuento);
            this.gbox_Ventas.Controls.Add(this.label6);
            this.gbox_Ventas.Controls.Add(this.CB_MedioPago);
            this.gbox_Ventas.Controls.Add(this.lbl_Pagos);
            this.gbox_Ventas.Controls.Add(this.BTN_RestarArt);
            this.gbox_Ventas.Controls.Add(this.label4);
            this.gbox_Ventas.Controls.Add(this.txtbox_Fecha);
            this.gbox_Ventas.Controls.Add(this.label3);
            this.gbox_Ventas.Controls.Add(this.lbl_Idventas);
            this.gbox_Ventas.Controls.Add(this.lbl_fechas);
            this.gbox_Ventas.Controls.Add(this.txtbox_IDventa);
            this.gbox_Ventas.Controls.Add(this.BTN_SumarArt);
            this.gbox_Ventas.Controls.Add(this.btn_AgregarArticulo);
            this.gbox_Ventas.Location = new System.Drawing.Point(73, 45);
            this.gbox_Ventas.Name = "gbox_Ventas";
            this.gbox_Ventas.Size = new System.Drawing.Size(534, 156);
            this.gbox_Ventas.TabIndex = 11;
            this.gbox_Ventas.TabStop = false;
            // 
            // btn_AplicarTodos
            // 
            this.btn_AplicarTodos.BackColor = System.Drawing.Color.White;
            this.btn_AplicarTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AplicarTodos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_AplicarTodos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AplicarTodos.ForeColor = System.Drawing.Color.Black;
            this.btn_AplicarTodos.Location = new System.Drawing.Point(431, 122);
            this.btn_AplicarTodos.Name = "btn_AplicarTodos";
            this.btn_AplicarTodos.Size = new System.Drawing.Size(93, 23);
            this.btn_AplicarTodos.TabIndex = 16;
            this.btn_AplicarTodos.Text = "Aplicar Todos";
            this.btn_AplicarTodos.UseVisualStyleBackColor = false;
            this.btn_AplicarTodos.Click += new System.EventHandler(this.btn_AplicarTodos_Click);
            // 
            // btn_Descuento
            // 
            this.btn_Descuento.BackColor = System.Drawing.Color.White;
            this.btn_Descuento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Descuento.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Descuento.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Descuento.ForeColor = System.Drawing.Color.Black;
            this.btn_Descuento.Location = new System.Drawing.Point(357, 123);
            this.btn_Descuento.Name = "btn_Descuento";
            this.btn_Descuento.Size = new System.Drawing.Size(68, 23);
            this.btn_Descuento.TabIndex = 15;
            this.btn_Descuento.Text = "Aplicar";
            this.btn_Descuento.UseVisualStyleBackColor = false;
            this.btn_Descuento.Click += new System.EventHandler(this.btn_Descuento_Click);
            // 
            // txtbox_Descuento
            // 
            this.txtbox_Descuento.Location = new System.Drawing.Point(308, 125);
            this.txtbox_Descuento.MaxLength = 3;
            this.txtbox_Descuento.Name = "txtbox_Descuento";
            this.txtbox_Descuento.Size = new System.Drawing.Size(43, 20);
            this.txtbox_Descuento.TabIndex = 14;
            this.txtbox_Descuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_Descuento_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(205, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Descuento (%) :";
            // 
            // CB_MedioPago
            // 
            this.CB_MedioPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_MedioPago.FormattingEnabled = true;
            this.CB_MedioPago.Items.AddRange(new object[] {
            "Seleccionar Metodo",
            "Efectivo",
            "Trasferencia"});
            this.CB_MedioPago.Location = new System.Drawing.Point(308, 85);
            this.CB_MedioPago.Name = "CB_MedioPago";
            this.CB_MedioPago.Size = new System.Drawing.Size(166, 21);
            this.CB_MedioPago.TabIndex = 12;
            // 
            // lbl_Pagos
            // 
            this.lbl_Pagos.AutoSize = true;
            this.lbl_Pagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pagos.Location = new System.Drawing.Point(200, 88);
            this.lbl_Pagos.Name = "lbl_Pagos";
            this.lbl_Pagos.Size = new System.Drawing.Size(102, 13);
            this.lbl_Pagos.TabIndex = 11;
            this.lbl_Pagos.Text = "Medio De Pago :";
            // 
            // BTN_RestarArt
            // 
            this.BTN_RestarArt.BackColor = System.Drawing.Color.White;
            this.BTN_RestarArt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_RestarArt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTN_RestarArt.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_RestarArt.ForeColor = System.Drawing.Color.Black;
            this.BTN_RestarArt.Location = new System.Drawing.Point(156, 125);
            this.BTN_RestarArt.Name = "BTN_RestarArt";
            this.BTN_RestarArt.Size = new System.Drawing.Size(23, 23);
            this.BTN_RestarArt.TabIndex = 8;
            this.BTN_RestarArt.Text = "-";
            this.BTN_RestarArt.UseVisualStyleBackColor = false;
            this.BTN_RestarArt.Click += new System.EventHandler(this.BTN_RestarArt_Click);
            // 
            // DGV_Ventas
            // 
            this.DGV_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Ventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod,
            this.Marca,
            this.Nombre,
            this.Descp,
            this.Cantidad,
            this.PU,
            this.PrecioT});
            this.DGV_Ventas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV_Ventas.Location = new System.Drawing.Point(12, 236);
            this.DGV_Ventas.Name = "DGV_Ventas";
            this.DGV_Ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Ventas.Size = new System.Drawing.Size(672, 278);
            this.DGV_Ventas.TabIndex = 12;
            this.DGV_Ventas.SelectionChanged += new System.EventHandler(this.DGV_Ventas_SelectionChanged);
            // 
            // Cod
            // 
            this.Cod.HeaderText = "Código";
            this.Cod.Name = "Cod";
            this.Cod.Width = 50;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Descp
            // 
            this.Descp.HeaderText = "Descripción";
            this.Descp.Name = "Descp";
            this.Descp.Width = 150;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 75;
            // 
            // PU
            // 
            this.PU.HeaderText = "PU";
            this.PU.Name = "PU";
            this.PU.Width = 77;
            // 
            // PrecioT
            // 
            this.PrecioT.HeaderText = "Precio Total";
            this.PrecioT.Name = "PrecioT";
            this.PrecioT.Width = 77;
            // 
            // txtBox_Total
            // 
            this.txtBox_Total.Location = new System.Drawing.Point(558, 526);
            this.txtBox_Total.Name = "txtBox_Total";
            this.txtBox_Total.ReadOnly = true;
            this.txtBox_Total.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Total.TabIndex = 13;
            this.txtBox_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BTN_EliminarProducto
            // 
            this.BTN_EliminarProducto.Location = new System.Drawing.Point(12, 522);
            this.BTN_EliminarProducto.Name = "BTN_EliminarProducto";
            this.BTN_EliminarProducto.Size = new System.Drawing.Size(121, 26);
            this.BTN_EliminarProducto.TabIndex = 14;
            this.BTN_EliminarProducto.Text = "Eliminar";
            this.BTN_EliminarProducto.UseVisualStyleBackColor = true;
            this.BTN_EliminarProducto.Click += new System.EventHandler(this.BTN_EliminarProducto_Click);
            // 
            // BTN_FinalizarCompra
            // 
            this.BTN_FinalizarCompra.Location = new System.Drawing.Point(316, 522);
            this.BTN_FinalizarCompra.Name = "BTN_FinalizarCompra";
            this.BTN_FinalizarCompra.Size = new System.Drawing.Size(231, 26);
            this.BTN_FinalizarCompra.TabIndex = 15;
            this.BTN_FinalizarCompra.Text = "Finalizar";
            this.BTN_FinalizarCompra.UseVisualStyleBackColor = true;
            this.BTN_FinalizarCompra.Click += new System.EventHandler(this.BTN_FinalizarCompra_Click);
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(696, 561);
            this.Controls.Add(this.BTN_FinalizarCompra);
            this.Controls.Add(this.BTN_EliminarProducto);
            this.Controls.Add(this.txtBox_Total);
            this.Controls.Add(this.DGV_Ventas);
            this.Controls.Add(this.gbox_Ventas);
            this.Controls.Add(this.LB_TITULO);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(716, 604);
            this.MinimumSize = new System.Drawing.Size(716, 604);
            this.Name = "FormVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Realizar Venta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormVenta_FormClosed);
            this.Load += new System.EventHandler(this.FormVenta_Load);
            this.gbox_Ventas.ResumeLayout(false);
            this.gbox_Ventas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Ventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_TITULO;
        private System.Windows.Forms.Label lbl_Idventas;
        private System.Windows.Forms.Label lbl_fechas;
        private System.Windows.Forms.TextBox txtbox_IDventa;
        private System.Windows.Forms.TextBox txtbox_Fecha;
        private System.Windows.Forms.Button BTN_SumarArt;
        private System.Windows.Forms.Button btn_AgregarArticulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbox_Ventas;
        private System.Windows.Forms.Button BTN_RestarArt;
        private System.Windows.Forms.Label lbl_Pagos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CB_MedioPago;
        private System.Windows.Forms.TextBox txtbox_Descuento;
        private System.Windows.Forms.Button btn_Descuento;
        private System.Windows.Forms.DataGridView DGV_Ventas;
        private System.Windows.Forms.TextBox txtBox_Total;
        private System.Windows.Forms.Button BTN_EliminarProducto;
        private System.Windows.Forms.Button BTN_FinalizarCompra;
        private System.Windows.Forms.Button btn_AplicarTodos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PU;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioT;
    }
}