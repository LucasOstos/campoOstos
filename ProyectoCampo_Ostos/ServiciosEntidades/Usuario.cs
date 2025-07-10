using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosEntidades
{
    public class Usuario
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public string Perfil {  get; set; }
        public bool IsHabilitado { get; set; }
        public bool Estado { get; set; }
        public int Intentos { get; set; }
        public bool cambioContrasenia { get; set; }
        public DateTime ultimoLogin { get; set; }
        public string Idioma {  get; set; }
        public PermisoCompuesto PerfilUsuario { get; set; }
        public Usuario(int pDNI, string pNombre, string pApellido, string pEmail, string pContraseña, string pPerfil, bool pHabilitado, bool pEstado, int pIntentos, bool pCambioContrasenia, DateTime pUltimoLogin, string pIdioma)
        {
            DNI = pDNI;
            Nombre = pNombre;
            Apellido = pApellido;
            Email = pEmail;
            Contraseña = pContraseña;
            Perfil = pPerfil;
            IsHabilitado = pHabilitado;
            Estado = pEstado;
            Intentos = pIntentos;
            cambioContrasenia = pCambioContrasenia;
            ultimoLogin = pUltimoLogin;
            Idioma = pIdioma;
        }
        public Usuario()
        {

        }
    }
}
