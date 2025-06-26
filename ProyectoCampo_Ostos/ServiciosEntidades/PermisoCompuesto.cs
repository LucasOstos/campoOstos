using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosEntidades
{
    public class PermisoCompuesto : Permiso
    {
        public PermisoCompuesto(int pCodigo, string pNombre) : base(pCodigo, pNombre)
        {

        }
        private List<Permiso> permisos = new List<Permiso>();
        public override void Agregar(Permiso pPermiso)
        {
            permisos.Add(pPermiso);
        }

        public override void Quitar(Permiso pPermiso)
        {
            permisos.Remove(pPermiso);
        }

        public override bool EsCompuesto()
        {
            return true;
        }
        public override List<Permiso> ObtenerHijos()
        {
            return permisos;
        }
    }
}
