using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEdDiazB
{
    public partial class frmCiudades : Form
    {
        public frmCiudades()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtCiudad.Text == "")
            {
                btnGrabar.Enabled = false;
            }
            else
            {
                btnGrabar.Enabled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // x =  nombre variable tambien puede ser cualquier nombre, es el nombre del objeto que se va a crear (objCarreras,objColores, etc)
            clsArchivo x = new clsArchivo();
            x.NomArchi = "Meses.txt";
            if (MessageBox.Show(" Se borraran todoss los meses registrados , Continuar?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                x.Borrar();
                x.Recorrer(lstCiudades);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            // x =  nombre variable tambien puede ser cualquier nombre, es el nombre del objeto que se va a crear (objCarreras,objColores, etc)
            // Instanciamos la clase Archivo
            clsArchivo x = new clsArchivo();
            // Asignamos el nombre del archivo a la propiedad NomArchi
            x.NomArchi = "Ciudad.txt";
            // Grabamos el mes ingresado en el txtMes
            x.Grabar(txtCiudad.Text);
            // Recorrermos el ListBox para mostrar los meses grabados
            x.Recorrer(lstCiudades);

            MessageBox.Show("Ciudad grabada correctamente");
            txtCiudad.Text = "";
        }
    }
}
