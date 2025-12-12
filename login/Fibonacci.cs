/*
 * Creado por SharpDevelop.
 * Usuario: CC1_PC44
 * Fecha: 10/12/2025
 * Hora: 02:07 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace login
{
	/// <summary>
	/// Description of Fibonacci.
	/// </summary>
	public partial class Fibonacci : Form
	{
		public Fibonacci()
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
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			int n = int.Parse(txtNumero.Text);

    		int a = 0;
    		int b = 1;
    		int c = 0;

    		if (n == 0) c = 0;
    		else if (n == 1) c = 1;
   		 else
   		 {
       		 for (int i = 2; i <= n; i++)
       	 {
           		 c = a + b;
           		 a = b;
           		 b = c;
       	 }
    	}

    			lblResultado.Text = c.ToString();
		}
	}
}
