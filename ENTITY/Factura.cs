using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    internal class Factura
    {
        public Factura(int idFactura, string fechaFactura, int valorTotalFacturado)
        {
            IdFactura = idFactura;
            FechaFactura = fechaFactura;
            ValorTotalFacturado = valorTotalFacturado;
        }

        public Factura()
        {
        }
        public int IdFactura { get; set;}
        public string FechaFactura { get; set;}
        public int ValorTotalFacturado { get; set;}
    }
}
