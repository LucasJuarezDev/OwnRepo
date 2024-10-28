namespace sist01
{
    partial class VerArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerArticulos));
            this.DGV_VerArticulos = new System.Windows.Forms.DataGridView();
            this.BTN_Close_Art = new System.Windows.Forms.Button();
            this.BTN_Modificar = new System.Windows.Forms.Button();
            this.BTN_BajaLogica = new System.Windows.Forms.Button();
            this.txtbox_Filtro = new System.Windows.Forms.TextBox();
            this.txt_Filtro = new System.Windows.Forms.Label();
            this.tit_FiltroMarca = new System.Windows.Forms.Label();
            this.TXTBOX_FiltroMarca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VerArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_VerArticulos
            // 
            this.DGV_VerArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_VerArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV_VerArticulos.Location = new System.Drawing.Point(12, 49);
            this.DGV_VerArticulos.MaximumSize = new System.Drawing.Size(852, 279);
            this.DGV_VerArticulos.MinimumSize = new System.Drawing.Size(852, 279);
            this.DGV_VerArticulos.MultiSelect = false;
            this.DGV_VerArticulos.Name = "DGV_VerArticulos";
            this.DGV_VerArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_VerArticulos.Size = new System.Drawing.Size(852, 279);
            this.DGV_VerArticulos.TabIndex = 0;
            this.DGV_VerArticulos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DGV_VerArticulos_DataBindingComplete);
            // 
            // BTN_Close_Art
            // 
            this.BTN_Close_Art.Location = new System.Drawing.Point(12, 336);
            this.BTN_Close_Art.Name = "BTN_Close_Art";
            this.BTN_Close_Art.Size = new System.Drawing.Size(75, 23);
            this.BTN_Close_Art.TabIndex = 1;
            this.BTN_Close_Art.Text = "Atras";
            this.BTN_Close_Art.UseVisualStyleBackColor = true;
            this.BTN_Close_Art.Click += new System.EventHandler(this.BTN_Close_Art_Click);
            // 
            // BTN_Modificar
            // 
            this.BTN_Modificar.Location = new System.Drawing.Point(108, 334);
            this.BTN_Modificar.Name = "BTN_Modificar";
            this.BTN_Modificar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Modificar.TabIndex = 2;
            this.BTN_Modificar.Text = "Modificar";
            this.BTN_Modificar.UseVisualStyleBackColor = true;
            this.BTN_Modificar.Click += new System.EventHandler(this.BTN_Modificar_Click);
            // 
            // BTN_BajaLogica
            // 
            this.BTN_BajaLogica.Location = new System.Drawing.Point(213, 334);
            this.BTN_BajaLogica.Name = "BTN_BajaLogica";
            this.BTN_BajaLogica.Size = new System.Drawing.Size(75, 23);
            this.BTN_BajaLogica.TabIndex = 3;
            this.BTN_BajaLogica.Text = "Eliminar";
            this.BTN_BajaLogica.UseVisualStyleBackColor = true;
            this.BTN_BajaLogica.Click += new System.EventHandler(this.BTN_BajaLogica_Click);
            // 
            // txtbox_Filtro
            // 
            this.txtbox_Filtro.Location = new System.Drawing.Point(201, 23);
            this.txtbox_Filtro.Name = "txtbox_Filtro";
            this.txtbox_Filtro.Size = new System.Drawing.Size(180, 20);
            this.txtbox_Filtro.TabIndex = 4;
            this.txtbox_Filtro.TextChanged += new System.EventHandler(this.txtbox_Filtro_TextChanged);
            // 
            // txt_Filtro
            // 
            this.txt_Filtro.AutoSize = true;
            this.txt_Filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Filtro.Location = new System.Drawing.Point(21, 26);
            this.txt_Filtro.Name = "txt_Filtro";
            this.txt_Filtro.Size = new System.Drawing.Size(174, 13);
            this.txt_Filtro.TabIndex = 5;
            this.txt_Filtro.Text = "Filtro Rápido POR NOMBRE :";
            // 
            // tit_FiltroMarca
            // 
            this.tit_FiltroMarca.AutoSize = true;
            this.tit_FiltroMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tit_FiltroMarca.Location = new System.Drawing.Point(397, 26);
            this.tit_FiltroMarca.Name = "tit_FiltroMarca";
            this.tit_FiltroMarca.Size = new System.Drawing.Size(164, 13);
            this.tit_FiltroMarca.TabIndex = 6;
            this.tit_FiltroMarca.Text = "Filtro Rápido POR MARCA :";
            // 
            // TXTBOX_FiltroMarca
            // 
            this.TXTBOX_FiltroMarca.Location = new System.Drawing.Point(577, 19);
            this.TXTBOX_FiltroMarca.Name = "TXTBOX_FiltroMarca";
            this.TXTBOX_FiltroMarca.Size = new System.Drawing.Size(180, 20);
            this.TXTBOX_FiltroMarca.TabIndex = 7;
            this.TXTBOX_FiltroMarca.TextChanged += new System.EventHandler(this.TXTBOX_FiltroMarca_TextChanged);
            // 
            // VerArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 371);
            this.Controls.Add(this.TXTBOX_FiltroMarca);
            this.Controls.Add(this.tit_FiltroMarca);
            this.Controls.Add(this.txt_Filtro);
            this.Controls.Add(this.txtbox_Filtro);
            this.Controls.Add(this.BTN_BajaLogica);
            this.Controls.Add(this.BTN_Modificar);
            this.Controls.Add(this.BTN_Close_Art);
            this.Controls.Add(this.DGV_VerArticulos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(892, 410);
            this.MinimumSize = new System.Drawing.Size(892, 410);
            this.Name = "VerArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VerArticulos";
            this.Load += new System.EventHandler(this.VerArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_VerArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_VerArticulos;
        private System.Windows.Forms.Button BTN_Close_Art;
        private System.Windows.Forms.Button BTN_Modificar;
        private System.Windows.Forms.Button BTN_BajaLogica;
        private System.Windows.Forms.TextBox txtbox_Filtro;
        private System.Windows.Forms.Label txt_Filtro;
        private System.Windows.Forms.Label tit_FiltroMarca;
        private System.Windows.Forms.TextBox TXTBOX_FiltroMarca;
    }
}