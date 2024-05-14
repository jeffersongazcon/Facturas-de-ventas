using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioFacturas
    {
        private FacturaRepositorio _facturaRepositorio;
        private DetalleFacturaRepositorio _detalleFacturaRepositorio;
        private ProductoRepositorio _productoRepositorio;

        public ServicioFacturas()
        {
            _facturaRepositorio = new FacturaRepositorio();
            _detalleFacturaRepositorio = new DetalleFacturaRepositorio();
            _productoRepositorio = new ProductoRepositorio();
        }

        public void CrearFactura(int idFactura, DateTime fechaFactura, List<Tuple<string, int>> productos)
        {
            var ultimaFactura = _facturaRepositorio.GetAll().OrderByDescending(f => f.FechaFactura).FirstOrDefault();
            if (ultimaFactura != null && fechaFactura < DateTime.Parse(ultimaFactura.FechaFactura))
            {
                throw new ArgumentException("La fecha de la factura debe ser superior o igual a la fecha de la última factura registrada.");
            }

            double valorTotalFacturado = 0;
            List<DetalleFactura> detalles = new List<DetalleFactura>();

            foreach (var prod in productos)
            {
                var producto = _productoRepositorio.GetAll().FirstOrDefault(p => p.Referencia == prod.Item1);
                if (producto == null)
                {
                    throw new ArgumentException($"Producto con referencia {prod.Item1} no encontrado.");
                }

                if (producto.Cantidad < prod.Item2)
                {
                    throw new ArgumentException($"No hay suficientes existencias del producto {producto.Nombre}. Existencias disponibles: {producto.Cantidad}");
                }

                double valorItemVendido = producto.PrecioUnitario * prod.Item2;
                valorTotalFacturado += valorItemVendido;

                DetalleFactura detalle = new DetalleFactura
                {
                    IdDetalle = _detalleFacturaRepositorio.GetAll().Count + 1,
                    IdFactura = idFactura,
                    FechaFactura = fechaFactura.ToString("dd/MM/yyyy"),
                    ReferenciaProducto = producto.Referencia,
                    Nombre = producto.Nombre,
                    Cantidad = prod.Item2,
                    PrecioUnitario = producto.PrecioUnitario,
                    ValorItemVendido = valorItemVendido
                };

                detalles.Add(detalle);

                // Descontar existencias
                producto.Cantidad -= prod.Item2;
                _productoRepositorio.Update(producto);
            }

            Factura factura = new Factura
            {
                IdFactura = idFactura,
                FechaFactura = fechaFactura.ToString("dd/MM/yyyy"),
                ValorTotalFacturado = valorTotalFacturado
            };

            _facturaRepositorio.Add(factura);

            foreach (var detalle in detalles)
            {
                _detalleFacturaRepositorio.Add(detalle);
            }
        }

        public List<Factura> ObtenerFacturas()
        {
            return _facturaRepositorio.GetAll();
        }
    }
}
