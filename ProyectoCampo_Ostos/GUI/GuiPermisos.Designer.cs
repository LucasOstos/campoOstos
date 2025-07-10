namespace GUI
{
    partial class GuiPermisos
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
            this.btnCrearFamilia = new System.Windows.Forms.Button();
            this.tbNombrePerfil = new System.Windows.Forms.TextBox();
            this.btnCrearPerfil = new System.Windows.Forms.Button();
            this.labelPermisos = new System.Windows.Forms.Label();
            this.btnSalirPermisos = new System.Windows.Forms.Button();
            this.cbPerfiles = new System.Windows.Forms.ComboBox();
            this.btnAgregarPermisosPerfil = new System.Windows.Forms.Button();
            this.lbNombrePerfil = new System.Windows.Forms.Label();
            this.lbPerfiles = new System.Windows.Forms.Label();
            this.labelFamilias = new System.Windows.Forms.Label();
            this.lbFamilias = new System.Windows.Forms.Label();
            this.cbFamilias = new System.Windows.Forms.ComboBox();
            this.lbNombreFamilia = new System.Windows.Forms.Label();
            this.tbNombreFamilia = new System.Windows.Forms.TextBox();
            this.btnAgregarPermisosFamilia = new System.Windows.Forms.Button();
            this.lbPermisosPerfil = new System.Windows.Forms.ListBox();
            this.lbPermisosFamilia = new System.Windows.Forms.ListBox();
            this.btnQuitarPermisosPerfil = new System.Windows.Forms.Button();
            this.btnBorrarPerfil = new System.Windows.Forms.Button();
            this.btnQuitarPermisosFamilia = new System.Windows.Forms.Button();
            this.btnBorrarFamilia = new System.Windows.Forms.Button();
            this.listBoxPermisosPerfil = new System.Windows.Forms.ListBox();
            this.listBoxPermisosFamilia = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearFamilia
            // 
            this.btnCrearFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearFamilia.Location = new System.Drawing.Point(658, 212);
            this.btnCrearFamilia.Name = "btnCrearFamilia";
            this.btnCrearFamilia.Size = new System.Drawing.Size(117, 41);
            this.btnCrearFamilia.TabIndex = 1;
            this.btnCrearFamilia.Text = "Crear Familia";
            this.btnCrearFamilia.UseVisualStyleBackColor = true;
            this.btnCrearFamilia.Click += new System.EventHandler(this.btnCrearFamilia_Click);
            // 
            // tbNombrePerfil
            // 
            this.tbNombrePerfil.Location = new System.Drawing.Point(16, 90);
            this.tbNombrePerfil.Multiline = true;
            this.tbNombrePerfil.Name = "tbNombrePerfil";
            this.tbNombrePerfil.Size = new System.Drawing.Size(142, 22);
            this.tbNombrePerfil.TabIndex = 2;
            // 
            // btnCrearPerfil
            // 
            this.btnCrearPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPerfil.Location = new System.Drawing.Point(179, 212);
            this.btnCrearPerfil.Name = "btnCrearPerfil";
            this.btnCrearPerfil.Size = new System.Drawing.Size(117, 41);
            this.btnCrearPerfil.TabIndex = 4;
            this.btnCrearPerfil.Text = "Crear Perfil";
            this.btnCrearPerfil.UseVisualStyleBackColor = true;
            this.btnCrearPerfil.Click += new System.EventHandler(this.btnCrearPerfil_Click);
            // 
            // labelPermisos
            // 
            this.labelPermisos.AutoSize = true;
            this.labelPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPermisos.Location = new System.Drawing.Point(10, 9);
            this.labelPermisos.Name = "labelPermisos";
            this.labelPermisos.Size = new System.Drawing.Size(154, 31);
            this.labelPermisos.TabIndex = 5;
            this.labelPermisos.Text = "PERFILES";
            // 
            // btnSalirPermisos
            // 
            this.btnSalirPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirPermisos.Location = new System.Drawing.Point(845, 418);
            this.btnSalirPermisos.Name = "btnSalirPermisos";
            this.btnSalirPermisos.Size = new System.Drawing.Size(93, 23);
            this.btnSalirPermisos.TabIndex = 8;
            this.btnSalirPermisos.Text = "Salir";
            this.btnSalirPermisos.UseVisualStyleBackColor = true;
            this.btnSalirPermisos.Click += new System.EventHandler(this.button4_Click);
            // 
            // cbPerfiles
            // 
            this.cbPerfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPerfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPerfiles.FormattingEnabled = true;
            this.cbPerfiles.Location = new System.Drawing.Point(317, 91);
            this.cbPerfiles.Name = "cbPerfiles";
            this.cbPerfiles.Size = new System.Drawing.Size(142, 21);
            this.cbPerfiles.TabIndex = 9;
            this.cbPerfiles.SelectedIndexChanged += new System.EventHandler(this.cbPerfiles_SelectedIndexChanged);
            // 
            // btnAgregarPermisosPerfil
            // 
            this.btnAgregarPermisosPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPermisosPerfil.Location = new System.Drawing.Point(179, 118);
            this.btnAgregarPermisosPerfil.Name = "btnAgregarPermisosPerfil";
            this.btnAgregarPermisosPerfil.Size = new System.Drawing.Size(117, 41);
            this.btnAgregarPermisosPerfil.TabIndex = 10;
            this.btnAgregarPermisosPerfil.Text = "Agregar Permisos";
            this.btnAgregarPermisosPerfil.UseVisualStyleBackColor = true;
            this.btnAgregarPermisosPerfil.Click += new System.EventHandler(this.btnAgregarPermisosPerfil_Click);
            // 
            // lbNombrePerfil
            // 
            this.lbNombrePerfil.AutoSize = true;
            this.lbNombrePerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombrePerfil.Location = new System.Drawing.Point(12, 67);
            this.lbNombrePerfil.Name = "lbNombrePerfil";
            this.lbNombrePerfil.Size = new System.Drawing.Size(146, 20);
            this.lbNombrePerfil.TabIndex = 11;
            this.lbNombrePerfil.Text = "Nombre del Perfil";
            // 
            // lbPerfiles
            // 
            this.lbPerfiles.AutoSize = true;
            this.lbPerfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPerfiles.Location = new System.Drawing.Point(390, 68);
            this.lbPerfiles.Name = "lbPerfiles";
            this.lbPerfiles.Size = new System.Drawing.Size(69, 20);
            this.lbPerfiles.TabIndex = 12;
            this.lbPerfiles.Text = "Perfiles";
            // 
            // labelFamilias
            // 
            this.labelFamilias.AutoSize = true;
            this.labelFamilias.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFamilias.Location = new System.Drawing.Point(786, 9);
            this.labelFamilias.Name = "labelFamilias";
            this.labelFamilias.Size = new System.Drawing.Size(146, 31);
            this.labelFamilias.TabIndex = 14;
            this.labelFamilias.Text = "FAMILIAS";
            // 
            // lbFamilias
            // 
            this.lbFamilias.AutoSize = true;
            this.lbFamilias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFamilias.Location = new System.Drawing.Point(863, 67);
            this.lbFamilias.Name = "lbFamilias";
            this.lbFamilias.Size = new System.Drawing.Size(75, 20);
            this.lbFamilias.TabIndex = 17;
            this.lbFamilias.Text = "Familias";
            // 
            // cbFamilias
            // 
            this.cbFamilias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFamilias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFamilias.FormattingEnabled = true;
            this.cbFamilias.Location = new System.Drawing.Point(795, 91);
            this.cbFamilias.Name = "cbFamilias";
            this.cbFamilias.Size = new System.Drawing.Size(143, 21);
            this.cbFamilias.TabIndex = 16;
            this.cbFamilias.SelectedIndexChanged += new System.EventHandler(this.cbFamilias_SelectedIndexChanged);
            // 
            // lbNombreFamilia
            // 
            this.lbNombreFamilia.AutoSize = true;
            this.lbNombreFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreFamilia.Location = new System.Drawing.Point(491, 67);
            this.lbNombreFamilia.Name = "lbNombreFamilia";
            this.lbNombreFamilia.Size = new System.Drawing.Size(177, 20);
            this.lbNombreFamilia.TabIndex = 19;
            this.lbNombreFamilia.Text = "Nombre de la Familia";
            // 
            // tbNombreFamilia
            // 
            this.tbNombreFamilia.Location = new System.Drawing.Point(495, 90);
            this.tbNombreFamilia.Multiline = true;
            this.tbNombreFamilia.Name = "tbNombreFamilia";
            this.tbNombreFamilia.Size = new System.Drawing.Size(142, 22);
            this.tbNombreFamilia.TabIndex = 18;
            // 
            // btnAgregarPermisosFamilia
            // 
            this.btnAgregarPermisosFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPermisosFamilia.Location = new System.Drawing.Point(658, 118);
            this.btnAgregarPermisosFamilia.Name = "btnAgregarPermisosFamilia";
            this.btnAgregarPermisosFamilia.Size = new System.Drawing.Size(117, 41);
            this.btnAgregarPermisosFamilia.TabIndex = 21;
            this.btnAgregarPermisosFamilia.Text = "Agregar Permisos";
            this.btnAgregarPermisosFamilia.UseVisualStyleBackColor = true;
            this.btnAgregarPermisosFamilia.Click += new System.EventHandler(this.btnAgregarPermisosFamilia_Click);
            // 
            // lbPermisosPerfil
            // 
            this.lbPermisosPerfil.FormattingEnabled = true;
            this.lbPermisosPerfil.Location = new System.Drawing.Point(16, 118);
            this.lbPermisosPerfil.Name = "lbPermisosPerfil";
            this.lbPermisosPerfil.Size = new System.Drawing.Size(157, 225);
            this.lbPermisosPerfil.TabIndex = 23;
            // 
            // lbPermisosFamilia
            // 
            this.lbPermisosFamilia.FormattingEnabled = true;
            this.lbPermisosFamilia.Location = new System.Drawing.Point(495, 118);
            this.lbPermisosFamilia.Name = "lbPermisosFamilia";
            this.lbPermisosFamilia.Size = new System.Drawing.Size(157, 225);
            this.lbPermisosFamilia.TabIndex = 24;
            // 
            // btnQuitarPermisosPerfil
            // 
            this.btnQuitarPermisosPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarPermisosPerfil.Location = new System.Drawing.Point(179, 165);
            this.btnQuitarPermisosPerfil.Name = "btnQuitarPermisosPerfil";
            this.btnQuitarPermisosPerfil.Size = new System.Drawing.Size(117, 41);
            this.btnQuitarPermisosPerfil.TabIndex = 26;
            this.btnQuitarPermisosPerfil.Text = "Quitar Permisos";
            this.btnQuitarPermisosPerfil.UseVisualStyleBackColor = true;
            this.btnQuitarPermisosPerfil.Click += new System.EventHandler(this.btnQuitarPermisosPerfil_Click);
            // 
            // btnBorrarPerfil
            // 
            this.btnBorrarPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarPerfil.Location = new System.Drawing.Point(179, 259);
            this.btnBorrarPerfil.Name = "btnBorrarPerfil";
            this.btnBorrarPerfil.Size = new System.Drawing.Size(117, 41);
            this.btnBorrarPerfil.TabIndex = 25;
            this.btnBorrarPerfil.Text = "Borrar Perfil";
            this.btnBorrarPerfil.UseVisualStyleBackColor = true;
            this.btnBorrarPerfil.Click += new System.EventHandler(this.btnBorrarPerfil_Click);
            // 
            // btnQuitarPermisosFamilia
            // 
            this.btnQuitarPermisosFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarPermisosFamilia.Location = new System.Drawing.Point(658, 165);
            this.btnQuitarPermisosFamilia.Name = "btnQuitarPermisosFamilia";
            this.btnQuitarPermisosFamilia.Size = new System.Drawing.Size(117, 41);
            this.btnQuitarPermisosFamilia.TabIndex = 28;
            this.btnQuitarPermisosFamilia.Text = "Quitar Permisos";
            this.btnQuitarPermisosFamilia.UseVisualStyleBackColor = true;
            this.btnQuitarPermisosFamilia.Click += new System.EventHandler(this.btnQuitarPermisosFamilia_Click);
            // 
            // btnBorrarFamilia
            // 
            this.btnBorrarFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarFamilia.Location = new System.Drawing.Point(658, 259);
            this.btnBorrarFamilia.Name = "btnBorrarFamilia";
            this.btnBorrarFamilia.Size = new System.Drawing.Size(117, 41);
            this.btnBorrarFamilia.TabIndex = 27;
            this.btnBorrarFamilia.Text = "Borrar Familia";
            this.btnBorrarFamilia.UseVisualStyleBackColor = true;
            this.btnBorrarFamilia.Click += new System.EventHandler(this.btnBorrarFamilia_Click);
            // 
            // listBoxPermisosPerfil
            // 
            this.listBoxPermisosPerfil.FormattingEnabled = true;
            this.listBoxPermisosPerfil.Location = new System.Drawing.Point(302, 117);
            this.listBoxPermisosPerfil.Name = "listBoxPermisosPerfil";
            this.listBoxPermisosPerfil.Size = new System.Drawing.Size(157, 225);
            this.listBoxPermisosPerfil.TabIndex = 29;
            // 
            // listBoxPermisosFamilia
            // 
            this.listBoxPermisosFamilia.FormattingEnabled = true;
            this.listBoxPermisosFamilia.Location = new System.Drawing.Point(781, 117);
            this.listBoxPermisosFamilia.Name = "listBoxPermisosFamilia";
            this.listBoxPermisosFamilia.Size = new System.Drawing.Size(157, 225);
            this.listBoxPermisosFamilia.TabIndex = 30;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(746, 418);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(93, 23);
            this.btnLimpiar.TabIndex = 31;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // GuiPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(944, 453);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.listBoxPermisosFamilia);
            this.Controls.Add(this.listBoxPermisosPerfil);
            this.Controls.Add(this.btnQuitarPermisosFamilia);
            this.Controls.Add(this.btnBorrarFamilia);
            this.Controls.Add(this.btnQuitarPermisosPerfil);
            this.Controls.Add(this.btnBorrarPerfil);
            this.Controls.Add(this.lbPermisosFamilia);
            this.Controls.Add(this.lbPermisosPerfil);
            this.Controls.Add(this.btnAgregarPermisosFamilia);
            this.Controls.Add(this.lbNombreFamilia);
            this.Controls.Add(this.tbNombreFamilia);
            this.Controls.Add(this.lbFamilias);
            this.Controls.Add(this.cbFamilias);
            this.Controls.Add(this.labelFamilias);
            this.Controls.Add(this.lbPerfiles);
            this.Controls.Add(this.lbNombrePerfil);
            this.Controls.Add(this.btnAgregarPermisosPerfil);
            this.Controls.Add(this.cbPerfiles);
            this.Controls.Add(this.btnSalirPermisos);
            this.Controls.Add(this.labelPermisos);
            this.Controls.Add(this.btnCrearPerfil);
            this.Controls.Add(this.tbNombrePerfil);
            this.Controls.Add(this.btnCrearFamilia);
            this.Name = "GuiPermisos";
            this.Text = "GuiPermisos";
            this.Load += new System.EventHandler(this.GuiPermisos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCrearFamilia;
        private System.Windows.Forms.TextBox tbNombrePerfil;
        private System.Windows.Forms.Button btnCrearPerfil;
        private System.Windows.Forms.Label labelPermisos;
        private System.Windows.Forms.Button btnSalirPermisos;
        private System.Windows.Forms.ComboBox cbPerfiles;
        private System.Windows.Forms.Button btnAgregarPermisosPerfil;
        private System.Windows.Forms.Label lbNombrePerfil;
        private System.Windows.Forms.Label lbPerfiles;
        private System.Windows.Forms.Label labelFamilias;
        private System.Windows.Forms.Label lbFamilias;
        private System.Windows.Forms.ComboBox cbFamilias;
        private System.Windows.Forms.Label lbNombreFamilia;
        private System.Windows.Forms.TextBox tbNombreFamilia;
        private System.Windows.Forms.Button btnAgregarPermisosFamilia;
        private System.Windows.Forms.ListBox lbPermisosPerfil;
        private System.Windows.Forms.ListBox lbPermisosFamilia;
        private System.Windows.Forms.Button btnQuitarPermisosPerfil;
        private System.Windows.Forms.Button btnBorrarPerfil;
        private System.Windows.Forms.Button btnQuitarPermisosFamilia;
        private System.Windows.Forms.Button btnBorrarFamilia;
        private System.Windows.Forms.ListBox listBoxPermisosPerfil;
        private System.Windows.Forms.ListBox listBoxPermisosFamilia;
        private System.Windows.Forms.Button btnLimpiar;
    }
}