namespace sist01
{
    partial class FormRepSem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRepSem));
            this.DTP_SelecDia1 = new System.Windows.Forms.DateTimePicker();
            this.DGV_VentasSem = new System.Windows.Forms.DataGridView();
            this.gbox_ExcelSem = new System.Windows.Forms.GroupBox();
            this.btn_ExportarFileSem = new System.Windows.Forms.Button();
            this.btn_ExportarVentaSem = new System.Windows.Forms.Button();
            this.gbx_OrdenSem = new System.Windows.Forms.GroupBox();
            this.CB_OrdenPagoSem = new System.Windows.Forms.ComboBox();
            this.lbl_Pagos = new System.Windows.Forms.Label();
            this.lbl_AscDesc = new System.Windows.Forms.Label();
            this.CB_OrdenVentasSem = new System.Windows.Forms.ComboBox();
            this.gbox_SelecDia = new System.Windows.Forms.GroupBox();
            this.lbl_Hasta = new System.Windows.Forms.Label();
            this.lbl_Desde = new System.Windows.Forms.Label();
            this.btn_BuscarVenta = new System.Windows.Forms.Button();
            this.DTP_SelecDia2 = new System.Windows.Forms.DateTimePicker();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VentasSem)).BeginInit();
            this.gbox_ExcelSem.SuspendLayout();
            this.gbx_OrdenSem.SuspendLayout();
            this.gbox_SelecDia.SuspendLayout();
            this.SuspendLayout();
            // 
            // DTP_SelecDia1
            // 
            this.DTP_SelecDia1.Location = new System.Drawing.Point(6, 27);
            this.DTP_SelecDia1.MinDate = new System.DateTime(2024, 9, 1, 0, 0, 0, 0);
            this.DTP_SelecDia1.Name = "DTP_SelecDia1";
            this.DTP_SelecDia1.Size = new System.Drawing.Size(211, 20);
            this.DTP_SelecDia1.TabIndex = 0;
            this.DTP_SelecDia1.Value = new System.DateTime(2024, 10, 17, 18, 45, 38, 0);
            this.DTP_SelecDia1.ValueChanged += new System.EventHandler(this.DTP_SelecDia1_ValueChanged);
            // 
            // DGV_VentasSem
            // 
            this.DGV_VentasSem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_VentasSem.Location = new System.Drawing.Point(12, 180);
            this.DGV_VentasSem.MaximumSize = new System.Drawing.Size(967, 212);
            this.DGV_VentasSem.MinimumSize = new System.Drawing.Size(967, 212);
            this.DGV_VentasSem.MultiSelect = false;
            this.DGV_VentasSem.Name = "DGV_VentasSem";
            this.DGV_VentasSem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_VentasSem.Size = new System.Drawing.Size(967, 212);
            this.DGV_VentasSem.TabIndex = 1;
            this.DGV_VentasSem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_VentasSem_CellClick);
            // 
            // gbox_ExcelSem
            // 
            this.gbox_ExcelSem.Controls.Add(this.btn_ExportarFileSem);
            this.gbox_ExcelSem.Controls.Add(this.btn_ExportarVentaSem);
            this.gbox_ExcelSem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_ExcelSem.Location = new System.Drawing.Point(12, 42);
            this.gbox_ExcelSem.Name = "gbox_ExcelSem";
            this.gbox_ExcelSem.Size = new System.Drawing.Size(126, 117);
            this.gbox_ExcelSem.TabIndex = 10;
            this.gbox_ExcelSem.TabStop = false;
            this.gbox_ExcelSem.Text = "Exportar";
            // 
            // btn_ExportarFileSem
            // 
            this.btn_ExportarFileSem.Location = new System.Drawing.Point(6, 24);
            this.btn_ExportarFileSem.Name = "btn_ExportarFileSem";
            this.btn_ExportarFileSem.Size = new System.Drawing.Size(109, 23);
            this.btn_ExportarFileSem.TabIndex = 2;
            this.btn_ExportarFileSem.Text = "Exportar Todo";
            this.btn_ExportarFileSem.UseVisualStyleBackColor = true;
            this.btn_ExportarFileSem.Click += new System.EventHandler(this.btn_ExportarFileSem_Click);
            // 
            // btn_ExportarVentaSem
            // 
            this.btn_ExportarVentaSem.Location = new System.Drawing.Point(6, 84);
            this.btn_ExportarVentaSem.Name = "btn_ExportarVentaSem";
            this.btn_ExportarVentaSem.Size = new System.Drawing.Size(109, 23);
            this.btn_ExportarVentaSem.TabIndex = 9;
            this.btn_ExportarVentaSem.Text = "Exportar Venta";
            this.btn_ExportarVentaSem.UseVisualStyleBackColor = true;
            this.btn_ExportarVentaSem.Click += new System.EventHandler(this.btn_ExportarVentaSem_Click);
            // 
            // gbx_OrdenSem
            // 
            this.gbx_OrdenSem.Controls.Add(this.CB_OrdenPagoSem);
            this.gbx_OrdenSem.Controls.Add(this.lbl_Pagos);
            this.gbx_OrdenSem.Controls.Add(this.lbl_AscDesc);
            this.gbx_OrdenSem.Controls.Add(this.CB_OrdenVentasSem);
            this.gbx_OrdenSem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_OrdenSem.Location = new System.Drawing.Point(624, 42);
            this.gbx_OrdenSem.Name = "gbx_OrdenSem";
            this.gbx_OrdenSem.Size = new System.Drawing.Size(355, 117);
            this.gbx_OrdenSem.TabIndex = 12;
            this.gbx_OrdenSem.TabStop = false;
            this.gbx_OrdenSem.Text = "Ordenar Por";
            // 
            // CB_OrdenPagoSem
            // 
            this.CB_OrdenPagoSem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_OrdenPagoSem.FormattingEnabled = true;
            this.CB_OrdenPagoSem.Items.AddRange(new object[] {
            "Seleccionar Metodo",
            "Efectivo",
            "Transferencia"});
            this.CB_OrdenPagoSem.Location = new System.Drawing.Point(168, 87);
            this.CB_OrdenPagoSem.Name = "CB_OrdenPagoSem";
            this.CB_OrdenPagoSem.Size = new System.Drawing.Size(121, 21);
            this.CB_OrdenPagoSem.TabIndex = 5;
            this.CB_OrdenPagoSem.SelectedIndexChanged += new System.EventHandler(this.CB_OrdenPagoSem_SelectedIndexChanged);
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
            // CB_OrdenVentasSem
            // 
            this.CB_OrdenVentasSem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_OrdenVentasSem.FormattingEnabled = true;
            this.CB_OrdenVentasSem.Items.AddRange(new object[] {
            "Descendente",
            "Ascendente"});
            this.CB_OrdenVentasSem.Location = new System.Drawing.Point(168, 19);
            this.CB_OrdenVentasSem.Name = "CB_OrdenVentasSem";
            this.CB_OrdenVentasSem.Size = new System.Drawing.Size(121, 21);
            this.CB_OrdenVentasSem.TabIndex = 7;
            this.CB_OrdenVentasSem.SelectedIndexChanged += new System.EventHandler(this.CB_OrdenVentasSem_SelectedIndexChanged);
            // 
            // gbox_SelecDia
            // 
            this.gbox_SelecDia.Controls.Add(this.lbl_Hasta);
            this.gbox_SelecDia.Controls.Add(this.lbl_Desde);
            this.gbox_SelecDia.Controls.Add(this.btn_BuscarVenta);
            this.gbox_SelecDia.Controls.Add(this.DTP_SelecDia2);
            this.gbox_SelecDia.Controls.Add(this.DTP_SelecDia1);
            this.gbox_SelecDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_SelecDia.Location = new System.Drawing.Point(243, 42);
            this.gbox_SelecDia.Name = "gbox_SelecDia";
            this.gbox_SelecDia.Size = new System.Drawing.Size(287, 117);
            this.gbox_SelecDia.TabIndex = 11;
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
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(453, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(183, 23);
            this.lbl_Titulo.TabIndex = 11;
            this.lbl_Titulo.Text = "Ventas Por Semana";
            // 
            // FormRepSem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 404);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.gbox_SelecDia);
            this.Controls.Add(this.gbx_OrdenSem);
            this.Controls.Add(this.gbox_ExcelSem);
            this.Controls.Add(this.DGV_VentasSem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1007, 443);
            this.MinimumSize = new System.Drawing.Size(1007, 443);
            this.Name = "FormRepSem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.FormRepSem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VentasSem)).EndInit();
            this.gbox_ExcelSem.ResumeLayout(false);
            this.gbx_OrdenSem.ResumeLayout(false);
            this.gbx_OrdenSem.PerformLayout();
            this.gbox_SelecDia.ResumeLayout(false);
            this.gbox_SelecDia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTP_SelecDia1;
        private System.Windows.Forms.DataGridView DGV_VentasSem;
        private System.Windows.Forms.GroupBox gbox_ExcelSem;
        private System.Windows.Forms.Button btn_ExportarFileSem;
        private System.Windows.Forms.Button btn_ExportarVentaSem;
        private System.Windows.Forms.GroupBox gbx_OrdenSem;
        private System.Windows.Forms.ComboBox CB_OrdenPagoSem;
        private System.Windows.Forms.Label lbl_Pagos;
        private System.Windows.Forms.Label lbl_AscDesc;
        private System.Windows.Forms.ComboBox CB_OrdenVentasSem;
        private System.Windows.Forms.GroupBox gbox_SelecDia;
        private System.Windows.Forms.Button btn_BuscarVenta;
        private System.Windows.Forms.DateTimePicker DTP_SelecDia2;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_Hasta;
        private System.Windows.Forms.Label lbl_Desde;
    }
}