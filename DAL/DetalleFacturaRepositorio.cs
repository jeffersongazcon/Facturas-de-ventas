using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace DAL
{
    public class DetalleFacturaRepositorio : ICrudBase<DetalleFactura>
    {
        private List<DetalleFactura> _detalles = new List<DetalleFactura>();

        public string Add(DetalleFactura entity)
        {
            _detalles.Add(entity);
            return "Detalle de factura registrado exitosamente";
        }

        public string Delete(DetalleFactura entity)
        {
            _detalles.Remove(entity);
            return "Detalle de factura eliminado exitosamente";
        }

        public string Update(DetalleFactura entity)
        {
            var detalle = _detalles.FirstOrDefault(d => d.IdDetalle == entity.IdDetalle);
            if (detalle != null)
            {
                detalle.IdFactura = entity.IdFactura;
                detalle.FechaFactura = entity.FechaFactura;
                detalle.ReferenciaProducto = entity.ReferenciaProducto;
                detalle.Nombre = entity.Nombre;
                detalle.Cantidad = entity.Cantidad;
                detalle.PrecioUnitario = entity.PrecioUnitario;
                detalle.ValorItemVendido = entity.ValorItemVendido;
                return "Detalle de factura actualizado exitosamente";
            }
            return "Detalle de factura no encontrado";
        }

        public List<DetalleFactura> GetAll()
        {
            return _detalles;
        }
    }
}
