namespace Entrega
{
    partial class FormularioPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.txtStockMinimo = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnRegistrarProducto = new System.Windows.Forms.Button();
            this.txtFiltroNombre = new System.Windows.Forms.TextBox();
            this.cmbFiltroEstado = new System.Windows.Forms.ComboBox();
            this.btnConsultarProductos = new System.Windows.Forms.Button();
            this.txtIdFactura = new System.Windows.Forms.TextBox();
            this.dtpFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.listViewProductos = new System.Windows.Forms.ListView();
            this.columnReferencia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRegistrarFactura = new System.Windows.Forms.Button();
            this.btnVerFacturas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(16, 15);
            this.txtReferencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(132, 22);
            this.txtReferencia.TabIndex = 0;
            this.txtReferencia.Text = "Referencia";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(16, 47);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 22);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "Nombre";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(16, 79);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(132, 22);
            this.txtCantidad.TabIndex = 2;
            this.txtCantidad.Text = "Cantidad";
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Location = new System.Drawing.Point(16, 111);
            this.txtPrecioUnitario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(132, 22);
            this.txtPrecioUnitario.TabIndex = 3;
            this.txtPrecioUnitario.Text = "Precio Unitario";
            // 
            // txtStockMinimo
            // 
            this.txtStockMinimo.Location = new System.Drawing.Point(16, 143);
            this.txtStockMinimo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStockMinimo.Name = "txtStockMinimo";
            this.txtStockMinimo.Size = new System.Drawing.Size(132, 22);
            this.txtStockMinimo.TabIndex = 4;
            this.txtStockMinimo.Text = "Stock Mínimo";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "activo",
            "inactivo"});
            this.cmbEstado.Location = new System.Drawing.Point(16, 175);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(132, 24);
            this.cmbEstado.TabIndex = 5;
            // 
            // btnRegistrarProducto
            // 
            this.btnRegistrarProducto.Location = new System.Drawing.Point(16, 208);
            this.btnRegistrarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrarProducto.Name = "btnRegistrarProducto";
            this.btnRegistrarProducto.Size = new System.Drawing.Size(133, 28);
            this.btnRegistrarProducto.TabIndex = 6;
            this.btnRegistrarProducto.Text = "Registrar Producto";
            this.btnRegistrarProducto.UseVisualStyleBackColor = true;
            this.btnRegistrarProducto.Click += new System.EventHandler(this.btnRegistrarProducto_Click);
            // 
            // txtFiltroNombre
            // 
            this.txtFiltroNombre.Location = new System.Drawing.Point(16, 244);
            this.txtFiltroNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFiltroNombre.Name = "txtFiltroNombre";
            this.txtFiltroNombre.Size = new System.Drawing.Size(132, 22);
            this.txtFiltroNombre.TabIndex = 7;
            this.txtFiltroNombre.Text = "Filtro Nombre";
            // 
            // cmbFiltroEstado
            // 
            this.cmbFiltroEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroEstado.FormattingEnabled = true;
            this.cmbFiltroEstado.Items.AddRange(new object[] {
            "activo",
            "inactivo"});
            this.cmbFiltroEstado.Location = new System.Drawing.Point(16, 276);
            this.cmbFiltroEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFiltroEstado.Name = "cmbFiltroEstado";
            this.cmbFiltroEstado.Size = new System.Drawing.Size(132, 24);
            this.cmbFiltroEstado.TabIndex = 8;
            // 
            // btnConsultarProductos
            // 
            this.btnConsultarProductos.Location = new System.Drawing.Point(16, 309);
            this.btnConsultarProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultarProductos.Name = "btnConsultarProductos";
            this.btnConsultarProductos.Size = new System.Drawing.Size(133, 28);
            this.btnConsultarProductos.TabIndex = 9;
            this.btnConsultarProductos.Text = "Consultar Productos";
            this.btnConsultarProductos.UseVisualStyleBackColor = true;
            this.btnConsultarProductos.Click += new System.EventHandler(this.btnConsultarProductos_Click);
            // 
            // txtIdFactura
            // 
            this.txtIdFactura.Location = new System.Drawing.Point(16, 345);
            this.txtIdFactura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdFactura.Name = "txtIdFactura";
            this.txtIdFactura.Size = new System.Drawing.Size(132, 22);
            this.txtIdFactura.TabIndex = 10;
            this.txtIdFactura.Text = "ID Factura";
            // 
            // dtpFechaFactura
            // 
            this.dtpFechaFactura.Location = new System.Drawing.Point(16, 377);
            this.dtpFechaFactura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaFactura.Name = "dtpFechaFactura";
            this.dtpFechaFactura.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaFactura.TabIndex = 11;
            // 
            // listViewProductos
            // 
            this.listViewProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnReferencia,
            this.columnCantidad});
            this.listViewProductos.HideSelection = false;
            this.listViewProductos.Location = new System.Drawing.Point(16, 409);
            this.listViewProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewProductos.Name = "listViewProductos";
            this.listViewProductos.Size = new System.Drawing.Size(265, 118);
            this.listViewProductos.TabIndex = 12;
            this.listViewProductos.UseCompatibleStateImageBehavior = false;
            this.listViewProductos.View = System.Windows.Forms.View.Details;
            // 
            // columnReferencia
            // 
            this.columnReferencia.Text = "Referencia";
            this.columnReferencia.Width = 100;
            // 
            // columnCantidad
            // 
            this.columnCantidad.Text = "Cantidad";
            this.columnCantidad.Width = 100;
            // 
            // btnRegistrarFactura
            // 
            this.btnRegistrarFactura.Location = new System.Drawing.Point(16, 535);
            this.btnRegistrarFactura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrarFactura.Name = "btnRegistrarFactura";
            this.btnRegistrarFactura.Size = new System.Drawing.Size(133, 28);
            this.btnRegistrarFactura.TabIndex = 13;
            this.btnRegistrarFactura.Text = "Registrar Factura";
            this.btnRegistrarFactura.UseVisualStyleBackColor = true;
            this.btnRegistrarFactura.Click += new System.EventHandler(this.btnRegistrarFactura_Click);
            // 
            // btnVerFacturas
            // 
            this.btnVerFacturas.Location = new System.Drawing.Point(16, 571);
            this.btnVerFacturas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerFacturas.Name = "btnVerFacturas";
            this.btnVerFacturas.Size = new System.Drawing.Size(133, 28);
            this.btnVerFacturas.TabIndex = 14;
            this.btnVerFacturas.Text = "Ver Facturas";
            this.btnVerFacturas.UseVisualStyleBackColor = true;
            this.btnVerFacturas.Click += new System.EventHandler(this.btnVerFacturas_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 690);
            this.Controls.Add(this.btnVerFacturas);
            this.Controls.Add(this.btnRegistrarFactura);
            this.Controls.Add(this.listViewProductos);
            this.Controls.Add(this.dtpFechaFactura);
            this.Controls.Add(this.txtIdFactura);
            this.Controls.Add(this.btnConsultarProductos);
            this.Controls.Add(this.cmbFiltroEstado);
            this.Controls.Add(this.txtFiltroNombre);
            this.Controls.Add(this.btnRegistrarProducto);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.txtStockMinimo);
            this.Controls.Add(this.txtPrecioUnitario);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtReferencia);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormularioPrincipal";
            this.Text = "Formulario Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.TextBox txtStockMinimo;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnRegistrarProducto;
        private System.Windows.Forms.TextBox txtFiltroNombre;
        private System.Windows.Forms.ComboBox cmbFiltroEstado;
        private System.Windows.Forms.Button btnConsultarProductos;
        private System.Windows.Forms.TextBox txtIdFactura;
        private System.Windows.Forms.DateTimePicker dtpFechaFactura;
        private System.Windows.Forms.ListView listViewProductos;
        private System.Windows.Forms.ColumnHeader columnReferencia;
        private System.Windows.Forms.ColumnHeader columnCantidad;
        private System.Windows.Forms.Button btnRegistrarFactura;
        private System.Windows.Forms.Button btnVerFacturas;
    }
}
