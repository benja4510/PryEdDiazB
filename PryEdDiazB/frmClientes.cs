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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchi = "Clientes.csv";
            if (File.Exists(x.NomArchi)) x.Recorrer(dgvClientes);


        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchi = "Clientes.csv";
            x.Grabar(txtCodigo.Text, txtNombre.Text, txtDeuda.Text);
            x.Recorrer(dgvClientes);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            // x =  nombre variable tambien puede ser cualquier nombre, es el nombre del objeto que se va a crear (objCarreras,objColores, etc)
            clsArchivo x = new clsArchivo();
            // El método Borrar() se llama para eliminar el archivo "Clientes.csv" si existe, lo que permite limpiar la lista de clientes. Luego, se establece el nombre del archivo nuevamente y se llama al método Recorrer() para actualizar la lista de clientes en el DataGridView dgvClientes, mostrando que ya no hay clientes registrados.

            x.NomArchi = "Clientes.csv";
            if (MessageBox.Show(" Se borraran todos los clientes registradas , Continuar?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                x.Borrar();
                x.Recorrer(dgvClientes);
            }
        }
    }
}

