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
	/// Description of Masa.
	/// </summary>
	public partial class Masa : Form
	{
		public Masa()
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
				double kg, libras;

		
   				 if (double.TryParse(TxtKilogramos.Text, out kg))
    		{

       			 libras = kg * 2.20462;

       		 lblResultado.Text = libras.ToString("0.00");
   		 }
   			 else
   			 {
      			  MessageBox.Show("Ingresa un valor numérico válido.");
   			 }
		}
	}
}
