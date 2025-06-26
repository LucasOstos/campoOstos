namespace GUI
{
    partial class GuiContrasenia
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
            this.btnContrasenia = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelContrasenia = new System.Windows.Forms.Label();
            this.labelConfirmacion = new System.Windows.Forms.Label();
            this.btnSalirContrasenia = new System.Windows.Forms.Button();
            this.labelActual = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnContrasenia
            // 
            this.btnContrasenia.Location = new System.Drawing.Point(12, 147);
            this.btnContrasenia.Name = "btnContrasenia";
            this.btnContrasenia.Size = new System.Drawing.Size(124, 23);
            this.btnContrasenia.TabIndex = 0;
            this.btnContrasenia.Text = "Cambiar Contraseña";
            this.btnContrasenia.UseVisualStyleBackColor = true;
            this.btnContrasenia.Click += new System.EventHandler(this.btnContrasenia_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(124, 20);
            this.textBox2.TabIndex = 2;
            // 
            // labelContrasenia
            // 
            this.labelContrasenia.AutoSize = true;
            this.labelContrasenia.Location = new System.Drawing.Point(9, 57);
            this.labelContrasenia.Name = "labelContrasenia";
            this.labelContrasenia.Size = new System.Drawing.Size(96, 13);
            this.labelContrasenia.TabIndex = 3;
            this.labelContrasenia.Text = "Contraseña Nueva";
            // 
            // labelConfirmacion
            // 
            this.labelConfirmacion.AutoSize = true;
            this.labelConfirmacion.Location = new System.Drawing.Point(9, 105);
            this.labelConfirmacion.Name = "labelConfirmacion";
            this.labelConfirmacion.Size = new System.Drawing.Size(108, 13);
            this.labelConfirmacion.TabIndex = 4;
            this.labelConfirmacion.Text = "Confirmar Contraseña";
            // 
            // btnSalirContrasenia
            // 
            this.btnSalirContrasenia.Location = new System.Drawing.Point(146, 176);
            this.btnSalirContrasenia.Name = "btnSalirContrasenia";
            this.btnSalirContrasenia.Size = new System.Drawing.Size(84, 23);
            this.btnSalirContrasenia.TabIndex = 5;
            this.btnSalirContrasenia.Text = "Salir";
            this.btnSalirContrasenia.UseVisualStyleBackColor = true;
            this.btnSalirContrasenia.Click += new System.EventHandler(this.btnSalirContrasenia_Click);
            // 
            // labelActual
            // 
            this.labelActual.AutoSize = true;
            this.labelActual.Location = new System.Drawing.Point(9, 9);
            this.labelActual.Name = "labelActual";
            this.labelActual.Size = new System.Drawing.Size(94, 13);
            this.labelActual.TabIndex = 7;
            this.labelActual.Text = "Contraseña Actual";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 25);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(124, 20);
            this.textBox3.TabIndex = 6;
            // 
            // GuiContrasenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(242, 211);
            this.Controls.Add(this.labelActual);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnSalirContrasenia);
            this.Controls.Add(this.labelConfirmacion);
            this.Controls.Add(this.labelContrasenia);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnContrasenia);
            this.Name = "GuiContrasenia";
            this.Text = "GuiContrasenia";
            this.Load += new System.EventHandler(this.GuiContrasenia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContrasenia;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelContrasenia;
        private System.Windows.Forms.Label labelConfirmacion;
        private System.Windows.Forms.Button btnSalirContrasenia;
        private System.Windows.Forms.Label labelActual;
        private System.Windows.Forms.TextBox textBox3;
    }
}