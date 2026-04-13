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
            clsArchivo x = new clsArchivo();
            x.NomArchi = "Carreras.csv";
            if (File.Exists(x.NomArchi)) x.Recorrer(cmbCarrera);

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
    }
}
