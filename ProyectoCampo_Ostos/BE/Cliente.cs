using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cliente
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Celular { get; set; }
        public string Email { get; set; }
        public Cliente(int pDNI, string pNombre, string pApellido, int pCelu, string pEmail)
        {
            DNI = pDNI;
            Nombre = pNombre;
            Apellido = pApellido;
            Celular = pCelu;
            Email = pEmail;
        }
        public Cliente()
        {

        }
    }
}
