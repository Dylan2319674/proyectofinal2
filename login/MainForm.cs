/*
 * Created by SharpDevelop.
 * User: CC2_PC28
 * Date: 08/12/2025
 * Time: 05:37 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace login
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnEntrarClick(object sender, EventArgs e)
		{
			string usuario = txtUsuario.Text;
	string contraseña = txtContraseña.Text;
	if (usuario == "admin" && contraseña == "123")
	{
	MessageBox.Show("Inicio de sesion exitoso");
	Principal FormularioPrincipal = new Principal();
	FormularioPrincipal.Show();
	this.Hide();
	}
	else
	{	
	MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	}
		}
		
		void TxtUsuarioTextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
