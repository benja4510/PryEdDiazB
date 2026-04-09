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
    public partial class frmCarreras : Form
    {
        public frmCarreras()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            // x =  nombre variable tambien puede ser cualquier nombre, es el nombre del objeto que se va a crear (objCarreras,objColores, etc)
            clsArchivo x = new clsArchivo();
            x.NomArchi = "Carreras.csv";
            x.Grabar(txtCarrera.Text);
            x.Recorrer(lstCarreras);

            MessageBox.Show("Carrera grabada correctamente");
            // Limpia el txtCarrera despues de grabar para que el usuario pueda ingresar otra carrera sin tener que borrar el texto anterior
            txtCarrera.Clear();

        }

        private void txtCarrera_TextChanged(object sender, EventArgs e)
        {
            // Habilita o deshabilita el botón Grabar dependiendo de si el txtCarrera está vacío o no. Si el txtCarrera está vacío, el botón Grabar se deshabilita para evitar que el usuario intente grabar una carrera sin ingresar un nombre. Si el txtCarrera tiene texto, el botón Grabar se habilita para permitir que el usuario grabe la carrera.
            if (txtCarrera.Text == "")
            {
                btnGrabar.Enabled = false;
            }
            else
            {
                btnGrabar.Enabled = true;          
            
            }
    
        }

        private void frmCarreras_Load(object sender, EventArgs e)
        {
            btnGrabar.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // x =  nombre variable tambien puede ser cualquier nombre, es el nombre del objeto que se va a crear (objCarreras,objColores, etc)
            clsArchivo x = new clsArchivo();
            // El método Borrar() se llama para eliminar el archivo "Carreras.csv" si existe, lo que permite limpiar la lista de carreras. Luego, se establece el nombre del archivo nuevamente y se llama al método Recorrer() para actualizar la lista de carreras en el ListBox lstCarreras, mostrando que ya no hay carreras registradas.
            
            x.NomArchi = "Carreras.csv";
            if (MessageBox.Show(" Se borraran todas las carreras registradas , Continuar?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                x.Borrar();
                x.Recorrer(lstCarreras);
            }
        }
    }
}
