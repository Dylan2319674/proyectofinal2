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
			this.btnCalcular = new System.Windows.Forms.Button();
			this.txtCelcius = new System.Windows.Forms.TextBox();
			this.lblResultado = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(247, 59);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(75, 23);
			this.btnRegresar.TabIndex = 0;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(115, 120);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 23);
			this.btnCalcular.TabIndex = 15;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// txtCelcius
			// 
			this.txtCelcius.Location = new System.Drawing.Point(115, 9);
			this.txtCelcius.Name = "txtCelcius";
			this.txtCelcius.Size = new System.Drawing.Size(100, 20);
			this.txtCelcius.TabIndex = 14;
			// 
			// lblResultado
			// 
			this.lblResultado.Location = new System.Drawing.Point(118, 64);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(100, 23);
			this.lblResultado.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 12;
			this.label2.Text = "Farenheit:";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 11;
			this.label1.Text = "Celcius:";
			// 
			// Temperatura
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(350, 168);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtCelcius);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnRegresar);
			this.Name = "Temperatura";
			this.Text = "Temperatura";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.TextBox txtCelcius;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Button btnRegresar;
	}
}