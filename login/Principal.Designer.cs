/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC29
 * Fecha: 08/12/2025
 * Hora: 06:08 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace login
{
	partial class Principal
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.aplicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.factorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fIbonacciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cuadradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rectanguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.trianguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.perimetroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.circunferenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.trapecioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.volumenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.esferaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cuboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.conversionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.longitudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kilometrosAMillasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.masaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kilogramosALibrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.temperaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.celciusAFarenheitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tiempoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.segundosAHorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.boletaDeCalificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.postresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.aplicacionesToolStripMenuItem,
									this.areaToolStripMenuItem,
									this.perimetroToolStripMenuItem,
									this.volumenToolStripMenuItem,
									this.conversionesToolStripMenuItem,
									this.boletaDeCalificacionesToolStripMenuItem,
									this.postresToolStripMenuItem,
									this.empleadosToolStripMenuItem,
									this.acercaDeToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1299, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// aplicacionesToolStripMenuItem
			// 
			this.aplicacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.factorialToolStripMenuItem,
									this.fIbonacciToolStripMenuItem});
			this.aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
			this.aplicacionesToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
			this.aplicacionesToolStripMenuItem.Text = "Aplicaciones";
			// 
			// factorialToolStripMenuItem
			// 
			this.factorialToolStripMenuItem.Name = "factorialToolStripMenuItem";
			this.factorialToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
			this.factorialToolStripMenuItem.Text = "Factorial";
			this.factorialToolStripMenuItem.Click += new System.EventHandler(this.FactorialToolStripMenuItemClick);
			// 
			// fIbonacciToolStripMenuItem
			// 
			this.fIbonacciToolStripMenuItem.Name = "fIbonacciToolStripMenuItem";
			this.fIbonacciToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
			this.fIbonacciToolStripMenuItem.Text = "FIbonacci";
			this.fIbonacciToolStripMenuItem.Click += new System.EventHandler(this.FIbonacciToolStripMenuItemClick);
			// 
			// areaToolStripMenuItem
			// 
			this.areaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.cuadradoToolStripMenuItem,
									this.rectanguloToolStripMenuItem,
									this.trianguloToolStripMenuItem});
			this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
			this.areaToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
			this.areaToolStripMenuItem.Text = "Area";
			// 
			// cuadradoToolStripMenuItem
			// 
			this.cuadradoToolStripMenuItem.Name = "cuadradoToolStripMenuItem";
			this.cuadradoToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
			this.cuadradoToolStripMenuItem.Text = "Cuadrado";
			this.cuadradoToolStripMenuItem.Click += new System.EventHandler(this.CuadradoToolStripMenuItemClick);
			// 
			// rectanguloToolStripMenuItem
			// 
			this.rectanguloToolStripMenuItem.Name = "rectanguloToolStripMenuItem";
			this.rectanguloToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
			this.rectanguloToolStripMenuItem.Text = "Rectangulo";
			this.rectanguloToolStripMenuItem.Click += new System.EventHandler(this.RectanguloToolStripMenuItemClick);
			// 
			// trianguloToolStripMenuItem
			// 
			this.trianguloToolStripMenuItem.Name = "trianguloToolStripMenuItem";
			this.trianguloToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
			this.trianguloToolStripMenuItem.Text = "Triangulo";
			this.trianguloToolStripMenuItem.Click += new System.EventHandler(this.TrianguloToolStripMenuItemClick);
			// 
			// perimetroToolStripMenuItem
			// 
			this.perimetroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.circunferenciaToolStripMenuItem,
									this.trapecioToolStripMenuItem});
			this.perimetroToolStripMenuItem.Name = "perimetroToolStripMenuItem";
			this.perimetroToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
			this.perimetroToolStripMenuItem.Text = "Perimetro";
			// 
			// circunferenciaToolStripMenuItem
			// 
			this.circunferenciaToolStripMenuItem.Name = "circunferenciaToolStripMenuItem";
			this.circunferenciaToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
			this.circunferenciaToolStripMenuItem.Text = "Circunferencia";
			this.circunferenciaToolStripMenuItem.Click += new System.EventHandler(this.CircunferenciaToolStripMenuItemClick);
			// 
			// trapecioToolStripMenuItem
			// 
			this.trapecioToolStripMenuItem.Name = "trapecioToolStripMenuItem";
			this.trapecioToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
			this.trapecioToolStripMenuItem.Text = "Trapecio";
			this.trapecioToolStripMenuItem.Click += new System.EventHandler(this.TrapecioToolStripMenuItemClick);
			// 
			// volumenToolStripMenuItem
			// 
			this.volumenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.esferaToolStripMenuItem,
									this.cuboToolStripMenuItem});
			this.volumenToolStripMenuItem.Name = "volumenToolStripMenuItem";
			this.volumenToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
			this.volumenToolStripMenuItem.Text = "Volumen";
			// 
			// esferaToolStripMenuItem
			// 
			this.esferaToolStripMenuItem.Name = "esferaToolStripMenuItem";
			this.esferaToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
			this.esferaToolStripMenuItem.Text = "Esfera";
			this.esferaToolStripMenuItem.Click += new System.EventHandler(this.EsferaToolStripMenuItemClick);
			// 
			// cuboToolStripMenuItem
			// 
			this.cuboToolStripMenuItem.Name = "cuboToolStripMenuItem";
			this.cuboToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
			this.cuboToolStripMenuItem.Text = "Cubo";
			this.cuboToolStripMenuItem.Click += new System.EventHandler(this.CuboToolStripMenuItemClick);
			// 
			// conversionesToolStripMenuItem
			// 
			this.conversionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.longitudToolStripMenuItem,
									this.masaToolStripMenuItem,
									this.temperaturaToolStripMenuItem,
									this.tiempoToolStripMenuItem});
			this.conversionesToolStripMenuItem.Name = "conversionesToolStripMenuItem";
			this.conversionesToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
			this.conversionesToolStripMenuItem.Text = "Conversiones";
			this.conversionesToolStripMenuItem.Click += new System.EventHandler(this.ConversionesToolStripMenuItemClick);
			// 
			// longitudToolStripMenuItem
			// 
			this.longitudToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.kilometrosAMillasToolStripMenuItem});
			this.longitudToolStripMenuItem.Name = "longitudToolStripMenuItem";
			this.longitudToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
			this.longitudToolStripMenuItem.Text = "Longitud";
			this.longitudToolStripMenuItem.Click += new System.EventHandler(this.LongitudToolStripMenuItemClick);
			// 
			// kilometrosAMillasToolStripMenuItem
			// 
			this.kilometrosAMillasToolStripMenuItem.Name = "kilometrosAMillasToolStripMenuItem";
			this.kilometrosAMillasToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
			this.kilometrosAMillasToolStripMenuItem.Text = "Kilometros a Millas";
			this.kilometrosAMillasToolStripMenuItem.Click += new System.EventHandler(this.KilometrosAMillasToolStripMenuItemClick);
			// 
			// masaToolStripMenuItem
			// 
			this.masaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.kilogramosALibrasToolStripMenuItem});
			this.masaToolStripMenuItem.Name = "masaToolStripMenuItem";
			this.masaToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
			this.masaToolStripMenuItem.Text = "Masa";
			// 
			// kilogramosALibrasToolStripMenuItem
			// 
			this.kilogramosALibrasToolStripMenuItem.Name = "kilogramosALibrasToolStripMenuItem";
			this.kilogramosALibrasToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
			this.kilogramosALibrasToolStripMenuItem.Text = "Kilogramos a Libras";
			this.kilogramosALibrasToolStripMenuItem.Click += new System.EventHandler(this.KilogramosALibrasToolStripMenuItemClick);
			// 
			// temperaturaToolStripMenuItem
			// 
			this.temperaturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.celciusAFarenheitToolStripMenuItem});
			this.temperaturaToolStripMenuItem.Name = "temperaturaToolStripMenuItem";
			this.temperaturaToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
			this.temperaturaToolStripMenuItem.Text = "Temperatura";
			// 
			// celciusAFarenheitToolStripMenuItem
			// 
			this.celciusAFarenheitToolStripMenuItem.Name = "celciusAFarenheitToolStripMenuItem";
			this.celciusAFarenheitToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
			this.celciusAFarenheitToolStripMenuItem.Text = "Celcius a Farenheit";
			this.celciusAFarenheitToolStripMenuItem.Click += new System.EventHandler(this.CelciusAFarenheitToolStripMenuItemClick);
			// 
			// tiempoToolStripMenuItem
			// 
			this.tiempoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.segundosAHorasToolStripMenuItem});
			this.tiempoToolStripMenuItem.Name = "tiempoToolStripMenuItem";
			this.tiempoToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
			this.tiempoToolStripMenuItem.Text = "Tiempo";
			// 
			// segundosAHorasToolStripMenuItem
			// 
			this.segundosAHorasToolStripMenuItem.Name = "segundosAHorasToolStripMenuItem";
			this.segundosAHorasToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
			this.segundosAHorasToolStripMenuItem.Text = "Segundos a horas";
			this.segundosAHorasToolStripMenuItem.Click += new System.EventHandler(this.SegundosAHorasToolStripMenuItemClick);
			// 
			// boletaDeCalificacionesToolStripMenuItem
			// 
			this.boletaDeCalificacionesToolStripMenuItem.Name = "boletaDeCalificacionesToolStripMenuItem";
			this.boletaDeCalificacionesToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
			this.boletaDeCalificacionesToolStripMenuItem.Text = "Boleta de Calificaciones";
			this.boletaDeCalificacionesToolStripMenuItem.Click += new System.EventHandler(this.BoletaDeCalificacionesToolStripMenuItemClick);
			// 
			// postresToolStripMenuItem
			// 
			this.postresToolStripMenuItem.Name = "postresToolStripMenuItem";
			this.postresToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
			this.postresToolStripMenuItem.Text = "Postres";
			this.postresToolStripMenuItem.Click += new System.EventHandler(this.PostresToolStripMenuItemClick);
			// 
			// empleadosToolStripMenuItem
			// 
			this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
			this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
			this.empleadosToolStripMenuItem.Text = "Empleados";
			this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.EmpleadosToolStripMenuItemClick);
			// 
			// acercaDeToolStripMenuItem
			// 
			this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
			this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
			this.acercaDeToolStripMenuItem.Text = "Acerca de...";
			this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.AcercaDeToolStripMenuItemClick);
			// 
			// Principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.ClientSize = new System.Drawing.Size(1299, 320);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Principal";
			this.Text = "Principal";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem postresToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem boletaDeCalificacionesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem segundosAHorasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tiempoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem celciusAFarenheitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem temperaturaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem kilogramosALibrasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem masaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem kilometrosAMillasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem longitudToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem conversionesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cuboToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem esferaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem volumenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem trapecioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem circunferenciaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem perimetroToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem trianguloToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rectanguloToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cuadradoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fIbonacciToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem factorialToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aplicacionesToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
