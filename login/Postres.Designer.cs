namespace login
{
	partial class Postres
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Postres));
			this.btnRegresar = new System.Windows.Forms.Button();
			this.TxtBorrar = new System.Windows.Forms.Button();
			this.BtnGuardar = new System.Windows.Forms.Button();
			this.TxtCambio = new System.Windows.Forms.TextBox();
			this.LblCambio = new System.Windows.Forms.Label();
			this.TxtImportePagado = new System.Windows.Forms.TextBox();
			this.TxtImporteNeto = new System.Windows.Forms.TextBox();
			this.LblImportePagado = new System.Windows.Forms.Label();
			this.LblImporteNeto = new System.Windows.Forms.Label();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.TxtDescuento = new System.Windows.Forms.TextBox();
			this.LblDescuento = new System.Windows.Forms.Label();
			this.TxtSubtotal = new System.Windows.Forms.TextBox();
			this.LblSubtotal = new System.Windows.Forms.Label();
			this.BtnEliminarProducto = new System.Windows.Forms.Button();
			this.BtnAgregarProducto = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.BtnImprimir = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.TxtTotal = new System.Windows.Forms.TextBox();
			this.TxtCantidad = new System.Windows.Forms.TextBox();
			this.TxtPrecio = new System.Windows.Forms.TextBox();
			this.LblCantidad = new System.Windows.Forms.Label();
			this.LblTotal = new System.Windows.Forms.Label();
			this.LblPrecio = new System.Windows.Forms.Label();
			this.cmbProducto = new System.Windows.Forms.ComboBox();
			this.LblProducto = new System.Windows.Forms.Label();
			this.RbdSalado = new System.Windows.Forms.RadioButton();
			this.RbdDulce = new System.Windows.Forms.RadioButton();
			this.BtnLimpiar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(975, 779);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(100, 70);
			this.btnRegresar.TabIndex = 0;
			this.btnRegresar.Text = "Calcular";
			this.btnRegresar.UseVisualStyleBackColor = true;
			// 
			// TxtBorrar
			// 
			this.TxtBorrar.Location = new System.Drawing.Point(908, 364);
			this.TxtBorrar.Name = "TxtBorrar";
			this.TxtBorrar.Size = new System.Drawing.Size(96, 41);
			this.TxtBorrar.TabIndex = 52;
			this.TxtBorrar.Text = "Borrar";
			this.TxtBorrar.UseVisualStyleBackColor = true;
			// 
			// BtnGuardar
			// 
			this.BtnGuardar.Location = new System.Drawing.Point(908, 220);
			this.BtnGuardar.Name = "BtnGuardar";
			this.BtnGuardar.Size = new System.Drawing.Size(96, 41);
			this.BtnGuardar.TabIndex = 51;
			this.BtnGuardar.Text = "Guardar";
			this.BtnGuardar.UseVisualStyleBackColor = true;
			// 
			// TxtCambio
			// 
			this.TxtCambio.Location = new System.Drawing.Point(786, 727);
			this.TxtCambio.Name = "TxtCambio";
			this.TxtCambio.Size = new System.Drawing.Size(100, 22);
			this.TxtCambio.TabIndex = 50;
			// 
			// LblCambio
			// 
			this.LblCambio.Location = new System.Drawing.Point(687, 730);
			this.LblCambio.Name = "LblCambio";
			this.LblCambio.Size = new System.Drawing.Size(73, 23);
			this.LblCambio.TabIndex = 49;
			this.LblCambio.Text = "Cambio";
			// 
			// TxtImportePagado
			// 
			this.TxtImportePagado.Location = new System.Drawing.Point(535, 776);
			this.TxtImportePagado.Name = "TxtImportePagado";
			this.TxtImportePagado.Size = new System.Drawing.Size(100, 22);
			this.TxtImportePagado.TabIndex = 48;
			// 
			// TxtImporteNeto
			// 
			this.TxtImporteNeto.Location = new System.Drawing.Point(535, 731);
			this.TxtImporteNeto.Name = "TxtImporteNeto";
			this.TxtImporteNeto.Size = new System.Drawing.Size(100, 22);
			this.TxtImporteNeto.TabIndex = 47;
			// 
			// LblImportePagado
			// 
			this.LblImportePagado.Location = new System.Drawing.Point(394, 779);
			this.LblImportePagado.Name = "LblImportePagado";
			this.LblImportePagado.Size = new System.Drawing.Size(112, 23);
			this.LblImportePagado.TabIndex = 46;
			this.LblImportePagado.Text = "Importe Pagado";
			// 
			// LblImporteNeto
			// 
			this.LblImporteNeto.Location = new System.Drawing.Point(394, 730);
			this.LblImporteNeto.Name = "LblImporteNeto";
			this.LblImporteNeto.Size = new System.Drawing.Size(100, 23);
			this.LblImporteNeto.TabIndex = 45;
			this.LblImporteNeto.Text = "Importe Neto";
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Sal o Dul";
			this.columnHeader5.Width = 94;
			// 
			// TxtDescuento
			// 
			this.TxtDescuento.Location = new System.Drawing.Point(217, 780);
			this.TxtDescuento.Name = "TxtDescuento";
			this.TxtDescuento.Size = new System.Drawing.Size(100, 22);
			this.TxtDescuento.TabIndex = 44;
			// 
			// LblDescuento
			// 
			this.LblDescuento.Location = new System.Drawing.Point(111, 779);
			this.LblDescuento.Name = "LblDescuento";
			this.LblDescuento.Size = new System.Drawing.Size(77, 23);
			this.LblDescuento.TabIndex = 43;
			this.LblDescuento.Text = "Descuento";
			// 
			// TxtSubtotal
			// 
			this.TxtSubtotal.Location = new System.Drawing.Point(217, 734);
			this.TxtSubtotal.Name = "TxtSubtotal";
			this.TxtSubtotal.Size = new System.Drawing.Size(100, 22);
			this.TxtSubtotal.TabIndex = 42;
			// 
			// LblSubtotal
			// 
			this.LblSubtotal.Location = new System.Drawing.Point(111, 733);
			this.LblSubtotal.Name = "LblSubtotal";
			this.LblSubtotal.Size = new System.Drawing.Size(100, 23);
			this.LblSubtotal.TabIndex = 41;
			this.LblSubtotal.Text = "Subtotal";
			// 
			// BtnEliminarProducto
			// 
			this.BtnEliminarProducto.Location = new System.Drawing.Point(587, 376);
			this.BtnEliminarProducto.Name = "BtnEliminarProducto";
			this.BtnEliminarProducto.Size = new System.Drawing.Size(223, 37);
			this.BtnEliminarProducto.TabIndex = 40;
			this.BtnEliminarProducto.Text = "Eliminar Producto";
			this.BtnEliminarProducto.UseVisualStyleBackColor = true;
			this.BtnEliminarProducto.Click += new System.EventHandler(this.BtnEliminarProductoClick);
			// 
			// BtnAgregarProducto
			// 
			this.BtnAgregarProducto.Location = new System.Drawing.Point(587, 316);
			this.BtnAgregarProducto.Name = "BtnAgregarProducto";
			this.BtnAgregarProducto.Size = new System.Drawing.Size(223, 37);
			this.BtnAgregarProducto.TabIndex = 39;
			this.BtnAgregarProducto.Text = "Agragar Producto";
			this.BtnAgregarProducto.UseVisualStyleBackColor = true;
			this.BtnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProductoClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(27, 19);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1026, 182);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 27;
			this.pictureBox1.TabStop = false;
			// 
			// BtnImprimir
			// 
			this.BtnImprimir.Location = new System.Drawing.Point(908, 296);
			this.BtnImprimir.Name = "BtnImprimir";
			this.BtnImprimir.Size = new System.Drawing.Size(96, 41);
			this.BtnImprimir.TabIndex = 53;
			this.BtnImprimir.Text = "Imprimir";
			this.BtnImprimir.UseVisualStyleBackColor = true;
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader4,
									this.columnHeader5});
			this.listView1.Location = new System.Drawing.Point(65, 419);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(1040, 249);
			this.listView1.TabIndex = 38;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Producto";
			this.columnHeader1.Width = 219;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Precio";
			this.columnHeader2.Width = 163;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Cantidad";
			this.columnHeader3.Width = 153;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Total";
			this.columnHeader4.Width = 160;
			// 
			// TxtTotal
			// 
			this.TxtTotal.Location = new System.Drawing.Point(394, 383);
			this.TxtTotal.Name = "TxtTotal";
			this.TxtTotal.Size = new System.Drawing.Size(100, 22);
			this.TxtTotal.TabIndex = 37;
			this.TxtTotal.TextChanged += new System.EventHandler(this.TxtTotalTextChanged);
			// 
			// TxtCantidad
			// 
			this.TxtCantidad.Location = new System.Drawing.Point(248, 383);
			this.TxtCantidad.Name = "TxtCantidad";
			this.TxtCantidad.Size = new System.Drawing.Size(100, 22);
			this.TxtCantidad.TabIndex = 36;
			// 
			// TxtPrecio
			// 
			this.TxtPrecio.Location = new System.Drawing.Point(111, 383);
			this.TxtPrecio.Name = "TxtPrecio";
			this.TxtPrecio.Size = new System.Drawing.Size(100, 22);
			this.TxtPrecio.TabIndex = 35;
			// 
			// LblCantidad
			// 
			this.LblCantidad.Location = new System.Drawing.Point(248, 330);
			this.LblCantidad.Name = "LblCantidad";
			this.LblCantidad.Size = new System.Drawing.Size(100, 23);
			this.LblCantidad.TabIndex = 33;
			this.LblCantidad.Text = "Cantidad";
			this.LblCantidad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// LblTotal
			// 
			this.LblTotal.Location = new System.Drawing.Point(394, 330);
			this.LblTotal.Name = "LblTotal";
			this.LblTotal.Size = new System.Drawing.Size(100, 23);
			this.LblTotal.TabIndex = 34;
			this.LblTotal.Text = "Total";
			this.LblTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// LblPrecio
			// 
			this.LblPrecio.Location = new System.Drawing.Point(98, 330);
			this.LblPrecio.Name = "LblPrecio";
			this.LblPrecio.Size = new System.Drawing.Size(100, 23);
			this.LblPrecio.TabIndex = 32;
			this.LblPrecio.Text = "Precio";
			this.LblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmbProducto
			// 
			this.cmbProducto.FormattingEnabled = true;
			this.cmbProducto.Items.AddRange(new object[] {
									"\"Pastel de Chocolate\",",
									"\"Pastel de Vainilla\",",
									"\"Pastel de Tres Leches\",",
									"\"Cheesecake\",",
									"\"Cupcake\",",
									"\"Brownie\",",
									"\"Pay de Limón\",",
									"\"Gelatina\",",
									"\"Flan Napolitano\",",
									"\"Donas\"",
									"",
									"\"Empanada de Queso\",",
									"\"Quiche de Jamón\",",
									"\"Pan de Ajo\",",
									"\"Croissant Salado\",",
									"\"Pastel de Carne\",",
									"\"Volován\",",
									"\"Pizza Individual\",",
									"\"Tarta Salada\",",
									"\"Panini\",",
									"\"Enchilada\""});
			this.cmbProducto.Location = new System.Drawing.Point(473, 220);
			this.cmbProducto.Name = "cmbProducto";
			this.cmbProducto.Size = new System.Drawing.Size(162, 24);
			this.cmbProducto.TabIndex = 31;
			// 
			// LblProducto
			// 
			this.LblProducto.Location = new System.Drawing.Point(261, 220);
			this.LblProducto.Name = "LblProducto";
			this.LblProducto.Size = new System.Drawing.Size(172, 23);
			this.LblProducto.TabIndex = 30;
			this.LblProducto.Text = "Seleccione Producto";
			// 
			// RbdSalado
			// 
			this.RbdSalado.Location = new System.Drawing.Point(84, 267);
			this.RbdSalado.Name = "RbdSalado";
			this.RbdSalado.Size = new System.Drawing.Size(104, 24);
			this.RbdSalado.TabIndex = 29;
			this.RbdSalado.TabStop = true;
			this.RbdSalado.Text = "Salado";
			this.RbdSalado.UseVisualStyleBackColor = true;
			// 
			// RbdDulce
			// 
			this.RbdDulce.Location = new System.Drawing.Point(84, 228);
			this.RbdDulce.Name = "RbdDulce";
			this.RbdDulce.Size = new System.Drawing.Size(104, 24);
			this.RbdDulce.TabIndex = 28;
			this.RbdDulce.TabStop = true;
			this.RbdDulce.Text = "Dulce";
			this.RbdDulce.UseVisualStyleBackColor = true;
			// 
			// BtnLimpiar
			// 
			this.BtnLimpiar.Location = new System.Drawing.Point(587, 268);
			this.BtnLimpiar.Name = "BtnLimpiar";
			this.BtnLimpiar.Size = new System.Drawing.Size(223, 32);
			this.BtnLimpiar.TabIndex = 54;
			this.BtnLimpiar.Text = "Limpiar";
			this.BtnLimpiar.UseVisualStyleBackColor = true;
			this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// Postres
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(1302, 1055);
			this.Controls.Add(this.BtnLimpiar);
			this.Controls.Add(this.TxtBorrar);
			this.Controls.Add(this.BtnGuardar);
			this.Controls.Add(this.TxtCambio);
			this.Controls.Add(this.LblCambio);
			this.Controls.Add(this.TxtImportePagado);
			this.Controls.Add(this.TxtImporteNeto);
			this.Controls.Add(this.LblImportePagado);
			this.Controls.Add(this.LblImporteNeto);
			this.Controls.Add(this.TxtDescuento);
			this.Controls.Add(this.LblDescuento);
			this.Controls.Add(this.TxtSubtotal);
			this.Controls.Add(this.LblSubtotal);
			this.Controls.Add(this.BtnEliminarProducto);
			this.Controls.Add(this.BtnAgregarProducto);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.BtnImprimir);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.TxtTotal);
			this.Controls.Add(this.TxtCantidad);
			this.Controls.Add(this.TxtPrecio);
			this.Controls.Add(this.LblCantidad);
			this.Controls.Add(this.LblTotal);
			this.Controls.Add(this.LblPrecio);
			this.Controls.Add(this.cmbProducto);
			this.Controls.Add(this.LblProducto);
			this.Controls.Add(this.RbdSalado);
			this.Controls.Add(this.RbdDulce);
			this.Controls.Add(this.btnRegresar);
			this.Name = "Postres";
			this.Text = "Postres";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button BtnLimpiar;
		private System.Windows.Forms.RadioButton RbdDulce;
		private System.Windows.Forms.RadioButton RbdSalado;
		private System.Windows.Forms.Label LblProducto;
		private System.Windows.Forms.ComboBox cmbProducto;
		private System.Windows.Forms.Label LblPrecio;
		private System.Windows.Forms.Label LblTotal;
		private System.Windows.Forms.Label LblCantidad;
		private System.Windows.Forms.TextBox TxtPrecio;
		private System.Windows.Forms.TextBox TxtCantidad;
		private System.Windows.Forms.TextBox TxtTotal;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button BtnImprimir;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button BtnAgregarProducto;
		private System.Windows.Forms.Button BtnEliminarProducto;
		private System.Windows.Forms.Label LblSubtotal;
		private System.Windows.Forms.TextBox TxtSubtotal;
		private System.Windows.Forms.Label LblDescuento;
		private System.Windows.Forms.TextBox TxtDescuento;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.Label LblImporteNeto;
		private System.Windows.Forms.Label LblImportePagado;
		private System.Windows.Forms.TextBox TxtImporteNeto;
		private System.Windows.Forms.TextBox TxtImportePagado;
		private System.Windows.Forms.Label LblCambio;
		private System.Windows.Forms.TextBox TxtCambio;
		private System.Windows.Forms.Button BtnGuardar;
		private System.Windows.Forms.Button TxtBorrar;

		private System.Windows.Forms.Button btnRegresar;
		
		
	}
}