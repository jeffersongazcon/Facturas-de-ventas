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
        private ProductoRepositorio _repositorio;

        public ServicioProductos()
        {
            _repositorio = new ProductoRepositorio();
        }

        public void RegistroProducto(string referencia, string nombre, int cantidad, float precioUnitario, int stockMinimo, string estado)
        {
            if (string.IsNullOrWhiteSpace(referencia))
                throw new ArgumentException("La referencia de producto no puede estar vacía.");

            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del producto no puede estar vacío.");

            if (cantidad < 0)
                throw new ArgumentException("La cantidad no puede ser negativa.");

            if (precioUnitario < 0)
                throw new ArgumentException("El precio unitario no puede ser negativo.");

            if (stockMinimo < 0)
                throw new ArgumentException("El stock mínimo no puede ser negativo.");

            if (estado != "activo" && estado != "inactivo")
                throw new ArgumentException("El estado debe ser 'activo' o 'inactivo'.");

            // Check for unique product reference
            var existingProduct = _repositorio.GetAll().FirstOrDefault(p => p.Referencia == referencia);
            if (existingProduct != null)
                throw new ArgumentException("La referencia del producto ya existe.");

            Producto producto = new Producto(referencia, nombre, cantidad, precioUnitario, stockMinimo, estado);
            _repositorio.Add(producto);
        }

        public List<Producto> FiltrarProductos(string nombre = null, string estado = null)
        {
            var productos = _repositorio.GetAll();

            if (!string.IsNullOrEmpty(nombre))
                productos = productos.Where(p => p.Nombre.IndexOf(nombre, StringComparison.OrdinalIgnoreCase) >= 0).ToList();


            if (!string.IsNullOrEmpty(estado))
                productos = productos.Where(p => p.Estado.Equals(estado, StringComparison.OrdinalIgnoreCase)).ToList();

            return productos;
        }
    }
}
