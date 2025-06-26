using BE;
using SERVICIOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class GestorCarrito
    {
        private static GestorCarrito instancia;
        public static GestorCarrito Instancia
        {
            get
            {
                if (instancia == null) { instancia = new GestorCarrito(); }
                return instancia;
            }
        }
        public Carrito carrito = new Carrito();
        
        public void AgregarProductoCarrito(Producto P)
        {
            Producto p = carrito.productosCarrito.FirstOrDefault(x => x.Codigo == P.Codigo);
            if (p != null)
            {
                if(p.CantidadEnCarrito < p.Cantidad)
                {
                    p.CantidadEnCarrito += P.CantidadEnCarrito;
                }
                else { MessageBox.Show("No hay más stock del producto seleccionado"); }               
            }
            else { carrito.productosCarrito.Add(P); }
        }
        public List<Producto> ObtenerProductos()
        {
            return carrito.productosCarrito;
        }
        public void AsignarCarrito(int codigoCarrito, Cliente cliente)
        {
            carrito.CodCarrito = codigoCarrito;
            carrito.Duenio = cliente;
        }
        public void CobrarVenta()
        {
            foreach (var producto in carrito.productosCarrito)
            {
                producto.Cantidad -= producto.CantidadEnCarrito;
                GestorProducto.Instancia.DisminuirStock(producto.Codigo, producto.Cantidad);
            }
        }
        public void BorrarCarrito()
        {
            carrito.productosCarrito.Clear();
        }
        public Carrito BuscarCarritoPorDNI(int dni)
        {
            if (carrito.Duenio != null && carrito.Duenio.DNI == dni)
            {
                return carrito;
            }
            else { return null; }
        }        
    }
}
