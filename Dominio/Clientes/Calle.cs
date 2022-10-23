using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine.Dominio
{
    internal class Calle
    {
        public int IdLocalidad { get; set; }

        public Calle(int idLocalidad)
        {
            IdLocalidad = idLocalidad;
        }
    }
}
