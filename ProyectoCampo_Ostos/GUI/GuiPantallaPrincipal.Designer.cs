namespace GUI
{
    partial class GuiPantallaPrincipal
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
            this.labelSesion = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.idiomaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuEspaniol = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuIngles = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuFrances = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuAleman = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuPortugues = new System.Windows.Forms.ToolStripMenuItem();
            this.sesionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.loginItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContraseñaItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilesItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.productosItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carritoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajeroMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbBienvenida = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSesion
            // 
            this.labelSesion.AutoSize = true;
            this.labelSesion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSesion.Location = new System.Drawing.Point(9, 35);
            this.labelSesion.Name = "labelSesion";
            this.labelSesion.Size = new System.Drawing.Size(50, 16);
            this.labelSesion.TabIndex = 10;
            this.labelSesion.Text = "label1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idiomaMenu,
            this.sesionMenu,
            this.adminMenu,
            this.vendedorMenu,
            this.cajeroMenu});
            this.menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(6, 2, 0, 5);
            this.menuStrip2.Size = new System.Drawing.Size(631, 26);
            this.menuStrip2.TabIndex = 19;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // idiomaMenu
            // 
            this.idiomaMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.idiomaMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuEspaniol,
            this.StripMenuIngles,
            this.StripMenuFrances,
            this.StripMenuAleman,
            this.StripMenuPortugues});
            this.idiomaMenu.Name = "idiomaMenu";
            this.idiomaMenu.Size = new System.Drawing.Size(108, 19);
            this.idiomaMenu.Text = "Cambiar Idioma";
            // 
            // StripMenuEspaniol
            // 
            this.StripMenuEspaniol.Name = "StripMenuEspaniol";
            this.StripMenuEspaniol.Size = new System.Drawing.Size(180, 22);
            this.StripMenuEspaniol.Text = "Español";
            this.StripMenuEspaniol.Click += new System.EventHandler(this.españolToolStripMenuItem_Click);
            // 
            // StripMenuIngles
            // 
            this.StripMenuIngles.Name = "StripMenuIngles";
            this.StripMenuIngles.Size = new System.Drawing.Size(180, 22);
            this.StripMenuIngles.Text = "Ingles";
            this.StripMenuIngles.Click += new System.EventHandler(this.inglesToolStripMenuItem_Click);
            // 
            // StripMenuFrances
            // 
            this.StripMenuFrances.Name = "StripMenuFrances";
            this.StripMenuFrances.Size = new System.Drawing.Size(180, 22);
            this.StripMenuFrances.Text = "Francés";
            this.StripMenuFrances.Click += new System.EventHandler(this.francésToolStripMenuItem_Click);
            // 
            // StripMenuAleman
            // 
            this.StripMenuAleman.Name = "StripMenuAleman";
            this.StripMenuAleman.Size = new System.Drawing.Size(180, 22);
            this.StripMenuAleman.Text = "Alemán";
            this.StripMenuAleman.Click += new System.EventHandler(this.alemánToolStripMenuItem_Click);
            // 
            // StripMenuPortugues
            // 
            this.StripMenuPortugues.Name = "StripMenuPortugues";
            this.StripMenuPortugues.Size = new System.Drawing.Size(180, 22);
            this.StripMenuPortugues.Text = "Portugues";
            this.StripMenuPortugues.Click += new System.EventHandler(this.portuguesToolStripMenuItem_Click);
            // 
            // sesionMenu
            // 
            this.sesionMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginItem,
            this.logoutItem,
            this.ContraseñaItem});
            this.sesionMenu.Name = "sesionMenu";
            this.sesionMenu.Size = new System.Drawing.Size(58, 19);
            this.sesionMenu.Text = "Sesión";
            // 
            // loginItem
            // 
            this.loginItem.Name = "loginItem";
            this.loginItem.Size = new System.Drawing.Size(191, 22);
            this.loginItem.Text = "Iniciar Sesión";
            this.loginItem.Click += new System.EventHandler(this.loginItem_Click);
            // 
            // logoutItem
            // 
            this.logoutItem.Name = "logoutItem";
            this.logoutItem.Size = new System.Drawing.Size(191, 22);
            this.logoutItem.Text = "Cerrar Sesión";
            this.logoutItem.Click += new System.EventHandler(this.logoutItem_Click);
            // 
            // ContraseñaItem
            // 
            this.ContraseñaItem.Name = "ContraseñaItem";
            this.ContraseñaItem.Size = new System.Drawing.Size(191, 22);
            this.ContraseñaItem.Text = "Cambiar Contraseña";
            this.ContraseñaItem.Click += new System.EventHandler(this.ContraseñaItem_Click);
            // 
            // adminMenu
            // 
            this.adminMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilesItem,
            this.usuariosItem});
            this.adminMenu.Name = "adminMenu";
            this.adminMenu.Size = new System.Drawing.Size(105, 19);
            this.adminMenu.Text = "Administración";
            // 
            // perfilesItem
            // 
            this.perfilesItem.Name = "perfilesItem";
            this.perfilesItem.Size = new System.Drawing.Size(188, 22);
            this.perfilesItem.Text = "Gestión de Perfiles";
            this.perfilesItem.Click += new System.EventHandler(this.perfilesItem_Click);
            // 
            // usuariosItem
            // 
            this.usuariosItem.Name = "usuariosItem";
            this.usuariosItem.Size = new System.Drawing.Size(188, 22);
            this.usuariosItem.Text = "Gestión de Usuarios";
            this.usuariosItem.Click += new System.EventHandler(this.usuariosItem_Click);
            // 
            // vendedorMenu
            // 
            this.vendedorMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosItem,
            this.carritoItem,
            this.clientesItem});
            this.vendedorMenu.Name = "vendedorMenu";
            this.vendedorMenu.Size = new System.Drawing.Size(73, 19);
            this.vendedorMenu.Text = "Vendedor";
            // 
            // productosItem
            // 
            this.productosItem.Name = "productosItem";
            this.productosItem.Size = new System.Drawing.Size(182, 22);
            this.productosItem.Text = "Agregar Productos";
            this.productosItem.Click += new System.EventHandler(this.productosItem_Click);
            // 
            // carritoItem
            // 
            this.carritoItem.Name = "carritoItem";
            this.carritoItem.Size = new System.Drawing.Size(182, 22);
            this.carritoItem.Text = "Asignar Carrito";
            this.carritoItem.Click += new System.EventHandler(this.carritoItem_Click);
            // 
            // clientesItem
            // 
            this.clientesItem.Name = "clientesItem";
            this.clientesItem.Size = new System.Drawing.Size(182, 22);
            this.clientesItem.Text = "Registrar Cliente";
            this.clientesItem.Click += new System.EventHandler(this.clientesItem_Click);
            // 
            // cajeroMenu
            // 
            this.cajeroMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaItem});
            this.cajeroMenu.Name = "cajeroMenu";
            this.cajeroMenu.Size = new System.Drawing.Size(56, 19);
            this.cajeroMenu.Text = "Cajero";
            // 
            // facturaItem
            // 
            this.facturaItem.Name = "facturaItem";
            this.facturaItem.Size = new System.Drawing.Size(180, 22);
            this.facturaItem.Text = "Generar Factura";
            this.facturaItem.Click += new System.EventHandler(this.facturaItem_Click);
            // 
            // lbBienvenida
            // 
            this.lbBienvenida.AutoSize = true;
            this.lbBienvenida.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbBienvenida.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBienvenida.Location = new System.Drawing.Point(12, 298);
            this.lbBienvenida.Name = "lbBienvenida";
            this.lbBienvenida.Size = new System.Drawing.Size(594, 31);
            this.lbBienvenida.TabIndex = 20;
            this.lbBienvenida.Text = "BIENVENIDO A BELLEZA ARGENTINA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = global::GUI.Properties.Resources.LogoEmpresa;
            this.pictureBox1.Location = new System.Drawing.Point(12, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(597, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // GuiPantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(631, 338);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbBienvenida);
            this.Controls.Add(this.labelSesion);
            this.Controls.Add(this.menuStrip2);
            this.MinimumSize = new System.Drawing.Size(645, 377);
            this.Name = "GuiPantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuiPantallaPrincipal";
            this.Load += new System.EventHandler(this.GuiPantallaPrincipal_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSesion;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem idiomaMenu;
        private System.Windows.Forms.ToolStripMenuItem StripMenuEspaniol;
        private System.Windows.Forms.ToolStripMenuItem StripMenuIngles;
        private System.Windows.Forms.ToolStripMenuItem StripMenuFrances;
        private System.Windows.Forms.ToolStripMenuItem StripMenuAleman;
        private System.Windows.Forms.ToolStripMenuItem StripMenuPortugues;
        private System.Windows.Forms.ToolStripMenuItem sesionMenu;
        private System.Windows.Forms.ToolStripMenuItem loginItem;
        private System.Windows.Forms.ToolStripMenuItem logoutItem;
        private System.Windows.Forms.ToolStripMenuItem adminMenu;
        private System.Windows.Forms.ToolStripMenuItem perfilesItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosItem;
        private System.Windows.Forms.ToolStripMenuItem ContraseñaItem;
        private System.Windows.Forms.ToolStripMenuItem vendedorMenu;
        private System.Windows.Forms.ToolStripMenuItem productosItem;
        private System.Windows.Forms.ToolStripMenuItem carritoItem;
        private System.Windows.Forms.ToolStripMenuItem clientesItem;
        private System.Windows.Forms.ToolStripMenuItem cajeroMenu;
        private System.Windows.Forms.ToolStripMenuItem facturaItem;
        private System.Windows.Forms.Label lbBienvenida;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}