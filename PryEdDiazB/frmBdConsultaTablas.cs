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
    public partial class frmBdConsultaTablas : Form
    {
        // CORREGIDO: Apunta al nombre correcto de la clase unificada a nivel formulario
        clsBaseDatos bd = new clsBaseDatos();

        public frmBdConsultaTablas()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            // Validamos que el usuario haya seleccionado una tabla en el combo
            if (cboTablaDatos.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione una tabla de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Armamos dinámicamente la consulta para traer todo lo de la tabla seleccionada
            String sql = "SELECT * FROM " + cboTablaDatos.Text;

            // CORREGIDO: Usamos el método unificado (primero la consulta SQL, luego la grilla)
            bd.ListarOperacion(sql, dgvTablaDatos);
        }
    }
}