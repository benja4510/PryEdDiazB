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
        
                if (txtCodigo.Text == "" || txtNombre.Text == "" || txtTramite.Text == "")
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

              
                clsNodo nuevoNodo = new clsNodo();
                nuevoNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
                nuevoNodo.Nombre = txtNombre.Text;
                nuevoNodo.Tramite = txtTramite.Text;

                
                Arbol.Agregar(nuevoNodo);

               
                txtCodigo.Clear();
                txtNombre.Clear();
                txtTramite.Clear();
                txtCodigo.Focus();

               
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
            
            Arbol.Recorrer(tvArbol);

            
            Arbol.Recorrer(cmbCodigo);

           
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
                
                if (cmbCodigo.SelectedIndex != -1)
                {
                   
                    Int32 codigoAEliminar = Convert.ToInt32(cmbCodigo.SelectedItem);

                  
                    Arbol.Eliminar(codigoAEliminar);

                    
                    cmbCodigo.SelectedIndex = -1;

                   
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


