using ServiciosEntidades;
using DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace SERVICIOS
{
    public class Sesion
    {
        public Usuario Usuario;
        private static Sesion instancia;
        public static Sesion Instancia
        {
            get
            {
                if (instancia == null) instancia = new Sesion();
                return instancia;
            }
        }
        public string IdiomaSesion;

        public void LogIn(Usuario pUsuario)
        {
            Usuario = pUsuario;
            Usuario.Intentos = 0;
            IdiomaSesion = Usuario.Idioma;
            LectorDatos.Datos.ActualizarIntentos(Usuario.Intentos, Usuario.DNI);
            if(Usuario.Perfil != "Administrador General") Usuario.PerfilUsuario = (PermisoCompuesto)PermisosBD.Instancia.ObtenerPerfilesRelaciones().Find(x => x.Nombre == Usuario.Perfil);
        }
        public bool TienePermiso(string nombrePermiso)
        {
            if (Usuario.Perfil == nombrePermiso)
                return true;
            // Recorremos todos los permisos hijos recursivamente
            foreach (Permiso p in Usuario.PerfilUsuario.ObtenerHijosRecursivo())
            {
                if (p.Nombre == nombrePermiso)
                    return true;
            }
            return false;
        }
        public void LogOut()
        {
            if (Usuario != null)
            {
                LectorDatos.Datos.ActualizarIdiomaUsuario(IdiomaSesion, Usuario);
                Usuario = null;
            }
        }        
        public bool IsLogueado()
        {
            return Usuario == null ? false : true;
        }        
        public bool Verificar(string pEmail, string pContra)
        {
            return GestorBD.Instancia.ValidarUsuario(pEmail, pContra);
        }
        public string ObtenerIdiomaSesion()
        {
            return IdiomaSesion;
        }
        public void EstablecerIdioma(string nuevoIdioma)
        {
            IdiomaSesion = nuevoIdioma;
            Traductor.Instancia.CargarTraducciones(nuevoIdioma);
        }
    }
}
