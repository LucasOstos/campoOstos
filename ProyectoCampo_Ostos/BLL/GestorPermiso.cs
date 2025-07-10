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

        #region Perfiles
        public List<Permiso> Perfiles()
        {
            return PermisosBD.Instancia.ObtenerPerfilesRelaciones();
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
        public bool PermisoExistentePerfil(int codPerfil, Permiso codPermiso)
        {
            return PermisosBD.Instancia.PermisoYaExisteEnPerfil(codPerfil, codPermiso);
        }
        #endregion

        #region Familias
        public List<Permiso> Familias()
        {
            return PermisosBD.Instancia.ObtenerFamiliasRelaciones();
        }
        public void CrearFamilia(Permiso pFamilia)
        {
            pFamilia.Codigo = PermisosBD.Instancia.ObtenerCodigoFamilia();
            PermisosBD.Instancia.CrearFamilia(pFamilia);
        }
        public void AgregarPermisosFamilia(int codFamilia, Permiso pPermiso)
        {
            PermisosBD.Instancia.AgregarPermisoAFamilia(codFamilia, pPermiso);
        }
        public void QuitarPermisosFamilia(int codFamilia, Permiso pPermiso)
        {
            PermisosBD.Instancia.QuitarPermisoAFamilia(codFamilia, pPermiso);
        }
        public void EliminarFamilia(Permiso pFamilia)
        {
            PermisosBD.Instancia.EliminarFamilia(pFamilia);
        }
        public bool PermisoExistenteFamilia(int codFamilia, Permiso codPermiso)
        {
            return PermisosBD.Instancia.PermisoYaExisteEnFamilia(codFamilia, codPermiso);
        }
        #endregion

        public List<Permiso> Permisos()
        {
            return PermisosBD.Instancia.ObtenerPermisos();
        }
        
    }
}
