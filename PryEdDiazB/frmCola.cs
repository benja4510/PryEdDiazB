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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }
        clsCola ColaEspera = new clsCola();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Persona = new clsNodo();
            Persona.Codigo = Convert.ToInt32(txtCodigo.Text);
            Persona.Nombre = txtNombre.Text;
            Persona.Tramite = txtTramite.Text;

            ColaEspera.Agregar(Persona);
            ColaEspera.Recorrer(dgvCola);
            ColaEspera.Recorrer("Cola.csv");
            ColaEspera.Recorrer(lstCola);

            txtCodigo.Text="";
            txtNombre.Text="";
            txtTramite.Text="";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ColaEspera.Primero != null)
            {
                lblCodigo.Text= ColaEspera.Primero.Codigo.ToString();
                lblNombre.Text= ColaEspera.Primero.Nombre;
                lblTramite.Text= ColaEspera.Primero.Tramite;

                ColaEspera.Eliminar();
                ColaEspera.Recorrer(dgvCola);
                ColaEspera.Recorrer("Cola.csv");
                ColaEspera.Recorrer(lstCola);
            }
             else
            {
                MessageBox.Show("No hay personas en la cola.");
                lblCodigo.Text = "";
                lblNombre.Text = "";
                lblTramite.Text = "";
            }
        }
    }
}
