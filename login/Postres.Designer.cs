namespace login
{
	partial class Postres
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.btnRegresar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(118, 71);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(100, 70);
			this.btnRegresar.TabIndex = 0;
			this.btnRegresar.Text = "Calcular";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// Postres
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
			this.ClientSize = new System.Drawing.Size(334, 188);
			this.Controls.Add(this.btnRegresar);
			this.Name = "Postres";
			this.Text = "Postres";
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Button btnRegresar;
	}
}