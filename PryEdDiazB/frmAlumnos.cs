using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEdDiazB
{
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            
            clsArchivo y = new clsArchivo();
            y.NomArchi = "Alumnos.csv";
            if (File.Exists(y.NomArchi)) y.Recorrer(DgvAlumnos);
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchi = "Alumnos.csv";
            x.Grabar(txtCodigo.Text, txtNombre.Text, cmbCarrera.Text);
            x.Recorrer(DgvAlumnos);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // x =  nombre variable tambien puede ser cualquier nombre, es el nombre del objeto que se va a crear (objCarreras,objColores, etc)
            clsArchivo x = new clsArchivo();
            // El método Borrar() se llama para eliminar el archivo "Alumnos.csv" si existe, lo que permite limpiar la lista de alumnos. Luego, se establece el nombre del archivo nuevamente y se llama al método Recorrer() para actualizar la lista de alumnos en el DataGridView DgvAlumnos, mostrando que ya no hay alumnos registrados.

            x.NomArchi = "Alumnos.csv";
            if (MessageBox.Show(" Se borraran todos los alumnos registradas , Continuar?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                x.Borrar();
                x.Recorrer(DgvAlumnos);
            }
        }
    }
}
