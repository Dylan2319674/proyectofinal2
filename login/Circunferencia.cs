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
	/// Description of Circunferencia.
	/// </summary>
	public partial class Circunferencia : Form
	{
		public Circunferencia()
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
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			 if(txtRadio.Text == "")
			 {
			 	MessageBox.Show("Ingresa un valor para el radio");
                return;
			 }
			  double radio = Convert.ToDouble(txtRadio.Text);
			  double diametro = radio * 2;
           	  double circunferencia = 2 * Math.PI * radio;
           	  double area = Math.PI * radio * radio;
           	  
           	  lblResultado.Text =
                "Diámetro: " + diametro.ToString("F2") + "\n" +
                "Circunferencia: " + circunferencia.ToString("F2") + "\n" +
                "Área: " + area.ToString("F2");
		}
	}
}
