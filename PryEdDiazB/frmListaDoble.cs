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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }
        clsListaDoble objLista = new clsListaDoble();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo x = new clsNodo();
            x.Codigo = Convert.ToInt32(txtCodigo.Text);
            x.Nombre = txtNombre.Text;
            x.Tramite = txtTramite.Text;

            objLista.Agregar(x);
            objLista.Recorrer(dgvListaDoble);
            objLista.Recorrer(cmbCodigo);
            objLista.Recorrer(lstListaDoble);
            objLista.Recorrer("clsListaDoble.csv");

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

            if (optAscendente.Checked)
            {
                objLista.Recorrer(dgvListaDoble);
            }
            else
            {
                objLista.RecorrerDesc(dgvListaDoble);
            }
        }
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void ValidarDatos()
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbCodigo.SelectedIndex != -1)
            {
                // Intentamos convertir de forma segura
                if (Int32.TryParse(cmbCodigo.Text, out Int32 codigo))
                {
                    objLista.Eliminar(codigo);

                    // Actualizar visualmente
                    objLista.Recorrer(dgvListaDoble);
                    objLista.Recorrer(cmbCodigo);
                    objLista.Recorrer(lstListaDoble);

                    MessageBox.Show("Eliminado correctamente");
                }
                else
                {
                    MessageBox.Show("El valor seleccionado no es un código válido.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un código.");
            }
        }
        private void optAscendente_CheckedChanged(object sender, EventArgs e)
        {
            if (optAscendente.Checked)
            {
                // Llamas a tus métodos normales (Siguiente)
                objLista.Recorrer(dgvListaDoble);
                objLista.Recorrer(lstListaDoble);
                objLista.Recorrer(cmbCodigo);
            }
        }

        private void optDescendente_CheckedChanged(object sender, EventArgs e)
        {
            if (optDescendente.Checked)
            {
                // Llamas a tus métodos nuevos (Anterior)
                objLista.RecorrerDesc(dgvListaDoble);
                objLista.RecorrerDesc(lstListaDoble);
                objLista.RecorrerDesc(cmbCodigo);
            }
        }

    }   
}