using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class DetalleFactura
    {
        public DetalleFactura(int idDeDetalle, int idDeFactura, string fechaFactura, int referenciaDelProducto, string nombre, int cantidad, double precioUnitario, double valorItemVendido)
        {
           IdDeDetalle = idDeDetalle;
           IdDeFactura = idDeFactura;
           FechaFactura = fechaFactura;
           ReferenciaDelProducto = referenciaDelProducto;
           Nombre = nombre;
           Cantidad = cantidad;
           PrecioUnitario = precioUnitario;
           ValorItemVendido = valorItemVendido;
        }

        public DetalleFactura() 
        {
        }

        public int IdDeDetalle { get; set; }
        public int IdDeFactura { get; set; }
        public string FechaFactura { get; set; }
        public float ReferenciaDelProducto { get; set; }
        public string Nombre { get; set;}
        public float Cantidad { get; set; }
        public double PrecioUnitario { get; set; }
        public double ValorItemVendido { get; set; }
    }
}
