/*
 * Creado por SharpDevelop.
 * Usuario: CC1_PC44
 * Fecha: 10/12/2025
 * Hora: 02:20 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace login
{
	partial class Temperatura
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
			this.btnRegresar = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.BtnConvertir = new System.Windows.Forms.Button();
			this.TxtCelsius = new System.Windows.Forms.TextBox();
			this.LblFahrenheit = new System.Windows.Forms.Label();
			this.LblCelcius = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(263, 68);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(75, 23);
			this.btnRegresar.TabIndex = 0;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// lblResultado
			// 
			this.lblResultado.Location = new System.Drawing.Point(133, 73);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(100, 23);
			this.lblResultado.TabIndex = 10;
			// 
			// BtnConvertir
			// 
			this.BtnConvertir.Location = new System.Drawing.Point(134, 135);
			this.BtnConvertir.Margin = new System.Windows.Forms.Padding(2);
			this.BtnConvertir.Name = "BtnConvertir";
			this.BtnConvertir.Size = new System.Drawing.Size(75, 27);
			this.BtnConvertir.TabIndex = 9;
			this.BtnConvertir.Text = "Convertir";
			this.BtnConvertir.UseVisualStyleBackColor = true;
			this.BtnConvertir.Click += new System.EventHandler(this.BtnConvertirClick);
			// 
			// TxtCelsius
			// 
			this.TxtCelsius.Location = new System.Drawing.Point(133, 23);
			this.TxtCelsius.Margin = new System.Windows.Forms.Padding(2);
			this.TxtCelsius.Name = "TxtCelsius";
			this.TxtCelsius.Size = new System.Drawing.Size(76, 20);
			this.TxtCelsius.TabIndex = 8;
			// 
			// LblFahrenheit
			// 
			this.LblFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblFahrenheit.Location = new System.Drawing.Point(11, 77);
			this.LblFahrenheit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblFahrenheit.Name = "LblFahrenheit";
			this.LblFahrenheit.Size = new System.Drawing.Size(86, 19);
			this.LblFahrenheit.TabIndex = 7;
			this.LblFahrenheit.Text = "Fahrenheit";
			// 
			// LblCelcius
			// 
			this.LblCelcius.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblCelcius.Location = new System.Drawing.Point(11, 25);
			this.LblCelcius.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblCelcius.Name = "LblCelcius";
			this.LblCelcius.Size = new System.Drawing.Size(75, 19);
			this.LblCelcius.TabIndex = 6;
			this.LblCelcius.Text = "Celcius";
			// 
			// Temperatura
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(471, 193);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.BtnConvertir);
			this.Controls.Add(this.TxtCelsius);
			this.Controls.Add(this.LblFahrenheit);
			this.Controls.Add(this.LblCelcius);
			this.Controls.Add(this.btnRegresar);
			this.Name = "Temperatura";
			this.Text = "Temperatura";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label LblCelcius;
		private System.Windows.Forms.Label LblFahrenheit;
		private System.Windows.Forms.TextBox TxtCelsius;
		private System.Windows.Forms.Button BtnConvertir;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button btnRegresar;
	}
}
