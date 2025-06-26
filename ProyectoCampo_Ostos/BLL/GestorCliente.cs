using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using SERVICIOS;

namespace BLL
{
    public class GestorCliente
    {
        private static GestorCliente instancia;
        public static GestorCliente Instancia
        {
            get
            {
                if (instancia == null) { instancia = new GestorCliente(); }
                return instancia;
            }
        }
        public List<Cliente> ObtenerClientes()
        {
            return LectorDatos.Datos.LeerClientes();
        }
        public void AltaCliente(Cliente C)
        {
            C.Email = Encriptado.InstanceEncriptado.EncriptacionReversible(C.Email);
            LectorDatos.Datos.AgregarCliente(C);
        }
        public void BajaCliente(int DNICliente)
        {
            LectorDatos.Datos.BorrarCliente(DNICliente);
        }
        public void ModificarCliente(Cliente C)
        {
            LectorDatos.Datos.ModificarCliente(C);
        }
    }
}
