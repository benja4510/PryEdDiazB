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
    public partial class frmProvincias : Form
    {
        public frmProvincias()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            // x =  nombre variable tambien puede ser cualquier nombre, es el nombre del objeto que se va a crear (objCarreras,objColores, etc)
            // Instanciamos la clase Archivo
            clsArchivo x = new clsArchivo();
            // Asignamos el nombre del archivo a la propiedad NomArchi
            x.NomArchi = "Ciudad.txt";
            // Grabamos el mes ingresado en el txtMes
            x.Grabar(txtProvincia.Text);
            // Recorrermos el ListBox para mostrar los meses grabados
            x.Recorrer(lstProvincias);

            MessageBox.Show("Provincia grabada correctamente");
            txtProvincia.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // x =  nombre variable tambien puede ser cualquier nombre, es el nombre del objeto que se va a crear (objCarreras,objColores, etc)
            clsArchivo x = new clsArchivo();
            x.NomArchi = "Provincias.txt";
            if (MessageBox.Show(" Se borraran todas las provincias registradas , Continuar?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                x.Borrar();
                x.Recorrer(lstProvincias);
            }
        }

        private void txtProvincia_TextChanged(object sender, EventArgs e)
        {
            if (txtProvincia.Text == "")
            {
                btnGrabar.Enabled = false;
            }
            else
            {
                btnGrabar.Enabled = true;
            }
        }

        private void frmProvincias_Load(object sender, EventArgs e)
        {
            btnGrabar.Enabled = false;
        }
    }
}