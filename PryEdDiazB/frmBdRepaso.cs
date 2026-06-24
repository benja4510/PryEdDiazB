using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace PryEdDiazB
{
    public partial class frmBdRepaso : Form
    {
        private clsBaseDatos BD = new clsBaseDatos();
        public frmBdRepaso()
        {
            InitializeComponent();
        }

        private void frmBdRepaso_Load(object sender, EventArgs e)
        {
            
            cmbOperacion.Items.Clear();
            cmbOperacion.Items.Add("Proyección (SELECT simple)");
            cmbOperacion.Items.Add("Selección (WHERE simple)");
            cmbOperacion.Items.Add("Selección Multiatributo (AND/OR)");
            cmbOperacion.Items.Add("Unión (JOIN de tablas)");
            cmbOperacion.Items.Add("Intersección / Subconsulta");
            cmbOperacion.Items.Add("Diferencia (NOT IN)");

            cmbOperacion.SelectedIndex = 0;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (cmbOperacion.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione una operación de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            String sql = "";

            switch (cmbOperacion.SelectedIndex)
            {
                case 0: // Proyección
                    txtDescripcion.Text = "PROYECTO: Trae columnas específicas de una tabla sin filtrar filas.\r\nSQL: SELECT IdLibro, Titulo FROM Libro";
                    // Traemos solo algunas columnas de la tabla Libro
                    sql = "SELECT IdLibro, Titulo, Año FROM Libro";
                    break;

                case 1: // Selección
                    txtDescripcion.Text = "SELECCIÓN: Filtra las filas que cumplen una condición determinada.\r\nSQL: SELECT * FROM Libro WHERE Año > '2000'";

                    // CORREGIDO: Llleva comillas simples '2000' porque Año es de tipo Texto en Access
                    sql = "SELECT * FROM Libro WHERE Año > '2000'";
                    break;

                case 2: // Selección Multiatributo
                    txtDescripcion.Text = "MULTIATRIBUTO: Combina condiciones lógicas utilizando operadores AND u OR.\r\nSQL: SELECT * FROM Libro WHERE Año > '1990' AND IdIdioma = 1";

                    // CORREGIDO: Lleva comillas simples '1990'. (IdIdioma queda igual porque es numérico)
                    sql = "SELECT * FROM Libro WHERE Año > '1990' AND IdIdioma = 1";
                    break;

                case 3: // Unión / JOIN
                    txtDescripcion.Text = "JUNCIÓN (JOIN): Combina datos de dos o más tablas mediante una clave común.\r\nSQL: SELECT Libro.Titulo, Autor.Nombre FROM Libro INNER JOIN Autor ON Libro.IdAutor = Autor.IdAutor";
                    // Cruza la tabla Libro con la de Autor para ver el nombre real del escritor
                    sql = "SELECT Libro.IdLibro, Libro.Titulo, Autor.Nombre AS [Nombre Autor] FROM Libro INNER JOIN Autor ON Libro.IdAutor = Autor.IdAutor";
                    break;

                case 4: // Intersección / Subconsulta
                    txtDescripcion.Text = "INTERSECCIÓN: Resuelve operaciones cruzadas mediante subconsultas.\r\nSQL: SELECT * FROM Libro WHERE IdPais IN (SELECT IdPais FROM Pais)";
                    // Muestra los libros cuyo país de origen está efectivamente cargado en la tabla Pais
                    sql = "SELECT * FROM Libro WHERE IdPais IN (SELECT IdPais FROM Pais)";
                    break;

                case 5: // Diferencia
                    txtDescripcion.Text = "DIFERENCIA: Trae registros de una tabla que NO figuran en otra (Exclusión).\r\nSQL: SELECT * FROM Autor WHERE IdAutor NOT IN (SELECT IdAutor FROM Libro)";
                    // Muestra los autores que todavía no tienen ningún libro cargado en el sistema
                    sql = "SELECT * FROM Autor WHERE IdAutor NOT IN (SELECT IdAutor FROM Libro)";
                    break;
            }

            // Ejecuta la consulta usando tu clase lógica y llena la grilla
            BD.ListarOperacion(sql, dgvRepaso);
        }

        internal class clsBaseDatos
        {
            // Cambiá el nombre del archivo .mdb o .accdb según corresponda a tu proyecto de cátedra
             private String CadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\Libreria.mdb;";

            private OleDbConnection conexion;
            private OleDbCommand comando;
            private OleDbDataAdapter adaptador;
            private DataTable tabla;

            public void ListarOperacion(String sql, DataGridView Grilla)
            {
                try
                {
                    conexion = new OleDbConnection(CadenaConexion);
                    comando = new OleDbCommand();

                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = sql;

                    adaptador = new OleDbDataAdapter(comando);
                    tabla = new DataTable();

                    conexion.Open();
                    adaptador.Fill(tabla);
                    conexion.Close();

                    // Volcamos automáticamente las columnas y filas obtenidas
                    Grilla.DataSource = tabla;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar o consultar la Base de Datos:\n" + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (conexion.State == ConnectionState.Open)
                    {
                        conexion.Close();
                    }
                }

        }
    }
}
}
