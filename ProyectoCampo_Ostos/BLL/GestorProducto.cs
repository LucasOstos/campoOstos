using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GestorProducto
    {
        private static GestorProducto instancia;
        public static GestorProducto Instancia
        {
            get
            {
                if (instancia == null) { instancia = new GestorProducto(); }
                return instancia;
            }
        }
        public List<Producto> BuscarProductosPorTipo(string Tipo)
        {
            return LectorDatos.Datos.ObtenerProductosPorTipo(Tipo);
        }
        public Producto BuscarProductoPorNombre(string Tipo)
        {
            return LectorDatos.Datos.ObtenerProductoPorNombre(Tipo);
        }
        public Producto ObtenerProducto(int pCodigo)
        {
            return LectorDatos.Datos.ObtenerProducto(pCodigo);
        }
        public void DisminuirStock(int codigo, int cantidad)
        {
            LectorDatos.Datos.StockProducto(codigo, cantidad);
        }
    }
}
