namespace GUI
{
    partial class GuiAgregarProducto
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbTipoProducto = new System.Windows.Forms.TextBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrito = new System.Windows.Forms.ListBox();
            this.labelBusquedaProducto = new System.Windows.Forms.Label();
            this.btnFinBusqueda = new System.Windows.Forms.Button();
            this.rbNombreProducto = new System.Windows.Forms.RadioButton();
            this.rbTipoProducto = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTipoProducto
            // 
            this.tbTipoProducto.Location = new System.Drawing.Point(12, 33);
            this.tbTipoProducto.Multiline = true;
            this.tbTipoProducto.Name = "tbTipoProducto";
            this.tbTipoProducto.Size = new System.Drawing.Size(166, 22);
            this.tbTipoProducto.TabIndex = 3;
            this.tbTipoProducto.TextChanged += new System.EventHandler(this.tbTipoProducto_TextChanged);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(691, 185);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(152, 26);
            this.btnAgregarProducto.TabIndex = 4;
            this.btnAgregarProducto.Text = "Agregar Producto a Carrito";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvProductos.Location = new System.Drawing.Point(12, 61);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(603, 150);
            this.dgvProductos.TabIndex = 5;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Prod_Codigo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 93;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Prod_Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 94;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Prod_Marca";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 93;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prod_Tipo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 93;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Prod_Cantidad";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 94;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Prod_Precio";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 93;
            // 
            // Carrito
            // 
            this.Carrito.FormattingEnabled = true;
            this.Carrito.Location = new System.Drawing.Point(666, 19);
            this.Carrito.Name = "Carrito";
            this.Carrito.Size = new System.Drawing.Size(292, 160);
            this.Carrito.TabIndex = 6;
            // 
            // labelBusquedaProducto
            // 
            this.labelBusquedaProducto.AutoSize = true;
            this.labelBusquedaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBusquedaProducto.Location = new System.Drawing.Point(9, 10);
            this.labelBusquedaProducto.Name = "labelBusquedaProducto";
            this.labelBusquedaProducto.Size = new System.Drawing.Size(169, 16);
            this.labelBusquedaProducto.TabIndex = 7;
            this.labelBusquedaProducto.Text = "Buscador de Productos";
            // 
            // btnFinBusqueda
            // 
            this.btnFinBusqueda.Location = new System.Drawing.Point(849, 185);
            this.btnFinBusqueda.Name = "btnFinBusqueda";
            this.btnFinBusqueda.Size = new System.Drawing.Size(109, 26);
            this.btnFinBusqueda.TabIndex = 9;
            this.btnFinBusqueda.Text = "Finalizar Busqueda";
            this.btnFinBusqueda.UseVisualStyleBackColor = true;
            this.btnFinBusqueda.Click += new System.EventHandler(this.btnFinBusqueda_Click);
            // 
            // rbNombreProducto
            // 
            this.rbNombreProducto.AutoSize = true;
            this.rbNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNombreProducto.Location = new System.Drawing.Point(184, 34);
            this.rbNombreProducto.Name = "rbNombreProducto";
            this.rbNombreProducto.Size = new System.Drawing.Size(68, 17);
            this.rbNombreProducto.TabIndex = 10;
            this.rbNombreProducto.TabStop = true;
            this.rbNombreProducto.Text = "Nombre";
            this.rbNombreProducto.UseVisualStyleBackColor = true;
            // 
            // rbTipoProducto
            // 
            this.rbTipoProducto.AutoSize = true;
            this.rbTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTipoProducto.Location = new System.Drawing.Point(275, 34);
            this.rbTipoProducto.Name = "rbTipoProducto";
            this.rbTipoProducto.Size = new System.Drawing.Size(50, 17);
            this.rbTipoProducto.TabIndex = 11;
            this.rbTipoProducto.TabStop = true;
            this.rbTipoProducto.Text = "Tipo";
            this.rbTipoProducto.UseVisualStyleBackColor = true;
            // 
            // GuiAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(970, 222);
            this.Controls.Add(this.rbTipoProducto);
            this.Controls.Add(this.rbNombreProducto);
            this.Controls.Add(this.btnFinBusqueda);
            this.Controls.Add(this.labelBusquedaProducto);
            this.Controls.Add(this.Carrito);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.tbTipoProducto);
            this.Name = "GuiAgregarProducto";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbTipoProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.ListBox Carrito;
        private System.Windows.Forms.Label labelBusquedaProducto;
        private System.Windows.Forms.Button btnFinBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.RadioButton rbNombreProducto;
        private System.Windows.Forms.RadioButton rbTipoProducto;
    }
}

