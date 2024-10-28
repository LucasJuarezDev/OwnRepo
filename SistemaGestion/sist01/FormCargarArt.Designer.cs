namespace sist01
{
    partial class FormCargarArt
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
            this.Titulo = new System.Windows.Forms.Label();
            this.cod_titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Titulo_Cantidad = new System.Windows.Forms.Label();
            this.TXT_Tipo = new System.Windows.Forms.TextBox();
            this.TXT_Cantidad = new System.Windows.Forms.TextBox();
            this.BTN_Cargar_Art = new System.Windows.Forms.Button();
            this.BTN_Cancelar_Art = new System.Windows.Forms.Button();
            this.TIT_Marca = new System.Windows.Forms.Label();
            this.CB_Marca = new System.Windows.Forms.ComboBox();
            this.TIT_Categoria = new System.Windows.Forms.Label();
            this.CB_Categoria = new System.Windows.Forms.ComboBox();
            this.Titulo_PrecioVenta = new System.Windows.Forms.Label();
            this.TXT_PrecioVenta = new System.Windows.Forms.TextBox();
            this.lbl_StockMin = new System.Windows.Forms.Label();
            this.txtbox_StockMin = new System.Windows.Forms.TextBox();
            this.gbox_CargaArt = new System.Windows.Forms.GroupBox();
            this.lbl_newNombre = new System.Windows.Forms.Label();
            this.txt_NewNombre = new System.Windows.Forms.TextBox();
            this.lbl_NewClasf = new System.Windows.Forms.Label();
            this.lbl_NewMarca = new System.Windows.Forms.Label();
            this.txt_NewClasf = new System.Windows.Forms.TextBox();
            this.TXT_NewMarca = new System.Windows.Forms.TextBox();
            this.Subrayado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Articulos = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.gbox_CargaArt.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(218, 34);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(168, 23);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "NUEVO ARTÍCULO";
            // 
            // cod_titulo
            // 
            this.cod_titulo.AutoSize = true;
            this.cod_titulo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod_titulo.Location = new System.Drawing.Point(16, 192);
            this.cod_titulo.Name = "cod_titulo";
            this.cod_titulo.Size = new System.Drawing.Size(85, 15);
            this.cod_titulo.TabIndex = 1;
            this.cod_titulo.Text = "DESCRIPCION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "NOMBRE";
            // 
            // Titulo_Cantidad
            // 
            this.Titulo_Cantidad.AutoSize = true;
            this.Titulo_Cantidad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Cantidad.Location = new System.Drawing.Point(49, 228);
            this.Titulo_Cantidad.Name = "Titulo_Cantidad";
            this.Titulo_Cantidad.Size = new System.Drawing.Size(52, 16);
            this.Titulo_Cantidad.TabIndex = 3;
            this.Titulo_Cantidad.Text = "STOCK";
            // 
            // TXT_Tipo
            // 
            this.TXT_Tipo.Location = new System.Drawing.Point(115, 187);
            this.TXT_Tipo.MaxLength = 50;
            this.TXT_Tipo.Name = "TXT_Tipo";
            this.TXT_Tipo.Size = new System.Drawing.Size(255, 20);
            this.TXT_Tipo.TabIndex = 1;
            // 
            // TXT_Cantidad
            // 
            this.TXT_Cantidad.Location = new System.Drawing.Point(115, 224);
            this.TXT_Cantidad.MaxLength = 7;
            this.TXT_Cantidad.Name = "TXT_Cantidad";
            this.TXT_Cantidad.Size = new System.Drawing.Size(88, 20);
            this.TXT_Cantidad.TabIndex = 2;
            this.TXT_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_Cantidad_KeyPress);
            // 
            // BTN_Cargar_Art
            // 
            this.BTN_Cargar_Art.Location = new System.Drawing.Point(108, 396);
            this.BTN_Cargar_Art.Name = "BTN_Cargar_Art";
            this.BTN_Cargar_Art.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cargar_Art.TabIndex = 8;
            this.BTN_Cargar_Art.Text = "Cargar";
            this.BTN_Cargar_Art.UseVisualStyleBackColor = true;
            this.BTN_Cargar_Art.Click += new System.EventHandler(this.BTN_Cargar_Art_Click);
            // 
            // BTN_Cancelar_Art
            // 
            this.BTN_Cancelar_Art.Location = new System.Drawing.Point(295, 396);
            this.BTN_Cancelar_Art.Name = "BTN_Cancelar_Art";
            this.BTN_Cancelar_Art.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancelar_Art.TabIndex = 7;
            this.BTN_Cancelar_Art.Text = "Cancelar";
            this.BTN_Cancelar_Art.UseVisualStyleBackColor = true;
            this.BTN_Cancelar_Art.Click += new System.EventHandler(this.BTN_Cancelar_Art_Click);
            // 
            // TIT_Marca
            // 
            this.TIT_Marca.AutoSize = true;
            this.TIT_Marca.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIT_Marca.Location = new System.Drawing.Point(47, 297);
            this.TIT_Marca.Name = "TIT_Marca";
            this.TIT_Marca.Size = new System.Drawing.Size(54, 16);
            this.TIT_Marca.TabIndex = 9;
            this.TIT_Marca.Text = "MARCA";
            // 
            // CB_Marca
            // 
            this.CB_Marca.FormattingEnabled = true;
            this.CB_Marca.Location = new System.Drawing.Point(115, 292);
            this.CB_Marca.Name = "CB_Marca";
            this.CB_Marca.Size = new System.Drawing.Size(255, 21);
            this.CB_Marca.TabIndex = 5;
            // 
            // TIT_Categoria
            // 
            this.TIT_Categoria.AutoSize = true;
            this.TIT_Categoria.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIT_Categoria.Location = new System.Drawing.Point(7, 342);
            this.TIT_Categoria.Name = "TIT_Categoria";
            this.TIT_Categoria.Size = new System.Drawing.Size(94, 15);
            this.TIT_Categoria.TabIndex = 11;
            this.TIT_Categoria.Text = "CLASIFICACION";
            // 
            // CB_Categoria
            // 
            this.CB_Categoria.FormattingEnabled = true;
            this.CB_Categoria.Location = new System.Drawing.Point(115, 336);
            this.CB_Categoria.Name = "CB_Categoria";
            this.CB_Categoria.Size = new System.Drawing.Size(255, 21);
            this.CB_Categoria.TabIndex = 6;
            // 
            // Titulo_PrecioVenta
            // 
            this.Titulo_PrecioVenta.AutoSize = true;
            this.Titulo_PrecioVenta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_PrecioVenta.Location = new System.Drawing.Point(76, 264);
            this.Titulo_PrecioVenta.Name = "Titulo_PrecioVenta";
            this.Titulo_PrecioVenta.Size = new System.Drawing.Size(25, 16);
            this.Titulo_PrecioVenta.TabIndex = 13;
            this.Titulo_PrecioVenta.Text = "PU";
            // 
            // TXT_PrecioVenta
            // 
            this.TXT_PrecioVenta.Location = new System.Drawing.Point(115, 260);
            this.TXT_PrecioVenta.MaxLength = 7;
            this.TXT_PrecioVenta.Name = "TXT_PrecioVenta";
            this.TXT_PrecioVenta.Size = new System.Drawing.Size(88, 20);
            this.TXT_PrecioVenta.TabIndex = 4;
            this.TXT_PrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_PrecioVenta_KeyPress);
            // 
            // lbl_StockMin
            // 
            this.lbl_StockMin.AutoSize = true;
            this.lbl_StockMin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StockMin.Location = new System.Drawing.Point(219, 228);
            this.lbl_StockMin.Name = "lbl_StockMin";
            this.lbl_StockMin.Size = new System.Drawing.Size(31, 16);
            this.lbl_StockMin.TabIndex = 15;
            this.lbl_StockMin.Text = "MIN";
            // 
            // txtbox_StockMin
            // 
            this.txtbox_StockMin.Location = new System.Drawing.Point(256, 224);
            this.txtbox_StockMin.MaxLength = 7;
            this.txtbox_StockMin.Name = "txtbox_StockMin";
            this.txtbox_StockMin.Size = new System.Drawing.Size(88, 20);
            this.txtbox_StockMin.TabIndex = 3;
            this.txtbox_StockMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_StockMin_KeyPress);
            // 
            // gbox_CargaArt
            // 
            this.gbox_CargaArt.Controls.Add(this.lbl_newNombre);
            this.gbox_CargaArt.Controls.Add(this.txt_NewNombre);
            this.gbox_CargaArt.Controls.Add(this.lbl_NewClasf);
            this.gbox_CargaArt.Controls.Add(this.lbl_NewMarca);
            this.gbox_CargaArt.Controls.Add(this.txt_NewClasf);
            this.gbox_CargaArt.Controls.Add(this.TXT_NewMarca);
            this.gbox_CargaArt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_CargaArt.Location = new System.Drawing.Point(378, 100);
            this.gbox_CargaArt.Name = "gbox_CargaArt";
            this.gbox_CargaArt.Size = new System.Drawing.Size(216, 279);
            this.gbox_CargaArt.TabIndex = 18;
            this.gbox_CargaArt.TabStop = false;
            this.gbox_CargaArt.Text = "AÑADIR";
            // 
            // lbl_newNombre
            // 
            this.lbl_newNombre.AutoSize = true;
            this.lbl_newNombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newNombre.Location = new System.Drawing.Point(81, 11);
            this.lbl_newNombre.Name = "lbl_newNombre";
            this.lbl_newNombre.Size = new System.Drawing.Size(63, 16);
            this.lbl_newNombre.TabIndex = 27;
            this.lbl_newNombre.Text = "NOMBRE";
            // 
            // txt_NewNombre
            // 
            this.txt_NewNombre.Location = new System.Drawing.Point(24, 30);
            this.txt_NewNombre.MaxLength = 50;
            this.txt_NewNombre.Name = "txt_NewNombre";
            this.txt_NewNombre.Size = new System.Drawing.Size(186, 22);
            this.txt_NewNombre.TabIndex = 26;
            this.txt_NewNombre.TextChanged += new System.EventHandler(this.txt_NewNombre_TextChanged);
            // 
            // lbl_NewClasf
            // 
            this.lbl_NewClasf.AutoSize = true;
            this.lbl_NewClasf.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewClasf.Location = new System.Drawing.Point(59, 217);
            this.lbl_NewClasf.Name = "lbl_NewClasf";
            this.lbl_NewClasf.Size = new System.Drawing.Size(108, 16);
            this.lbl_NewClasf.TabIndex = 25;
            this.lbl_NewClasf.Text = "CLASIFICACION";
            // 
            // lbl_NewMarca
            // 
            this.lbl_NewMarca.AutoSize = true;
            this.lbl_NewMarca.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewMarca.Location = new System.Drawing.Point(90, 161);
            this.lbl_NewMarca.Name = "lbl_NewMarca";
            this.lbl_NewMarca.Size = new System.Drawing.Size(54, 16);
            this.lbl_NewMarca.TabIndex = 24;
            this.lbl_NewMarca.Text = "MARCA";
            // 
            // txt_NewClasf
            // 
            this.txt_NewClasf.Location = new System.Drawing.Point(24, 236);
            this.txt_NewClasf.MaxLength = 50;
            this.txt_NewClasf.Name = "txt_NewClasf";
            this.txt_NewClasf.Size = new System.Drawing.Size(186, 22);
            this.txt_NewClasf.TabIndex = 1;
            this.txt_NewClasf.TextChanged += new System.EventHandler(this.txt_NewClasf_TextChanged);
            // 
            // TXT_NewMarca
            // 
            this.TXT_NewMarca.Location = new System.Drawing.Point(24, 180);
            this.TXT_NewMarca.MaxLength = 50;
            this.TXT_NewMarca.Name = "TXT_NewMarca";
            this.TXT_NewMarca.Size = new System.Drawing.Size(186, 22);
            this.TXT_NewMarca.TabIndex = 0;
            this.TXT_NewMarca.TextChanged += new System.EventHandler(this.TXT_NewMarca_TextChanged);
            // 
            // Subrayado
            // 
            this.Subrayado.AutoSize = true;
            this.Subrayado.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.Subrayado.Location = new System.Drawing.Point(104, 360);
            this.Subrayado.Name = "Subrayado";
            this.Subrayado.Size = new System.Drawing.Size(268, 19);
            this.Subrayado.TabIndex = 21;
            this.Subrayado.Text = "_____________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(535, 40);
            this.label2.TabIndex = 22;
            this.label2.Text = "_____________________________________";
            // 
            // cb_Articulos
            // 
            this.cb_Articulos.FormattingEnabled = true;
            this.cb_Articulos.Location = new System.Drawing.Point(115, 131);
            this.cb_Articulos.Name = "cb_Articulos";
            this.cb_Articulos.Size = new System.Drawing.Size(255, 21);
            this.cb_Articulos.TabIndex = 23;
            // 
            // FormCargarArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(622, 475);
            this.Controls.Add(this.cb_Articulos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Subrayado);
            this.Controls.Add(this.gbox_CargaArt);
            this.Controls.Add(this.txtbox_StockMin);
            this.Controls.Add(this.lbl_StockMin);
            this.Controls.Add(this.TXT_PrecioVenta);
            this.Controls.Add(this.Titulo_PrecioVenta);
            this.Controls.Add(this.CB_Categoria);
            this.Controls.Add(this.TIT_Categoria);
            this.Controls.Add(this.CB_Marca);
            this.Controls.Add(this.TIT_Marca);
            this.Controls.Add(this.BTN_Cancelar_Art);
            this.Controls.Add(this.BTN_Cargar_Art);
            this.Controls.Add(this.TXT_Cantidad);
            this.Controls.Add(this.TXT_Tipo);
            this.Controls.Add(this.Titulo_Cantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cod_titulo);
            this.Controls.Add(this.Titulo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(638, 514);
            this.MinimumSize = new System.Drawing.Size(638, 514);
            this.Name = "FormCargarArt";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormCargarArt_Load);
            this.gbox_CargaArt.ResumeLayout(false);
            this.gbox_CargaArt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label cod_titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Titulo_Cantidad;
        private System.Windows.Forms.TextBox TXT_Tipo;
        private System.Windows.Forms.TextBox TXT_Cantidad;
        private System.Windows.Forms.Button BTN_Cargar_Art;
        private System.Windows.Forms.Button BTN_Cancelar_Art;
        private System.Windows.Forms.Label TIT_Marca;
        private System.Windows.Forms.ComboBox CB_Marca;
        private System.Windows.Forms.Label TIT_Categoria;
        private System.Windows.Forms.ComboBox CB_Categoria;
        private System.Windows.Forms.Label Titulo_PrecioVenta;
        private System.Windows.Forms.TextBox TXT_PrecioVenta;
        private System.Windows.Forms.Label lbl_StockMin;
        private System.Windows.Forms.TextBox txtbox_StockMin;
        private System.Windows.Forms.GroupBox gbox_CargaArt;
        private System.Windows.Forms.Label Subrayado;
        private System.Windows.Forms.Label lbl_NewClasf;
        private System.Windows.Forms.Label lbl_NewMarca;
        private System.Windows.Forms.TextBox txt_NewClasf;
        private System.Windows.Forms.TextBox TXT_NewMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Articulos;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lbl_newNombre;
        private System.Windows.Forms.TextBox txt_NewNombre;
    }
}