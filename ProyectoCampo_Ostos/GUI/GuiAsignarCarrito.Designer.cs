namespace GUI
{
    partial class GuiAsignarCarrito
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
            this.labelDatosDuenioCarrito = new System.Windows.Forms.Label();
            this.labelDatosCarrito = new System.Windows.Forms.Label();
            this.tbCodCarrito = new System.Windows.Forms.TextBox();
            this.labelCodCarrito = new System.Windows.Forms.Label();
            this.labelDuenioCarrito = new System.Windows.Forms.Label();
            this.tbDuenioCarrito = new System.Windows.Forms.TextBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.tbClienteDNI = new System.Windows.Forms.TextBox();
            this.tbClienteNombre = new System.Windows.Forms.TextBox();
            this.tbClienteApellido = new System.Windows.Forms.TextBox();
            this.labelDniDuenioCarrito = new System.Windows.Forms.Label();
            this.labelNombreDuenioCarrito = new System.Windows.Forms.Label();
            this.labelApellidoDuenioCarrito = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalirAsignar = new System.Windows.Forms.Button();
            this.labelCelularDuenioCarrito = new System.Windows.Forms.Label();
            this.tbClienteCelular = new System.Windows.Forms.TextBox();
            this.labelEmailDuenioCarrito = new System.Windows.Forms.Label();
            this.tbClienteEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDatosDuenioCarrito
            // 
            this.labelDatosDuenioCarrito.AutoSize = true;
            this.labelDatosDuenioCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatosDuenioCarrito.Location = new System.Drawing.Point(9, 174);
            this.labelDatosDuenioCarrito.Name = "labelDatosDuenioCarrito";
            this.labelDatosDuenioCarrito.Size = new System.Drawing.Size(100, 16);
            this.labelDatosDuenioCarrito.TabIndex = 1;
            this.labelDatosDuenioCarrito.Text = "Datos Cliente";
            // 
            // labelDatosCarrito
            // 
            this.labelDatosCarrito.AutoSize = true;
            this.labelDatosCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatosCarrito.Location = new System.Drawing.Point(9, 251);
            this.labelDatosCarrito.Name = "labelDatosCarrito";
            this.labelDatosCarrito.Size = new System.Drawing.Size(98, 16);
            this.labelDatosCarrito.TabIndex = 2;
            this.labelDatosCarrito.Text = "Datos Carrito";
            // 
            // tbCodCarrito
            // 
            this.tbCodCarrito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCodCarrito.Location = new System.Drawing.Point(12, 283);
            this.tbCodCarrito.Name = "tbCodCarrito";
            this.tbCodCarrito.Size = new System.Drawing.Size(100, 20);
            this.tbCodCarrito.TabIndex = 3;
            this.tbCodCarrito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // labelCodCarrito
            // 
            this.labelCodCarrito.AutoSize = true;
            this.labelCodCarrito.Location = new System.Drawing.Point(9, 267);
            this.labelCodCarrito.Name = "labelCodCarrito";
            this.labelCodCarrito.Size = new System.Drawing.Size(73, 13);
            this.labelCodCarrito.TabIndex = 4;
            this.labelCodCarrito.Text = "Codigo Carrito";
            // 
            // labelDuenioCarrito
            // 
            this.labelDuenioCarrito.AutoSize = true;
            this.labelDuenioCarrito.Location = new System.Drawing.Point(131, 270);
            this.labelDuenioCarrito.Name = "labelDuenioCarrito";
            this.labelDuenioCarrito.Size = new System.Drawing.Size(72, 13);
            this.labelDuenioCarrito.TabIndex = 5;
            this.labelDuenioCarrito.Text = "Dueño Carrito";
            // 
            // tbDuenioCarrito
            // 
            this.tbDuenioCarrito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDuenioCarrito.Location = new System.Drawing.Point(134, 283);
            this.tbDuenioCarrito.Name = "tbDuenioCarrito";
            this.tbDuenioCarrito.Size = new System.Drawing.Size(100, 20);
            this.tbDuenioCarrito.TabIndex = 6;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(12, 314);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(95, 23);
            this.btnAsignar.TabIndex = 7;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // tbClienteDNI
            // 
            this.tbClienteDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbClienteDNI.Location = new System.Drawing.Point(12, 206);
            this.tbClienteDNI.MaxLength = 8;
            this.tbClienteDNI.Name = "tbClienteDNI";
            this.tbClienteDNI.Size = new System.Drawing.Size(100, 20);
            this.tbClienteDNI.TabIndex = 8;
            // 
            // tbClienteNombre
            // 
            this.tbClienteNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbClienteNombre.Location = new System.Drawing.Point(134, 206);
            this.tbClienteNombre.Name = "tbClienteNombre";
            this.tbClienteNombre.Size = new System.Drawing.Size(100, 20);
            this.tbClienteNombre.TabIndex = 10;
            // 
            // tbClienteApellido
            // 
            this.tbClienteApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbClienteApellido.Location = new System.Drawing.Point(255, 206);
            this.tbClienteApellido.Name = "tbClienteApellido";
            this.tbClienteApellido.Size = new System.Drawing.Size(100, 20);
            this.tbClienteApellido.TabIndex = 11;
            // 
            // labelDniDuenioCarrito
            // 
            this.labelDniDuenioCarrito.AutoSize = true;
            this.labelDniDuenioCarrito.Location = new System.Drawing.Point(9, 190);
            this.labelDniDuenioCarrito.Name = "labelDniDuenioCarrito";
            this.labelDniDuenioCarrito.Size = new System.Drawing.Size(26, 13);
            this.labelDniDuenioCarrito.TabIndex = 12;
            this.labelDniDuenioCarrito.Text = "DNI";
            // 
            // labelNombreDuenioCarrito
            // 
            this.labelNombreDuenioCarrito.AutoSize = true;
            this.labelNombreDuenioCarrito.Location = new System.Drawing.Point(131, 190);
            this.labelNombreDuenioCarrito.Name = "labelNombreDuenioCarrito";
            this.labelNombreDuenioCarrito.Size = new System.Drawing.Size(44, 13);
            this.labelNombreDuenioCarrito.TabIndex = 13;
            this.labelNombreDuenioCarrito.Text = "Nombre";
            // 
            // labelApellidoDuenioCarrito
            // 
            this.labelApellidoDuenioCarrito.AutoSize = true;
            this.labelApellidoDuenioCarrito.Location = new System.Drawing.Point(252, 190);
            this.labelApellidoDuenioCarrito.Name = "labelApellidoDuenioCarrito";
            this.labelApellidoDuenioCarrito.Size = new System.Drawing.Size(44, 13);
            this.labelApellidoDuenioCarrito.TabIndex = 14;
            this.labelApellidoDuenioCarrito.Text = "Apellido";
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(595, 150);
            this.dataGridView1.TabIndex = 16;
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
            // btnSalirAsignar
            // 
            this.btnSalirAsignar.Location = new System.Drawing.Point(512, 314);
            this.btnSalirAsignar.Name = "btnSalirAsignar";
            this.btnSalirAsignar.Size = new System.Drawing.Size(95, 23);
            this.btnSalirAsignar.TabIndex = 17;
            this.btnSalirAsignar.Text = "Salir";
            this.btnSalirAsignar.UseVisualStyleBackColor = true;
            this.btnSalirAsignar.Click += new System.EventHandler(this.btnSalirAsignar_Click);
            // 
            // labelCelularDuenioCarrito
            // 
            this.labelCelularDuenioCarrito.AutoSize = true;
            this.labelCelularDuenioCarrito.Location = new System.Drawing.Point(372, 190);
            this.labelCelularDuenioCarrito.Name = "labelCelularDuenioCarrito";
            this.labelCelularDuenioCarrito.Size = new System.Drawing.Size(39, 13);
            this.labelCelularDuenioCarrito.TabIndex = 19;
            this.labelCelularDuenioCarrito.Text = "Celular";
            // 
            // tbClienteCelular
            // 
            this.tbClienteCelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbClienteCelular.Location = new System.Drawing.Point(375, 206);
            this.tbClienteCelular.Name = "tbClienteCelular";
            this.tbClienteCelular.Size = new System.Drawing.Size(100, 20);
            this.tbClienteCelular.TabIndex = 18;
            // 
            // labelEmailDuenioCarrito
            // 
            this.labelEmailDuenioCarrito.AutoSize = true;
            this.labelEmailDuenioCarrito.Location = new System.Drawing.Point(490, 190);
            this.labelEmailDuenioCarrito.Name = "labelEmailDuenioCarrito";
            this.labelEmailDuenioCarrito.Size = new System.Drawing.Size(32, 13);
            this.labelEmailDuenioCarrito.TabIndex = 21;
            this.labelEmailDuenioCarrito.Text = "Email";
            // 
            // tbClienteEmail
            // 
            this.tbClienteEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbClienteEmail.Location = new System.Drawing.Point(493, 206);
            this.tbClienteEmail.Name = "tbClienteEmail";
            this.tbClienteEmail.Size = new System.Drawing.Size(114, 20);
            this.tbClienteEmail.TabIndex = 20;
            // 
            // GuiAsignarCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(619, 349);
            this.Controls.Add(this.labelEmailDuenioCarrito);
            this.Controls.Add(this.tbClienteEmail);
            this.Controls.Add(this.labelCelularDuenioCarrito);
            this.Controls.Add(this.tbClienteCelular);
            this.Controls.Add(this.btnSalirAsignar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelApellidoDuenioCarrito);
            this.Controls.Add(this.labelNombreDuenioCarrito);
            this.Controls.Add(this.labelDniDuenioCarrito);
            this.Controls.Add(this.tbClienteApellido);
            this.Controls.Add(this.tbClienteNombre);
            this.Controls.Add(this.tbClienteDNI);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.tbDuenioCarrito);
            this.Controls.Add(this.labelDuenioCarrito);
            this.Controls.Add(this.labelCodCarrito);
            this.Controls.Add(this.tbCodCarrito);
            this.Controls.Add(this.labelDatosCarrito);
            this.Controls.Add(this.labelDatosDuenioCarrito);
            this.Name = "GuiAsignarCarrito";
            this.Text = "GuiAsignarCarrito";
            this.Load += new System.EventHandler(this.GuiAsignarCarrito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDatosDuenioCarrito;
        private System.Windows.Forms.Label labelDatosCarrito;
        private System.Windows.Forms.TextBox tbCodCarrito;
        private System.Windows.Forms.Label labelCodCarrito;
        private System.Windows.Forms.Label labelDuenioCarrito;
        private System.Windows.Forms.TextBox tbDuenioCarrito;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.TextBox tbClienteDNI;
        private System.Windows.Forms.TextBox tbClienteNombre;
        private System.Windows.Forms.TextBox tbClienteApellido;
        private System.Windows.Forms.Label labelDniDuenioCarrito;
        private System.Windows.Forms.Label labelNombreDuenioCarrito;
        private System.Windows.Forms.Label labelApellidoDuenioCarrito;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnSalirAsignar;
        private System.Windows.Forms.Label labelCelularDuenioCarrito;
        private System.Windows.Forms.TextBox tbClienteCelular;
        private System.Windows.Forms.Label labelEmailDuenioCarrito;
        private System.Windows.Forms.TextBox tbClienteEmail;
    }
}