using DAL;
using ServiciosEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GestorPermiso
    {
        private static GestorPermiso instancia;
        public static GestorPermiso Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new GestorPermiso();
                }
                return instancia;
            }
        }
        public List<Permiso> Perfiles()
        {
            return PermisosBD.Instancia.ObtenerPerfilesRelaciones();
        }
        public List<Permiso> Familias()
        {
            return PermisosBD.Instancia.ObtenerFamiliasRelaciones();
        }
        public List<Permiso> Permisos()
        {
            return PermisosBD.Instancia.ObtenerPermisos();
        }
        public void CrearPerfil(Permiso permiso)
        {
            permiso.Codigo = PermisosBD.Instancia.ObtenerCodigoPerfil();
            PermisosBD.Instancia.CrearPerfil(permiso);
        }
        public void AgregarPermisosPerfil(int codPerfil, Permiso pPermiso)
        {
            PermisosBD.Instancia.AgregarPermisoAPerfil(codPerfil, pPermiso);
        }
        public void QuitarPermisosPerfil(int codPerfil, Permiso pPermiso)
        {
            PermisosBD.Instancia.QuitarPermisoAPerfil(codPerfil, pPermiso);
        }
        public void EliminarPerfil(Permiso pPermiso)
        {
            PermisosBD.Instancia.EliminarPerfil(pPermiso);
        }
        //public List<Permiso> CargarPermisosUsuario(int dni)
        //{
        //    return PermisosBD.Instancia.ObtenerPermisosPorUsuario(dni);
        //}
        //public bool UsuarioTienePermiso(Usuario u, string permisoBuscado)
        //{
        //    return u.Permisos.Any(p => TienePermiso(p, permisoBuscado));
        //}
        //private bool TienePermiso(Permiso PC, string NombrePermiso)
        //{
        //    if (PC == null) return false;
        //    if (PC.Nombre == NombrePermiso)
        //        return true;

        //    foreach (var hijo in PC.ObtenerHijos())
        //    {
        //        if (TienePermiso(hijo, NombrePermiso))
        //            return true;
        //    }
        //    return false;
        //}
    }
}
