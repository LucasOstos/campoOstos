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
    public partial class GuiAgregarProducto : Form, IObserver
    {        
        public GuiAgregarProducto()
        {
            InitializeComponent();            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Traductor.Instancia.Suscribir(this);
            ActualizarIdioma();
        }

        #region Funciones
        private void MostrarProductosPorTipo(string Tipo)
        {
            dgvProductos.Rows.Clear();
            List<Producto> productos = GestorProducto.Instancia.BuscarProductosPorTipo(Tipo);
            if(productos.Count > 0)
            {
                foreach (Producto P in productos)
                {
                    dgvProductos.Rows.Add(P.Codigo, P.Nombre, P.Marca, P.Tipo, P.Cantidad, P.Precio);
                }
            }
            else { }
        }
        private void MostrarProductoPorNombre(string nombre)
        {
            dgvProductos.Rows.Clear();
            Producto p = GestorProducto.Instancia.BuscarProductoPorNombre(nombre);
            if (p != null)
            {
                dgvProductos.Rows.Add(p.Codigo, p.Nombre, p.Marca, p.Tipo, p.Cantidad, p.Precio);
            }
            else { }
        }
        public void MostrarCarrito()
        {
            Carrito.Items.Clear();
            List<Producto> productosCarrito = GestorCarrito.Instancia.ObtenerProductos();
            foreach(var prod in productosCarrito)
            {
                Carrito.Items.Add($"{prod.Codigo} - {prod.Nombre} - {prod.Precio} - {Traducir("Cantidad")}: {prod.CantidadEnCarrito}");
            }
        }
        #endregion
       
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count > 0)
            {
                if(GestorCarrito.Instancia.carrito.Duenio != null)
                {
                    int codigo = int.Parse(dgvProductos.SelectedRows[0].Cells[0].Value.ToString());
                    Producto producto = GestorProducto.Instancia.ObtenerProducto(codigo);
                    producto.CantidadEnCarrito = 1;
                    GestorCarrito.Instancia.AgregarProductoCarrito(producto);
                    MostrarCarrito();
                }
                else { MessageBox.Show(Traducir("MsgCarritoNoAsignado")); }
            }
            else
            {
                MessageBox.Show(Traducir("MsgProductoCarrito"));
            }
        }

        private void btnFinBusqueda_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Traducir("MsgBusquedaFinalizada"));
            tbTipoProducto.Clear();
            dgvProductos.Rows.Clear();
            Carrito.Items.Clear();
            this.Close();
        }

        #region Idiomas
        private void TraducirDGV()
        {
            dgvProductos.Columns[0].HeaderText = Traductor.Instancia.Traducir("Prod_Codigo");
            dgvProductos.Columns[1].HeaderText = Traductor.Instancia.Traducir("Prod_Nombre");
            dgvProductos.Columns[2].HeaderText = Traductor.Instancia.Traducir("Prod_Marca");
            dgvProductos.Columns[3].HeaderText = Traductor.Instancia.Traducir("Prod_Tipo");
            dgvProductos.Columns[4].HeaderText = Traductor.Instancia.Traducir("Prod_Cantidad");
            dgvProductos.Columns[5].HeaderText = Traductor.Instancia.Traducir("Prod_Precio");
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

        private void tbTipoProducto_TextChanged(object sender, EventArgs e)
        {
            if(rbNombreProducto.Checked)
            {
                string nombre = tbTipoProducto.Text;
                MostrarProductoPorNombre(nombre);
            }
            else if(rbTipoProducto.Checked)
            {
                string nombre = tbTipoProducto.Text;
                MostrarProductosPorTipo(nombre);
            }
        }
    }
}
