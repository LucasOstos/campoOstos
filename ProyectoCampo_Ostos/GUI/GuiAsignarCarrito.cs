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
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class GuiAsignarCarrito : Form, IObserver
    {
        public GuiAsignarCarrito()
        {
            InitializeComponent();            
        }
        private void GuiAsignarCarrito_Load(object sender, EventArgs e)
        {
            Traductor.Instancia.Suscribir(this);
            Traductor.Instancia.Notificar(Sesion.Instancia.Usuario.Idioma);
            MostrarClientes();
            ActualizarIdioma();
            DeshabilitarTB();
        }
        
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbCodCarrito.Text))
            {
                if (!string.IsNullOrWhiteSpace(tbClienteDNI.Text))
                {
                    if (GestorCarrito.Instancia.carrito.Duenio == null)
                    {
                        int CodCarrito = int.Parse(tbCodCarrito.Text);
                        var Cliente = new Cliente
                        {
                            DNI = int.Parse(tbClienteDNI.Text),
                            Nombre = tbClienteNombre.Text,
                            Apellido = tbClienteApellido.Text,
                            Celular = int.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString()),
                            Email = dataGridView1.SelectedRows[0].Cells[4].Value.ToString()
                        };
                        tbDuenioCarrito.Text = tbClienteNombre.Text;
                        GestorCarrito.Instancia.AsignarCarrito(CodCarrito, Cliente);
                        MessageBox.Show(Traducir("MsgAsignacion"));
                        tbCodCarrito.Enabled = false;
                        
                        this.Close();
                    }
                    else { MessageBox.Show("El carrito ya tiene dueño"); }
                }
                else { MessageBox.Show("Seleccione un cliente"); }
            }
            else { MessageBox.Show(Traducir("MsgCodigoNulo")); }
        }

        private void btnSalirAsignar_Click(object sender, EventArgs e)
        {
            GestorFormulario.Instancia.ObtenerGui().Close();
        }
        
        #region Funciones
        public void MostrarClientes()
        {
            dataGridView1.Rows.Clear();
            if (GestorCliente.Instancia.ObtenerClientes().Count() > 0)
            {
                foreach (Cliente C in GestorCliente.Instancia.ObtenerClientes())
                {
                    dataGridView1.Rows.Add(C.DNI, C.Nombre, C.Apellido, C.Celular, Encriptado.InstanceEncriptado.DesencriptacionReversible(C.Email));
                }
            }
        }
        private void DeshabilitarTB()
        {            
            tbDuenioCarrito.Enabled = false;
            tbClienteDNI.Enabled = false;
            tbClienteNombre.Enabled = false;
            tbClienteApellido.Enabled = false;
            tbClienteCelular.Enabled = false;
            tbClienteEmail.Enabled = false;
        }
        #endregion

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
            TraducirDGV();
        }        
        private void TraducirDGV()
        {
            dataGridView1.Columns[0].HeaderText = Traductor.Instancia.Traducir("Cliente_DNI");
            dataGridView1.Columns[1].HeaderText = Traductor.Instancia.Traducir("Cliente_Nombre");
            dataGridView1.Columns[2].HeaderText = Traductor.Instancia.Traducir("Cliente_Apellido");
            dataGridView1.Columns[3].HeaderText = Traductor.Instancia.Traducir("Cliente_Celular");
            dataGridView1.Columns[4].HeaderText = Traductor.Instancia.Traducir("Cliente_Email");
        }
        private string Traducir(string paraTraducir)
        {
            return Traductor.Instancia.Traducir(paraTraducir);
        }
        #endregion

        #region Eventos
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbClienteDNI.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            tbClienteNombre.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            tbClienteApellido.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            tbClienteCelular.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            tbClienteEmail.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        #endregion

        
    }
}
