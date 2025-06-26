namespace GUI
{
    partial class GuiGestionClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegistrarCliente = new System.Windows.Forms.Button();
            this.labelDatosCliente = new System.Windows.Forms.Label();
            this.labelCelular = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelDNI = new System.Windows.Forms.Label();
            this.tbCelularCliente = new System.Windows.Forms.TextBox();
            this.tbApellidoCliente = new System.Windows.Forms.TextBox();
            this.tbNombreCliente = new System.Windows.Forms.TextBox();
            this.tbDniCliente = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.tbEmailCliente = new System.Windows.Forms.TextBox();
            this.botonBorrarCliente = new System.Windows.Forms.Button();
            this.botonModificarCliente = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(675, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cliente_DNI";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cliente_Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cliente_Apellido";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cliente_Celular";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Cliente_Email";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnRegistrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCliente.Location = new System.Drawing.Point(541, 183);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Size = new System.Drawing.Size(146, 23);
            this.btnRegistrarCliente.TabIndex = 1;
            this.btnRegistrarCliente.Text = "Registrar";
            this.btnRegistrarCliente.UseVisualStyleBackColor = false;
            this.btnRegistrarCliente.Click += new System.EventHandler(this.btnRegistrarCliente_Click);
            // 
            // labelDatosCliente
            // 
            this.labelDatosCliente.AutoSize = true;
            this.labelDatosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatosCliente.Location = new System.Drawing.Point(9, 8);
            this.labelDatosCliente.Name = "labelDatosCliente";
            this.labelDatosCliente.Size = new System.Drawing.Size(100, 16);
            this.labelDatosCliente.TabIndex = 2;
            this.labelDatosCliente.Text = "Datos Cliente";
            // 
            // labelCelular
            // 
            this.labelCelular.AutoSize = true;
            this.labelCelular.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCelular.Location = new System.Drawing.Point(9, 279);
            this.labelCelular.Name = "labelCelular";
            this.labelCelular.Size = new System.Drawing.Size(63, 18);
            this.labelCelular.TabIndex = 25;
            this.labelCelular.Text = "Celular";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(9, 224);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(72, 18);
            this.labelNombre.TabIndex = 24;
            this.labelNombre.Text = "Nombre";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.Location = new System.Drawing.Point(9, 251);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(72, 18);
            this.labelApellido.TabIndex = 23;
            this.labelApellido.Text = "Apellido";
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDNI.Location = new System.Drawing.Point(9, 195);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(40, 18);
            this.labelDNI.TabIndex = 22;
            this.labelDNI.Text = "DNI";
            // 
            // tbCelularCliente
            // 
            this.tbCelularCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCelularCliente.Location = new System.Drawing.Point(122, 279);
            this.tbCelularCliente.MaxLength = 10;
            this.tbCelularCliente.Name = "tbCelularCliente";
            this.tbCelularCliente.Size = new System.Drawing.Size(137, 20);
            this.tbCelularCliente.TabIndex = 21;
            this.tbCelularCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // tbApellidoCliente
            // 
            this.tbApellidoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbApellidoCliente.Location = new System.Drawing.Point(122, 251);
            this.tbApellidoCliente.Name = "tbApellidoCliente";
            this.tbApellidoCliente.Size = new System.Drawing.Size(137, 20);
            this.tbApellidoCliente.TabIndex = 20;
            // 
            // tbNombreCliente
            // 
            this.tbNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNombreCliente.Location = new System.Drawing.Point(122, 224);
            this.tbNombreCliente.Name = "tbNombreCliente";
            this.tbNombreCliente.Size = new System.Drawing.Size(137, 20);
            this.tbNombreCliente.TabIndex = 19;
            // 
            // tbDniCliente
            // 
            this.tbDniCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDniCliente.Location = new System.Drawing.Point(122, 195);
            this.tbDniCliente.MaxLength = 8;
            this.tbDniCliente.Name = "tbDniCliente";
            this.tbDniCliente.Size = new System.Drawing.Size(137, 20);
            this.tbDniCliente.TabIndex = 18;
            this.tbDniCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(9, 308);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(51, 18);
            this.labelEmail.TabIndex = 28;
            this.labelEmail.Text = "Email";
            // 
            // tbEmailCliente
            // 
            this.tbEmailCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmailCliente.Location = new System.Drawing.Point(122, 308);
            this.tbEmailCliente.Name = "tbEmailCliente";
            this.tbEmailCliente.Size = new System.Drawing.Size(137, 20);
            this.tbEmailCliente.TabIndex = 27;
            // 
            // botonBorrarCliente
            // 
            this.botonBorrarCliente.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.botonBorrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonBorrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBorrarCliente.Location = new System.Drawing.Point(541, 212);
            this.botonBorrarCliente.Name = "botonBorrarCliente";
            this.botonBorrarCliente.Size = new System.Drawing.Size(146, 23);
            this.botonBorrarCliente.TabIndex = 29;
            this.botonBorrarCliente.Text = "Borrar";
            this.botonBorrarCliente.UseVisualStyleBackColor = false;
            this.botonBorrarCliente.Click += new System.EventHandler(this.button2_Click);
            // 
            // botonModificarCliente
            // 
            this.botonModificarCliente.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.botonModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonModificarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonModificarCliente.Location = new System.Drawing.Point(541, 241);
            this.botonModificarCliente.Name = "botonModificarCliente";
            this.botonModificarCliente.Size = new System.Drawing.Size(146, 23);
            this.botonModificarCliente.TabIndex = 30;
            this.botonModificarCliente.Text = "Modificar";
            this.botonModificarCliente.UseVisualStyleBackColor = false;
            this.botonModificarCliente.Click += new System.EventHandler(this.button3_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.botonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSalir.Location = new System.Drawing.Point(543, 305);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(146, 23);
            this.botonSalir.TabIndex = 31;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = false;
            this.botonSalir.Click += new System.EventHandler(this.button4_Click);
            // 
            // GuiGestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(701, 342);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonModificarCliente);
            this.Controls.Add(this.botonBorrarCliente);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.tbEmailCliente);
            this.Controls.Add(this.labelCelular);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelDNI);
            this.Controls.Add(this.tbCelularCliente);
            this.Controls.Add(this.tbApellidoCliente);
            this.Controls.Add(this.tbNombreCliente);
            this.Controls.Add(this.tbDniCliente);
            this.Controls.Add(this.labelDatosCliente);
            this.Controls.Add(this.btnRegistrarCliente);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GuiGestionClientes";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.GuiGestionClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRegistrarCliente;
        private System.Windows.Forms.Label labelDatosCliente;
        private System.Windows.Forms.Label labelCelular;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.TextBox tbCelularCliente;
        private System.Windows.Forms.TextBox tbApellidoCliente;
        private System.Windows.Forms.TextBox tbNombreCliente;
        private System.Windows.Forms.TextBox tbDniCliente;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox tbEmailCliente;
        private System.Windows.Forms.Button botonBorrarCliente;
        private System.Windows.Forms.Button botonModificarCliente;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}