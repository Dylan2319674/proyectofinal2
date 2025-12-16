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
	/// Description of Temperatura.
	/// </summary>
	public partial class Temperatura : Form
	{
		public Temperatura()
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
			double c = double.Parse(txtCelcius.Text);
    		double f = (c * 9.0 / 5.0) + 32;
   		    lblResultado.Text = f.ToString("0.00");
		}
		
		
	}
}