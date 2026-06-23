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
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }

     
        clsArbolBinario Arbol = new clsArbolBinario();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validar campos vacíos
                if (txtCodigo.Text == "" || txtNombre.Text == "" || txtTramite.Text == "")
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Crear el nuevo nodo usando tu clase clsNodo
                clsNodo nuevoNodo = new clsNodo();
                nuevoNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
                nuevoNodo.Nombre = txtNombre.Text;
                nuevoNodo.Tramite = txtTramite.Text;

                // 3. Agregar al árbol de forma lógica
                Arbol.Agregar(nuevoNodo);

                // 4. Limpiar la interfaz de entrada
                txtCodigo.Clear();
                txtNombre.Clear();
                txtTramite.Clear();
                txtCodigo.Focus();

                // 5. Sincronizar todos los controles visuales
                ListarEstructuras();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar en el árbol: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            ListarEstructuras();
        }

        private void rdoIN_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoIN.Checked) Arbol.Recorrer(dgvArbol);
        }

        private void rdoPRE_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPRE.Checked) Arbol.RecorrerPreOrden(dgvArbol);
        }

        private void rdoPOST_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPOST.Checked) Arbol.RecorrerPostOrden(dgvArbol);
        }

        private void ListarEstructuras()
        {
            // 1. Cargar el TreeView de forma ramificada
            Arbol.Recorrer(tvArbol);

            // 2. Cargar el ComboBox de eliminación con los códigos en In-Orden
            Arbol.Recorrer(cmbCodigo);

            // 3. Evaluar los RadioButtons para rellenar el DataGridView en el orden correcto
            if (rdoIN.Checked == true)
            {
                Arbol.Recorrer(dgvArbol);
            }
            else if (rdoPRE.Checked == true)
            {
                Arbol.RecorrerPreOrden(dgvArbol);
            }
            else if (rdoPOST.Checked == true)
            {
                Arbol.RecorrerPostOrden(dgvArbol);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validar que el usuario haya seleccionado un código válido en el ComboBox
                if (cmbCodigo.SelectedIndex != -1)
                {
                    // 2. Obtener el código seleccionado convirtiendo el texto a entero
                    Int32 codigoAEliminar = Convert.ToInt32(cmbCodigo.SelectedItem);

                    // 3. Llamar al método lógico de eliminación que agregamos en la clase
                    Arbol.Eliminar(codigoAEliminar);

                    // 4. Limpiar la selección del ComboBox
                    cmbCodigo.SelectedIndex = -1;

                    // 5. Refrescar automáticamente el TreeView, DataGridView y ComboBox
                    ListarEstructuras();

                    MessageBox.Show("Elemento eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un código de la lista para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


