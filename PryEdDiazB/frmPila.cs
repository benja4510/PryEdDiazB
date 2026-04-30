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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }
        clsPila objPila = new clsPila();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos antes de agregar
            clsNodo x = new clsNodo();
            x.Codigo = Convert.ToInt32(txtCodigo.Text);
            x.Nombre = txtNombre.Text;
            x.Tramite = txtTramite.Text;

            // Agregar el nuevo nodo a la pila
            objPila.Agregar(x);
            MessageBox.Show("Tramite Agregado");
            objPila.Recorrer(lstPila);
            objPila.Recorrer(dgvPila);
            objPila.Recorrer("Pila.csv");

            // Limpiar los campos de entrada después de agregar el trámite
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si la pila no está vacía antes de eliminar
            if (objPila.Primero != null)
            {
                lblCodigo.Text = objPila.Primero.Codigo.ToString();
                lblNombre.Text = objPila.Primero.Nombre;
                lblTramite.Text = objPila.Primero.Tramite;

                objPila.Eliminar();
                MessageBox.Show("Tramite Eliminado");
                objPila.Recorrer(lstPila);
                objPila.Recorrer(dgvPila);
                objPila.Recorrer("Pila.csv");
            }
            // Si la pila está vacía, mostrar un mensaje y limpiar las etiquetas
            else
            {
                lblCodigo.Text =
                lblNombre.Text = "";
                lblTramite.Text = "";
                MessageBox.Show("La pila está vacía.");
            }
        }

      
    }
}
