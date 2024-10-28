namespace sist01
{
    partial class FormAñadirStockBTN
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
            this.BTN_ModStock = new System.Windows.Forms.Button();
            this.BTN_StockCancelar = new System.Windows.Forms.Button();
            this.CHBox_ModStkMin = new System.Windows.Forms.CheckBox();
            this.lbl_Stock = new System.Windows.Forms.Label();
            this.lbl_StkMin = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.DUP_Stock = new System.Windows.Forms.DomainUpDown();
            this.DUP_MinStock = new System.Windows.Forms.DomainUpDown();
            this.SuspendLayout();
            // 
            // BTN_ModStock
            // 
            this.BTN_ModStock.Location = new System.Drawing.Point(12, 151);
            this.BTN_ModStock.Name = "BTN_ModStock";
            this.BTN_ModStock.Size = new System.Drawing.Size(75, 23);
            this.BTN_ModStock.TabIndex = 0;
            this.BTN_ModStock.Text = "Aceptar";
            this.BTN_ModStock.UseVisualStyleBackColor = true;
            this.BTN_ModStock.Click += new System.EventHandler(this.BTN_ModStock_Click);
            // 
            // BTN_StockCancelar
            // 
            this.BTN_StockCancelar.Location = new System.Drawing.Point(221, 151);
            this.BTN_StockCancelar.Name = "BTN_StockCancelar";
            this.BTN_StockCancelar.Size = new System.Drawing.Size(75, 23);
            this.BTN_StockCancelar.TabIndex = 1;
            this.BTN_StockCancelar.Text = "Cancelar";
            this.BTN_StockCancelar.UseVisualStyleBackColor = true;
            this.BTN_StockCancelar.Click += new System.EventHandler(this.BTN_StockCancelar_Click);
            // 
            // CHBox_ModStkMin
            // 
            this.CHBox_ModStkMin.AutoSize = true;
            this.CHBox_ModStkMin.Location = new System.Drawing.Point(81, 78);
            this.CHBox_ModStkMin.Name = "CHBox_ModStkMin";
            this.CHBox_ModStkMin.Size = new System.Drawing.Size(148, 17);
            this.CHBox_ModStkMin.TabIndex = 4;
            this.CHBox_ModStkMin.Text = "¿Modificar Stock Minimo?";
            this.CHBox_ModStkMin.UseVisualStyleBackColor = true;
            this.CHBox_ModStkMin.CheckedChanged += new System.EventHandler(this.CHBox_ModStkMin_CheckedChanged);
            // 
            // lbl_Stock
            // 
            this.lbl_Stock.AutoSize = true;
            this.lbl_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stock.Location = new System.Drawing.Point(39, 48);
            this.lbl_Stock.Name = "lbl_Stock";
            this.lbl_Stock.Size = new System.Drawing.Size(48, 13);
            this.lbl_Stock.TabIndex = 5;
            this.lbl_Stock.Text = "Stock :";
            // 
            // lbl_StkMin
            // 
            this.lbl_StkMin.AutoSize = true;
            this.lbl_StkMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StkMin.Location = new System.Drawing.Point(4, 119);
            this.lbl_StkMin.Name = "lbl_StkMin";
            this.lbl_StkMin.Size = new System.Drawing.Size(91, 13);
            this.lbl_StkMin.TabIndex = 6;
            this.lbl_StkMin.Text = "Stock Minimo :";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(78, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(0, 13);
            this.lbl_Titulo.TabIndex = 7;
            // 
            // DUP_Stock
            // 
            this.DUP_Stock.Location = new System.Drawing.Point(101, 41);
            this.DUP_Stock.Name = "DUP_Stock";
            this.DUP_Stock.Size = new System.Drawing.Size(120, 20);
            this.DUP_Stock.TabIndex = 8;
            this.DUP_Stock.SelectedItemChanged += new System.EventHandler(this.DUP_Stock_SelectedItemChanged);
            // 
            // DUP_MinStock
            // 
            this.DUP_MinStock.Location = new System.Drawing.Point(101, 112);
            this.DUP_MinStock.Name = "DUP_MinStock";
            this.DUP_MinStock.Size = new System.Drawing.Size(120, 20);
            this.DUP_MinStock.TabIndex = 9;
            this.DUP_MinStock.SelectedItemChanged += new System.EventHandler(this.DUP_MinStock_SelectedItemChanged);
            // 
            // FormAñadirStockBTN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 186);
            this.ControlBox = false;
            this.Controls.Add(this.DUP_MinStock);
            this.Controls.Add(this.DUP_Stock);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.lbl_StkMin);
            this.Controls.Add(this.lbl_Stock);
            this.Controls.Add(this.CHBox_ModStkMin);
            this.Controls.Add(this.BTN_StockCancelar);
            this.Controls.Add(this.BTN_ModStock);
            this.MaximumSize = new System.Drawing.Size(324, 225);
            this.MinimumSize = new System.Drawing.Size(324, 225);
            this.Name = "FormAñadirStockBTN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Añadir Stock";
            this.Load += new System.EventHandler(this.FormAñadirStockBTN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_ModStock;
        private System.Windows.Forms.Button BTN_StockCancelar;
        private System.Windows.Forms.CheckBox CHBox_ModStkMin;
        private System.Windows.Forms.Label lbl_Stock;
        private System.Windows.Forms.Label lbl_StkMin;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.DomainUpDown DUP_Stock;
        private System.Windows.Forms.DomainUpDown DUP_MinStock;
    }
}