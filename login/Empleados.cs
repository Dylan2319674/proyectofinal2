/*
* Creado por SharpDevelop.
* Usuario: Reyes
* Fecha: 08/12/2025
* Hora: 01:27 p. m.
*/

using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using MySql.Data.MySqlClient;
namespace login
{
    public partial class Empleados : Form
    {
        int indiceImagen = 1;
        private ErrorProvider errorProvider1;
		string conexion = "Server=localhost;Database=empleados;Uid=root;Pwd=231913;";

        public Empleados()
        {
            InitializeComponent();
            InicializarExtras();
        }

        private void InicializarExtras()
        {
            
            errorProvider1 = new ErrorProvider();
            errorProvider1.ContainerControl = this;
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "dd/MM/yyyy";

           
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("Codigo", "Código");
                dataGridView1.Columns.Add("Nombre", "Nombre");
                dataGridView1.Columns.Add("Puesto", "Puesto");
                dataGridView1.Columns.Add("Fecha", "Fecha");
                dataGridView1.Columns.Add("Sexo", "Sexo");
            }

            CargarImagen(@"imagenes\imagen1.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

       private void BtnGuardarClick(object sender, EventArgs e)
{
    bool valido = true;

    // Validación con ErrorProvider
    if (TxtCodigoEmpleado.Text == "")
    {
        errorProvider1.SetError(TxtCodigoEmpleado, "Este campo es obligatorio");
        valido = false;
    }
    else
    {
        errorProvider1.SetError(TxtCodigoEmpleado, "");
    }

    if (TxtNombre.Text == "")
    {
        errorProvider1.SetError(TxtNombre, "Este campo es obligatorio");
        valido = false;
    }
    else
    {
        errorProvider1.SetError(TxtNombre, "");
    }

    if (!valido)
        return;

    
    dataGridView1.Rows.Add(
        TxtCodigoEmpleado.Text,
        TxtNombre.Text,
        cmbPuesto.Text,
        dtpFecha.Value.ToString("dd/MM/yyyy"),
        cmbSexo.Text
    );

   
    try
    {
        using (MySqlConnection cn = new MySqlConnection(conexion))
        {
            cn.Open();

            string query = "INSERT INTO empleados (codigo, nombre, puesto) VALUES (@codigo, @nombre, @puesto)";

            MySqlCommand cmd = new MySqlCommand(query, cn);

            cmd.Parameters.AddWithValue("@codigo", int.Parse(TxtCodigoEmpleado.Text));
            cmd.Parameters.AddWithValue("@nombre", TxtNombre.Text);
            cmd.Parameters.AddWithValue("@puesto", cmbPuesto.Text);

            cmd.ExecuteNonQuery();
        }

        MessageBox.Show("Empleado guardado correctamente en MySQL");
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error al guardar en MySQL: " + ex.Message);
    }
}

        private void BtnLimpiarClick(object sender, EventArgs e)
        {
            TxtCodigoEmpleado.Clear();
            TxtNombre.Clear();
            cmbPuesto.SelectedIndex = -1;
            cmbSexo.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;

           
            errorProvider1.SetError(TxtCodigoEmpleado, "");
            errorProvider1.SetError(TxtNombre, "");
        }

            private void BtnEliminarClick(object sender, EventArgs e)
{
    if (dataGridView1.SelectedRows.Count > 0)
    {
        
        int codigo = Convert.ToInt32(
            dataGridView1.SelectedRows[0].Cells["Codigo"].Value
        );

      
        try
        {
            using (MySqlConnection cn = new MySqlConnection(conexion))
            {
                cn.Open();

                string query = "DELETE FROM empleados WHERE codigo = @codigo";
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@codigo", codigo);

                cmd.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al eliminar de MySQL: " + ex.Message);
            return;
        }

    
        dataGridView1.Rows.RemoveAt(
            dataGridView1.SelectedRows[0].Index
        );

        MessageBox.Show("Empleado eliminado correctamente.");
    }
    else
    {
        MessageBox.Show("Selecciona una fila");
    }
}
        
 private void CargarImagen(string nombreArchivo)
{
    try
    {
        string ruta = Path.Combine(Application.StartupPath, nombreArchivo);

        if (!File.Exists(ruta))
        {
            MessageBox.Show("NO se encontró:\n" + ruta);
            pictureBox1.Image = null;
            return;
        }

        // Liberar imagen anterior
        if (pictureBox1.Image != null)
        {
            pictureBox1.Image.Dispose();
            pictureBox1.Image = null;
        }

        using (FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read))
        {
            Image img = Image.FromStream(fs);
            pictureBox1.Image = new Bitmap(img);
        }

        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error al cargar imagen:\n" + ex.Message);
    }
}

        void BtnquitarClick(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        void BtnSalirClick(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "¿Estás seguro que quieres salir?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			
		}
		
	void BtnActualizarClick(object sender, EventArgs e)
{
    indiceImagen++;

    if (indiceImagen > 7)
        indiceImagen = 1;

    CargarImagen("imagen" + indiceImagen + ".jpg");
}
    }
}