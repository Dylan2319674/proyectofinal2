/*
 * Creado por SharpDevelop.
 * Usuario: CC1_PC44
 * Fecha: 10/12/2025
 * Hora: 02:21 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace login
{
    public partial class Empleados : Form
    {
        int indiceImagen = 1;

        public Empleados()
        {
            InitializeComponent();
        }

        void EmpleadosLoad(object sender, EventArgs e)
        {
            string ruta = Application.StartupPath + @"\Imagen1.jpg";
        }

        void BtnRegresarClick(object sender, EventArgs e)
        {
            Principal FormularioPrincipal = new Principal();
            FormularioPrincipal.Show();
            this.Hide();
        }

        void BtnGuardarClick(object sender, EventArgs e)
        {
            if (TxtCodigoEmpleado.Text == "" || TxtNombre.Text == "")
            {
                MessageBox.Show("Llena los campos obligatorios");
                return;
            }

            dataGridView1.Rows.Add(
                TxtCodigoEmpleado.Text,
                TxtNombre.Text,
                cmbPuesto.Text,
                dtpFecha.Value.ToString("dd/MM/yyyy"),
                cmbSexo.Text
            );
        }

        void BtnLimpiarClick(object sender, EventArgs e)
        {
            TxtCodigoEmpleado.Clear();
            TxtNombre.Clear();
            cmbPuesto.SelectedIndex = -1;
            cmbSexo.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
        }

        void BtnEliminarClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Selecciona una fila");
            }
        }

        void BtnActualizarClick(object sender, EventArgs e)
        {
            indiceImagen++;

            if (indiceImagen > 7)
                indiceImagen = 1;

            string ruta = Application.StartupPath + @"\Imagen" + indiceImagen + ".jpg";
            pictureBox1.Image = Image.FromFile(ruta);
        }

        void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
		
		void BtnquitarClick(object sender, EventArgs e)
		{
			    pictureBox1.Image = null;

		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			DialogResult r = MessageBox.Show(
        "¿Estás seguro que quieres salir?",
        "Salir",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

    if (r == DialogResult.Yes)
    {
        Application.Exit();
    }
		}
    }
}
