using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Producto
    {
        public string Referencia { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public float PrecioUnitario { get; set; }
        public int StockMinimo { get; set; }
        public string Estado { get; set; }

        public Producto(string referencia, string nombre, int cantidad, float precioUnitario, int stockMinimo, string estado)
        {
            Referencia = referencia;
            Nombre = nombre;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
            StockMinimo = stockMinimo;
            Estado = estado;
        }
    }
}
