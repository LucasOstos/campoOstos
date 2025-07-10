using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Carrito
    {
        public int CodCarrito { get; set; }
        public Cliente Duenio { get; set; }
        public decimal ImporteTotal { get; set; }
        public List<Producto> productosCarrito;
        public Carrito()
        {            
            productosCarrito = new List<Producto>();
        }
    }
}
