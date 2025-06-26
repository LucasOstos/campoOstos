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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GuiGestionUsuarios : Form, IObserver
    {
        public GuiGestionUsuarios()
        {
            InitializeComponent();
        }
        private void GuiGestionUsuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
            AplicarCambios.Enabled = false;
            CancelarCambios.Enabled = false;
            DesbloquearUsuario.Enabled = false;
            TraducirDGV();
            CargarRoles();
        }

        #region Funciones
        private void LimpiarTextBox()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            cbRoles.Text = "";
        }
        private void BloquearTextBox()
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            cbRoles.Enabled = false;
        }
        private void DesbloquearTextBox()
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            cbRoles.Enabled = true;
        }
        public void MostrarBloqueados()
        {
            dgvUsuarios.Rows.Clear();
            if (GestorUsuario.Instancia.ReturnBloqueados().Count() > 0)
            {
                foreach (Usuario U in GestorUsuario.Instancia.ReturnBloqueados())
                {
                    dgvUsuarios.Rows.Add(U.DNI, U.Apellido, U.Nombre, U.Email, U.Tipo, U.IsHabilitado, U.cambioContrasenia, U.ultimoLogin);
                }
            }
        }
        public void MostrarUsuarios()
        {
            dgvUsuarios.Rows.Clear();
            if(GestorUsuario.Instancia.ReturnUsuarios().Count() > 0)
            {
                foreach(Usuario U in GestorUsuario.Instancia.ReturnUsuarios())
                {
                    dgvUsuarios.Rows.Add(U.DNI, U.Apellido, U.Nombre, U.Email, U.Tipo, U.IsHabilitado, U.cambioContrasenia, U.ultimoLogin);
                }
            }
        }
        private void CargarRoles()
        {            
            cbRoles.Items.Clear();
            cbRoles.DisplayMember = "Nombre";
            foreach (Permiso P in GestorPermiso.Instancia.Perfiles())
            {
                cbRoles.Items.Add(P);
            }
        }
        public bool EsEmailValido(string email)
        {
            string patronEmail = @"^[a-zA-Z0-9._%+-]+@(gmail|hotmail|outlook|yahoo)\.com$";
            return Regex.IsMatch(email, patronEmail);
        }
        private bool UsuarioDuplicado(int pDNI)
        {
            return GestorUsuario.Instancia.ReturnUsuarios().Exists(x => x.DNI == pDNI);
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                if (!UsuarioDuplicado(int.Parse(textBox1.Text)))
                {
                    if (!string.IsNullOrWhiteSpace(textBox3.Text))
                    {
                        if (!string.IsNullOrWhiteSpace(textBox2.Text))
                        {
                            if(EsEmailValido(textBox4.Text))
                            {
                                if(!string.IsNullOrWhiteSpace(cbRoles.Text))
                                {
                                    Usuario pUsuario = new Usuario();
                                    pUsuario.DNI = int.Parse(textBox1.Text);
                                    pUsuario.Apellido = textBox2.Text;
                                    pUsuario.Nombre = textBox3.Text;
                                    pUsuario.Email = textBox4.Text;
                                    pUsuario.Contraseña = Encriptado.InstanceEncriptado.EncriptarContraseña($"{pUsuario.DNI}{pUsuario.Apellido}");
                                    pUsuario.Tipo = cbRoles.Text;
                                    pUsuario.IsHabilitado = true;
                                    pUsuario.Estado = false;
                                    pUsuario.Intentos = 0;
                                    pUsuario.cambioContrasenia = false;
                                    pUsuario.ultimoLogin = DateTime.Now;
                                    DialogResult Confirmacion = MessageBox.Show(Traducir("MsgConfirmarUsuario"), "", MessageBoxButtons.YesNo);
                                    if (Confirmacion == DialogResult.Yes)
                                    {
                                        GestorUsuario.Instancia.AgregarUsuario(pUsuario);
                                        LimpiarTextBox();
                                        MessageBox.Show(Traducir("MsgUsuarioOK"));
                                        MostrarUsuarios();
                                    }
                                    else if (Confirmacion == DialogResult.No)
                                    {
                                        LimpiarTextBox();
                                        MostrarUsuarios();
                                    }
                                }
                                else { MessageBox.Show("Debe elegir un rol"); }
                            }
                            else { MessageBox.Show(Traducir("MsgFormatoEmail")); }
                        }
                        else { MessageBox.Show("El apellido no puede estar vacio"); }
                    }
                    else { MessageBox.Show("El nombre no puede estar vacio"); }
                }
                else
                {
                    MessageBox.Show("El usuario ya existe");
                }
            }
            else
            {
                MessageBox.Show("El DNI no puede estar vacío");
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsuarios.SelectedRows.Count == 0) throw new Exception(Traducir("MsgUsuarioNulo"));
                int pDNI = int.Parse(dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString());
                GestorUsuario.Instancia.BorrarUsuario(pDNI);
                LimpiarTextBox();
                MostrarUsuarios();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            AniadirUsuario.Enabled = false;
            BorrarUsuario.Enabled = false;
            btnCambiarEstado.Enabled = false;
            DesbloquearUsuario.Enabled = false;
            AplicarCambios.Enabled = true;
            CancelarCambios.Enabled = true;
        }
        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            if(dgvUsuarios.SelectedRows.Count > 0)
            {
                string pEmail = dgvUsuarios.SelectedRows[0].Cells[3].Value.ToString();
                GestorUsuario.Instancia.CambiarEstado(pEmail);
                MostrarUsuarios();
            }
            else { MessageBox.Show("Debe seleccionar un usuario"); }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            AplicarCambios.Enabled = true;
            CancelarCambios.Enabled = true;
            Salir.Enabled = false;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButtonBloqueados.Checked == true)
            {
                if (dgvUsuarios.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un usuario");
                }
                else
                {
                    int dniBloqueado = int.Parse(dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString());
                    Usuario usuarioBloqueado = GestorUsuario.Instancia.ReturnUsuarios().Find(x => x.DNI == dniBloqueado);
                    if (usuarioBloqueado.Estado == true)
                    {
                        usuarioBloqueado.Estado = false;
                        usuarioBloqueado.Contraseña = Encriptado.InstanceEncriptado.EncriptarContraseña($"{usuarioBloqueado.DNI}{usuarioBloqueado.Apellido}");
                        usuarioBloqueado.Intentos = 0;
                        GestorUsuario.Instancia.DesbloquearUsuario(usuarioBloqueado);
                        MessageBox.Show(Traducir("MsgUsuarioDesbloqueado"));
                        LimpiarTextBox();
                    }
                }                
            }
            else
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(cbRoles.Text))
                {
                    MessageBox.Show(Traducir("MsgCamposVacios"));
                }
                else
                {
                    Usuario Usuario = new Usuario();
                    Usuario.DNI = int.Parse(textBox1.Text);
                    Usuario.Apellido = textBox2.Text;
                    Usuario.Nombre = textBox3.Text;
                    Usuario.Email = textBox4.Text;
                    Usuario.Tipo = cbRoles.Text;
                    GestorUsuario.Instancia.ModificarUsuario((int)dgvUsuarios.SelectedRows[0].Cells[0].Value, Usuario);
                    MostrarUsuarios();
                    MessageBox.Show(Traducir("MsgUsuarioModificado"));
                    LimpiarTextBox();
                    textBox1.Enabled = true;
                    AniadirUsuario.Enabled = true;
                    BorrarUsuario.Enabled = true;
                    btnCambiarEstado.Enabled = true;
                    DesbloquearUsuario.Enabled = false;
                    AplicarCambios.Enabled = false;
                    CancelarCambios.Enabled = false;
                }
            }   
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if(radioButtonTodos.Checked)
            {
                textBox1.Enabled = true;
                AniadirUsuario.Enabled = true;
                BorrarUsuario.Enabled = true;
                btnCambiarEstado.Enabled = true;
                DesbloquearUsuario.Enabled = false;
                AplicarCambios.Enabled = false;
                CancelarCambios.Enabled = false;
                LimpiarTextBox();
            }
            else if(radioButtonBloqueados.Checked)
            {
                AplicarCambios.Enabled = false;
                CancelarCambios.Enabled = false;
                Salir.Enabled = true;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Eventos
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                textBox1.Text = dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dgvUsuarios.SelectedRows[0].Cells[1].Value.ToString();
                textBox3.Text = dgvUsuarios.SelectedRows[0].Cells[2].Value.ToString();
                textBox4.Text = dgvUsuarios.SelectedRows[0].Cells[3].Value.ToString();
                cbRoles.Text = dgvUsuarios.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch{ }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBloqueados.Checked)
            {
                MostrarBloqueados();
                BloquearTextBox();
                LimpiarTextBox();
                AniadirUsuario.Enabled = false;
                BorrarUsuario.Enabled = false;
                ModificarUsuario.Enabled = false;
                btnCambiarEstado.Enabled = false;
                DesbloquearUsuario.Enabled = true;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonTodos.Checked)
            {
                AniadirUsuario.Enabled = true;
                BorrarUsuario.Enabled = true;
                ModificarUsuario.Enabled = true;
                btnCambiarEstado.Enabled = true;
                DesbloquearUsuario.Enabled = false;
                AplicarCambios.Enabled = false;
                CancelarCambios.Enabled = false;
                Salir.Enabled = true;
                MostrarUsuarios();
                DesbloquearTextBox();
                LimpiarTextBox();
            } 
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        #endregion
        
        #region Idiomas
        private void TraducirDGV()
        {
            dgvUsuarios.Columns[0].HeaderText = Traductor.Instancia.Traducir("Usuario_DNI");
            dgvUsuarios.Columns[1].HeaderText = Traductor.Instancia.Traducir("Usuario_Apellido");
            dgvUsuarios.Columns[2].HeaderText = Traductor.Instancia.Traducir("Usuario_Nombre");
            dgvUsuarios.Columns[3].HeaderText = Traductor.Instancia.Traducir("Usuario_Email");
            dgvUsuarios.Columns[4].HeaderText = Traductor.Instancia.Traducir("Usuario_Rol");            
            dgvUsuarios.Columns[5].HeaderText = Traductor.Instancia.Traducir("Usuario_Habilitado");
            dgvUsuarios.Columns[6].HeaderText = Traductor.Instancia.Traducir("Usuario_Cambio");
            dgvUsuarios.Columns[7].HeaderText = Traductor.Instancia.Traducir("Usuario_UltimoLogin");
        }
        public void ActualizarIdioma()
        {
            TraducirFormulario();
        }
        private void TraducirFormulario()
        {
            foreach (Control c in Controls)
            {
                if(c.GetType() != typeof(ComboBox))
                {
                    if (c.GetType() != typeof(TextBox))
                    {
                        if (c.GetType() != typeof(Label))
                        {
                            if (c.GetType() == typeof(Button))
                            {
                                c.Text = Traducir(c.Name);
                            }
                            if (c.GetType() == typeof(RadioButton))
                            {
                                c.Text = Traducir(c.Name);
                            }
                        }
                        c.Text = Traducir(c.Name);
                    }
                }           
            }
            TraducirDGV(); 
        }
        private string Traducir(string paraTraducir)
        {
            return Traductor.Instancia.Traducir(paraTraducir);
        }
        #endregion

    }
}