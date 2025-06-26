namespace GUI
{
    partial class InterfazInicioSesion
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
            this.labelNombreEmpresa = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelEmailUsuario = new System.Windows.Forms.Label();
            this.labelContrasenaUsuario = new System.Windows.Forms.Label();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.cambiarIdiomaMenuStrip = new System.Windows.Forms.MenuStrip();
            this.IdiomaLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.EspanolMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.InglesMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.FrancesMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.AlemanMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.PortuguesMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cambiarIdiomaMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombreEmpresa
            // 
            this.labelNombreEmpresa.AutoSize = true;
            this.labelNombreEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNombreEmpresa.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreEmpresa.ForeColor = System.Drawing.Color.Black;
            this.labelNombreEmpresa.Location = new System.Drawing.Point(8, 193);
            this.labelNombreEmpresa.Name = "labelNombreEmpresa";
            this.labelNombreEmpresa.Size = new System.Drawing.Size(393, 35);
            this.labelNombreEmpresa.TabIndex = 0;
            this.labelNombreEmpresa.Text = "BELLEZA ARGENTINA";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.SeaShell;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(12, 157);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(137, 30);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Iniciar Sesión";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(137, 20);
            this.textBox2.TabIndex = 4;
            // 
            // labelEmailUsuario
            // 
            this.labelEmailUsuario.AutoSize = true;
            this.labelEmailUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailUsuario.Location = new System.Drawing.Point(9, 39);
            this.labelEmailUsuario.Name = "labelEmailUsuario";
            this.labelEmailUsuario.Size = new System.Drawing.Size(46, 16);
            this.labelEmailUsuario.TabIndex = 5;
            this.labelEmailUsuario.Text = "Email";
            // 
            // labelContrasenaUsuario
            // 
            this.labelContrasenaUsuario.AutoSize = true;
            this.labelContrasenaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContrasenaUsuario.Location = new System.Drawing.Point(9, 104);
            this.labelContrasenaUsuario.Name = "labelContrasenaUsuario";
            this.labelContrasenaUsuario.Size = new System.Drawing.Size(86, 16);
            this.labelContrasenaUsuario.TabIndex = 6;
            this.labelContrasenaUsuario.Text = "Contraseña";
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrar.Location = new System.Drawing.Point(12, 231);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(100, 35);
            this.buttonCerrar.TabIndex = 7;
            this.buttonCerrar.Text = "Salir";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // cambiarIdiomaMenuStrip
            // 
            this.cambiarIdiomaMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IdiomaLogin});
            this.cambiarIdiomaMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.cambiarIdiomaMenuStrip.Name = "cambiarIdiomaMenuStrip";
            this.cambiarIdiomaMenuStrip.Size = new System.Drawing.Size(425, 24);
            this.cambiarIdiomaMenuStrip.TabIndex = 8;
            this.cambiarIdiomaMenuStrip.Text = "Cambiar Idioma";
            // 
            // IdiomaLogin
            // 
            this.IdiomaLogin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EspanolMenuStrip,
            this.InglesMenuStrip,
            this.FrancesMenuStrip,
            this.AlemanMenuStrip,
            this.PortuguesMenuStrip});
            this.IdiomaLogin.Name = "IdiomaLogin";
            this.IdiomaLogin.Size = new System.Drawing.Size(104, 20);
            this.IdiomaLogin.Text = "Cambiar Idioma";
            // 
            // EspanolMenuStrip
            // 
            this.EspanolMenuStrip.Name = "EspanolMenuStrip";
            this.EspanolMenuStrip.Size = new System.Drawing.Size(128, 22);
            this.EspanolMenuStrip.Text = "Español";
            this.EspanolMenuStrip.Click += new System.EventHandler(this.EspanolMenuStrip_Click);
            // 
            // InglesMenuStrip
            // 
            this.InglesMenuStrip.Name = "InglesMenuStrip";
            this.InglesMenuStrip.Size = new System.Drawing.Size(128, 22);
            this.InglesMenuStrip.Text = "Ingles";
            this.InglesMenuStrip.Click += new System.EventHandler(this.InglesMenuStrip_Click);
            // 
            // FrancesMenuStrip
            // 
            this.FrancesMenuStrip.Name = "FrancesMenuStrip";
            this.FrancesMenuStrip.Size = new System.Drawing.Size(128, 22);
            this.FrancesMenuStrip.Text = "Francés";
            this.FrancesMenuStrip.Click += new System.EventHandler(this.FrancesMenuStrip_Click);
            // 
            // AlemanMenuStrip
            // 
            this.AlemanMenuStrip.Name = "AlemanMenuStrip";
            this.AlemanMenuStrip.Size = new System.Drawing.Size(128, 22);
            this.AlemanMenuStrip.Text = "Alemán";
            this.AlemanMenuStrip.Click += new System.EventHandler(this.AlemanMenuStrip_Click);
            // 
            // PortuguesMenuStrip
            // 
            this.PortuguesMenuStrip.Name = "PortuguesMenuStrip";
            this.PortuguesMenuStrip.Size = new System.Drawing.Size(128, 22);
            this.PortuguesMenuStrip.Text = "Portugues";
            this.PortuguesMenuStrip.Click += new System.EventHandler(this.PortuguesMenuStrip_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.LogoEmpresa;
            this.pictureBox1.Location = new System.Drawing.Point(199, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // InterfazInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(425, 284);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.labelContrasenaUsuario);
            this.Controls.Add(this.labelEmailUsuario);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelNombreEmpresa);
            this.Controls.Add(this.cambiarIdiomaMenuStrip);
            this.MainMenuStrip = this.cambiarIdiomaMenuStrip;
            this.Name = "InterfazInicioSesion";
            this.Text = "Inicio de Sesion";
            this.Load += new System.EventHandler(this.InterfazInicioSesion_Load);
            this.cambiarIdiomaMenuStrip.ResumeLayout(false);
            this.cambiarIdiomaMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombreEmpresa;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelEmailUsuario;
        private System.Windows.Forms.Label labelContrasenaUsuario;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.MenuStrip cambiarIdiomaMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem IdiomaLogin;
        private System.Windows.Forms.ToolStripMenuItem EspanolMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem InglesMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FrancesMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AlemanMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem PortuguesMenuStrip;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}