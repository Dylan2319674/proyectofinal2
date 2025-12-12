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
	partial class Longitud
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
			this.LblMillas = new System.Windows.Forms.Label();
			this.btnConvertir = new System.Windows.Forms.Button();
			this.TxtKilometros = new System.Windows.Forms.TextBox();
			this.LblkKilometros = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(327, 86);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(75, 23);
			this.btnRegresar.TabIndex = 11;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// lblResultado
			// 
			this.lblResultado.Location = new System.Drawing.Point(137, 86);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(100, 23);
			this.lblResultado.TabIndex = 10;
			// 
			// LblMillas
			// 
			this.LblMillas.BackColor = System.Drawing.Color.Transparent;
			this.LblMillas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblMillas.Location = new System.Drawing.Point(25, 84);
			this.LblMillas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblMillas.Name = "LblMillas";
			this.LblMillas.Size = new System.Drawing.Size(75, 20);
			this.LblMillas.TabIndex = 9;
			this.LblMillas.Text = "Millas";
			// 
			// btnConvertir
			// 
			this.btnConvertir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnConvertir.Location = new System.Drawing.Point(144, 146);
			this.btnConvertir.Margin = new System.Windows.Forms.Padding(2);
			this.btnConvertir.Name = "btnConvertir";
			this.btnConvertir.Size = new System.Drawing.Size(91, 26);
			this.btnConvertir.TabIndex = 8;
			this.btnConvertir.Text = "Convertir";
			this.btnConvertir.UseVisualStyleBackColor = false;
			this.btnConvertir.Click += new System.EventHandler(this.BtnConvertirClick);
			// 
			// TxtKilometros
			// 
			this.TxtKilometros.BackColor = System.Drawing.Color.White;
			this.TxtKilometros.Location = new System.Drawing.Point(137, 28);
			this.TxtKilometros.Margin = new System.Windows.Forms.Padding(2);
			this.TxtKilometros.Name = "TxtKilometros";
			this.TxtKilometros.Size = new System.Drawing.Size(98, 20);
			this.TxtKilometros.TabIndex = 7;
			// 
			// LblkKilometros
			// 
			this.LblkKilometros.BackColor = System.Drawing.Color.Transparent;
			this.LblkKilometros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblkKilometros.Location = new System.Drawing.Point(25, 28);
			this.LblkKilometros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblkKilometros.Name = "LblkKilometros";
			this.LblkKilometros.Size = new System.Drawing.Size(75, 19);
			this.LblkKilometros.TabIndex = 6;
			this.LblkKilometros.Text = "Kilometros";
			// 
			// Longitud
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(483, 201);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.LblMillas);
			this.Controls.Add(this.btnConvertir);
			this.Controls.Add(this.TxtKilometros);
			this.Controls.Add(this.LblkKilometros);
			this.Name = "Longitud";
			this.Text = "Longitud";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label LblkKilometros;
		private System.Windows.Forms.TextBox TxtKilometros;
		private System.Windows.Forms.Button btnConvertir;
		private System.Windows.Forms.Label LblMillas;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button btnRegresar;
	}
}
