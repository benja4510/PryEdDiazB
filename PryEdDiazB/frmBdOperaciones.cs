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
    public partial class frmBdOperaciones : Form
    {
        clsBaseDeDatos objBaseDatos = new clsBaseDeDatos();

        public frmBdOperaciones()
        {
            InitializeComponent();
        }

        private void btnProyeccionSimple_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO" +
                     "FROM LIBRO" +
                     "ORDER BY 1 DESC";
            objBaseDatos.Listar(dgvDatosBaseDatos, varSQL);
        }

        private void btnProyeccionMultiatributo_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO, AÑO" +
                     "FROM LIBRO" +
                     "ORDER BY 1 DESC";
            objBaseDatos.Listar(dgvDatosBaseDatos, varSQL);
        }
    }
}
