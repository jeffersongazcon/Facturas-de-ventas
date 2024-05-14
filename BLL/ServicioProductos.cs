using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DAL;

namespace BLL
{
    public class ServicioProductos
    {
        char OP='S';
        private List<Producto> productos = new List<Producto>();

        public void RegistroProducto(string referencia, string nombre, int cantidad, float precioUnitario, int stockMinimo, bool estado)
        {
            while (OP == 'S')
            {
                do
                {
                    if (referencia == "")
                        throw new ArgumentException("Referencia de producto no puede estar vacía.");
                    if (nombre == "")
                        throw new ArgumentException("Nombre de producto no puede estar vacía.");
                    if (cantidad == 0)
                        throw new ArgumentNullException("Cantidad no puede ser cero");
                    if (precioUnitario == 0)
                        throw new ArgumentException("Precio Unitario no puede ser cero");
                    if (stockMinimo == 0)
                        throw new ArgumentException("Stock Minimo no puede estar vacio");
                    if (estado == false)
                        throw new ArgumentException("Estado no puede estar vacio ");
                } while ((referencia=="")||(nombre=="")||(cantidad == 0)||(precioUnitario==0)||(stockMinimo==0)||(estado==false));
               OP = 'N';
            }
        }
    }
}
