using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FacturaRepositorio : ICrudBase<Factura>
    {
        private List<Factura> _facturas = new List<Factura>();

        public string Add(Factura entity)
        {
            _facturas.Add(entity);
            return "Factura registrada exitosamente";
        }

        public string Delete(Factura entity)
        {
            _facturas.Remove(entity);
            return "Factura eliminada exitosamente";
        }

        public string Update(Factura entity)
        {
            var factura = _facturas.FirstOrDefault(f => f.IdFactura == entity.IdFactura);
            if (factura != null)
            {
                factura.FechaFactura = entity.FechaFactura;
                factura.ValorTotalFacturado = entity.ValorTotalFacturado;
                return "Factura actualizada exitosamente";
            }
            return "Factura no encontrada";
        }

        public List<Factura> GetAll()
        {
            return _facturas;
        }
    }
}
