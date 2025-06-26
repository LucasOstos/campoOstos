using BE;
using DAL;
using SERVICIOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class GestorFactura
    {
        private static GestorFactura instancia;
        public static GestorFactura Instancia
        {
            get
            {
                if (instancia == null) { instancia = new GestorFactura(); }
                return instancia;
            }
        }
        public Factura GenerarFactura(Cliente cliente)
        {
            Factura factura = new Factura
            {
                NumFactura = LectorDatos.Datos.ObtenerProximoNumeroFactura(),
                FechaEmision = DateTime.Now,
                facturaCliente = cliente,
                detallesFactura = new List<DetalleFactura>(),
                PrecioTotal = 0
            };

            foreach (Producto prod in GestorCarrito.Instancia.ObtenerProductos())
            {
                DetalleFactura detalle = new DetalleFactura
                {
                    Producto = prod,
                    Cantidad = prod.CantidadEnCarrito,
                    PrecioUnitario = prod.Precio
                };
                factura.detallesFactura.Add(detalle);
                factura.PrecioTotal += detalle.Subtotal;
            }
            return factura;
        }
        public void CargarFactura(int pDNI, DataGridView dgv, Label lblDatos)
        {
            Cliente clienteFactura = GestorCliente.Instancia.ObtenerClientes().Find(x => x.DNI == pDNI);            
            Factura factura = GenerarFactura(clienteFactura);

            DataTable tablaFactura = new DataTable();            
            tablaFactura.Columns.Add(Traductor.Instancia.Traducir("Factura_NomProd"), typeof(string));
            tablaFactura.Columns.Add(Traductor.Instancia.Traducir("Factura_PrecioProducto"), typeof(decimal));
            tablaFactura.Columns.Add(Traductor.Instancia.Traducir("Factura_CantProducto"), typeof(int));
            tablaFactura.Columns.Add(Traductor.Instancia.Traducir("Factura_Subtotal"), typeof(decimal));
            tablaFactura.Columns.Add(Traductor.Instancia.Traducir("Factura_PrecioTotal"), typeof(decimal));
            foreach (var detalle in factura.detallesFactura)
            {
                tablaFactura.Rows.Add(                    
                    detalle.Producto.Nombre,
                    detalle.PrecioUnitario,
                    detalle.Cantidad,
                    detalle.Subtotal                  
                );
            }
            tablaFactura.Rows.Add("TOTAL", null, null, null, factura.PrecioTotal);
            dgv.DataSource = tablaFactura;
            lblDatos.Text += $" N°: {factura.NumFactura.ToString()}";            
        }
        public void GuardarFactura(Cliente clienteFactura, Factura factura)
        {
            LectorDatos.Datos.GuardarFactura(clienteFactura, factura);
        }
    }
}
