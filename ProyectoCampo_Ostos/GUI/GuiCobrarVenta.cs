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

namespace GUI
{
    public partial class GuiCobrarVenta : Form, IObserver
    {
        public GuiCobrarVenta()
        {
            InitializeComponent();            
        }
        private void GuiCobrarVenta_Load(object sender, EventArgs e)
        {
            Traductor.Instancia.Suscribir(this);
            Traductor.Instancia.Notificar(Sesion.Instancia.Usuario.Idioma);
            ActualizarIdioma();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) MessageBox.Show(Traducir("MsgGrillaVacia"));
            else
            {
                DataGridViewRow UltimaFila = dataGridView1.Rows[dataGridView1.Rows.Count - 1];
                if (dataGridView1.Rows.Count > 0)
                {
                    if(!(radioButtonEfectivo.Checked || radioButtonTarjeta.Checked))
                    {
                        MessageBox.Show("Debe seleccionar un método de pago");
                    }
                    else
                    {
                        if (radioButtonEfectivo.Checked == true)
                        {
                            if (string.IsNullOrWhiteSpace(textBox2.Text)) MessageBox.Show(Traducir("MsgMontoNulo"));
                            else
                            {
                                if (int.Parse(textBox2.Text) >= int.Parse(UltimaFila.Cells[UltimaFila.Cells.Count - 1].Value.ToString()))
                                {
                                    DialogResult Confirmacion = MessageBox.Show(Traducir("MsgConfirmarCobro"), "", MessageBoxButtons.YesNo);
                                    if (Confirmacion == DialogResult.Yes)
                                    {
                                        GestorCarrito.Instancia.CobrarVenta();
                                        GestorCarrito.Instancia.BorrarCarrito();
                                        MostrarCarrito();
                                        MessageBox.Show(Traducir("MsgCobroOK"));
                                    }
                                    else if (Confirmacion == DialogResult.No)
                                    {
                                        MessageBox.Show(Traducir("MsgCobroCancelado"));
                                    }
                                }
                                else
                                {
                                    MessageBox.Show(Traducir("MsgMontoInsuficiente"));
                                }
                            }
                        }
                        else if (radioButtonTarjeta.Checked == true)
                        {
                            if (string.IsNullOrWhiteSpace(cbTipoTarjeta.Text) || string.IsNullOrWhiteSpace(tbNumTarjeta.Text) || string.IsNullOrWhiteSpace(tbFechaVencimiento.Text) || string.IsNullOrWhiteSpace(tbCodSeguridad.Text))
                            {
                                MessageBox.Show(Traducir("MsgTarjetaNula"));
                            }
                            else
                            {
                                DialogResult Confirmacion = MessageBox.Show(Traducir("MsgConfirmarCobro"), "", MessageBoxButtons.YesNo);
                                if (Confirmacion == DialogResult.Yes)
                                {
                                    GestorCarrito.Instancia.CobrarVenta();
                                    GestorCarrito.Instancia.BorrarCarrito();
                                    MostrarCarrito();
                                    MessageBox.Show(Traducir("MsgCobroOK"));
                                }
                                else if (Confirmacion == DialogResult.No)
                                {
                                    MessageBox.Show(Traducir("MsgCobroCancelado"));
                                }
                            }
                        }
                    }                    
                }
                else
                {
                    MessageBox.Show(Traducir("MsgGrillaVacia"));
                }
            } 
        }        
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show(Traducir("MsgDniNulo"));
            }
            else
            {
                int dniCliente = int.Parse(textBox1.Text);
                Carrito carrito = GestorCarrito.Instancia.BuscarCarritoPorDNI(dniCliente);
                if (carrito != null)
                {
                    MostrarProductos(carrito.productosCarrito);
                    string T1 = Traducir("label1");
                    label1.Text = T1.Replace("{cliente}", $"{carrito.Duenio.Nombre} {carrito.Duenio.Apellido}").ToUpper();
                }
                else
                {
                    MessageBox.Show(Traducir($"MsgBusquedaCarrito"));
                }
            }
        }                
        private void btnSalirVenta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        #region Funciones
        private void MostrarProductos(List<Producto> productos)
        {
            int precioTotal = 0;
            int subtotal = 0;
            dataGridView1.Rows.Clear();
            foreach (Producto producto in productos)
            {
                subtotal = producto.Precio * producto.CantidadEnCarrito;
                precioTotal += subtotal;
                dataGridView1.Rows.Add(producto.Codigo, producto.Nombre, producto.Tipo, producto.Precio, producto.CantidadEnCarrito, subtotal, "");
            }
            dataGridView1.Rows.Add("","","","","", "", precioTotal);
        }
        private void MostrarCarrito()
        {
            dataGridView1.Rows.Clear();
            foreach (var producto in GestorCarrito.Instancia.ObtenerProductos())
            {
                dataGridView1.Rows.Add(producto.Codigo, producto.Nombre, producto.Tipo, producto.Precio, producto.CantidadEnCarrito);
            }
        }
        #endregion

        #region Idiomas
        private void TraducirDGV()
        {
            dataGridView1.Columns[0].HeaderText = Traductor.Instancia.Traducir("Carrito_CodProd");
            dataGridView1.Columns[1].HeaderText = Traductor.Instancia.Traducir("Carrito_NombreProd");
            dataGridView1.Columns[2].HeaderText = Traductor.Instancia.Traducir("Carrito_TipoProd");
            dataGridView1.Columns[3].HeaderText = Traductor.Instancia.Traducir("Carrito_PrecioProd");
            dataGridView1.Columns[4].HeaderText = Traductor.Instancia.Traducir("Carrito_CantProd");
            dataGridView1.Columns[5].HeaderText = Traductor.Instancia.Traducir("Carrito_Subtotal");
            dataGridView1.Columns[6].HeaderText = Traductor.Instancia.Traducir("Carrito_PrecioTotal");
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
                        if (c.GetType() == typeof(RadioButton))
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

        #region TextBox 
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (tbNumTarjeta.Text.Length > 16)
            {
                
                tbNumTarjeta.Text = tbNumTarjeta.Text.Substring(0, 16);
                tbNumTarjeta.SelectionStart = tbNumTarjeta.Text.Length;
            }
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (tbCodSeguridad.Text.Length > 3)
            {
                tbCodSeguridad.Text = tbCodSeguridad.Text.Substring(0, 3);
                tbCodSeguridad.SelectionStart = tbCodSeguridad.Text.Length;
            }
        }
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {            
            if (tbFechaVencimiento.Text.Length > 5)
            {
                tbFechaVencimiento.Text = tbFechaVencimiento.Text.Substring(0, 5);
                tbFechaVencimiento.SelectionStart = tbFechaVencimiento.Text.Length;
            }         
            if (tbFechaVencimiento.Text.Length == 2 && !tbFechaVencimiento.Text.Contains("/"))
            {
                tbFechaVencimiento.Text = tbFechaVencimiento.Text + "/";
                tbFechaVencimiento.SelectionStart = tbFechaVencimiento.Text.Length;
            }
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '/' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
               
        private void rbNumTarjeta_Click(object sender, EventArgs e)
        {
            string num = Encriptado.InstanceEncriptado.EncriptacionReversible(tbNumTarjeta.Text); 
            if (rbNumTarjeta.Checked)
            {
                MessageBox.Show($"Numero tarjeta encriptado: {num}" + Environment.NewLine +
                                $"Numero tarjeta desencriptado: {Encriptado.InstanceEncriptado.DesencriptacionReversible(num)}");
                rbNumTarjeta.Checked = false;
            }
        }

        private void rbCodigoSeguridad_Click(object sender, EventArgs e)
        {
            string num = Encriptado.InstanceEncriptado.EncriptacionReversible(tbCodSeguridad.Text);
            if (rbCodigoSeguridad.Checked)
            {
                MessageBox.Show($"Código de seguridad encriptado: {num}" + Environment.NewLine +
                                $"Código de seguridad desencriptado: {Encriptado.InstanceEncriptado.DesencriptacionReversible(num)}");
                rbCodigoSeguridad.Checked = false;
            }
        }
        #endregion

    }
}
