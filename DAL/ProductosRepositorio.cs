using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductoRepositorio : ICrudBase<Producto>
    {
        private List<Producto> _productos = new List<Producto>();

        public string Add(Producto entity)
        {
            _productos.Add(entity);
            return "Producto registrado exitosamente";
        }

        public string Delete(Producto entity)
        {
            _productos.Remove(entity);
            return "Producto eliminado exitosamente";
        }

        public string Update(Producto entity)
        {
            var producto = _productos.FirstOrDefault(p => p.Referencia == entity.Referencia);
            if (producto != null)
            {
                producto.Nombre = entity.Nombre;
                producto.Cantidad = entity.Cantidad;
                producto.PrecioUnitario = entity.PrecioUnitario;
                producto.StockMinimo = entity.StockMinimo;
                producto.Estado = entity.Estado;
                return "Producto actualizado exitosamente";
            }
            return "Producto no encontrado";
        }

        public List<Producto> GetAll()
        {
            return _productos;
        }
    }
}
