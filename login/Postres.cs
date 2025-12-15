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
using System.IO;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace login
{
	public partial class Postres : Form
	{
		string[] productosDulces = {
			"Pastel de Chocolate",
			"Pastel de Vainilla",
			"Cheesecake",
			"Cupcake",
			"Brownie"
		};

		string[] productosSalados = {
			"Empanada de Queso",
			"Pizza Individual",
			"Panini",
			"Quiche",
			"Pan de Ajo"
		};

		public Postres()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;

			RbdDulce.CheckedChanged += RbdDulceCheckedChanged;
			RbdSalado.CheckedChanged += RbdSaladoCheckedChanged;

			cmbProducto.SelectedIndexChanged += cmbProductoSelectedIndexChanged;

			TxtPrecio.KeyPress += SoloNumeros;
			TxtCantidad.KeyPress += SoloNumeros;
			TxtImportePagado.KeyPress += SoloNumeros;
			TxtDescuento.KeyPress += SoloNumeros;
		}

		void RbdDulceCheckedChanged(object sender, EventArgs e)
		{
			if (RbdDulce.Checked)
			{
				cmbProducto.Items.Clear();
				foreach (string p in productosDulces)
					cmbProducto.Items.Add(p);
				cmbProducto.SelectedIndex = 0;
			}
		}

		void RbdSaladoCheckedChanged(object sender, EventArgs e)
		{
			if (RbdSalado.Checked)
			{
				cmbProducto.Items.Clear();
				foreach (string p in productosSalados)
					cmbProducto.Items.Add(p);
				cmbProducto.SelectedIndex = 0;
			}
		}

		void cmbProductoSelectedIndexChanged(object sender, EventArgs e)
		{
			switch (cmbProducto.Text)
			{
				case "Pastel de Chocolate": TxtPrecio.Text = "250"; break;
				case "Pastel de Vainilla": TxtPrecio.Text = "220"; break;
				case "Cheesecake": TxtPrecio.Text = "300"; break;
				case "Cupcake": TxtPrecio.Text = "40"; break;
				case "Brownie": TxtPrecio.Text = "50"; break;

				case "Empanada de Queso": TxtPrecio.Text = "35"; break;
				case "Pizza Individual": TxtPrecio.Text = "80"; break;
				case "Panini": TxtPrecio.Text = "70"; break;
				case "Quiche": TxtPrecio.Text = "90"; break;
				case "Pan de Ajo": TxtPrecio.Text = "30"; break;
			}
		}

		void SoloNumeros(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
				e.Handled = true;
		}

		void BtnAgregarProductoClick(object sender, EventArgs e)
		{
			if (TxtPrecio.Text == "" || TxtCantidad.Text == "")
	{
		MessageBox.Show("Ingrese precio y cantidad");
		return;
	}

	decimal precio = Convert.ToDecimal(TxtPrecio.Text);
	decimal cantidad = Convert.ToDecimal(TxtCantidad.Text);

	// TOTAL DEL PRODUCTO (SIN DESCUENTO)
	decimal total = precio * cantidad;
	TxtTotal.Text = total.ToString("0.00");

	string tipo = RbdDulce.Checked ? "Dulce" : "Salado";

	ListViewItem fila = new ListViewItem(cmbProducto.Text);
	fila.SubItems.Add(precio.ToString("0.00"));
	fila.SubItems.Add(cantidad.ToString());
	fila.SubItems.Add(total.ToString("0.00"));
	fila.SubItems.Add(tipo);

	listView1.Items.Add(fila);

	RecalcularTotales();
		}

		void RecalcularTotales()
		{
			decimal subtotal = 0m;

			foreach (ListViewItem item in listView1.Items)
				subtotal += Convert.ToDecimal(item.SubItems[3].Text);

			TxtSubtotal.Text = subtotal.ToString("0.00");

			decimal descuento = 0m;
			if (TxtDescuento.Text != "")
				descuento = subtotal * (Convert.ToDecimal(TxtDescuento.Text) / 100m);

			decimal neto = subtotal - descuento;

			TxtImporteNeto.Text = neto.ToString("0.00");


			TxtTotal.Text = neto.ToString("0.00");

			RecalcularCambio();
		}

		void RecalcularCambio()
		{
			if (TxtImportePagado.Text == "") return;

			decimal cambio = Convert.ToDecimal(TxtImportePagado.Text) -
			                 Convert.ToDecimal(TxtImporteNeto.Text);

			if (cambio < 0) cambio = 0;
			TxtCambio.Text = cambio.ToString("0.00");
		}

		void BtnGuardarClick(object sender, EventArgs e)
		{
			StreamWriter sw = new StreamWriter("ticket.txt");

			sw.WriteLine("=== TICKET ===");
			foreach (ListViewItem item in listView1.Items)
				sw.WriteLine(item.Text + " - $" + item.SubItems[3].Text);

			sw.WriteLine("Total: $" + TxtTotal.Text);
			sw.Close();

			MessageBox.Show("Ticket guardado correctamente");
		}

		void BtnImprimirClick(object sender, EventArgs e)
		{
			PrintDocument doc = new PrintDocument();
			doc.PrintPage += Imprimir;
			doc.Print();
		}

		void Imprimir(object sender, PrintPageEventArgs e)
		{
			float y = 20;
			e.Graphics.DrawString("TICKET", new Font("Arial", 12), Brushes.Black, 20, y);
			y += 30;

			foreach (ListViewItem item in listView1.Items)
			{
				e.Graphics.DrawString(
					item.Text + " $" + item.SubItems[3].Text,
					new Font("Arial", 10),
					Brushes.Black,
					20, y);
				y += 20;
			}

			y += 20;
			e.Graphics.DrawString(
				"Total: $" + TxtTotal.Text,
				new Font("Arial", 11, FontStyle.Bold),
				Brushes.Black, 20, y);
		}
		
		void TxtTotalTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{

	TxtPrecio.Text = "";
	TxtCantidad.Text = "";
	TxtTotal.Text = "";
	TxtSubtotal.Text = "";
	TxtDescuento.Text = "";
	TxtImporteNeto.Text = "";
	TxtImportePagado.Text = "";
	TxtCambio.Text = "";
	TxtTotal.Text = "";


	cmbProducto.Items.Clear();
	cmbProducto.Text = "";


	RbdDulce.Checked = false;
	RbdSalado.Checked = false;



		}
		void BtnEliminarProductoClick(object sender, System.EventArgs e)
		{
			if (listView1.SelectedItems.Count == 0)
	{
		MessageBox.Show("Seleccione un producto para eliminar");
		return;
	}

	listView1.Items.Remove(listView1.SelectedItems[0]);
	RecalcularTotales();
		}
	}
}
