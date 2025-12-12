/*
 * Creado por SharpDevelop.
 * Usuario: CC1_PC44
 * Fecha: 10/12/2025
 * Hora: 02:09 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace login
{
	/// <summary>
	/// Description of Trapecio.
	/// </summary>
	public partial class Trapecio : Form
	{
		public Trapecio()
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
			if(txtBaseMayor.Text == "" || txtBasemenor.Text == "" || txtAltura.Text == "")
            {
                MessageBox.Show("Completa todos los campos.");
                return;
            }

            // Convertir valores
            double B = Convert.ToDouble(txtBaseMayor.Text);
            double b = Convert.ToDouble(txtBasemenor.Text);
            double h = Convert.ToDouble(txtAltura.Text);

            // Fórmula del área del trapecio:
            // A = (B + b) / 2 * h
            double area = ((B + b) / 2) * h;

            // Mostrar resultado
            lblResultado.Text = "Área: " + area.ToString("F2");
		}
	}
}
