using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class DetalleFactura
    {
        public int IdDetalle { get; set; }
        public int IdFactura { get; set; }
        public string FechaFactura { get; set; }
        public string ReferenciaProducto { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public float PrecioUnitario { get; set; }
        public double ValorItemVendido { get; set; }
    }
}
