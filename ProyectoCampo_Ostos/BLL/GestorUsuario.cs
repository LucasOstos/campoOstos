using DAL;
using ServiciosEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BLL
{
    public class GestorUsuario
    {

        private static GestorUsuario instancia;
        public static GestorUsuario Instancia
        {
            get
            {
                if (instancia == null) { instancia = new GestorUsuario(); }
                return instancia;
            }
        }
        public void AgregarUsuario(Usuario pUsuario)
        {
            LectorDatos.Datos.AgregarUsuario(pUsuario);
        }

        public void BorrarUsuario(int DniUsuario)
        {
            LectorDatos.Datos.BorrarUsuario(DniUsuario);
        }

        public void ModificarUsuario(int pDNI, Usuario pUsuario)
        {
            LectorDatos.Datos.ModificarUsuario(pDNI, pUsuario);
        }

        public Usuario ObtenerUsuario(string pEmail)
        {
            return GestorBD.Instancia.ObtenerUsuario(pEmail);
        }

        public List<Usuario> ReturnUsuarios()
        {
            return LectorDatos.Datos.LeerUsuarios();
        }

        public List<Usuario> ReturnBloqueados()
        {
            return LectorDatos.Datos.LeerUsuariosBloqueados();
        }



        public void BloquearUsuario(bool pEstado, int pDNI)
        {
            LectorDatos.Datos.BloquearUsuario(pEstado, pDNI);
            MessageBox.Show("Usuario bloqueado");
        }

        public void Intentos(int Intentos, int pDNI)
        {
            LectorDatos.Datos.ActualizarIntentos(Intentos, pDNI);
        }

        public void CambiarContraseña(int pDNI, Usuario pUsuario)
        {
            LectorDatos.Datos.CambiarContraseña(pDNI, pUsuario);
        }
        public void DesbloquearUsuario(Usuario pUsuario)
        {
            LectorDatos.Datos.Desbloquear(pUsuario);
        }
        public void CambiarEstado(string pEmail)
        {
            Usuario usuario = ObtenerUsuario(pEmail);
            bool habilitado = usuario.IsHabilitado;
            LectorDatos.Datos.CambiarEstado(!habilitado, pEmail);
        }
    }
}
