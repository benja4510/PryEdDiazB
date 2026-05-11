using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PryEdDiazB
{
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }
        clsListaSimple objLista = new clsListaSimple();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo x = new clsNodo();
            x.Codigo = Convert.ToInt32(txtCodigo.Text);
            x.Nombre = txtNombre.Text;
            x.Tramite = txtTramite.Text;

            objLista.Agregar(x);
            objLista.Recorrer(dgvListaSimple);
            objLista.Recorrer(cmbCodigo);
            objLista.Recorrer(lstListaSimple);
            objLista.Recorrer("clsListaSimple.csv");

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
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
            // Usamos IsNullOrWhiteSpace para que sea más robusto
            bool codigoOk = !string.IsNullOrWhiteSpace(txtCodigo.Text);
            bool nombreOk = !string.IsNullOrWhiteSpace(txtNombre.Text);
            bool tramiteOk = !string.IsNullOrWhiteSpace(txtTramite.Text);

            if (codigoOk && nombreOk && tramiteOk)
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
                    objLista.Recorrer(dgvListaSimple);
                    objLista.Recorrer(cmbCodigo);
                    objLista.Recorrer(lstListaSimple);

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
    }
}