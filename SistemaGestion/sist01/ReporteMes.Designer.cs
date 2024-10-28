namespace sist01
{
    partial class ReporteMes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteMes));
            this.DGV_VentasMes = new System.Windows.Forms.DataGridView();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.gbox_SelecDia = new System.Windows.Forms.GroupBox();
            this.lbl_Hasta = new System.Windows.Forms.Label();
            this.lbl_Desde = new System.Windows.Forms.Label();
            this.btn_BuscarVenta = new System.Windows.Forms.Button();
            this.DTP_SelecDia2 = new System.Windows.Forms.DateTimePicker();
            this.DTP_SelecDia1 = new System.Windows.Forms.DateTimePicker();
            this.gbx_OrdenMes = new System.Windows.Forms.GroupBox();
            this.CB_OrdenPagoMes = new System.Windows.Forms.ComboBox();
            this.lbl_Pagos = new System.Windows.Forms.Label();
            this.lbl_AscDesc = new System.Windows.Forms.Label();
            this.CB_OrdenVentasMes = new System.Windows.Forms.ComboBox();
            this.gbox_ExcelMes = new System.Windows.Forms.GroupBox();
            this.btn_ExportarFileMes = new System.Windows.Forms.Button();
            this.btn_ExportarVentaMes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VentasMes)).BeginInit();
            this.gbox_SelecDia.SuspendLayout();
            this.gbx_OrdenMes.SuspendLayout();
            this.gbox_ExcelMes.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_VentasMes
            // 
            this.DGV_VentasMes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_VentasMes.Location = new System.Drawing.Point(12, 180);
            this.DGV_VentasMes.MultiSelect = false;
            this.DGV_VentasMes.Name = "DGV_VentasMes";
            this.DGV_VentasMes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_VentasMes.Size = new System.Drawing.Size(967, 212);
            this.DGV_VentasMes.TabIndex = 2;
            this.DGV_VentasMes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_VentasMes_CellClick);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(399, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(158, 23);
            this.lbl_Titulo.TabIndex = 14;
            this.lbl_Titulo.Text = "Historial General";
            // 
            // gbox_SelecDia
            // 
            this.gbox_SelecDia.Controls.Add(this.lbl_Hasta);
            this.gbox_SelecDia.Controls.Add(this.lbl_Desde);
            this.gbox_SelecDia.Controls.Add(this.btn_BuscarVenta);
            this.gbox_SelecDia.Controls.Add(this.DTP_SelecDia2);
            this.gbox_SelecDia.Controls.Add(this.DTP_SelecDia1);
            this.gbox_SelecDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_SelecDia.Location = new System.Drawing.Point(243, 46);
            this.gbox_SelecDia.Name = "gbox_SelecDia";
            this.gbox_SelecDia.Size = new System.Drawing.Size(287, 117);
            this.gbox_SelecDia.TabIndex = 15;
            this.gbox_SelecDia.TabStop = false;
            this.gbox_SelecDia.Text = "Rango";
            // 
            // lbl_Hasta
            // 
            this.lbl_Hasta.AutoSize = true;
            this.lbl_Hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hasta.Location = new System.Drawing.Point(86, 71);
            this.lbl_Hasta.Name = "lbl_Hasta";
            this.lbl_Hasta.Size = new System.Drawing.Size(40, 13);
            this.lbl_Hasta.TabIndex = 12;
            this.lbl_Hasta.Text = "Hasta";
            // 
            // lbl_Desde
            // 
            this.lbl_Desde.AutoSize = true;
            this.lbl_Desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Desde.Location = new System.Drawing.Point(86, 11);
            this.lbl_Desde.Name = "lbl_Desde";
            this.lbl_Desde.Size = new System.Drawing.Size(43, 13);
            this.lbl_Desde.TabIndex = 11;
            this.lbl_Desde.Text = "Desde";
            // 
            // btn_BuscarVenta
            // 
            this.btn_BuscarVenta.Location = new System.Drawing.Point(220, 53);
            this.btn_BuscarVenta.Name = "btn_BuscarVenta";
            this.btn_BuscarVenta.Size = new System.Drawing.Size(55, 23);
            this.btn_BuscarVenta.TabIndex = 10;
            this.btn_BuscarVenta.Text = "Buscar";
            this.btn_BuscarVenta.UseVisualStyleBackColor = true;
            this.btn_BuscarVenta.Click += new System.EventHandler(this.btn_BuscarVenta_Click);
            // 
            // DTP_SelecDia2
            // 
            this.DTP_SelecDia2.Location = new System.Drawing.Point(6, 87);
            this.DTP_SelecDia2.MinDate = new System.DateTime(2024, 10, 1, 0, 0, 0, 0);
            this.DTP_SelecDia2.Name = "DTP_SelecDia2";
            this.DTP_SelecDia2.Size = new System.Drawing.Size(211, 20);
            this.DTP_SelecDia2.TabIndex = 1;
            this.DTP_SelecDia2.Value = new System.DateTime(2024, 10, 17, 18, 45, 38, 0);
            this.DTP_SelecDia2.ValueChanged += new System.EventHandler(this.DTP_SelecDia2_ValueChanged);
            // 
            // DTP_SelecDia1
            // 
            this.DTP_SelecDia1.Location = new System.Drawing.Point(6, 27);
            this.DTP_SelecDia1.MinDate = new System.DateTime(2024, 9, 1, 0, 0, 0, 0);
            this.DTP_SelecDia1.Name = "DTP_SelecDia1";
            this.DTP_SelecDia1.Size = new System.Drawing.Size(211, 20);
            this.DTP_SelecDia1.TabIndex = 0;
            this.DTP_SelecDia1.Value = new System.DateTime(2024, 10, 18, 0, 0, 0, 0);
            this.DTP_SelecDia1.ValueChanged += new System.EventHandler(this.DTP_SelecDia1_ValueChanged);
            // 
            // gbx_OrdenMes
            // 
            this.gbx_OrdenMes.Controls.Add(this.CB_OrdenPagoMes);
            this.gbx_OrdenMes.Controls.Add(this.lbl_Pagos);
            this.gbx_OrdenMes.Controls.Add(this.lbl_AscDesc);
            this.gbx_OrdenMes.Controls.Add(this.CB_OrdenVentasMes);
            this.gbx_OrdenMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_OrdenMes.Location = new System.Drawing.Point(624, 46);
            this.gbx_OrdenMes.Name = "gbx_OrdenMes";
            this.gbx_OrdenMes.Size = new System.Drawing.Size(355, 117);
            this.gbx_OrdenMes.TabIndex = 16;
            this.gbx_OrdenMes.TabStop = false;
            this.gbx_OrdenMes.Text = "Ordenar Por";
            // 
            // CB_OrdenPagoMes
            // 
            this.CB_OrdenPagoMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_OrdenPagoMes.FormattingEnabled = true;
            this.CB_OrdenPagoMes.Items.AddRange(new object[] {
            "Seleccionar Metodo",
            "Efectivo",
            "Transferencia"});
            this.CB_OrdenPagoMes.Location = new System.Drawing.Point(168, 87);
            this.CB_OrdenPagoMes.Name = "CB_OrdenPagoMes";
            this.CB_OrdenPagoMes.Size = new System.Drawing.Size(121, 21);
            this.CB_OrdenPagoMes.TabIndex = 5;
            this.CB_OrdenPagoMes.SelectedIndexChanged += new System.EventHandler(this.CB_OrdenPagoMes_SelectedIndexChanged);
            // 
            // lbl_Pagos
            // 
            this.lbl_Pagos.AutoSize = true;
            this.lbl_Pagos.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pagos.Location = new System.Drawing.Point(56, 91);
            this.lbl_Pagos.Name = "lbl_Pagos";
            this.lbl_Pagos.Size = new System.Drawing.Size(80, 16);
            this.lbl_Pagos.TabIndex = 4;
            this.lbl_Pagos.Text = "Tipo De Pago : ";
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
            // CB_OrdenVentasMes
            // 
            this.CB_OrdenVentasMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_OrdenVentasMes.FormattingEnabled = true;
            this.CB_OrdenVentasMes.Items.AddRange(new object[] {
            "Descendente",
            "Ascendente"});
            this.CB_OrdenVentasMes.Location = new System.Drawing.Point(168, 19);
            this.CB_OrdenVentasMes.Name = "CB_OrdenVentasMes";
            this.CB_OrdenVentasMes.Size = new System.Drawing.Size(121, 21);
            this.CB_OrdenVentasMes.TabIndex = 7;
            this.CB_OrdenVentasMes.SelectedIndexChanged += new System.EventHandler(this.CB_OrdenVentasMes_SelectedIndexChanged);
            // 
            // gbox_ExcelMes
            // 
            this.gbox_ExcelMes.Controls.Add(this.btn_ExportarFileMes);
            this.gbox_ExcelMes.Controls.Add(this.btn_ExportarVentaMes);
            this.gbox_ExcelMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_ExcelMes.Location = new System.Drawing.Point(12, 46);
            this.gbox_ExcelMes.Name = "gbox_ExcelMes";
            this.gbox_ExcelMes.Size = new System.Drawing.Size(126, 117);
            this.gbox_ExcelMes.TabIndex = 13;
            this.gbox_ExcelMes.TabStop = false;
            this.gbox_ExcelMes.Text = "Exportar";
            // 
            // btn_ExportarFileMes
            // 
            this.btn_ExportarFileMes.Location = new System.Drawing.Point(6, 24);
            this.btn_ExportarFileMes.Name = "btn_ExportarFileMes";
            this.btn_ExportarFileMes.Size = new System.Drawing.Size(109, 23);
            this.btn_ExportarFileMes.TabIndex = 2;
            this.btn_ExportarFileMes.Text = "Exportar Todo";
            this.btn_ExportarFileMes.UseVisualStyleBackColor = true;
            this.btn_ExportarFileMes.Click += new System.EventHandler(this.btn_ExportarFileMes_Click);
            // 
            // btn_ExportarVentaMes
            // 
            this.btn_ExportarVentaMes.Location = new System.Drawing.Point(6, 84);
            this.btn_ExportarVentaMes.Name = "btn_ExportarVentaMes";
            this.btn_ExportarVentaMes.Size = new System.Drawing.Size(109, 23);
            this.btn_ExportarVentaMes.TabIndex = 9;
            this.btn_ExportarVentaMes.Text = "Exportar Venta";
            this.btn_ExportarVentaMes.UseVisualStyleBackColor = true;
            this.btn_ExportarVentaMes.Click += new System.EventHandler(this.btn_ExportarVentaMes_Click);
            // 
            // ReporteMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 404);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.gbox_SelecDia);
            this.Controls.Add(this.gbx_OrdenMes);
            this.Controls.Add(this.gbox_ExcelMes);
            this.Controls.Add(this.DGV_VentasMes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1007, 443);
            this.MinimumSize = new System.Drawing.Size(1007, 443);
            this.Name = "ReporteMes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.ReporteMes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VentasMes)).EndInit();
            this.gbox_SelecDia.ResumeLayout(false);
            this.gbox_SelecDia.PerformLayout();
            this.gbx_OrdenMes.ResumeLayout(false);
            this.gbx_OrdenMes.PerformLayout();
            this.gbox_ExcelMes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_VentasMes;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.GroupBox gbox_SelecDia;
        private System.Windows.Forms.Label lbl_Hasta;
        private System.Windows.Forms.Label lbl_Desde;
        private System.Windows.Forms.Button btn_BuscarVenta;
        private System.Windows.Forms.DateTimePicker DTP_SelecDia2;
        private System.Windows.Forms.DateTimePicker DTP_SelecDia1;
        private System.Windows.Forms.GroupBox gbx_OrdenMes;
        private System.Windows.Forms.ComboBox CB_OrdenPagoMes;
        private System.Windows.Forms.Label lbl_Pagos;
        private System.Windows.Forms.Label lbl_AscDesc;
        private System.Windows.Forms.ComboBox CB_OrdenVentasMes;
        private System.Windows.Forms.GroupBox gbox_ExcelMes;
        private System.Windows.Forms.Button btn_ExportarFileMes;
        private System.Windows.Forms.Button btn_ExportarVentaMes;
    }
}