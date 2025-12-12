/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC29
 * Fecha: 08/12/2025
 * Hora: 06:08 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace login
{
	/// <summary>
	/// Description of Principal.
	/// </summary>
	public partial class Principal : Form
	{
		public Principal()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void FactorialToolStripMenuItemClick(object sender, EventArgs e)
		{
			Factorial FormularioFactorial = new Factorial();
			FormularioFactorial.Show();
			this.Hide();
		}
		
		void FIbonacciToolStripMenuItemClick(object sender, EventArgs e)
		{
			Fibonacci FormularioFibonacci = new Fibonacci();
			FormularioFibonacci.Show();
			this.Hide();
		}
		
		void CuadradoToolStripMenuItemClick(object sender, EventArgs e)
		{
			Cuadrado FormularioCuadrado = new Cuadrado();
			FormularioCuadrado.Show();
			this.Hide();
		}
		
		void RectanguloToolStripMenuItemClick(object sender, EventArgs e)
		{
			Rectangulo FormularioRectangulo = new Rectangulo();
			FormularioRectangulo.Show();
			this.Hide();
		}
		
		void TrianguloToolStripMenuItemClick(object sender, EventArgs e)
		{
			Triangulo FormularioTriangulo = new Triangulo();
			FormularioTriangulo.Show();
			this.Hide();
		}
		
		void CircunferenciaToolStripMenuItemClick(object sender, EventArgs e)
		{
			Circunferencia FormularioCircunferencia = new Circunferencia();
			FormularioCircunferencia.Show();
			this.Hide();
		}
		
		void TrapecioToolStripMenuItemClick(object sender, EventArgs e)
		{
			Trapecio FormularioTrapecio = new Trapecio();
			FormularioTrapecio.Show();
			this.Hide();
		}
		
		void EsferaToolStripMenuItemClick(object sender, EventArgs e)
		{
			Esfera FormularioEsfera = new Esfera();
			FormularioEsfera.Show();
			this.Hide();
		}
		
		void CuboToolStripMenuItemClick(object sender, EventArgs e)
		{
			Cubo FormularioCubo = new Cubo();
			FormularioCubo.Show();
			this.Hide();
		}
		
		void KilometrosAMillasToolStripMenuItemClick(object sender, EventArgs e)
		{
			Longitud FormularioLongitud = new Longitud();
			FormularioLongitud.Show();
			this.Hide();
		}
		
		void KilogramosALibrasToolStripMenuItemClick(object sender, EventArgs e)
		{
			Masa FormularioMasa = new Masa();
			FormularioMasa.Show();
			this.Hide();
		}
		
		void CelciusAFarenheitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Temperatura FormularioTemperatura = new Temperatura();
			FormularioTemperatura.Show();
			this.Hide();
		}
		
		void SegundosAHorasToolStripMenuItemClick(object sender, EventArgs e)
		{
			Tiempo FormularioTiempo = new Tiempo();
			FormularioTiempo.Show();
			this.Hide();
		}
		
		void BoletaDeCalificacionesToolStripMenuItemClick(object sender, EventArgs e)
		{
			Boleta FormularioBoleta = new Boleta();

			this.Hide();
		}
		
		void PostresToolStripMenuItemClick(object sender, EventArgs e)
		{
			Postres FormularioPostres = new Postres();
			FormularioPostres.Show();
			this.Hide();
		}
		
		void EmpleadosToolStripMenuItemClick(object sender, EventArgs e)
		{
			Empleados FormularioEmpleados = new Empleados();
			FormularioEmpleados.Show();
			this.Hide();
		}
		
		void AcercaDeToolStripMenuItemClick(object sender, EventArgs e)
		{
			Acerca FormularioAcerca = new Acerca();
			FormularioAcerca.Show();
			this.Hide();
		}
		
		void ConversionesToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
		
		void LongitudToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
	}
}
