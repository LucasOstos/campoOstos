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

        GuiAsignarCarrito guiCarrito = new GuiAsignarCarrito();

        public GuiAsignarCarrito ObtenerGui()
        {
            return guiCarrito;
        }
    }
}
