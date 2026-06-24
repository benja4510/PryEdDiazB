using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PryEdDiazB.frmBdRepaso;

namespace PryEdDiazB
{
    public partial class frmbdConsultaSQL : Form
    {
        private clsBaseDatos BD = new clsBaseDatos();
        public frmbdConsultaSQL()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            // Validamos que el usuario haya escrito una consulta para no mandar un string vacío
            if (txtSQL.Text.Trim() == "")
            {
                MessageBox.Show("Por favor, escriba una consulta SQL (Ej: SELECT * FROM Libro)", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSQL.Focus();
                return;
            }

            // Tomamos lo que escribiste en el cuadro de texto y lo mandamos directo al método ejecutor
            String sql = txtSQL.Text;
            BD.ListarOperacion(sql, dgvDatos);
        }
    }
    
}
