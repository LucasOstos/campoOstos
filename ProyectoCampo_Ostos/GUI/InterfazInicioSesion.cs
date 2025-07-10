using BE;
using BLL;
using SERVICIOS;
using ServiciosEntidades;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace GUI
{
    public partial class InterfazInicioSesion : Form
    {
        public InterfazInicioSesion()
        {
            InitializeComponent();
        }
        private void InterfazInicioSesion_Load(object sender, EventArgs e)
        {
            textBox1.Text = "lucas.ostos28@gmail.com";
            textBox2.Text = "usuarioMemoria";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(!Sesion.Instancia.IsLogueado())
            {
                Usuario usuarioMemoria = new Usuario(94486458, "Lucas", "Ostos", "lucas.ostos28@gmail.com", "c7ecd535fb00be09869188e3308b61b5108844f39f43e424d5d698930d57aa23", "Administrador General", true, true, 0, true, DateTime.Now, "Español");
                if (textBox1.Text == "lucas.ostos28@gmail.com" && textBox2.Text == "usuarioMemoria")
                {
                    Sesion.Instancia.LogIn(usuarioMemoria);
                    Sesion.Instancia.IdiomaSesion = usuarioMemoria.Idioma;
                    this.Hide();
                    GuiPantallaPrincipal frmPS = new GuiPantallaPrincipal();
                    frmPS.ShowDialog();
                    this.Close();
                }
                else
                {
                    Usuario u = GestorUsuario.Instancia.ObtenerUsuario(textBox1.Text);
                    if (u == null)
                    {
                        MessageBox.Show("El usuario no existe");
                    }
                    else
                    {
                        string contraseña = Encriptado.InstanceEncriptado.EncriptarContraseña(textBox2.Text);
                        if (Sesion.Instancia.Verificar(u.Email, contraseña))
                        {
                            if (u.Estado == false)
                            {
                                if (u.IsHabilitado == true)
                                {
                                    if (u.cambioContrasenia == true)
                                    {
                                        Sesion.Instancia.LogIn(u);                                        
                                        this.Hide();
                                        GuiPantallaPrincipal frmPS = new GuiPantallaPrincipal();
                                        frmPS.ShowDialog();
                                        this.Close();
                                    }
                                    else
                                    {
                                        Sesion.Instancia.LogIn(u);
                                        this.Hide();
                                        GuiContrasenia guiContrasenia = new GuiContrasenia();
                                        guiContrasenia.ShowDialog();
                                        this.Close();
                                    }
                                }
                                else { MessageBox.Show($"El usuario {u.Nombre} {u.Apellido} está deshabilitado"); }
                            }
                            else { MessageBox.Show($"El usuario {u.Nombre} {u.Apellido} está bloqueado"); }
                        }
                        else
                        {
                            u.Intentos++;
                            GestorUsuario.Instancia.Intentos(u.Intentos, u.DNI);
                            if (u.Intentos == 3)
                            {
                                GestorUsuario.Instancia.BloquearUsuario(true, u.DNI);
                            }
                            //MessageBox.Show(Traducir("MsgContraseñaIncorrecta"));
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Ya hay un usuario logueado");
                this.Hide();
                this.Close();
            }                        
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(Sesion.Instancia.IsLogueado())
            {
                MessageBox.Show("Debe cerrar sesión para salir del sistema");
                this.Hide();
                this.Close();
            }
            else
            {
                Application.Exit();
            }
        }
        
        #region Idiomas        
        private void EspanolMenuStrip_Click(object sender, EventArgs e)
        {
            DialogResult Confirmacion = MessageBox.Show("Desea confirmar el cambio de idioma", "", MessageBoxButtons.YesNo);
            if (Confirmacion == DialogResult.Yes)
            {
                Traductor.Instancia.Notificar("Español");
            }
            else { MessageBox.Show(""); }
        }
        private void InglesMenuStrip_Click(object sender, EventArgs e)
        {
            DialogResult Confirmacion = MessageBox.Show("", "", MessageBoxButtons.YesNo);
            if (Confirmacion == DialogResult.Yes)
            {
                Traductor.Instancia.Notificar("Ingles");
            }
            else { MessageBox.Show(""); }
        }
        private void FrancesMenuStrip_Click(object sender, EventArgs e)
        {
            DialogResult Confirmacion = MessageBox.Show("", "", MessageBoxButtons.YesNo);
            if (Confirmacion == DialogResult.Yes)
            {
                Traductor.Instancia.Notificar("Francés");
            }
            else { MessageBox.Show(""); }
        }
        private void AlemanMenuStrip_Click(object sender, EventArgs e)
        {
            DialogResult Confirmacion = MessageBox.Show("", "", MessageBoxButtons.YesNo);
            if (Confirmacion == DialogResult.Yes)
            {
                Traductor.Instancia.Notificar("Alemán");
            }
            else { MessageBox.Show(""); }
        }
        private void PortuguesMenuStrip_Click(object sender, EventArgs e)
        {
            DialogResult Confirmacion = MessageBox.Show("", "", MessageBoxButtons.YesNo);
            if (Confirmacion == DialogResult.Yes)
            {
                Traductor.Instancia.Notificar("Portugués");
            }
            else { MessageBox.Show(""); }
        }

        #endregion

    }
}

