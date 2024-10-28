namespace sist01
{
    partial class FormSelecArtVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelecArtVenta));
            this.DGV_VentaArt = new System.Windows.Forms.DataGridView();
            this.txt_Filtro = new System.Windows.Forms.Label();
            this.txtBox_Filtro = new System.Windows.Forms.TextBox();
            this.btn_Atras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GBOX_Filtros = new System.Windows.Forms.GroupBox();
            this.txtBox_Marca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VentaArt)).BeginInit();
            this.GBOX_Filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_VentaArt
            // 
            this.DGV_VentaArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_VentaArt.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV_VentaArt.Location = new System.Drawing.Point(12, 63);
            this.DGV_VentaArt.MultiSelect = false;
            this.DGV_VentaArt.Name = "DGV_VentaArt";
            this.DGV_VentaArt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_VentaArt.Size = new System.Drawing.Size(664, 279);
            this.DGV_VentaArt.TabIndex = 1;
            this.DGV_VentaArt.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DGV_VentaArt_DataBindingComplete);
            this.DGV_VentaArt.DoubleClick += new System.EventHandler(this.DGV_VentaArt_DoubleClick);
            // 
            // txt_Filtro
            // 
            this.txt_Filtro.AutoSize = true;
            this.txt_Filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Filtro.Location = new System.Drawing.Point(76, 20);
            this.txt_Filtro.Name = "txt_Filtro";
            this.txt_Filtro.Size = new System.Drawing.Size(68, 13);
            this.txt_Filtro.TabIndex = 6;
            this.txt_Filtro.Text = "NOMBRE :";
            // 
            // txtBox_Filtro
            // 
            this.txtBox_Filtro.Location = new System.Drawing.Point(150, 11);
            this.txtBox_Filtro.Name = "txtBox_Filtro";
            this.txtBox_Filtro.Size = new System.Drawing.Size(169, 22);
            this.txtBox_Filtro.TabIndex = 7;
            this.txtBox_Filtro.TextChanged += new System.EventHandler(this.txtBox_Filtro_TextChanged);
            // 
            // btn_Atras
            // 
            this.btn_Atras.Location = new System.Drawing.Point(12, 348);
            this.btn_Atras.Name = "btn_Atras";
            this.btn_Atras.Size = new System.Drawing.Size(75, 23);
            this.btn_Atras.TabIndex = 9;
            this.btn_Atras.Text = "Cancelar";
            this.btn_Atras.UseVisualStyleBackColor = true;
            this.btn_Atras.Click += new System.EventHandler(this.btn_Atras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "MARCA :";
            // 
            // GBOX_Filtros
            // 
            this.GBOX_Filtros.Controls.Add(this.txtBox_Marca);
            this.GBOX_Filtros.Controls.Add(this.txt_Filtro);
            this.GBOX_Filtros.Controls.Add(this.label1);
            this.GBOX_Filtros.Controls.Add(this.txtBox_Filtro);
            this.GBOX_Filtros.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBOX_Filtros.Location = new System.Drawing.Point(13, 13);
            this.GBOX_Filtros.Name = "GBOX_Filtros";
            this.GBOX_Filtros.Size = new System.Drawing.Size(663, 44);
            this.GBOX_Filtros.TabIndex = 11;
            this.GBOX_Filtros.TabStop = false;
            this.GBOX_Filtros.Text = "FILTRAR POR";
            // 
            // txtBox_Marca
            // 
            this.txtBox_Marca.Location = new System.Drawing.Point(450, 9);
            this.txtBox_Marca.Name = "txtBox_Marca";
            this.txtBox_Marca.Size = new System.Drawing.Size(169, 22);
            this.txtBox_Marca.TabIndex = 11;
            this.txtBox_Marca.TextChanged += new System.EventHandler(this.txtBox_Marca_TextChanged);
            // 
            // FormSelecArtVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 383);
            this.Controls.Add(this.GBOX_Filtros);
            this.Controls.Add(this.btn_Atras);
            this.Controls.Add(this.DGV_VentaArt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(698, 422);
            this.MinimumSize = new System.Drawing.Size(698, 422);
            this.Name = "FormSelecArtVenta";
            this.Text = "Seleccion Articulo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSelecArtVenta_FormClosing);
            this.Load += new System.EventHandler(this.FormSelecArtVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VentaArt)).EndInit();
            this.GBOX_Filtros.ResumeLayout(false);
            this.GBOX_Filtros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label txt_Filtro;
        private System.Windows.Forms.TextBox txtBox_Filtro;
        private System.Windows.Forms.Button btn_Atras;
        private System.Windows.Forms.DataGridView DGV_VentaArt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GBOX_Filtros;
        private System.Windows.Forms.TextBox txtBox_Marca;
    }
}