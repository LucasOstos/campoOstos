using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosEntidades
{
    public abstract class Permiso
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public Permiso(int pCodigo, string pNombre)
        {
            Codigo = pCodigo;
            Nombre = pNombre;
        }
        public virtual bool EsCompuesto()
        {
            return false;
        }
        public override string ToString()
        {
            return EsCompuesto() ? $"[Familia] {Nombre}" : $"[Permiso] {Nombre}";
        }
        public virtual void Agregar(Permiso pPermiso) { }
        public virtual void Quitar(Permiso pPermiso) { }
        public abstract List<Permiso> ObtenerHijos();

    }
}
