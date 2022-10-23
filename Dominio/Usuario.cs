using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine.Dominio
{
    internal class Usuario
    {
        public string User { get; }
        public string Contrasenia { get;}

        public Usuario()
        {
            User = "admin";
            Contrasenia = "1234";
        }
    }
}
