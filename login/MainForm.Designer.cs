/*
 * Created by SharpDevelop.
 * User: CC2_PC28
 * Date: 08/12/2025
 * Time: 05:37 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace login
{
	partial class MainForm
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
			this.btnEntrar = new System.Windows.Forms.Button();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtContraseña = new System.Windows.Forms.TextBox();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.lblContraseña = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnEntrar
			// 
			this.btnEntrar.Location = new System.Drawing.Point(183, 132);
			this.btnEntrar.Name = "btnEntrar";
			this.btnEntrar.Size = new System.Drawing.Size(75, 23);
			this.btnEntrar.TabIndex = 0;
			this.btnEntrar.Text = "Entrar";
			this.btnEntrar.UseVisualStyleBackColor = true;
			this.btnEntrar.Click += new System.EventHandler(this.BtnEntrarClick);
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(160, 32);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(102, 20);
			this.txtUsuario.TabIndex = 1;
			this.txtUsuario.TextChanged += new System.EventHandler(this.TxtUsuarioTextChanged);
			// 
			// txtContraseña
			// 
			this.txtContraseña.Location = new System.Drawing.Point(162, 83);
			this.txtContraseña.Name = "txtContraseña";
			this.txtContraseña.Size = new System.Drawing.Size(100, 20);
			this.txtContraseña.TabIndex = 2;
			// 
			// lblUsuario
			// 
			this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsuario.Location = new System.Drawing.Point(56, 33);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(100, 23);
			this.lblUsuario.TabIndex = 3;
			this.lblUsuario.Text = "Usuario:";
			// 
			// lblContraseña
			// 
			this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblContraseña.Location = new System.Drawing.Point(56, 80);
			this.lblContraseña.Name = "lblContraseña";
			this.lblContraseña.Size = new System.Drawing.Size(100, 23);
			this.lblContraseña.TabIndex = 4;
			this.lblContraseña.Text = "Contraseña:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.lblContraseña);
			this.Controls.Add(this.lblUsuario);
			this.Controls.Add(this.txtContraseña);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.btnEntrar);
			this.Name = "MainForm";
			this.Text = "login";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblContraseña;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.TextBox txtContraseña;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Button btnEntrar;
	}
}
