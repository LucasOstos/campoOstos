using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Producto
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public string Tipo { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
        public int CantidadEnCarrito { get; set; }
        public Producto(int pCod, string pNombre, string pMarca, string pTipo, int pCant, int pPrecio)
        {
            Codigo = pCod;
            Nombre = pNombre;
            Marca = pMarca;
            Tipo = pTipo;
            Cantidad = pCant;
            Precio = pPrecio;
        }        
    }
}
