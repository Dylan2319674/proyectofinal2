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
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnRegresarClick(object sender, EventArgs e)
		{
			Principal FormularioPrincipal = new Principal();
			FormularioPrincipal.Show();
			this.Hide();
		}
		
		void BtnConvertirClick(object sender, EventArgs e)
		{
			double c, f;


    	if (double.TryParse(TxtCelsius.Text, out c))
    	{

       	 f = (c * 9.0 / 5.0) + 32;

        	lblResultado.Text = f.ToString("0.00");
    	}
    	else
    	{
       		 MessageBox.Show("Ingresa un valor numérico válido.");
    	}
		}
	}
}
