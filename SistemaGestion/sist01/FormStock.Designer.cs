namespace sist01
{
    partial class FormStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStock));
            this.DGV_Stock = new System.Windows.Forms.DataGridView();
            this.BTN_StockPlus = new System.Windows.Forms.Button();
            this.txt_Filtro = new System.Windows.Forms.Label();
            this.txtbox_FiltroStock = new System.Windows.Forms.TextBox();
            this.gbox_Stock = new System.Windows.Forms.GroupBox();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.txt_Marca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Stock)).BeginInit();
            this.gbox_Stock.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Stock
            // 
            this.DGV_Stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Stock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV_Stock.Location = new System.Drawing.Point(94, 61);
            this.DGV_Stock.MultiSelect = false;
            this.DGV_Stock.Name = "DGV_Stock";
            this.DGV_Stock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Stock.Size = new System.Drawing.Size(564, 279);
            this.DGV_Stock.TabIndex = 1;
            this.DGV_Stock.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DGV_Stock_DataBindingComplete);
            // 
            // BTN_StockPlus
            // 
            this.BTN_StockPlus.Location = new System.Drawing.Point(4, 140);
            this.BTN_StockPlus.Name = "BTN_StockPlus";
            this.BTN_StockPlus.Size = new System.Drawing.Size(84, 71);
            this.BTN_StockPlus.TabIndex = 2;
            this.BTN_StockPlus.Text = "Añadir Stock";
            this.BTN_StockPlus.UseVisualStyleBackColor = true;
            this.BTN_StockPlus.Click += new System.EventHandler(this.BTN_StockPlus_Click);
            // 
            // txt_Filtro
            // 
            this.txt_Filtro.AutoSize = true;
            this.txt_Filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Filtro.Location = new System.Drawing.Point(74, 22);
            this.txt_Filtro.Name = "txt_Filtro";
            this.txt_Filtro.Size = new System.Drawing.Size(98, 13);
            this.txt_Filtro.TabIndex = 6;
            this.txt_Filtro.Text = "POR NOMBRE :";
            // 
            // txtbox_FiltroStock
            // 
            this.txtbox_FiltroStock.Location = new System.Drawing.Point(178, 13);
            this.txtbox_FiltroStock.Name = "txtbox_FiltroStock";
            this.txtbox_FiltroStock.Size = new System.Drawing.Size(181, 22);
            this.txtbox_FiltroStock.TabIndex = 7;
            this.txtbox_FiltroStock.TextChanged += new System.EventHandler(this.txtbox_FiltroStock_TextChanged);
            // 
            // gbox_Stock
            // 
            this.gbox_Stock.Controls.Add(this.lbl_Marca);
            this.gbox_Stock.Controls.Add(this.txt_Marca);
            this.gbox_Stock.Controls.Add(this.txt_Filtro);
            this.gbox_Stock.Controls.Add(this.txtbox_FiltroStock);
            this.gbox_Stock.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_Stock.Location = new System.Drawing.Point(4, 13);
            this.gbox_Stock.Name = "gbox_Stock";
            this.gbox_Stock.Size = new System.Drawing.Size(654, 42);
            this.gbox_Stock.TabIndex = 8;
            this.gbox_Stock.TabStop = false;
            this.gbox_Stock.Text = "FILTRAR POR";
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Marca.Location = new System.Drawing.Point(375, 22);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(88, 13);
            this.lbl_Marca.TabIndex = 9;
            this.lbl_Marca.Text = "POR MARCA :";
            // 
            // txt_Marca
            // 
            this.txt_Marca.Location = new System.Drawing.Point(469, 13);
            this.txt_Marca.Name = "txt_Marca";
            this.txt_Marca.Size = new System.Drawing.Size(181, 22);
            this.txt_Marca.TabIndex = 8;
            this.txt_Marca.TextChanged += new System.EventHandler(this.txt_Marca_TextChanged);
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 381);
            this.Controls.Add(this.gbox_Stock);
            this.Controls.Add(this.BTN_StockPlus);
            this.Controls.Add(this.DGV_Stock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(686, 420);
            this.MinimumSize = new System.Drawing.Size(686, 420);
            this.Name = "FormStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stock De Productos";
            this.Load += new System.EventHandler(this.FormStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Stock)).EndInit();
            this.gbox_Stock.ResumeLayout(false);
            this.gbox_Stock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Stock;
        private System.Windows.Forms.Button BTN_StockPlus;
        private System.Windows.Forms.Label txt_Filtro;
        private System.Windows.Forms.TextBox txtbox_FiltroStock;
        private System.Windows.Forms.GroupBox gbox_Stock;
        private System.Windows.Forms.Label lbl_Marca;
        private System.Windows.Forms.TextBox txt_Marca;
    }
}