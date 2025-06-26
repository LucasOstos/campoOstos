using BE;
using BLL;
using SERVICIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GuiFactura : Form, IObserver
    {
        private Reporte pdfGenerator = new Reporte();
        public GuiFactura()
        {
            InitializeComponent();
        }
        private void GuiFactura_Load(object sender, EventArgs e) { }
        
        private void btnCargarFactura_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbFacturaDNI.Text))
            {
                if(GestorCarrito.Instancia.BuscarCarritoPorDNI(int.Parse(tbFacturaDNI.Text)) != null)
                {
                    GestorFactura.Instancia.CargarFactura(int.Parse(tbFacturaDNI.Text), dgvFactura, labelDatosFactura);
                    CargarLabels();
                }
                else { MessageBox.Show("Este cliente no tiene ningún carrito"); }
            }
            else { MessageBox.Show(Traducir("MsgDniNulo")); }            
        }
        
        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            if(dgvFactura.Rows.Count > 0)
            {
                string ruta = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"..\..\..\Reporte\factura.pdf"));
                string rutaImagen = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"..\..\..\LogoEmpresa1.jpeg"));
                Cliente clienteFactura = GestorCliente.Instancia.ObtenerClientes().Find(x => x.DNI == int.Parse(tbFacturaDNI.Text));
                Factura factura = GestorFactura.Instancia.GenerarFactura(clienteFactura);
                pdfGenerator.GenerarFactura(dgvFactura, ruta, rutaImagen, factura);
                GestorFactura.Instancia.GuardarFactura(clienteFactura, factura);
                MessageBox.Show(Traducir("MsgFactura"));
                this.Hide();
                GestorFormulario.Instancia.GetGuiFactura().Close();
                GestorFormulario.Instancia.GetGuiVenta().ShowDialog();
            }
            else { MessageBox.Show("Factura no cargada"); }
        }
        
        private void botonSalirFactura_Click(object sender, EventArgs e)
        {
            GestorFormulario.Instancia.GetGuiFactura().Close();
        }

        #region Funciones
        private void CargarLabels()
        {
            Cliente clienteFactura = GestorCliente.Instancia.ObtenerClientes().Find(x => x.DNI == int.Parse(tbFacturaDNI.Text));
            labelFactura_DNICliente.Text += clienteFactura.DNI.ToString();
            labelFactura_NombreCliente.Text += clienteFactura.Nombre;
            labelFactura_ApellidoCliente.Text += clienteFactura.Apellido;
            labelFactura_CelularCliente.Text += clienteFactura.Celular.ToString();
            labelFactura_EmailCliente.Text += Encriptado.InstanceEncriptado.DesencriptacionReversible(clienteFactura.Email);
            labelFactura_FechaEmision.Text += DateTime.Now;            
        }
        #endregion

        #region Idiomas       
        public void ActualizarIdioma()
        {
            TraducirFormulario();
        }
        private void TraducirFormulario()
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

        #region Eventos
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
