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
    public partial class frmDias : Form
    {
        public frmDias()
        {
            InitializeComponent();
        }

        private void frmDias_Load(object sender, EventArgs e)
        {
            {
                
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // x =  nombre variable tambien puede ser cualquier nombre, es el nombre del objeto que se va a crear (objCarreras,objColores, etc)
            clsArchivo x = new clsArchivo();
            x.NomArchi = "Dias.txt";
            if (MessageBox.Show(" Se borraran todos los días registrados , Continuar?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                x.Borrar();
                x.Recorrer(lstDias);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            // x =  nombre variable tambien puede ser cualquier nombre, es el nombre del objeto que se va a crear (objCarreras,objColores, etc)
            // Instanciamos la clase Archivo
            clsArchivo x = new clsArchivo();
            // Asignamos el nombre del archivo a la propiedad NomArchi
            x.NomArchi = "Dias.txt";
            // Grabamos el día ingresado en el dtpDias
            x.Grabar(dtpDias.Text);
            // Recorrermos el ListBox para mostrar los días grabados
            x.Recorrer(lstDias);

            MessageBox.Show("Día grabado correctamente");
            dtpDias.Text = "";
        }
    }
}
