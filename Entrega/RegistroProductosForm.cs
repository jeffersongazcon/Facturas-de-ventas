using ENTITY;
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
    public partial class RegistroProductosForm : Form
    {
        Productos productos = new Productos();
        public RegistroProductosForm()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //pongan algo
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            productos.Referencia = textBox1.Text;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            productos.Nombre = txtNombre.Text;
        }

        private void txtExistencias_TextChanged(object sender, EventArgs e)
        {
            productos.Cantidad = Convert.ToInt32(txtExistencias.Text);
        }

        private void txtPrecioUnitario_TextChanged(object sender, EventArgs e)
        {
            productos.PrecioUnitario = Convert.ToInt32(txtExistencias.Text);
        }

        private void txtStockMinimo_TextChanged(object sender, EventArgs e)
        {
            productos.StockMinimo = Convert.ToInt32(txtExistencias.Text);
        }

        private void chkEstadoActivo_CheckedChanged(object sender, EventArgs e)
        {
            productos.Estado = chkEstadoActivo.Checked;
        }

        private void chkEstadoInactivo_CheckedChanged(object sender, EventArgs e)
        {
            productos.Estado = chkEstadoInactivo.Checked;
        }
    }
}
