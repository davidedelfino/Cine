using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine.Dominio.Comprobantes
{
    internal class Comprobante
    {
        public Cliente Cliente { get; set; }
        public int FormaPago { get; set; }
        public int TipoCompra { get; set; }
        public DateTime FechaEmision { get; set; }

        public Comprobante(Cliente cliente, int formaPago, int tipoCompra, DateTime fechaEmision)
        {
            Cliente = cliente;
            FormaPago = formaPago;
            TipoCompra = tipoCompra;
            FechaEmision = fechaEmision;
        }
    }
}
