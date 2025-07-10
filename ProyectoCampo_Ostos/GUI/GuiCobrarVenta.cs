using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;
using SERVICIOS;

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
                        MessageBox.Show(Traducir("MsgMetodoVacio"));
                    }
                    else
                    {
                        if (radioButtonEfectivo.Checked == true)
                        {
                            if (string.IsNullOrWhiteSpace(textBox2.Text)) MessageBox.Show(Traducir("MsgMontoNulo"));
                            else
                            {
                                if(!textBox2.Text.StartsWith("-"))
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
                                else { MessageBox.Show(Traducir("MsgMontoNegativo")); }
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
                                if(tbNumTarjeta.Text.Length == 16)
                                {
                                    if (tbCodSeguridad.Text.Length == 3)
                                    {
                                        if(FormatoFecha(tbFechaVencimiento.Text))
                                        {
                                            if (FechaVencimientoValida(tbFechaVencimiento.Text))
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
                                            else { MessageBox.Show(Traducir("MsgTarjetaVencida")); }
                                        }
                                        else { MessageBox.Show(Traducir("MsgFormatoFechaInvalido")); }
                                    }
                                    else { MessageBox.Show(Traducir("MsgCodigoSeguridadInvalido")); }
                                }
                                else { MessageBox.Show(Traducir("MsgNumeroTarjetaInvalido")); }
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
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                int dniCliente = int.Parse(textBox1.Text);
                Cliente c = GestorCliente.Instancia.ObtenerClientes().Find(x => x.DNI == dniCliente);
                if(c != null)
                {
                    Carrito carrito = GestorCarrito.Instancia.BuscarCarritoPorDNI(dniCliente);
                    if (carrito != null)
                    {
                        MostrarProductos(carrito.productosCarrito);
                        string T1 = Traducir("label1");
                        label1.Text = T1.Replace("{cliente}", $"{carrito.Duenio.Nombre} {carrito.Duenio.Apellido}").ToUpper();
                    }
                    else { MessageBox.Show(Traducir($"MsgBusquedaCarrito")); }
                }
                else { MessageBox.Show(Traducir("MsgClienteNoRegistrado")); }
            }
            else { MessageBox.Show(Traducir("MsgDniNulo")); }
        }                
        private void btnSalirVenta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        #region Funciones
        private void MostrarProductos(List<Producto> productos)
        {
            if(productos.Count > 0)
            {
                int subtotal = 0;
                dataGridView1.Rows.Clear();
                foreach (Producto producto in productos)
                {
                    subtotal = producto.Precio * producto.CantidadEnCarrito;
                    GestorCarrito.Instancia.carrito.ImporteTotal += subtotal;
                    dataGridView1.Rows.Add(producto.Codigo, producto.Nombre, producto.Tipo, producto.Precio, producto.CantidadEnCarrito, subtotal, "");
                }
                dataGridView1.Rows.Add("", "", "", "", "", "", GestorCarrito.Instancia.carrito.ImporteTotal);
            }
        }
        private void MostrarCarrito()
        {
            dataGridView1.Rows.Clear();
            foreach (var producto in GestorCarrito.Instancia.ObtenerProductos())
            {
                dataGridView1.Rows.Add(producto.Codigo, producto.Nombre, producto.Tipo, producto.Precio, producto.CantidadEnCarrito);
            }
        }
        private bool FormatoFecha(string fecha)
        {
            Regex formatoValido = new Regex(@"^(0[1-9]|1[0-2])\/\d{2}$");
            if (formatoValido.IsMatch(fecha)) return true;
            return false;
        }
        private bool FechaVencimientoValida(string fecha)
        {
            if (DateTime.TryParseExact(fecha, "MM/yy", null, DateTimeStyles.None, out DateTime fechaVencimiento))
            {
                //Esta linea lo que hace es ajustar la fecha ingresada al ultimo dia del mes ingresado. Ej: si ingreso 07/25, la linea de abajo lo ajusta a 31/07/25
                fechaVencimiento = new DateTime(fechaVencimiento.Year, fechaVencimiento.Month, DateTime.DaysInMonth(fechaVencimiento.Year, fechaVencimiento.Month));
                return fechaVencimiento >= DateTime.Today;
            }
            return false;
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
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
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
            if (tbFechaVencimiento.Text.Length >= 2 && !tbFechaVencimiento.Text.Contains("/"))
            {
                tbFechaVencimiento.Text += "/";
                tbFechaVencimiento.SelectionStart = tbFechaVencimiento.Text.Length;
            }
            if (tbFechaVencimiento.Text.Length == 3 && tbFechaVencimiento.Text.Contains("/")) { tbFechaVencimiento.SelectionStart = tbFechaVencimiento.Text.Length; }
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
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
