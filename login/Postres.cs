/*
 * Creado por SharpDevelop.
 * Usuario: CC1_PC44
 * Fecha: 10/12/2025
 * Hora: 02:21 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace login
{
	public partial class Postres : Form
	{
		string[] productosDulces = {
			"Pastel de Chocolate",
			"Pastel de Vainilla",
			"Pastel de Tres Leches",
			"Cheesecake",
			"Cupcake",
			"Brownie",
			"Pay de Limón",
			"Gelatina",
			"Flan Napolitano",
			"Donas"
		};

		string[] productosSalados = {
			"Empanada de Queso",
			"Quiche de Jamón",
			"Pan de Ajo",
			"Croissant Salado",
			"Pastel de Carne",
			"Volován",
			"Pizza Individual",
			"Tarta Salada",
			"Panini",
			"Enchilada"
		};

		public Postres()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Size = new Size(1200, 700);

			rbdDulce.CheckedChanged += RbdDulceCheckedChanged;
			rbdSalado.CheckedChanged += RbdSaladoCheckedChanged;
		}

		void BtnRegresarClick(object sender, EventArgs e)
		{
			Principal formularioPrincipal = new Principal();
			formularioPrincipal.Show();
			this.Hide();
		}

		void BtnAgregarProductoClick(object sender, EventArgs e)
		{
			if (TxtPrecio.Text == "" || TxtCantidad.Text == "")
			{
				MessageBox.Show("Ingrese precio y cantidad");
				return;
			}

			if (!rbdDulce.Checked && !rbdSalado.Checked)
			{
				MessageBox.Show("Seleccione si es Dulce o Salado");
				return;
			}

			decimal precio, cantidad;
			if (!decimal.TryParse(TxtPrecio.Text, out precio)) return;
			if (!decimal.TryParse(TxtCantidad.Text, out cantidad)) return;

			string tipo = rbdDulce.Checked ? "Dulce" : "Salado";

			decimal totalProducto = precio * cantidad;
			TxtTotal.Text = totalProducto.ToString("0.00");

			ListViewItem fila = new ListViewItem(cmbProducto.Text);
			fila.SubItems.Add(precio.ToString("0.00"));
			fila.SubItems.Add(cantidad.ToString());
			fila.SubItems.Add(totalProducto.ToString("0.00"));
			fila.SubItems.Add(tipo);
			listView1.Items.Add(fila);

			RecalcularTotales();
		}

		void TxtImportePagadoTextChanged(object sender, EventArgs e)
		{
			RecalcularCambio();
		}

		void BtnEliminarProductoClick(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count == 0)
			{
				MessageBox.Show("Seleccione un producto para eliminar");
				return;
			}

			listView1.Items.Remove(listView1.SelectedItems[0]);
			RecalcularTotales();
		}

		// ================= MÉTODOS DE APOYO =================

		void RecalcularTotales()
		{
			decimal subtotal = 0m;
			foreach (ListViewItem item in listView1.Items)
			{
				subtotal += Convert.ToDecimal(item.SubItems[3].Text);
			}
			TxtSubtotal.Text = subtotal.ToString("0.00");

			decimal descuento = 0m;
			if (TxtDescuento.Text != "")
			{
				decimal porc;
				if (decimal.TryParse(TxtDescuento.Text, out porc))
					descuento = subtotal * (porc / 100m);
			}

			decimal importeNeto = subtotal - descuento;
			TxtImporteNeto.Text = importeNeto.ToString("0.00");

			RecalcularCambio();
		}

		void RecalcularCambio()
		{
			decimal pagado, neto;
			if (!decimal.TryParse(TxtImportePagado.Text, out pagado)) return;
			if (!decimal.TryParse(TxtImporteNeto.Text, out neto)) return;

			decimal cambio = pagado - neto;
			if (cambio < 0) cambio = 0;

			TxtCambio.Text = cambio.ToString("0.00");
		}
	}
}
