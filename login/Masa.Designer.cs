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
	partial class Masa
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
			this.TxtKilogramos = new System.Windows.Forms.TextBox();
			this.LblLibras = new System.Windows.Forms.Label();
			this.LblKilogramos = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(275, 83);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(75, 23);
			this.btnRegresar.TabIndex = 0;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// lblResultado
			// 
			this.lblResultado.Location = new System.Drawing.Point(148, 83);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(100, 23);
			this.lblResultado.TabIndex = 11;
			// 
			// BtnConvertir
			// 
			this.BtnConvertir.BackColor = System.Drawing.Color.Transparent;
			this.BtnConvertir.Location = new System.Drawing.Point(148, 128);
			this.BtnConvertir.Margin = new System.Windows.Forms.Padding(2);
			this.BtnConvertir.Name = "BtnConvertir";
			this.BtnConvertir.Size = new System.Drawing.Size(76, 28);
			this.BtnConvertir.TabIndex = 10;
			this.BtnConvertir.Text = "Convertir";
			this.BtnConvertir.UseVisualStyleBackColor = false;
			this.BtnConvertir.Click += new System.EventHandler(this.BtnConvertirClick);
			// 
			// TxtKilogramos
			// 
			this.TxtKilogramos.BackColor = System.Drawing.Color.White;
			this.TxtKilogramos.Location = new System.Drawing.Point(148, 43);
			this.TxtKilogramos.Margin = new System.Windows.Forms.Padding(2);
			this.TxtKilogramos.Name = "TxtKilogramos";
			this.TxtKilogramos.Size = new System.Drawing.Size(88, 20);
			this.TxtKilogramos.TabIndex = 9;
			// 
			// LblLibras
			// 
			this.LblLibras.BackColor = System.Drawing.Color.Transparent;
			this.LblLibras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblLibras.Location = new System.Drawing.Point(32, 83);
			this.LblLibras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblLibras.Name = "LblLibras";
			this.LblLibras.Size = new System.Drawing.Size(75, 19);
			this.LblLibras.TabIndex = 8;
			this.LblLibras.Text = "LIbras";
			// 
			// LblKilogramos
			// 
			this.LblKilogramos.BackColor = System.Drawing.Color.Transparent;
			this.LblKilogramos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblKilogramos.Location = new System.Drawing.Point(32, 43);
			this.LblKilogramos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblKilogramos.Name = "LblKilogramos";
			this.LblKilogramos.Size = new System.Drawing.Size(94, 19);
			this.LblKilogramos.TabIndex = 7;
			this.LblKilogramos.Text = "Kilogramos";
			// 
			// Masa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(379, 188);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.BtnConvertir);
			this.Controls.Add(this.TxtKilogramos);
			this.Controls.Add(this.LblLibras);
			this.Controls.Add(this.LblKilogramos);
			this.Controls.Add(this.btnRegresar);
			this.Name = "Masa";
			this.Text = "Masa";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label LblKilogramos;
		private System.Windows.Forms.Label LblLibras;
		private System.Windows.Forms.TextBox TxtKilogramos;
		private System.Windows.Forms.Button BtnConvertir;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button btnRegresar;
	}
}
