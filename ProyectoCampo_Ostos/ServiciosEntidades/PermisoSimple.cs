using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosEntidades
{
    public class PermisoSimple : Permiso
    {
        public PermisoSimple(int pCodigo, string pNombre) : base(pCodigo, pNombre)
        {
        }
        public override List<Permiso> ObtenerHijos()
        {
            return new List<Permiso>(); // No tiene hijos
        }
    }
}
