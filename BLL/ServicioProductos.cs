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

        public void RegistroProducto(string referencia, string nombre, int cantidad, float precioUnitario, int stockMinimo, string estado)
        {
            while (OP == 'S')
            {
                switch (OP) 
                {
                    case '0';
                        throw new ArgumentException("La referencia de producto no puede estar vacía.");
                        break;
                    case '1':

                        break;

                }
            }
        }
    }
}
