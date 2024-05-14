using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrega
{
    public partial class FormularioPrincipal : Form
    {
        private ServicioProductos _servicioProductos;
        private ServicioFacturas _servicioFacturas;

        public FormularioPrincipal()
        {
            InitializeComponent();
            _servicioProductos = new ServicioProductos();
            _servicioFacturas = new ServicioFacturas();
        }

        private void btnRegistrarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                string referencia = txtReferencia.Text;
                string nombre = txtNombre.Text;
                int cantidad = int.Parse(txtCantidad.Text);
                float precioUnitario = float.Parse(txtPrecioUnitario.Text);
                int stockMinimo = int.Parse(txtStockMinimo.Text);
                string estado = cmbEstado.SelectedItem.ToString();

                _servicioProductos.RegistroProducto(referencia, nombre, cantidad, precioUnitario, stockMinimo, estado);
                MessageBox.Show("Producto registrado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar producto: {ex.Message}");
            }
        }

        private void btnConsultarProductos_Click(object sender, EventArgs e)
        {
            string nombre = txtFiltroNombre.Text;
            string estado = cmbFiltroEstado.SelectedItem?.ToString();
            var productos = _servicioProductos.FiltrarProductos(nombre, estado);
            // Lógica para mostrar los productos en el formulario
        }

        private void btnRegistrarFactura_Click(object sender, EventArgs e)
        {
            try
            {
                int idFactura = int.Parse(txtIdFactura.Text);
                DateTime fechaFactura = dtpFechaFactura.Value;

                List<Tuple<string, int>> productos = new List<Tuple<string, int>>();
                foreach (ListViewItem item in listViewProductos.Items)
                {
                    string referencia = item.SubItems[0].Text;
                    int cantidad = int.Parse(item.SubItems[1].Text);
                    productos.Add(new Tuple<string, int>(referencia, cantidad));
                }

                _servicioFacturas.CrearFactura(idFactura, fechaFactura, productos);
                MessageBox.Show("Factura registrada exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar la factura: {ex.Message}");
            }
        }

        private void btnVerFacturas_Click(object sender, EventArgs e)
        {
            var facturas = _servicioFacturas.ObtenerFacturas();
            // Lógica para mostrar las facturas en el formulario
        }
    }
}
