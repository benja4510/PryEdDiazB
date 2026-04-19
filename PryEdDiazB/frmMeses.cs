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
    public partial class frmMeses : Form
    {
        public frmMeses()
        {
            InitializeComponent();
        }

        private void frmMeses_Load(object sender, EventArgs e)
        {
            btnGrabar.Enabled = false;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            // x =  nombre variable tambien puede ser cualquier nombre, es el nombre del objeto que se va a crear (objCarreras,objColores, etc)
            // Instanciamos la clase Archivo
            clsArchivo x = new clsArchivo();
            // Asignamos el nombre del archivo a la propiedad NomArchi
            x.NomArchi = "Meses.txt";
            // Grabamos el mes ingresado en el txtMes
            x.Grabar(txtMes.Text);
            // Recorrermos el ListBox para mostrar los meses grabados
            x.Recorrer(lstMeses);

            MessageBox.Show("Mes grabado correctamente");
            txtMes.Text = "";

        }

        private void txtMes_TextChanged(object sender, EventArgs e)
        {
            if (txtMes.Text == "")
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
            if (MessageBox.Show(" Se borraran todos los meses registrados , Continuar?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                x.Borrar();
                x.Recorrer(lstMeses);
            }


        }

        private void lstMeses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
