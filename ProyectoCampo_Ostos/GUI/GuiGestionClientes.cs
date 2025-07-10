using BE;
using BLL;
using SERVICIOS;
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
    public partial class GuiGestionClientes : Form, IObserver
    {
        public GuiGestionClientes()
        {
            InitializeComponent();            
        }
        private void GuiGestionClientes_Load(object sender, EventArgs e)
        {
            Traductor.Instancia.Suscribir(this);
            Traductor.Instancia.Notificar(Sesion.Instancia.Usuario.Idioma);
            MostrarClientes();
            ActualizarIdioma();
        }

        #region Funciones
        public void MostrarClientes()
        {
            dataGridView1.Rows.Clear();
            if (GestorCliente.Instancia.ObtenerClientes().Count() > 0)
            {
                foreach (Cliente C in GestorCliente.Instancia.ObtenerClientes())
                {
                    dataGridView1.Rows.Add(C.DNI, C.Nombre,C.Apellido,C.Celular, C.Email);
                }
            }
        }
        public void LimpiarTextBox()
        {
            tbDniCliente.Text = "";
            tbNombreCliente.Text = "";
            tbApellidoCliente.Text = "";
            tbCelularCliente.Text = "";
            tbEmailCliente.Text = "";
        }
        public bool EsEmailValido(string email)
        {
            string patronEmail = @"^[a-zA-Z0-9._%+-]+@(gmail|hotmail|outlook|yahoo)\.com$";
            return Regex.IsMatch(email, patronEmail);
        }
        public bool ClienteDuplicado(int pDNI)
        {
            return GestorCliente.Instancia.ObtenerClientes().Exists(x => x.DNI == pDNI);
        }
        #endregion

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbDniCliente.Text))
            {
                if (!ClienteDuplicado(int.Parse(tbDniCliente.Text)))
                {
                    if(!(tbDniCliente.Text.Length < 8))
                    {
                        if (!string.IsNullOrWhiteSpace(tbNombreCliente.Text))
                        {
                            if (!string.IsNullOrWhiteSpace(tbApellidoCliente.Text))
                            {
                                if (!string.IsNullOrWhiteSpace(tbCelularCliente.Text))
                                {
                                    if (!string.IsNullOrWhiteSpace(tbEmailCliente.Text) && EsEmailValido(tbEmailCliente.Text))
                                    {
                                        Cliente nuevoCliente = new Cliente(int.Parse(tbDniCliente.Text), tbNombreCliente.Text, tbApellidoCliente.Text, int.Parse(tbCelularCliente.Text), tbEmailCliente.Text);
                                        DialogResult Confirmacion = MessageBox.Show(Traducir("MsgConfirmacionCliente"), "", MessageBoxButtons.YesNo);
                                        if (Confirmacion == DialogResult.Yes)
                                        {                                            
                                            GestorCliente.Instancia.AltaCliente(nuevoCliente);
                                            MostrarClientes();
                                            LimpiarTextBox();
                                            MessageBox.Show(Traducir("MsgClienteOK"));
                                        }
                                        else if (Confirmacion == DialogResult.No)
                                        {
                                            MessageBox.Show(Traducir("MsgRegistroCancelado"));
                                            LimpiarTextBox();
                                        }
                                    }
                                    else { MessageBox.Show(Traducir("MsgFormatoEmail")); }
                                }
                                else { MessageBox.Show(Traducir("MsgCamposVacios")); }
                            }
                            else { MessageBox.Show(Traducir("MsgCamposVacios")); }
                        }
                        else { MessageBox.Show(Traducir("MsgCamposVacios")); }
                    }
                    else { MessageBox.Show(Traducir("MsgDigitos")); }
                }
                else { MessageBox.Show(Traducir("MsgClienteExistente")); }
            }
            else { MessageBox.Show(Traducir("MsgCamposVacios")); }
        }        
        private void button2_Click(object sender, EventArgs e)
        {            
            GestorCliente.Instancia.BajaCliente(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
            MostrarClientes();
            LimpiarTextBox();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbNombreCliente.Text))
            {
                if (!string.IsNullOrWhiteSpace(tbApellidoCliente.Text))
                {
                    if (!string.IsNullOrWhiteSpace(tbCelularCliente.Text))
                    {
                        if (!string.IsNullOrWhiteSpace(tbEmailCliente.Text) && EsEmailValido(tbEmailCliente.Text))
                        {
                            DialogResult Confirmacion = MessageBox.Show(Traducir("MsgSolicitudMod"), "", MessageBoxButtons.YesNo);
                            if (Confirmacion == DialogResult.Yes)
                            {
                                Cliente C = GestorCliente.Instancia.ObtenerClientes().Find(x => x.DNI == int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                                C.Nombre = tbNombreCliente.Text;
                                C.Apellido = tbApellidoCliente.Text;
                                C.Celular = int.Parse(tbCelularCliente.Text);
                                C.Email = tbEmailCliente.Text;
                                GestorCliente.Instancia.ModificarCliente(C);
                                tbDniCliente.Enabled = true;
                                MostrarClientes();
                                LimpiarTextBox();
                            }
                            else if (Confirmacion == DialogResult.No)
                            {
                                MessageBox.Show(Traducir("MsgModClienteCancelada"));
                                tbDniCliente.Enabled = true;
                                LimpiarTextBox();
                            }
                        }
                        else { MessageBox.Show(Traducir("MsgFormatoEmail")); }
                    }
                    else { MessageBox.Show(Traducir("MsgCamposVacios")); }
                }
                else { MessageBox.Show(Traducir("MsgCamposVacios")); }
            }
            else { MessageBox.Show(Traducir("MsgCamposVacios")); }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Eventos
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbDniCliente.Enabled = false;
            tbDniCliente.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            tbNombreCliente.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            tbApellidoCliente.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            tbCelularCliente.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();            
            tbEmailCliente.Text = Encriptado.InstanceEncriptado.DesencriptacionReversible(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
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
            dataGridView1.Columns[0].HeaderText = Traductor.Instancia.Traducir("Cliente_DNI");
            dataGridView1.Columns[1].HeaderText = Traductor.Instancia.Traducir("Cliente_Nombre");
            dataGridView1.Columns[2].HeaderText = Traductor.Instancia.Traducir("Cliente_Apellido");
            dataGridView1.Columns[3].HeaderText = Traductor.Instancia.Traducir("Cliente_Celular");
            dataGridView1.Columns[4].HeaderText = Traductor.Instancia.Traducir("Cliente_Email");
        }
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
            TraducirDGV();
        }        
        private string Traducir(string paraTraducir)
        {
            return Traductor.Instancia.Traducir(paraTraducir);
        }
        #endregion

    }
}
