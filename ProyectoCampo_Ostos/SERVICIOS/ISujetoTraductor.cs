using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIOS
{
    public interface ISujetoTraductor
    {
        void Suscribir(IObserver pObservador);
        void Desuscribir(IObserver pObservador);
        void Notificar(string idioma);
    }
}
