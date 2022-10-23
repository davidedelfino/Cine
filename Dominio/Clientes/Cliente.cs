using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine.Dominio
{
    internal class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Calle Calle { get; set; }
        public long Altura { get; set; }
        public string Email { get; set; }

        public Cliente(string nombre, string apellido, Calle calle, long altura, string email)
        {
            Nombre = nombre;
            Apellido = apellido;
            Calle = calle;
            Altura = altura;
            Email = email;
        }
    }
}
