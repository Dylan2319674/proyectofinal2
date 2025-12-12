/*
 * Creado por SharpDevelop.
 * Usuario: CC1_PC44
 * Fecha: 10/12/2025
 * Hora: 02:21 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace login
{
	partial class Tiempo
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtSegundos = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnConvertir = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(309, 89);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(75, 23);
			this.btnRegresar.TabIndex = 0;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(49, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Segundos:";
			// 
			// txtSegundos
			// 
			this.txtSegundos.Location = new System.Drawing.Point(174, 39);
			this.txtSegundos.Name = "txtSegundos";
			this.txtSegundos.Size = new System.Drawing.Size(100, 20);
			this.txtSegundos.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(49, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Horas:";
			// 
			// btnConvertir
			// 
			this.btnConvertir.Location = new System.Drawing.Point(189, 136);
			this.btnConvertir.Name = "btnConvertir";
			this.btnConvertir.Size = new System.Drawing.Size(75, 23);
			this.btnConvertir.TabIndex = 4;
			this.btnConvertir.Text = "Convertir";
			this.btnConvertir.UseVisualStyleBackColor = true;
			this.btnConvertir.Click += new System.EventHandler(this.BtnConvertirClick);
			// 
			// lblResultado
			// 
			this.lblResultado.Location = new System.Drawing.Point(174, 89);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(100, 23);
			this.lblResultado.TabIndex = 5;
			// 
			// Tiempo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(409, 202);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.btnConvertir);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtSegundos);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnRegresar);
			this.Name = "Tiempo";
			this.Text = "Tiempo";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button btnConvertir;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSegundos;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnRegresar;
	}
}
