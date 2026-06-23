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
    public partial class frmGrafo : Form
    {
        public frmGrafo()
        {
            InitializeComponent();
        }

       
        clsGrafo Grafo = new clsGrafo();

        private void frmGrafo_Load(object sender, EventArgs e)
        {
            
            Grafo.MostrarCiudades(cmbOrigenCarga);
            Grafo.MostrarCiudades(cmbDestinoCarga);
            Grafo.MostrarCiudades(cmbOrigenConsulta);
            Grafo.MostrarCiudades(cmbDestinoConsulta);
            Grafo.MostrarCiudades(cmbDesdeListar);
            Grafo.MostrarCiudades(cmbHastaListar);

           
            Grafo.MostrarTodo(dgvGrafo);
        }


        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPrecioCarga.Text == "" || cmbOrigenCarga.SelectedIndex == -1 || cmbDestinoCarga.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, complete el origen, destino y precio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Int32 fila = cmbOrigenCarga.SelectedIndex;
                Int32 columna = cmbDestinoCarga.SelectedIndex;
                Decimal precio = Convert.ToDecimal(txtPrecioCarga.Text);

                
                Grafo.Agregar(fila, columna, precio);

               
                txtPrecioCarga.Clear();
                Grafo.MostrarTodo(dgvGrafo);
                txtPrecioCarga.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            Grafo.BorrarTodo();
            Grafo.MostrarTodo(dgvGrafo);
            MessageBox.Show("Se restablecieron todos los valores del grafo a cero.", "Grafo Limpio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      
       
      
        private void btnListarDestinos_Click(object sender, EventArgs e)
        {
            Int32 fila = cmbDesdeListar.SelectedIndex;

            if (fila != -1)
            {
                Grafo.MostrarDestinos(fila, dgvGrafo);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una provincia de origen.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnListarOrigenes_Click(object sender, EventArgs e)
        {
            Int32 columna = cmbHastaListar.SelectedIndex;

            if (columna != -1)
            {
                Grafo.MostrarOrigenes(columna, dgvGrafo);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una provincia de destino.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            if (cmbOrigenConsulta.SelectedIndex == -1 || cmbDestinoConsulta.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione origen y destino para consultar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Int32 fila = cmbOrigenConsulta.SelectedIndex;
            Int32 columna = cmbDestinoConsulta.SelectedIndex;

            Decimal precio = Grafo.Consultar(fila, columna);

            if (precio > 0)
            {
                txtPrecioConsulta.Text = precio.ToString();
            }
            else
            {
                txtPrecioConsulta.Text = "No disponible";
                MessageBox.Show("No existe un viaje directo registrado para la ruta seleccionada.", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            if (cmbOrigenConsulta.SelectedIndex == -1 || cmbDestinoConsulta.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione origen y destino para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Int32 fila = cmbOrigenConsulta.SelectedIndex;
            Int32 columna = cmbDestinoConsulta.SelectedIndex;

            Grafo.Eliminar(fila, columna);

            txtPrecioConsulta.Text = "";

            Grafo.MostrarTodo(dgvGrafo);
        }

        private void btnVerViajes_Click(object sender, EventArgs e)
        {
            Grafo.MostrarTodo(dgvGrafo);
        }
    }
}