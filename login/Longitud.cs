/*
 * Creado por SharpDevelop.
 * Usuario: CC1_PC44
 * Fecha: 10/12/2025
 * Hora: 02:20 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace login
{
	/// <summary>
	/// Description of Longitud.
	/// </summary>
	public partial class Longitud : Form
	{
		public Longitud()
		{
			InitializeComponent();
		}
		
		void BtnRegresarClick(object sender, EventArgs e)
		{
			Principal FormularioPrincipal = new Principal();
			FormularioPrincipal.Show();
			this.Hide();
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			double km = double.Parse(txtKilometros.Text);
			double millas = km * 0.621371;
			lblResultado.Text = millas.ToString("0.00");
		}
	}
}