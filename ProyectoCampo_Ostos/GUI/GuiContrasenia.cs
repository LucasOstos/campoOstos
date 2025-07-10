using BLL;
using Microsoft.VisualBasic;
using SERVICIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GuiContrasenia : Form, IObserver
    {
        public GuiContrasenia()
        {
            InitializeComponent();
        }
        private void GuiContrasenia_Load(object sender, EventArgs e)
        {
            Traductor.Instancia.Suscribir(this);
            Traductor.Instancia.Notificar(Sesion.Instancia.Usuario.Idioma);
        }
        private void btnContrasenia_Click(object sender, EventArgs e)
        {
            string Contrasenia = textBox1.Text;
            string Confirmacion = textBox2.Text;
            if(string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show(Traducir("MsgTextVacio"));
            }
            else
            {
                if(Encriptado.InstanceEncriptado.EncriptarContraseña(textBox3.Text) == Sesion.Instancia.Usuario.Contraseña)
                {
                    if (Encriptado.InstanceEncriptado.EncriptarContraseña(textBox3.Text) == Encriptado.InstanceEncriptado.EncriptarContraseña(textBox1.Text))
                    {
                        MessageBox.Show(Traducir("MsgNuevaIgualAnterior"));
                    }
                    else
                    {
                        if (Confirmacion == Contrasenia)
                        {
                            Sesion.Instancia.Usuario.Contraseña = Encriptado.InstanceEncriptado.EncriptarContraseña(Confirmacion);
                            Sesion.Instancia.Usuario.cambioContrasenia = true;
                            GestorUsuario.Instancia.CambiarContraseña(Sesion.Instancia.Usuario.DNI, Sesion.Instancia.Usuario);
                            Sesion.Instancia.LogOut();
                            this.Hide();
                            MessageBox.Show(Traducir("MsgContraseñaOK"));
                            InterfazInicioSesion guiLogin = new InterfazInicioSesion();
                            guiLogin.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(Traducir("MsgContrasDiferentes"));
                        }
                    }
                }
                else { MessageBox.Show(Traducir("MsgContraseñaNoActual")); }
            }
        }
        private void btnSalirContrasenia_Click(object sender, EventArgs e)
        {
            if(Sesion.Instancia.Usuario.cambioContrasenia == false)
            {
                Sesion.Instancia.LogOut();
                this.Hide();
                InterfazInicioSesion guiLogin = new InterfazInicioSesion();
                guiLogin.ShowDialog();
                this.Close();
            }
            else if(Sesion.Instancia.Usuario.cambioContrasenia == true)
            {
                this.Hide();
                GuiPantallaPrincipal formPrincipal = new GuiPantallaPrincipal();
                formPrincipal.ShowDialog();
                this.Close();
            }
            
        }

        #region Idiomas
        public void ActualizarIdioma()
        {
            foreach (Control c in Controls)
            {
                if (c.GetType() != typeof(TextBox))
                {
                    if (c.GetType() != typeof(Label))
                    {
                        if (c.GetType() == typeof(Button))
                        {
                            c.Text = Traducir(c.Name);
                        }

                    }
                    c.Text = Traducir(c.Name);
                }
            }
        }
        private string Traducir(string paraTraducir)
        {
            return Traductor.Instancia.Traducir(paraTraducir);
        }
        #endregion

    }
}
