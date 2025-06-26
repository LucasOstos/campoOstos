namespace GUI
{
    partial class GuiFactura
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
            this.labelDatosFactura = new System.Windows.Forms.Label();
            this.btnCargarFactura = new System.Windows.Forms.Button();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.botonSalirFactura = new System.Windows.Forms.Button();
            this.tbFacturaDNI = new System.Windows.Forms.TextBox();
            this.labelFacturaCliente = new System.Windows.Forms.Label();
            this.btnGenerarFactura = new System.Windows.Forms.Button();
            this.lblFacturaDatosC = new System.Windows.Forms.Label();
            this.labelFactura_DNICliente = new System.Windows.Forms.Label();
            this.labelFactura_NombreCliente = new System.Windows.Forms.Label();
            this.labelFactura_ApellidoCliente = new System.Windows.Forms.Label();
            this.labelFactura_CelularCliente = new System.Windows.Forms.Label();
            this.labelFactura_EmailCliente = new System.Windows.Forms.Label();
            this.labelFactura_FechaEmision = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDatosFactura
            // 
            this.labelDatosFactura.AutoSize = true;
            this.labelDatosFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatosFactura.Location = new System.Drawing.Point(9, 70);
            this.labelDatosFactura.Name = "labelDatosFactura";
            this.labelDatosFactura.Size = new System.Drawing.Size(78, 16);
            this.labelDatosFactura.TabIndex = 0;
            this.labelDatosFactura.Text = "FACTURA";
            // 
            // btnCargarFactura
            // 
            this.btnCargarFactura.Location = new System.Drawing.Point(12, 445);
            this.btnCargarFactura.Name = "btnCargarFactura";
            this.btnCargarFactura.Size = new System.Drawing.Size(84, 23);
            this.btnCargarFactura.TabIndex = 13;
            this.btnCargarFactura.Text = "Cargar";
            this.btnCargarFactura.UseVisualStyleBackColor = true;
            this.btnCargarFactura.Click += new System.EventHandler(this.btnCargarFactura_Click);
            // 
            // dgvFactura
            // 
            this.dgvFactura.AllowUserToAddRows = false;
            this.dgvFactura.AllowUserToDeleteRows = false;
            this.dgvFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFactura.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Location = new System.Drawing.Point(12, 104);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.ReadOnly = true;
            this.dgvFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFactura.Size = new System.Drawing.Size(875, 317);
            this.dgvFactura.TabIndex = 26;
            // 
            // botonSalirFactura
            // 
            this.botonSalirFactura.Location = new System.Drawing.Point(812, 445);
            this.botonSalirFactura.Name = "botonSalirFactura";
            this.botonSalirFactura.Size = new System.Drawing.Size(75, 23);
            this.botonSalirFactura.TabIndex = 27;
            this.botonSalirFactura.Text = "Salir";
            this.botonSalirFactura.UseVisualStyleBackColor = true;
            this.botonSalirFactura.Click += new System.EventHandler(this.botonSalirFactura_Click);
            // 
            // tbFacturaDNI
            // 
            this.tbFacturaDNI.Location = new System.Drawing.Point(192, 448);
            this.tbFacturaDNI.MaxLength = 8;
            this.tbFacturaDNI.Name = "tbFacturaDNI";
            this.tbFacturaDNI.Size = new System.Drawing.Size(100, 20);
            this.tbFacturaDNI.TabIndex = 28;
            this.tbFacturaDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // labelFacturaCliente
            // 
            this.labelFacturaCliente.AutoSize = true;
            this.labelFacturaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFacturaCliente.Location = new System.Drawing.Point(189, 432);
            this.labelFacturaCliente.Name = "labelFacturaCliente";
            this.labelFacturaCliente.Size = new System.Drawing.Size(33, 13);
            this.labelFacturaCliente.TabIndex = 29;
            this.labelFacturaCliente.Text = "DNI:";
            // 
            // btnGenerarFactura
            // 
            this.btnGenerarFactura.Location = new System.Drawing.Point(102, 445);
            this.btnGenerarFactura.Name = "btnGenerarFactura";
            this.btnGenerarFactura.Size = new System.Drawing.Size(84, 23);
            this.btnGenerarFactura.TabIndex = 30;
            this.btnGenerarFactura.Text = "Generar";
            this.btnGenerarFactura.UseVisualStyleBackColor = true;
            this.btnGenerarFactura.Click += new System.EventHandler(this.btnGenerarFactura_Click);
            // 
            // lblFacturaDatosC
            // 
            this.lblFacturaDatosC.AutoSize = true;
            this.lblFacturaDatosC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturaDatosC.Location = new System.Drawing.Point(9, 9);
            this.lblFacturaDatosC.Name = "lblFacturaDatosC";
            this.lblFacturaDatosC.Size = new System.Drawing.Size(100, 16);
            this.lblFacturaDatosC.TabIndex = 31;
            this.lblFacturaDatosC.Text = "Datos Cliente";
            // 
            // labelFactura_DNICliente
            // 
            this.labelFactura_DNICliente.AutoSize = true;
            this.labelFactura_DNICliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFactura_DNICliente.Location = new System.Drawing.Point(9, 25);
            this.labelFactura_DNICliente.Name = "labelFactura_DNICliente";
            this.labelFactura_DNICliente.Size = new System.Drawing.Size(37, 16);
            this.labelFactura_DNICliente.TabIndex = 32;
            this.labelFactura_DNICliente.Text = "DNI:";
            // 
            // labelFactura_NombreCliente
            // 
            this.labelFactura_NombreCliente.AutoSize = true;
            this.labelFactura_NombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFactura_NombreCliente.Location = new System.Drawing.Point(176, 25);
            this.labelFactura_NombreCliente.Name = "labelFactura_NombreCliente";
            this.labelFactura_NombreCliente.Size = new System.Drawing.Size(66, 16);
            this.labelFactura_NombreCliente.TabIndex = 33;
            this.labelFactura_NombreCliente.Text = "Nombre:";
            // 
            // labelFactura_ApellidoCliente
            // 
            this.labelFactura_ApellidoCliente.AutoSize = true;
            this.labelFactura_ApellidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFactura_ApellidoCliente.Location = new System.Drawing.Point(343, 25);
            this.labelFactura_ApellidoCliente.Name = "labelFactura_ApellidoCliente";
            this.labelFactura_ApellidoCliente.Size = new System.Drawing.Size(69, 16);
            this.labelFactura_ApellidoCliente.TabIndex = 34;
            this.labelFactura_ApellidoCliente.Text = "Apellido:";
            // 
            // labelFactura_CelularCliente
            // 
            this.labelFactura_CelularCliente.AutoSize = true;
            this.labelFactura_CelularCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFactura_CelularCliente.Location = new System.Drawing.Point(510, 25);
            this.labelFactura_CelularCliente.Name = "labelFactura_CelularCliente";
            this.labelFactura_CelularCliente.Size = new System.Drawing.Size(60, 16);
            this.labelFactura_CelularCliente.TabIndex = 35;
            this.labelFactura_CelularCliente.Text = "Celular:";
            // 
            // labelFactura_EmailCliente
            // 
            this.labelFactura_EmailCliente.AutoSize = true;
            this.labelFactura_EmailCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFactura_EmailCliente.Location = new System.Drawing.Point(677, 25);
            this.labelFactura_EmailCliente.Name = "labelFactura_EmailCliente";
            this.labelFactura_EmailCliente.Size = new System.Drawing.Size(50, 16);
            this.labelFactura_EmailCliente.TabIndex = 36;
            this.labelFactura_EmailCliente.Text = "Email:";
            // 
            // labelFactura_FechaEmision
            // 
            this.labelFactura_FechaEmision.AutoSize = true;
            this.labelFactura_FechaEmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFactura_FechaEmision.Location = new System.Drawing.Point(9, 86);
            this.labelFactura_FechaEmision.Name = "labelFactura_FechaEmision";
            this.labelFactura_FechaEmision.Size = new System.Drawing.Size(135, 16);
            this.labelFactura_FechaEmision.TabIndex = 37;
            this.labelFactura_FechaEmision.Text = "Fecha de Emisión:";
            // 
            // GuiFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(899, 480);
            this.Controls.Add(this.labelFactura_FechaEmision);
            this.Controls.Add(this.labelFactura_EmailCliente);
            this.Controls.Add(this.labelFactura_CelularCliente);
            this.Controls.Add(this.labelFactura_ApellidoCliente);
            this.Controls.Add(this.labelFactura_NombreCliente);
            this.Controls.Add(this.labelFactura_DNICliente);
            this.Controls.Add(this.lblFacturaDatosC);
            this.Controls.Add(this.btnGenerarFactura);
            this.Controls.Add(this.labelFacturaCliente);
            this.Controls.Add(this.tbFacturaDNI);
            this.Controls.Add(this.botonSalirFactura);
            this.Controls.Add(this.dgvFactura);
            this.Controls.Add(this.btnCargarFactura);
            this.Controls.Add(this.labelDatosFactura);
            this.Name = "GuiFactura";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.GuiFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDatosFactura;
        private System.Windows.Forms.Button btnCargarFactura;
        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.Button botonSalirFactura;
        private System.Windows.Forms.TextBox tbFacturaDNI;
        private System.Windows.Forms.Label labelFacturaCliente;
        private System.Windows.Forms.Button btnGenerarFactura;
        private System.Windows.Forms.Label lblFacturaDatosC;
        private System.Windows.Forms.Label labelFactura_DNICliente;
        private System.Windows.Forms.Label labelFactura_NombreCliente;
        private System.Windows.Forms.Label labelFactura_ApellidoCliente;
        private System.Windows.Forms.Label labelFactura_CelularCliente;
        private System.Windows.Forms.Label labelFactura_EmailCliente;
        private System.Windows.Forms.Label labelFactura_FechaEmision;
    }
}