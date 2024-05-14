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
        private readonly DetalleFacturaRepository detalleFacturaRepository;
        public DetalleFacturaRepository()
        {
            detalleFacturaRepository = new DetalleFacturaRepository();
        }
        public string ImprimirFactura(Factura factura)
        {
            try
            {

                if (servicioRepository.Buscar(productos.Identificacion) == null)
                {
                    servicioRepository.Guardar(productos);
                    return $"se han guardado Satisfactoriamente los datos de: {productos.Nombre} ";
                }
                else
                {
                    return $"Lo sentimos, con la Identificación {productos.Referencia} ya se encuentra registrada";
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicacion: {e.Message}";
            }
        }
    }
}
