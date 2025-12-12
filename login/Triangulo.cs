/*
 * Creado por SharpDevelop.
 * Usuario: CC1_PC44
 * Fecha: 10/12/2025
 * Hora: 02:08 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace login
{
	/// <summary>
	/// Description of Triangulo.
	/// </summary>
	public partial class Triangulo : Form
	{
		public Triangulo()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Principal FormularioPrincipal = new Principal();
			FormularioPrincipal.Show();
			this.Hide();
		}
		
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			double b = double.Parse(txtBase.Text);
    	double h = double.Parse(txtAltura.Text);

    	double area = (b * h) / 2;

    	lblResultado.Text = "Área: " + area;
		}
	}
}
