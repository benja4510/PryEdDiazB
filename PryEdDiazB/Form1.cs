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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datosDeDesarolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosDesarrollador Datos = new frmDatosDesarrollador();
            Datos.ShowDialog();
        }

        private void coloresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColores Colores = new frmColores();
            Colores.ShowDialog();
        }

        private void mesesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMeses Meses = new frmMeses();
            Meses.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            clientes.ShowDialog();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos alumnos = new frmAlumnos();
            alumnos.ShowDialog();
        }

        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarreras carreras = new frmCarreras();
            carreras.ShowDialog();
        }

        private void programacionOrientadaAObjetosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola Cola = new frmCola();
            Cola.ShowDialog();
        }

        private void ciudadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCiudades ciudades = new frmCiudades();
            ciudades.ShowDialog();
        }

        private void provinciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProvincias provincias = new frmProvincias();
            provincias.ShowDialog();
        }

        private void diasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDias dias = new frmDias();
            dias.ShowDialog();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila pila = new frmPila();
            pila.ShowDialog();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple listaSimple = new frmListaSimple();
            listaSimple.ShowDialog();
        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoble listaDoble = new frmListaDoble();
            listaDoble.ShowDialog();
        }

        private void arbolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbolBinario ArbolBinario = new frmArbolBinario();
            ArbolBinario.ShowDialog();
        }

        private void grafoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrafo Grafo = new frmGrafo();
            Grafo.ShowDialog();
        }

        private void consultaDeUnaTablaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBdConsultaTablas ConsultaTablas = new frmBdConsultaTablas();
            ConsultaTablas.ShowDialog();
        }

        private void operacionesEnBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBdOperaciones OperacionesBd = new frmBdOperaciones();
            OperacionesBd.ShowDialog();
        }

        private void consultaDeBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBdRepaso repaso = new frmBdRepaso();
            repaso.ShowDialog();
        }

        private void consultasVariasConOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbdConsultaSQL consulta = new frmbdConsultaSQL();
            consulta.ShowDialog();
        }
    }
}