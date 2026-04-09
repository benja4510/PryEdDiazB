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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchi = "Clientes.csv";
            x.Grabar(txtCodigo.Text, txtNombre.Text, txtDeuda.Text);

        }
    }
}
