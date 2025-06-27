namespace GUI
{
    partial class GuiGestionUsuarios
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.AniadirUsuario = new System.Windows.Forms.Button();
            this.BorrarUsuario = new System.Windows.Forms.Button();
            this.ModificarUsuario = new System.Windows.Forms.Button();
            this.DesbloquearUsuario = new System.Windows.Forms.Button();
            this.AplicarCambios = new System.Windows.Forms.Button();
            this.CancelarCambios = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelUserDNI = new System.Windows.Forms.Label();
            this.labelUserApellido = new System.Windows.Forms.Label();
            this.labelUserNombre = new System.Windows.Forms.Label();
            this.labelUserRol = new System.Windows.Forms.Label();
            this.labelUserEmail = new System.Windows.Forms.Label();
            this.labelGestionUsuario = new System.Windows.Forms.Label();
            this.radioButtonTodos = new System.Windows.Forms.RadioButton();
            this.radioButtonBloqueados = new System.Windows.Forms.RadioButton();
            this.cbRoles = new System.Windows.Forms.ComboBox();
            this.btnCambiarEstado = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 77);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(1067, 150);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // AniadirUsuario
            // 
            this.AniadirUsuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AniadirUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AniadirUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AniadirUsuario.ForeColor = System.Drawing.SystemColors.Desktop;
            this.AniadirUsuario.Location = new System.Drawing.Point(1085, 12);
            this.AniadirUsuario.Name = "AniadirUsuario";
            this.AniadirUsuario.Size = new System.Drawing.Size(152, 42);
            this.AniadirUsuario.TabIndex = 1;
            this.AniadirUsuario.Text = "Añadir Usuario";
            this.AniadirUsuario.UseVisualStyleBackColor = false;
            this.AniadirUsuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // BorrarUsuario
            // 
            this.BorrarUsuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BorrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrarUsuario.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BorrarUsuario.Location = new System.Drawing.Point(1085, 60);
            this.BorrarUsuario.Name = "BorrarUsuario";
            this.BorrarUsuario.Size = new System.Drawing.Size(152, 42);
            this.BorrarUsuario.TabIndex = 2;
            this.BorrarUsuario.Text = "Borrar Usuario";
            this.BorrarUsuario.UseVisualStyleBackColor = false;
            this.BorrarUsuario.Click += new System.EventHandler(this.button2_Click);
            // 
            // ModificarUsuario
            // 
            this.ModificarUsuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModificarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarUsuario.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ModificarUsuario.Location = new System.Drawing.Point(1085, 108);
            this.ModificarUsuario.Name = "ModificarUsuario";
            this.ModificarUsuario.Size = new System.Drawing.Size(152, 42);
            this.ModificarUsuario.TabIndex = 3;
            this.ModificarUsuario.Text = "Modificar Usuario";
            this.ModificarUsuario.UseVisualStyleBackColor = false;
            this.ModificarUsuario.Click += new System.EventHandler(this.button3_Click);
            // 
            // DesbloquearUsuario
            // 
            this.DesbloquearUsuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DesbloquearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DesbloquearUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesbloquearUsuario.ForeColor = System.Drawing.SystemColors.Desktop;
            this.DesbloquearUsuario.Location = new System.Drawing.Point(1085, 204);
            this.DesbloquearUsuario.Name = "DesbloquearUsuario";
            this.DesbloquearUsuario.Size = new System.Drawing.Size(152, 42);
            this.DesbloquearUsuario.TabIndex = 4;
            this.DesbloquearUsuario.Text = "Desbloquear";
            this.DesbloquearUsuario.UseVisualStyleBackColor = false;
            this.DesbloquearUsuario.Click += new System.EventHandler(this.button4_Click);
            // 
            // AplicarCambios
            // 
            this.AplicarCambios.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AplicarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AplicarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AplicarCambios.ForeColor = System.Drawing.SystemColors.Desktop;
            this.AplicarCambios.Location = new System.Drawing.Point(1085, 252);
            this.AplicarCambios.Name = "AplicarCambios";
            this.AplicarCambios.Size = new System.Drawing.Size(152, 42);
            this.AplicarCambios.TabIndex = 5;
            this.AplicarCambios.Text = "Aplicar";
            this.AplicarCambios.UseVisualStyleBackColor = false;
            this.AplicarCambios.Click += new System.EventHandler(this.button5_Click);
            // 
            // CancelarCambios
            // 
            this.CancelarCambios.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarCambios.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CancelarCambios.Location = new System.Drawing.Point(1085, 300);
            this.CancelarCambios.Name = "CancelarCambios";
            this.CancelarCambios.Size = new System.Drawing.Size(152, 42);
            this.CancelarCambios.TabIndex = 6;
            this.CancelarCambios.Text = "Cancelar";
            this.CancelarCambios.UseVisualStyleBackColor = false;
            this.CancelarCambios.Click += new System.EventHandler(this.button6_Click);
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Salir.Location = new System.Drawing.Point(1085, 348);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(152, 42);
            this.Salir.TabIndex = 7;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 238);
            this.textBox1.MaxLength = 8;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 273);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(120, 309);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(137, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(363, 238);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(137, 20);
            this.textBox4.TabIndex = 11;
            // 
            // labelUserDNI
            // 
            this.labelUserDNI.AutoSize = true;
            this.labelUserDNI.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserDNI.Location = new System.Drawing.Point(9, 240);
            this.labelUserDNI.Name = "labelUserDNI";
            this.labelUserDNI.Size = new System.Drawing.Size(40, 18);
            this.labelUserDNI.TabIndex = 13;
            this.labelUserDNI.Text = "DNI";
            // 
            // labelUserApellido
            // 
            this.labelUserApellido.AutoSize = true;
            this.labelUserApellido.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserApellido.Location = new System.Drawing.Point(9, 275);
            this.labelUserApellido.Name = "labelUserApellido";
            this.labelUserApellido.Size = new System.Drawing.Size(72, 18);
            this.labelUserApellido.TabIndex = 14;
            this.labelUserApellido.Text = "Apellido";
            // 
            // labelUserNombre
            // 
            this.labelUserNombre.AutoSize = true;
            this.labelUserNombre.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserNombre.Location = new System.Drawing.Point(9, 311);
            this.labelUserNombre.Name = "labelUserNombre";
            this.labelUserNombre.Size = new System.Drawing.Size(72, 18);
            this.labelUserNombre.TabIndex = 15;
            this.labelUserNombre.Text = "Nombre";
            // 
            // labelUserRol
            // 
            this.labelUserRol.AutoSize = true;
            this.labelUserRol.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserRol.Location = new System.Drawing.Point(292, 276);
            this.labelUserRol.Name = "labelUserRol";
            this.labelUserRol.Size = new System.Drawing.Size(35, 18);
            this.labelUserRol.TabIndex = 16;
            this.labelUserRol.Text = "Rol";
            // 
            // labelUserEmail
            // 
            this.labelUserEmail.AutoSize = true;
            this.labelUserEmail.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserEmail.Location = new System.Drawing.Point(292, 240);
            this.labelUserEmail.Name = "labelUserEmail";
            this.labelUserEmail.Size = new System.Drawing.Size(51, 18);
            this.labelUserEmail.TabIndex = 17;
            this.labelUserEmail.Text = "Email";
            // 
            // labelGestionUsuario
            // 
            this.labelGestionUsuario.AutoSize = true;
            this.labelGestionUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGestionUsuario.Location = new System.Drawing.Point(13, 12);
            this.labelGestionUsuario.Name = "labelGestionUsuario";
            this.labelGestionUsuario.Size = new System.Drawing.Size(217, 20);
            this.labelGestionUsuario.TabIndex = 18;
            this.labelGestionUsuario.Text = "GESTIÓN DE USUARIOS";
            // 
            // radioButtonTodos
            // 
            this.radioButtonTodos.AutoSize = true;
            this.radioButtonTodos.Checked = true;
            this.radioButtonTodos.Location = new System.Drawing.Point(17, 54);
            this.radioButtonTodos.Name = "radioButtonTodos";
            this.radioButtonTodos.Size = new System.Drawing.Size(55, 17);
            this.radioButtonTodos.TabIndex = 19;
            this.radioButtonTodos.TabStop = true;
            this.radioButtonTodos.Text = "Todos";
            this.radioButtonTodos.UseVisualStyleBackColor = true;
            this.radioButtonTodos.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonBloqueados
            // 
            this.radioButtonBloqueados.AutoSize = true;
            this.radioButtonBloqueados.Location = new System.Drawing.Point(92, 54);
            this.radioButtonBloqueados.Name = "radioButtonBloqueados";
            this.radioButtonBloqueados.Size = new System.Drawing.Size(81, 17);
            this.radioButtonBloqueados.TabIndex = 20;
            this.radioButtonBloqueados.Text = "Bloqueados";
            this.radioButtonBloqueados.UseVisualStyleBackColor = true;
            this.radioButtonBloqueados.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // cbRoles
            // 
            this.cbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoles.FormattingEnabled = true;
            this.cbRoles.Location = new System.Drawing.Point(363, 277);
            this.cbRoles.Name = "cbRoles";
            this.cbRoles.Size = new System.Drawing.Size(137, 21);
            this.cbRoles.TabIndex = 21;
            // 
            // btnCambiarEstado
            // 
            this.btnCambiarEstado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCambiarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarEstado.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCambiarEstado.Location = new System.Drawing.Point(1085, 156);
            this.btnCambiarEstado.Name = "btnCambiarEstado";
            this.btnCambiarEstado.Size = new System.Drawing.Size(152, 42);
            this.btnCambiarEstado.TabIndex = 22;
            this.btnCambiarEstado.Text = "Activar/Desactivar";
            this.btnCambiarEstado.UseVisualStyleBackColor = false;
            this.btnCambiarEstado.Click += new System.EventHandler(this.btnCambiarEstado_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Usuario_DNI";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Usuario_Apellido";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Usuario_Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Usuario_Email";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Usuario_Rol";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Usuario_Habilitado";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Usuario_UltimoLogin";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Usuario_Idioma";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // GuiGestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1249, 396);
            this.Controls.Add(this.btnCambiarEstado);
            this.Controls.Add(this.cbRoles);
            this.Controls.Add(this.radioButtonBloqueados);
            this.Controls.Add(this.radioButtonTodos);
            this.Controls.Add(this.labelGestionUsuario);
            this.Controls.Add(this.labelUserEmail);
            this.Controls.Add(this.labelUserRol);
            this.Controls.Add(this.labelUserNombre);
            this.Controls.Add(this.labelUserApellido);
            this.Controls.Add(this.labelUserDNI);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.CancelarCambios);
            this.Controls.Add(this.AplicarCambios);
            this.Controls.Add(this.DesbloquearUsuario);
            this.Controls.Add(this.ModificarUsuario);
            this.Controls.Add(this.BorrarUsuario);
            this.Controls.Add(this.AniadirUsuario);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "GuiGestionUsuarios";
            this.Text = "GuiGestionUsuarios";
            this.Load += new System.EventHandler(this.GuiGestionUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button AniadirUsuario;
        private System.Windows.Forms.Button BorrarUsuario;
        private System.Windows.Forms.Button ModificarUsuario;
        private System.Windows.Forms.Button DesbloquearUsuario;
        private System.Windows.Forms.Button AplicarCambios;
        private System.Windows.Forms.Button CancelarCambios;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labelUserDNI;
        private System.Windows.Forms.Label labelUserApellido;
        private System.Windows.Forms.Label labelUserNombre;
        private System.Windows.Forms.Label labelUserRol;
        private System.Windows.Forms.Label labelUserEmail;
        private System.Windows.Forms.Label labelGestionUsuario;
        private System.Windows.Forms.RadioButton radioButtonTodos;
        private System.Windows.Forms.RadioButton radioButtonBloqueados;
        private System.Windows.Forms.ComboBox cbRoles;
        private System.Windows.Forms.Button btnCambiarEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}