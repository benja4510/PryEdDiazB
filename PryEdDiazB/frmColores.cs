using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PryEdDiazB
{   

    public partial class frmColores : Form
    {
        public frmColores()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            // x =  nombre variable tambien puede ser cualquier nombre, es el nombre del objeto que se va a crear (objCarreras,objColores, etc)
            clsArchivo x = new clsArchivo();
            x.NomArchi = "Colores.txt";
            x.Grabar(txtNombre.Text);
            x.Recorrer(lstColores);

            MessageBox.Show("Color grabado correctamente");
            // Limpio el txtNombre para que el usuario pueda ingresar otro color
            txtNombre.Text = "";
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            // Habilita o deshabilita el botón Grabar dependiendo de si el txtNombre está vacío o no. Si el txtNombre está vacío, el botón Grabar se deshabilita para evitar que el usuario intente grabar un color sin ingresar un nombre. Si el txtNombre tiene texto, el botón Grabar se habilita para permitir que el usuario grabe el color.
            if (txtNombre.Text == "")
            {
                btnGrabar.Enabled = false;
            }
            else
            {
                btnGrabar.Enabled = true;
            }


        }

        private void frmColores_Load(object sender, EventArgs e)
        {
            btnGrabar.Enabled=false;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchi = "Colores.txt";
            if (MessageBox.Show(" Se borraran todos los colores registrados , Continuar?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                x.Borrar();
                x.Recorrer(lstColores);
            }
        }
    }
}
