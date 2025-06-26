using SERVICIOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class GestorFormulario
    {
        private static GestorFormulario instancia;
        public static GestorFormulario Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new GestorFormulario();
                }
                return instancia;
            }
        }
        GuiAgregarProducto guiProductos = new GuiAgregarProducto();
        GuiAsignarCarrito guiAsignar = new GuiAsignarCarrito();
        GuiCobrarVenta guiVenta = new GuiCobrarVenta();
        GuiFactura guiFactura = new GuiFactura();
        GuiGestionClientes guiClientes = new GuiGestionClientes();
        GuiGestionUsuarios guiUsuarios = new GuiGestionUsuarios();
        GuiPermisos guiPermisos = new GuiPermisos();
        GuiContrasenia guiContrasenia = new GuiContrasenia();
        InterfazInicioSesion guiLogin = new InterfazInicioSesion();
        public InterfazInicioSesion GetGuiLogin()
        {
            return guiLogin;
        }
        public GuiContrasenia GetGuiContrasenia()
        {
            return guiContrasenia;
        }
        public GuiGestionUsuarios GetGuiUsuarios()
        {
            return guiUsuarios;
        }
        public GuiPermisos GetGuiPermisos()
        {
            return guiPermisos;
        }
        public GuiAgregarProducto GetGuiProducto()
        {
            return guiProductos;
        }
        public GuiAsignarCarrito GetGuiAsignar()
        {
            return guiAsignar;
        }
        public GuiCobrarVenta GetGuiVenta()
        {
            return guiVenta;
        }
        public GuiFactura GetGuiFactura()
        {
            return guiFactura;
        }
        public GuiGestionClientes GetGuiClientes()
        {
            return guiClientes;
        }
    }
}
