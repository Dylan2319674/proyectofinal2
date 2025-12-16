/*
 * Creado por SharpDevelop.
 * Usuario: CC1_PC44
 * Fecha: 10/12/2025
 * Hora: 02:21 p. m.
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;
using MySql.Data.MySqlClient;

namespace login
{
	public partial class Postres : Form
	{
		// CADENA DE CONEXIÓN (AJUSTA SI ES NECESARIO)
		string conexion = "server=localhost;database=tu_basedatos;user=root;password=;";

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
			decimal total = precio * cantidad;

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
			if (listView1.Items.Count == 0)
			{
				MessageBox.Show("No hay productos");
				return;
			}

			try
			{
				MySqlConnection cn = new MySqlConnection(conexion);
				cn.Open();

				string sqlVenta = "INSERT INTO ventas (total, fecha) VALUES (@total, NOW())";
				MySqlCommand cmdVenta = new MySqlCommand(sqlVenta, cn);
				cmdVenta.Parameters.AddWithValue("@total", TxtTotal.Text);
				cmdVenta.ExecuteNonQuery();

				int ventaId = (int)cmdVenta.LastInsertedId;

				foreach (ListViewItem item in listView1.Items)
				{
					string sqlDetalle =
						"INSERT INTO detalle_venta (venta_id, producto, precio, cantidad, total, tipo) " +
						"VALUES (@venta, @producto, @precio, @cantidad, @total, @tipo)";

					MySqlCommand cmd = new MySqlCommand(sqlDetalle, cn);
					cmd.Parameters.AddWithValue("@venta", ventaId);
					cmd.Parameters.AddWithValue("@producto", item.Text);
					cmd.Parameters.AddWithValue("@precio", item.SubItems[1].Text);
					cmd.Parameters.AddWithValue("@cantidad", item.SubItems[2].Text);
					cmd.Parameters.AddWithValue("@total", item.SubItems[3].Text);
					cmd.Parameters.AddWithValue("@tipo", item.SubItems[4].Text);

					cmd.ExecuteNonQuery();
				}

				cn.Close();
				MessageBox.Show("Venta guardada en MySQL correctamente");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error MySQL: " + ex.Message);
			}
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
					Brushes.Black, 20, y);
				y += 20;
			}

			y += 20;
			e.Graphics.DrawString(
				"Total: $" + TxtTotal.Text,
				new Font("Arial", 11, FontStyle.Bold),
				Brushes.Black, 20, y);
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

			cmbProducto.Items.Clear();
			cmbProducto.Text = "";

			RbdDulce.Checked = false;
			RbdSalado.Checked = false;

			listView1.Items.Clear();
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
	}
}