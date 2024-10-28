namespace sist01
{
    partial class FormRepHoy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRepHoy));
            this.DGV_VentasDia = new System.Windows.Forms.DataGridView();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_ExportarFile = new System.Windows.Forms.Button();
            this.lbl_Pagos = new System.Windows.Forms.Label();
            this.CB_OrdenPago = new System.Windows.Forms.ComboBox();
            this.lbl_AscDesc = new System.Windows.Forms.Label();
            this.CB_OrdenVentas = new System.Windows.Forms.ComboBox();
            this.gbx_Orden = new System.Windows.Forms.GroupBox();
            this.btn_ExportarVenta = new System.Windows.Forms.Button();
            this.gbox_Excel = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VentasDia)).BeginInit();
            this.gbx_Orden.SuspendLayout();
            this.gbox_Excel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_VentasDia
            // 
            this.DGV_VentasDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_VentasDia.Location = new System.Drawing.Point(12, 180);
            this.DGV_VentasDia.MultiSelect = false;
            this.DGV_VentasDia.Name = "DGV_VentasDia";
            this.DGV_VentasDia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_VentasDia.Size = new System.Drawing.Size(892, 212);
            this.DGV_VentasDia.TabIndex = 0;
            this.DGV_VentasDia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_VentasDia_CellClick);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(372, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(137, 23);
            this.lbl_Titulo.TabIndex = 1;
            this.lbl_Titulo.Text = "Ventas Del Dia";
            // 
            // btn_ExportarFile
            // 
            this.btn_ExportarFile.Location = new System.Drawing.Point(6, 24);
            this.btn_ExportarFile.Name = "btn_ExportarFile";
            this.btn_ExportarFile.Size = new System.Drawing.Size(109, 23);
            this.btn_ExportarFile.TabIndex = 2;
            this.btn_ExportarFile.Text = "Exportar Todo";
            this.btn_ExportarFile.UseVisualStyleBackColor = true;
            this.btn_ExportarFile.Click += new System.EventHandler(this.btn_ExportarFile_Click);
            // 
            // lbl_Pagos
            // 
            this.lbl_Pagos.AutoSize = true;
            this.lbl_Pagos.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pagos.Location = new System.Drawing.Point(70, 84);
            this.lbl_Pagos.Name = "lbl_Pagos";
            this.lbl_Pagos.Size = new System.Drawing.Size(80, 16);
            this.lbl_Pagos.TabIndex = 4;
            this.lbl_Pagos.Text = "Tipo De Pago : ";
            // 
            // CB_OrdenPago
            // 
            this.CB_OrdenPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_OrdenPago.FormattingEnabled = true;
            this.CB_OrdenPago.Items.AddRange(new object[] {
            "Seleccionar Metodo",
            "Efectivo",
            "Transferencia"});
            this.CB_OrdenPago.Location = new System.Drawing.Point(168, 79);
            this.CB_OrdenPago.Name = "CB_OrdenPago";
            this.CB_OrdenPago.Size = new System.Drawing.Size(121, 21);
            this.CB_OrdenPago.TabIndex = 5;
            this.CB_OrdenPago.SelectedIndexChanged += new System.EventHandler(this.cmBox_Pago_SelectedIndexChanged);
            // 
            // lbl_AscDesc
            // 
            this.lbl_AscDesc.AutoSize = true;
            this.lbl_AscDesc.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AscDesc.Location = new System.Drawing.Point(56, 24);
            this.lbl_AscDesc.Name = "lbl_AscDesc";
            this.lbl_AscDesc.Size = new System.Drawing.Size(94, 16);
            this.lbl_AscDesc.TabIndex = 6;
            this.lbl_AscDesc.Text = "Orden De Ventas : ";
            // 
            // CB_OrdenVentas
            // 
            this.CB_OrdenVentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_OrdenVentas.FormattingEnabled = true;
            this.CB_OrdenVentas.Items.AddRange(new object[] {
            "Descendente",
            "Ascendente"});
            this.CB_OrdenVentas.Location = new System.Drawing.Point(168, 19);
            this.CB_OrdenVentas.Name = "CB_OrdenVentas";
            this.CB_OrdenVentas.Size = new System.Drawing.Size(121, 21);
            this.CB_OrdenVentas.TabIndex = 7;
            this.CB_OrdenVentas.SelectedIndexChanged += new System.EventHandler(this.CB_OrdenVentas_SelectedIndexChanged);
            // 
            // gbx_Orden
            // 
            this.gbx_Orden.Controls.Add(this.CB_OrdenPago);
            this.gbx_Orden.Controls.Add(this.lbl_Pagos);
            this.gbx_Orden.Controls.Add(this.lbl_AscDesc);
            this.gbx_Orden.Controls.Add(this.CB_OrdenVentas);
            this.gbx_Orden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_Orden.Location = new System.Drawing.Point(530, 46);
            this.gbx_Orden.Name = "gbx_Orden";
            this.gbx_Orden.Size = new System.Drawing.Size(355, 117);
            this.gbx_Orden.TabIndex = 8;
            this.gbx_Orden.TabStop = false;
            this.gbx_Orden.Text = "Ordenar Por";
            // 
            // btn_ExportarVenta
            // 
            this.btn_ExportarVenta.Location = new System.Drawing.Point(6, 84);
            this.btn_ExportarVenta.Name = "btn_ExportarVenta";
            this.btn_ExportarVenta.Size = new System.Drawing.Size(109, 23);
            this.btn_ExportarVenta.TabIndex = 9;
            this.btn_ExportarVenta.Text = "Exportar Venta";
            this.btn_ExportarVenta.UseVisualStyleBackColor = true;
            this.btn_ExportarVenta.Click += new System.EventHandler(this.btn_ExportarVenta_Click);
            // 
            // gbox_Excel
            // 
            this.gbox_Excel.Controls.Add(this.btn_ExportarFile);
            this.gbox_Excel.Controls.Add(this.btn_ExportarVenta);
            this.gbox_Excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_Excel.Location = new System.Drawing.Point(134, 46);
            this.gbox_Excel.Name = "gbox_Excel";
            this.gbox_Excel.Size = new System.Drawing.Size(126, 117);
            this.gbox_Excel.TabIndex = 9;
            this.gbox_Excel.TabStop = false;
            this.gbox_Excel.Text = "Exportar";
            // 
            // FormRepHoy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 404);
            this.Controls.Add(this.gbox_Excel);
            this.Controls.Add(this.gbx_Orden);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.DGV_VentasDia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(932, 443);
            this.MinimumSize = new System.Drawing.Size(932, 443);
            this.Name = "FormRepHoy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.FormRepHoy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VentasDia)).EndInit();
            this.gbx_Orden.ResumeLayout(false);
            this.gbx_Orden.PerformLayout();
            this.gbox_Excel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_VentasDia;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button btn_ExportarFile;
        private System.Windows.Forms.Label lbl_Pagos;
        private System.Windows.Forms.ComboBox CB_OrdenPago;
        private System.Windows.Forms.Label lbl_AscDesc;
        private System.Windows.Forms.ComboBox CB_OrdenVentas;
        private System.Windows.Forms.GroupBox gbx_Orden;
        private System.Windows.Forms.Button btn_ExportarVenta;
        private System.Windows.Forms.GroupBox gbox_Excel;
    }
}