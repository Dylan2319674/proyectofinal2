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
	partial class Empleados
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
			this.components = new System.ComponentModel.Container();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.BtnSalir = new System.Windows.Forms.Button();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BtnEliminar = new System.Windows.Forms.Button();
			this.BtnLimpiar = new System.Windows.Forms.Button();
			this.BtnGuardar = new System.Windows.Forms.Button();
			this.BtnActualizar = new System.Windows.Forms.Button();
			this.Btnquitar = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.cmbSexo = new System.Windows.Forms.ComboBox();
			this.Lblsexo = new System.Windows.Forms.Label();
			this.LblFechaNac = new System.Windows.Forms.Label();
			this.cmbPuesto = new System.Windows.Forms.ComboBox();
			this.TxtNombre = new System.Windows.Forms.TextBox();
			this.TxtCodigoEmpleado = new System.Windows.Forms.TextBox();
			this.LblPuesto = new System.Windows.Forms.Label();
			this.LblNombreEmpleado = new System.Windows.Forms.Label();
			this.LblCodigoEmpleado = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(558, 456);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(75, 23);
			this.btnRegresar.TabIndex = 0;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// BtnSalir
			// 
			this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnSalir.Location = new System.Drawing.Point(429, 436);
			this.BtnSalir.Margin = new System.Windows.Forms.Padding(2);
			this.BtnSalir.Name = "BtnSalir";
			this.BtnSalir.Size = new System.Drawing.Size(86, 43);
			this.BtnSalir.TabIndex = 37;
			this.BtnSalir.Text = "Salir";
			this.BtnSalir.UseVisualStyleBackColor = false;
			this.BtnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// dtpFecha
			// 
			this.dtpFecha.CalendarMonthBackground = System.Drawing.Color.White;
			this.dtpFecha.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFecha.Location = new System.Drawing.Point(167, 173);
			this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(228, 19);
			this.dtpFecha.TabIndex = 36;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Codigo,
									this.Nombre,
									this.Puesto,
									this.Fecha,
									this.Sexo});
			this.dataGridView1.Location = new System.Drawing.Point(9, 251);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(583, 146);
			this.dataGridView1.TabIndex = 35;
			// 
			// Codigo
			// 
			this.Codigo.HeaderText = "Codigo";
			this.Codigo.Name = "Codigo";
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			// 
			// Puesto
			// 
			this.Puesto.HeaderText = "Puesto";
			this.Puesto.Name = "Puesto";
			// 
			// Fecha
			// 
			this.Fecha.HeaderText = "FechaNac";
			this.Fecha.Name = "Fecha";
			// 
			// Sexo
			// 
			this.Sexo.HeaderText = "Sexo";
			this.Sexo.Name = "Sexo";
			// 
			// BtnEliminar
			// 
			this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnEliminar.Location = new System.Drawing.Point(308, 436);
			this.BtnEliminar.Margin = new System.Windows.Forms.Padding(2);
			this.BtnEliminar.Name = "BtnEliminar";
			this.BtnEliminar.Size = new System.Drawing.Size(86, 43);
			this.BtnEliminar.TabIndex = 34;
			this.BtnEliminar.Text = "Eliminar";
			this.BtnEliminar.UseVisualStyleBackColor = false;
			this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// BtnLimpiar
			// 
			this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnLimpiar.Location = new System.Drawing.Point(196, 436);
			this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(2);
			this.BtnLimpiar.Name = "BtnLimpiar";
			this.BtnLimpiar.Size = new System.Drawing.Size(86, 43);
			this.BtnLimpiar.TabIndex = 33;
			this.BtnLimpiar.Text = "Lmpiar";
			this.BtnLimpiar.UseVisualStyleBackColor = false;
			this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// BtnGuardar
			// 
			this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnGuardar.Location = new System.Drawing.Point(75, 436);
			this.BtnGuardar.Margin = new System.Windows.Forms.Padding(2);
			this.BtnGuardar.Name = "BtnGuardar";
			this.BtnGuardar.Size = new System.Drawing.Size(86, 43);
			this.BtnGuardar.TabIndex = 32;
			this.BtnGuardar.Text = "Guardar";
			this.BtnGuardar.UseVisualStyleBackColor = false;
			this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// BtnActualizar
			// 
			this.BtnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnActualizar.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnActualizar.Location = new System.Drawing.Point(444, 207);
			this.BtnActualizar.Margin = new System.Windows.Forms.Padding(2);
			this.BtnActualizar.Name = "BtnActualizar";
			this.BtnActualizar.Size = new System.Drawing.Size(71, 39);
			this.BtnActualizar.TabIndex = 31;
			this.BtnActualizar.Text = "Actualizar";
			this.BtnActualizar.UseVisualStyleBackColor = false;
			this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizarClick);
			// 
			// Btnquitar
			// 
			this.Btnquitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Btnquitar.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btnquitar.Location = new System.Drawing.Point(522, 207);
			this.Btnquitar.Margin = new System.Windows.Forms.Padding(2);
			this.Btnquitar.Name = "Btnquitar";
			this.Btnquitar.Size = new System.Drawing.Size(71, 39);
			this.Btnquitar.TabIndex = 30;
			this.Btnquitar.Text = "Quitar";
			this.Btnquitar.UseVisualStyleBackColor = false;
			this.Btnquitar.Click += new System.EventHandler(this.BtnquitarClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(444, 14);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(149, 176);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 29;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// cmbSexo
			// 
			this.cmbSexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.cmbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.cmbSexo.FormattingEnabled = true;
			this.cmbSexo.Items.AddRange(new object[] {
									"Hombre",
									"Mujer ",
									"Otro"});
			this.cmbSexo.Location = new System.Drawing.Point(167, 218);
			this.cmbSexo.Margin = new System.Windows.Forms.Padding(2);
			this.cmbSexo.Name = "cmbSexo";
			this.cmbSexo.Size = new System.Drawing.Size(92, 21);
			this.cmbSexo.TabIndex = 28;
			// 
			// Lblsexo
			// 
			this.Lblsexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Lblsexo.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lblsexo.Location = new System.Drawing.Point(10, 220);
			this.Lblsexo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Lblsexo.Name = "Lblsexo";
			this.Lblsexo.Size = new System.Drawing.Size(75, 19);
			this.Lblsexo.TabIndex = 27;
			this.Lblsexo.Text = "Sexo";
			// 
			// LblFechaNac
			// 
			this.LblFechaNac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.LblFechaNac.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblFechaNac.Location = new System.Drawing.Point(10, 172);
			this.LblFechaNac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblFechaNac.Name = "LblFechaNac";
			this.LblFechaNac.Size = new System.Drawing.Size(130, 19);
			this.LblFechaNac.TabIndex = 26;
			this.LblFechaNac.Text = "Fecha de nacimiento";
			// 
			// cmbPuesto
			// 
			this.cmbPuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.cmbPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.cmbPuesto.FormattingEnabled = true;
			this.cmbPuesto.Items.AddRange(new object[] {
									"Gerente ",
									"Supervisor ",
									"Secretario(a)",
									"Recepcionista",
									"Contador(a)",
									"Programador ",
									"Tecnico",
									"Jefe",
									"Conserje",
									"",
									""});
			this.cmbPuesto.Location = new System.Drawing.Point(167, 113);
			this.cmbPuesto.Margin = new System.Windows.Forms.Padding(2);
			this.cmbPuesto.Name = "cmbPuesto";
			this.cmbPuesto.Size = new System.Drawing.Size(92, 21);
			this.cmbPuesto.TabIndex = 25;
			// 
			// TxtNombre
			// 
			this.TxtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.TxtNombre.Location = new System.Drawing.Point(167, 57);
			this.TxtNombre.Margin = new System.Windows.Forms.Padding(2);
			this.TxtNombre.Name = "TxtNombre";
			this.TxtNombre.Size = new System.Drawing.Size(228, 19);
			this.TxtNombre.TabIndex = 24;
			// 
			// TxtCodigoEmpleado
			// 
			this.TxtCodigoEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.TxtCodigoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtCodigoEmpleado.Location = new System.Drawing.Point(167, 14);
			this.TxtCodigoEmpleado.Margin = new System.Windows.Forms.Padding(2);
			this.TxtCodigoEmpleado.Name = "TxtCodigoEmpleado";
			this.TxtCodigoEmpleado.Size = new System.Drawing.Size(228, 21);
			this.TxtCodigoEmpleado.TabIndex = 23;
			// 
			// LblPuesto
			// 
			this.LblPuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.LblPuesto.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblPuesto.Location = new System.Drawing.Point(12, 119);
			this.LblPuesto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblPuesto.Name = "LblPuesto";
			this.LblPuesto.Size = new System.Drawing.Size(75, 19);
			this.LblPuesto.TabIndex = 22;
			this.LblPuesto.Text = "Puesto";
			// 
			// LblNombreEmpleado
			// 
			this.LblNombreEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.LblNombreEmpleado.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblNombreEmpleado.Location = new System.Drawing.Point(10, 63);
			this.LblNombreEmpleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblNombreEmpleado.Name = "LblNombreEmpleado";
			this.LblNombreEmpleado.Size = new System.Drawing.Size(130, 19);
			this.LblNombreEmpleado.TabIndex = 21;
			this.LblNombreEmpleado.Text = "Nombre del Empleado";
			// 
			// LblCodigoEmpleado
			// 
			this.LblCodigoEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.LblCodigoEmpleado.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblCodigoEmpleado.Location = new System.Drawing.Point(10, 14);
			this.LblCodigoEmpleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblCodigoEmpleado.Name = "LblCodigoEmpleado";
			this.LblCodigoEmpleado.Size = new System.Drawing.Size(130, 19);
			this.LblCodigoEmpleado.TabIndex = 20;
			this.LblCodigoEmpleado.Text = "Codigo del empleado";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// Empleados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(753, 552);
			this.Controls.Add(this.BtnSalir);
			this.Controls.Add(this.dtpFecha);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.BtnEliminar);
			this.Controls.Add(this.BtnLimpiar);
			this.Controls.Add(this.BtnGuardar);
			this.Controls.Add(this.BtnActualizar);
			this.Controls.Add(this.Btnquitar);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.cmbSexo);
			this.Controls.Add(this.Lblsexo);
			this.Controls.Add(this.LblFechaNac);
			this.Controls.Add(this.cmbPuesto);
			this.Controls.Add(this.TxtNombre);
			this.Controls.Add(this.TxtCodigoEmpleado);
			this.Controls.Add(this.LblPuesto);
			this.Controls.Add(this.LblNombreEmpleado);
			this.Controls.Add(this.LblCodigoEmpleado);
			this.Controls.Add(this.btnRegresar);
			this.Name = "Empleados";
			this.Text = "Empleados";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
		private System.Windows.Forms.Label LblCodigoEmpleado;
		private System.Windows.Forms.Label LblNombreEmpleado;
		private System.Windows.Forms.Label LblPuesto;
		private System.Windows.Forms.TextBox TxtCodigoEmpleado;
		private System.Windows.Forms.TextBox TxtNombre;
		private System.Windows.Forms.ComboBox cmbPuesto;
		private System.Windows.Forms.Label LblFechaNac;
		private System.Windows.Forms.Label Lblsexo;
		private System.Windows.Forms.ComboBox cmbSexo;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button Btnquitar;
		private System.Windows.Forms.Button BtnActualizar;
		private System.Windows.Forms.Button BtnGuardar;
		private System.Windows.Forms.Button BtnLimpiar;
		private System.Windows.Forms.Button BtnEliminar;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.Button BtnSalir;
		private System.Windows.Forms.Button btnRegresar;
	}
}
