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
            Traductor.Instancia.Suscribir(this);
            Traductor.Instancia.Notificar(Sesion.Instancia.Usuario.Idioma);
            ActualizarIdioma();
            Vista();
        }
        #region Funciones        
        /*private void SuscribirFormularios()
        {            
            Traductor.Instancia.Suscribir(GestorFormulario.Instancia.GetGuiAsignar());
            Traductor.Instancia.Suscribir(GestorFormulario.Instancia.GetGuiFactura());
            Traductor.Instancia.Suscribir(GestorFormulario.Instancia.GetGuiPermisos());
            Traductor.Instancia.Suscribir(GestorFormulario.Instancia.GetGuiContrasenia());
        }*/
        public void Vista()
        {
            if(Sesion.Instancia.Usuario.Tipo == "Vendedor")
            {
                adminMenu.Visible = false;
            }
            else if(Sesion.Instancia.Usuario.Tipo == "Cajero")
            {
                adminMenu.Visible = false;
            }
            else
            {

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
            TraducirFormulario();
            TraducirLabels();
        }
        private void TraducirFormulario()
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
        }
        private void TraducirLabels()
        {
            string T1 = Traducir("labelUsuario");
            string T2 = Traducir("labelRol");
            labelSesion.Text = T1.Replace("{usuario}", $"{Sesion.Instancia.Usuario.Nombre} {Sesion.Instancia.Usuario.Apellido}") + Environment.NewLine +
                          T2.Replace("{rol}", Sesion.Instancia.Usuario.Tipo);
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
                Traductor.Instancia.Notificar("Español");
                MessageBox.Show("Idioma cambiado correctamente");
            }
            else { MessageBox.Show(Traducir("MsgIdiomaCancelado")); }
        }
        private void inglesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Confirmacion = MessageBox.Show(Traducir("MsgIdioma"), "", MessageBoxButtons.YesNo);
            if (Confirmacion == DialogResult.Yes)
            {
                Traductor.Instancia.Notificar("Ingles");
            }
            else { MessageBox.Show(Traducir("MsgIdiomaCancelado")); }
        }
        private void francésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Confirmacion = MessageBox.Show(Traducir("MsgIdioma"), "", MessageBoxButtons.YesNo);
            if (Confirmacion == DialogResult.Yes)
            {
                Traductor.Instancia.Notificar("Francés");
            }
            else { MessageBox.Show(Traducir("MsgIdiomaCancelado")); }
        }
        private void alemánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Confirmacion = MessageBox.Show(Traducir("MsgIdioma"), "", MessageBoxButtons.YesNo);
            if (Confirmacion == DialogResult.Yes)
            {
                Traductor.Instancia.Notificar("Alemán");
            }
            else { MessageBox.Show(Traducir("MsgIdiomaCancelado")); }
        }
        private void portuguesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Confirmacion = MessageBox.Show(Traducir("MsgIdioma"), "", MessageBoxButtons.YesNo);
            if (Confirmacion == DialogResult.Yes)
            {
                Traductor.Instancia.Notificar("Portugués");
            }
            else { MessageBox.Show(Traducir("MsgIdiomaCancelado")); }
        }
        #endregion
        
    }
}