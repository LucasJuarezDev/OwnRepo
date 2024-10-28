namespace sist01
{
    partial class FormModificar
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBOX_MODNAME = new System.Windows.Forms.TextBox();
            this.TBOX_MODESC = new System.Windows.Forms.TextBox();
            this.TBOX_MODPU = new System.Windows.Forms.TextBox();
            this.CB_MODMARCA = new System.Windows.Forms.ComboBox();
            this.CB_MODCLASF = new System.Windows.Forms.ComboBox();
            this.BTN_ACEPTAR_MOD = new System.Windows.Forms.Button();
            this.BTN_CANCELAR_MOD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOMBRE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "DESCRIPCION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "PU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "MARCA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "CLASIFICACION";
            // 
            // TBOX_MODNAME
            // 
            this.TBOX_MODNAME.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBOX_MODNAME.Location = new System.Drawing.Point(168, 28);
            this.TBOX_MODNAME.MaxLength = 50;
            this.TBOX_MODNAME.Name = "TBOX_MODNAME";
            this.TBOX_MODNAME.Size = new System.Drawing.Size(215, 20);
            this.TBOX_MODNAME.TabIndex = 8;
            // 
            // TBOX_MODESC
            // 
            this.TBOX_MODESC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBOX_MODESC.Location = new System.Drawing.Point(168, 74);
            this.TBOX_MODESC.MaxLength = 50;
            this.TBOX_MODESC.Name = "TBOX_MODESC";
            this.TBOX_MODESC.Size = new System.Drawing.Size(215, 20);
            this.TBOX_MODESC.TabIndex = 9;
            // 
            // TBOX_MODPU
            // 
            this.TBOX_MODPU.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBOX_MODPU.Location = new System.Drawing.Point(168, 124);
            this.TBOX_MODPU.MaxLength = 7;
            this.TBOX_MODPU.Name = "TBOX_MODPU";
            this.TBOX_MODPU.Size = new System.Drawing.Size(107, 20);
            this.TBOX_MODPU.TabIndex = 10;
            this.TBOX_MODPU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBOX_MODPU_KeyPress);
            // 
            // CB_MODMARCA
            // 
            this.CB_MODMARCA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_MODMARCA.FormattingEnabled = true;
            this.CB_MODMARCA.Location = new System.Drawing.Point(168, 170);
            this.CB_MODMARCA.Name = "CB_MODMARCA";
            this.CB_MODMARCA.Size = new System.Drawing.Size(215, 21);
            this.CB_MODMARCA.TabIndex = 11;
            // 
            // CB_MODCLASF
            // 
            this.CB_MODCLASF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_MODCLASF.FormattingEnabled = true;
            this.CB_MODCLASF.Location = new System.Drawing.Point(168, 222);
            this.CB_MODCLASF.Name = "CB_MODCLASF";
            this.CB_MODCLASF.Size = new System.Drawing.Size(215, 21);
            this.CB_MODCLASF.TabIndex = 12;
            // 
            // BTN_ACEPTAR_MOD
            // 
            this.BTN_ACEPTAR_MOD.Location = new System.Drawing.Point(53, 302);
            this.BTN_ACEPTAR_MOD.Name = "BTN_ACEPTAR_MOD";
            this.BTN_ACEPTAR_MOD.Size = new System.Drawing.Size(75, 23);
            this.BTN_ACEPTAR_MOD.TabIndex = 13;
            this.BTN_ACEPTAR_MOD.Text = "Aceptar";
            this.BTN_ACEPTAR_MOD.UseVisualStyleBackColor = true;
            this.BTN_ACEPTAR_MOD.Click += new System.EventHandler(this.BTN_ACEPTAR_MOD_Click);
            // 
            // BTN_CANCELAR_MOD
            // 
            this.BTN_CANCELAR_MOD.Location = new System.Drawing.Point(308, 302);
            this.BTN_CANCELAR_MOD.Name = "BTN_CANCELAR_MOD";
            this.BTN_CANCELAR_MOD.Size = new System.Drawing.Size(75, 23);
            this.BTN_CANCELAR_MOD.TabIndex = 14;
            this.BTN_CANCELAR_MOD.Text = "Cancelar";
            this.BTN_CANCELAR_MOD.UseVisualStyleBackColor = true;
            this.BTN_CANCELAR_MOD.Click += new System.EventHandler(this.BTN_CANCELAR_MOD_Click);
            // 
            // FormModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(410, 364);
            this.ControlBox = false;
            this.Controls.Add(this.BTN_CANCELAR_MOD);
            this.Controls.Add(this.BTN_ACEPTAR_MOD);
            this.Controls.Add(this.CB_MODCLASF);
            this.Controls.Add(this.CB_MODMARCA);
            this.Controls.Add(this.TBOX_MODPU);
            this.Controls.Add(this.TBOX_MODESC);
            this.Controls.Add(this.TBOX_MODNAME);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modificar";
            this.Load += new System.EventHandler(this.FormModificar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBOX_MODNAME;
        private System.Windows.Forms.TextBox TBOX_MODESC;
        private System.Windows.Forms.TextBox TBOX_MODPU;
        private System.Windows.Forms.ComboBox CB_MODMARCA;
        private System.Windows.Forms.ComboBox CB_MODCLASF;
        private System.Windows.Forms.Button BTN_ACEPTAR_MOD;
        private System.Windows.Forms.Button BTN_CANCELAR_MOD;
    }
}