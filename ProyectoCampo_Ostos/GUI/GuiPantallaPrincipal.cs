using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using SERVICIOS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using BE;

namespace GUI
{
    public partial class GuiPantallaPrincipal : Form, IObserver
    {
        public GuiPantallaPrincipal()
        {
            InitializeComponent();                        
        }
        private void GuiPantallaPrincipal_Load(object sender, EventArgs e)
        {
            StripMenuPortugues.Tag = null;
            Traductor.Instancia.Suscribir(this);
            Traductor.Instancia.Notificar(Sesion.Instancia.Usuario.Idioma);
            ActualizarIdioma();
            if(Sesion.Instancia.Usuario.Perfil != "Administrador General") ValidarPermisosMenu(menuStrip2.Items);
        }
        #region Funciones               
        
        private void ValidarPermisosMenu(ToolStripItemCollection items)
        {
            foreach (ToolStripItem item in items)
            {
                if (item.Tag != null)
                {
                    string permisoNecesario = item.Tag.ToString();
                    bool tienePermiso = Sesion.Instancia.TienePermiso(permisoNecesario);
                    item.Visible = tienePermiso;
                }
                if (item is ToolStripMenuItem menuItem && menuItem.DropDownItems.Count > 0)
                {
                    ValidarPermisosMenu(menuItem.DropDownItems);
                }
            }
        }
        #endregion

        #region Items MenuStrip
        private void loginItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            InterfazInicioSesion guiLogin = new InterfazInicioSesion();
            guiLogin.ShowDialog();
            this.Show();
        }
        
        private void logoutItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Confirmacion = MessageBox.Show(Traducir("MsgConfirmarLogOut"), "", MessageBoxButtons.YesNo);
                if (Confirmacion == DialogResult.Yes)
                {
                    Sesion.Instancia.LogOut();
                    this.Hide();
                    MessageBox.Show(Traducir("MsgLogOutOK"));
                    InterfazInicioSesion guiLogin = new InterfazInicioSesion();
                    guiLogin.ShowDialog();
                    this.Close();
                }
                else { }
            }
            catch { }
        }
        
        private void perfilesItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuiPermisos guiPermisos = new GuiPermisos();
            guiPermisos.ShowDialog();
            this.Show();
        }
        
        private void usuariosItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuiGestionUsuarios guiGestionUsuarios = new GuiGestionUsuarios();
            guiGestionUsuarios.ShowDialog();
            this.Show();
        }
        
        private void ContraseñaItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuiContrasenia guiContrasenia = new GuiContrasenia();
            guiContrasenia.ShowDialog();
            this.Close();
        }

        private void productosItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuiAgregarProducto guiAgregarProductos = new GuiAgregarProducto();
            guiAgregarProductos.ShowDialog();
            this.Show();
        }

        private void carritoItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestorFormulario.Instancia.ObtenerGui().ShowDialog();
            this.Show();
        }

        private void clientesItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuiGestionClientes guiClientes = new GuiGestionClientes();
            guiClientes.ShowDialog();
            this.Show();
        }

        private void facturaItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuiFactura guiFactura = new GuiFactura();
            guiFactura.ShowDialog();
            this.Show();
        }
        #endregion

        #region Idiomas
        public void ActualizarIdioma()
        {
            foreach (Control c in Controls)
            {
                if (c.GetType() != typeof(Label))
                {
                    if (c.GetType() == typeof(MenuStrip))
                    {
                        foreach (ToolStripMenuItem item in (c as MenuStrip).Items)
                        {
                            foreach (ToolStripMenuItem subItem in item.DropDownItems)
                            {
                                subItem.Text = Traducir(subItem.Name);
                            }
                            item.Text = Traducir(item.Name);
                        }
                    }
                    c.Text = Traducir(c.Name);
                }
            }
            TraducirLabels();
        }        
        private void TraducirLabels()
        {
            string usuario = Traducir("labelUsuario");
            string rol = Traducir("labelRol");
            labelSesion.Text = usuario.Replace("{usuario}", $"{Sesion.Instancia.Usuario.Nombre} {Sesion.Instancia.Usuario.Apellido}") + Environment.NewLine +
                          rol.Replace("{rol}", Sesion.Instancia.Usuario.Perfil);
            string bienvenida = Traducir("lbBienvenida");
            lbBienvenida.Text = bienvenida;
        }
        private string Traducir(string paraTraducir)
        {
            return Traductor.Instancia.Traducir(paraTraducir);
        }
        private void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Confirmacion = MessageBox.Show(Traducir("MsgIdioma"), "", MessageBoxButtons.YesNo);
            if(Confirmacion == DialogResult.Yes)
            {
                if(Sesion.Instancia.ObtenerIdiomaSesion() != "Español")
                {
                    Traductor.Instancia.Notificar("Español");
                    Sesion.Instancia.Usuario.Idioma = "Español";
                    MessageBox.Show(Traducir("MsgCambioIdiomaOK"));
                }
                else { MessageBox.Show(Traducir("MsgMismoIdioma")); }
            }
            else { MessageBox.Show(Traducir("MsgIdiomaCancelado")); }
        }
        private void inglesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Confirmacion = MessageBox.Show(Traducir("MsgIdioma"), "", MessageBoxButtons.YesNo);
            if (Confirmacion == DialogResult.Yes)
            {
                if (Sesion.Instancia.ObtenerIdiomaSesion() != "Ingles")
                {
                    Traductor.Instancia.Notificar("Ingles");
                    Sesion.Instancia.Usuario.Idioma = "Ingles";
                    MessageBox.Show(Traducir("MsgCambioIdiomaOK"));
                }
                else { MessageBox.Show(Traducir("MsgMismoIdioma")); }
            }
            else { MessageBox.Show(Traducir("MsgIdiomaCancelado")); }
        }
        private void francésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Confirmacion = MessageBox.Show(Traducir("MsgIdioma"), "", MessageBoxButtons.YesNo);
            if (Confirmacion == DialogResult.Yes)
            {
                if (Sesion.Instancia.ObtenerIdiomaSesion() != "Francés")
                {
                    Traductor.Instancia.Notificar("Francés");
                    Sesion.Instancia.Usuario.Idioma = "Francés";
                    MessageBox.Show(Traducir("MsgCambioIdiomaOK"));
                }
                else { MessageBox.Show(Traducir("MsgMismoIdioma")); }
            }
            else { MessageBox.Show(Traducir("MsgIdiomaCancelado")); }
        }
        private void alemánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Confirmacion = MessageBox.Show(Traducir("MsgIdioma"), "", MessageBoxButtons.YesNo);
            if (Confirmacion == DialogResult.Yes)
            {
                if (Sesion.Instancia.ObtenerIdiomaSesion() != "Alemán")
                {
                    Traductor.Instancia.Notificar("Alemán");
                    Sesion.Instancia.Usuario.Idioma = "Alemán";
                    MessageBox.Show(Traducir("MsgCambioIdiomaOK"));
                }
                else { MessageBox.Show(Traducir("MsgMismoIdioma")); }
            }
            else { MessageBox.Show(Traducir("MsgIdiomaCancelado")); }
        }
        private void portuguesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Confirmacion = MessageBox.Show(Traducir("MsgIdioma"), "", MessageBoxButtons.YesNo);
            if (Confirmacion == DialogResult.Yes)
            {
                if (Sesion.Instancia.ObtenerIdiomaSesion() != "Portugués")
                {
                    Traductor.Instancia.Notificar("Portugués");
                    Sesion.Instancia.Usuario.Idioma = "Portugués";
                    MessageBox.Show(Traducir("MsgCambioIdiomaOK"));
                }
                else { MessageBox.Show(Traducir("MsgMismoIdioma")); }
            }
            else { MessageBox.Show(Traducir("MsgIdiomaCancelado")); }
        }
        #endregion
        
    }
}