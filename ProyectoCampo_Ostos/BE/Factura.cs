using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Factura
    {        
        public int NumFactura { get; set; }
        public List<DetalleFactura> detallesFactura { get; set; } = new List<DetalleFactura>();
        public DateTime FechaEmision { get; set; }
        public Cliente facturaCliente { get; set; }
        public decimal PrecioTotal { get; set; }
    }
}
