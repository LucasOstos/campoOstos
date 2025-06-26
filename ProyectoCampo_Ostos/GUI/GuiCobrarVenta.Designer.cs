namespace GUI
{
    partial class GuiCobrarVenta
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
            this.botonCobrarVenta = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.botonBuscarCarrito = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelMetodoPago = new System.Windows.Forms.Label();
            this.radioButtonEfectivo = new System.Windows.Forms.RadioButton();
            this.radioButtonTarjeta = new System.Windows.Forms.RadioButton();
            this.tbNumTarjeta = new System.Windows.Forms.TextBox();
            this.tbFechaVencimiento = new System.Windows.Forms.TextBox();
            this.tbCodSeguridad = new System.Windows.Forms.TextBox();
            this.labelTipoTarjeta = new System.Windows.Forms.Label();
            this.labelNumTarjeta = new System.Windows.Forms.Label();
            this.labelFechaTarjeta = new System.Windows.Forms.Label();
            this.labelCodTarjeta = new System.Windows.Forms.Label();
            this.labelBuscador = new System.Windows.Forms.Label();
            this.cbTipoTarjeta = new System.Windows.Forms.ComboBox();
            this.rbNumTarjeta = new System.Windows.Forms.RadioButton();
            this.rbCodigoSeguridad = new System.Windows.Forms.RadioButton();
            this.btnSalirVenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // botonCobrarVenta
            // 
            this.botonCobrarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCobrarVenta.Location = new System.Drawing.Point(795, 284);
            this.botonCobrarVenta.Name = "botonCobrarVenta";
            this.botonCobrarVenta.Size = new System.Drawing.Size(113, 23);
            this.botonCobrarVenta.TabIndex = 0;
            this.botonCobrarVenta.Text = "Cobrar";
            this.botonCobrarVenta.UseVisualStyleBackColor = true;
            this.botonCobrarVenta.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Location = new System.Drawing.Point(12, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 23);
            this.textBox1.TabIndex = 1;
            // 
            // botonBuscarCarrito
            // 
            this.botonBuscarCarrito.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBuscarCarrito.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.botonBuscarCarrito.Location = new System.Drawing.Point(185, 29);
            this.botonBuscarCarrito.Name = "botonBuscarCarrito";
            this.botonBuscarCarrito.Size = new System.Drawing.Size(113, 23);
            this.botonBuscarCarrito.TabIndex = 2;
            this.botonBuscarCarrito.Text = "Buscar Carrito";
            this.botonBuscarCarrito.UseVisualStyleBackColor = true;
            this.botonBuscarCarrito.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column4,
            this.Column6,
            this.Column5,
            this.Column3,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(12, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(747, 192);
            this.dataGridView1.TabIndex = 6;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Carrito_CodProd";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 101;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Carrito_NombreProd";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Carrito_TipoProd";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 101;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Carrito_PrecioProd";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Carrito_CantProd";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 101;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Carrito_Subtotal";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Carrito_PrecioTotal";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 101;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "CARRITO DE:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Location = new System.Drawing.Point(795, 85);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(124, 23);
            this.textBox2.TabIndex = 10;
            // 
            // labelMetodoPago
            // 
            this.labelMetodoPago.AutoSize = true;
            this.labelMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMetodoPago.Location = new System.Drawing.Point(798, 29);
            this.labelMetodoPago.Name = "labelMetodoPago";
            this.labelMetodoPago.Size = new System.Drawing.Size(153, 16);
            this.labelMetodoPago.TabIndex = 11;
            this.labelMetodoPago.Text = "METODOS DE PAGO";
            // 
            // radioButtonEfectivo
            // 
            this.radioButtonEfectivo.AutoSize = true;
            this.radioButtonEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEfectivo.Location = new System.Drawing.Point(801, 62);
            this.radioButtonEfectivo.Name = "radioButtonEfectivo";
            this.radioButtonEfectivo.Size = new System.Drawing.Size(72, 17);
            this.radioButtonEfectivo.TabIndex = 12;
            this.radioButtonEfectivo.Text = "Efectivo";
            this.radioButtonEfectivo.UseVisualStyleBackColor = true;
            // 
            // radioButtonTarjeta
            // 
            this.radioButtonTarjeta.AutoSize = true;
            this.radioButtonTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTarjeta.Location = new System.Drawing.Point(795, 124);
            this.radioButtonTarjeta.Name = "radioButtonTarjeta";
            this.radioButtonTarjeta.Size = new System.Drawing.Size(65, 17);
            this.radioButtonTarjeta.TabIndex = 13;
            this.radioButtonTarjeta.Text = "Tarjeta";
            this.radioButtonTarjeta.UseVisualStyleBackColor = true;
            // 
            // tbNumTarjeta
            // 
            this.tbNumTarjeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNumTarjeta.Location = new System.Drawing.Point(947, 165);
            this.tbNumTarjeta.Name = "tbNumTarjeta";
            this.tbNumTarjeta.PasswordChar = '*';
            this.tbNumTarjeta.Size = new System.Drawing.Size(122, 20);
            this.tbNumTarjeta.TabIndex = 15;
            this.tbNumTarjeta.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.tbNumTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // tbFechaVencimiento
            // 
            this.tbFechaVencimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFechaVencimiento.Location = new System.Drawing.Point(795, 229);
            this.tbFechaVencimiento.Name = "tbFechaVencimiento";
            this.tbFechaVencimiento.Size = new System.Drawing.Size(117, 20);
            this.tbFechaVencimiento.TabIndex = 16;
            this.tbFechaVencimiento.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.tbFechaVencimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // tbCodSeguridad
            // 
            this.tbCodSeguridad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCodSeguridad.Location = new System.Drawing.Point(947, 229);
            this.tbCodSeguridad.Name = "tbCodSeguridad";
            this.tbCodSeguridad.PasswordChar = '*';
            this.tbCodSeguridad.Size = new System.Drawing.Size(122, 20);
            this.tbCodSeguridad.TabIndex = 17;
            this.tbCodSeguridad.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.tbCodSeguridad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // labelTipoTarjeta
            // 
            this.labelTipoTarjeta.AutoSize = true;
            this.labelTipoTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoTarjeta.Location = new System.Drawing.Point(818, 149);
            this.labelTipoTarjeta.Name = "labelTipoTarjeta";
            this.labelTipoTarjeta.Size = new System.Drawing.Size(94, 13);
            this.labelTipoTarjeta.TabIndex = 18;
            this.labelTipoTarjeta.Text = "Tipo de Tarjeta";
            // 
            // labelNumTarjeta
            // 
            this.labelNumTarjeta.AutoSize = true;
            this.labelNumTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumTarjeta.Location = new System.Drawing.Point(952, 149);
            this.labelNumTarjeta.Name = "labelNumTarjeta";
            this.labelNumTarjeta.Size = new System.Drawing.Size(112, 13);
            this.labelNumTarjeta.TabIndex = 19;
            this.labelNumTarjeta.Text = "Numero de Tarjeta";
            // 
            // labelFechaTarjeta
            // 
            this.labelFechaTarjeta.AutoSize = true;
            this.labelFechaTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaTarjeta.Location = new System.Drawing.Point(797, 213);
            this.labelFechaTarjeta.Name = "labelFechaTarjeta";
            this.labelFechaTarjeta.Size = new System.Drawing.Size(115, 13);
            this.labelFechaTarjeta.TabIndex = 20;
            this.labelFechaTarjeta.Text = "Fecha Vencimiento";
            // 
            // labelCodTarjeta
            // 
            this.labelCodTarjeta.AutoSize = true;
            this.labelCodTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodTarjeta.Location = new System.Drawing.Point(944, 213);
            this.labelCodTarjeta.Name = "labelCodTarjeta";
            this.labelCodTarjeta.Size = new System.Drawing.Size(125, 13);
            this.labelCodTarjeta.TabIndex = 21;
            this.labelCodTarjeta.Text = "Codigo de Seguridad";
            // 
            // labelBuscador
            // 
            this.labelBuscador.AutoSize = true;
            this.labelBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscador.Location = new System.Drawing.Point(12, 13);
            this.labelBuscador.Name = "labelBuscador";
            this.labelBuscador.Size = new System.Drawing.Size(72, 13);
            this.labelBuscador.TabIndex = 22;
            this.labelBuscador.Text = "DNI Cliente";
            // 
            // cbTipoTarjeta
            // 
            this.cbTipoTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoTarjeta.FormattingEnabled = true;
            this.cbTipoTarjeta.Items.AddRange(new object[] {
            "Crédito",
            "Débito"});
            this.cbTipoTarjeta.Location = new System.Drawing.Point(795, 165);
            this.cbTipoTarjeta.Name = "cbTipoTarjeta";
            this.cbTipoTarjeta.Size = new System.Drawing.Size(117, 21);
            this.cbTipoTarjeta.TabIndex = 23;
            // 
            // rbNumTarjeta
            // 
            this.rbNumTarjeta.AutoSize = true;
            this.rbNumTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNumTarjeta.Location = new System.Drawing.Point(947, 191);
            this.rbNumTarjeta.Name = "rbNumTarjeta";
            this.rbNumTarjeta.Size = new System.Drawing.Size(112, 17);
            this.rbNumTarjeta.TabIndex = 27;
            this.rbNumTarjeta.TabStop = true;
            this.rbNumTarjeta.Text = "Mostrar número";
            this.rbNumTarjeta.UseVisualStyleBackColor = true;
            this.rbNumTarjeta.Click += new System.EventHandler(this.rbNumTarjeta_Click);
            // 
            // rbCodigoSeguridad
            // 
            this.rbCodigoSeguridad.AutoSize = true;
            this.rbCodigoSeguridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCodigoSeguridad.Location = new System.Drawing.Point(947, 255);
            this.rbCodigoSeguridad.Name = "rbCodigoSeguridad";
            this.rbCodigoSeguridad.Size = new System.Drawing.Size(109, 17);
            this.rbCodigoSeguridad.TabIndex = 28;
            this.rbCodigoSeguridad.TabStop = true;
            this.rbCodigoSeguridad.Text = "Mostrar código";
            this.rbCodigoSeguridad.UseVisualStyleBackColor = true;
            this.rbCodigoSeguridad.Click += new System.EventHandler(this.rbCodigoSeguridad_Click);
            // 
            // btnSalirVenta
            // 
            this.btnSalirVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirVenta.Location = new System.Drawing.Point(959, 284);
            this.btnSalirVenta.Name = "btnSalirVenta";
            this.btnSalirVenta.Size = new System.Drawing.Size(113, 23);
            this.btnSalirVenta.TabIndex = 29;
            this.btnSalirVenta.Text = "Salir";
            this.btnSalirVenta.UseVisualStyleBackColor = true;
            this.btnSalirVenta.Click += new System.EventHandler(this.btnSalirVenta_Click);
            // 
            // GuiCobrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1084, 319);
            this.Controls.Add(this.btnSalirVenta);
            this.Controls.Add(this.rbCodigoSeguridad);
            this.Controls.Add(this.rbNumTarjeta);
            this.Controls.Add(this.cbTipoTarjeta);
            this.Controls.Add(this.labelBuscador);
            this.Controls.Add(this.labelCodTarjeta);
            this.Controls.Add(this.labelFechaTarjeta);
            this.Controls.Add(this.labelNumTarjeta);
            this.Controls.Add(this.labelTipoTarjeta);
            this.Controls.Add(this.tbCodSeguridad);
            this.Controls.Add(this.tbFechaVencimiento);
            this.Controls.Add(this.tbNumTarjeta);
            this.Controls.Add(this.radioButtonTarjeta);
            this.Controls.Add(this.radioButtonEfectivo);
            this.Controls.Add(this.labelMetodoPago);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.botonBuscarCarrito);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.botonCobrarVenta);
            this.Name = "GuiCobrarVenta";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonCobrarVenta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button botonBuscarCarrito;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelMetodoPago;
        private System.Windows.Forms.RadioButton radioButtonEfectivo;
        private System.Windows.Forms.RadioButton radioButtonTarjeta;
        private System.Windows.Forms.TextBox tbNumTarjeta;
        private System.Windows.Forms.TextBox tbFechaVencimiento;
        private System.Windows.Forms.TextBox tbCodSeguridad;
        private System.Windows.Forms.Label labelTipoTarjeta;
        private System.Windows.Forms.Label labelNumTarjeta;
        private System.Windows.Forms.Label labelFechaTarjeta;
        private System.Windows.Forms.Label labelCodTarjeta;
        private System.Windows.Forms.Label labelBuscador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ComboBox cbTipoTarjeta;
        private System.Windows.Forms.RadioButton rbNumTarjeta;
        private System.Windows.Forms.RadioButton rbCodigoSeguridad;
        private System.Windows.Forms.Button btnSalirVenta;
    }
}