using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace PryEdDiazB
{
    internal class clsBaseDeDatos
    {

        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string cadenaConexion1 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\BaseDeDatos.accdb";
        private string cadentaConexion2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\BaseDeDatos.accdb";


        public void Listar(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = cadenaConexion1;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Libro";

                adaptador.SelectCommand = comando;
                DataTable Ds = new DataTable();
                adaptador.Fill(Ds, "Libro");

                Grilla.DataSource = null;
                Grilla.DataSource = Ds.Tables["Libro"];

                conexion.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }

        }
        public void Listar(String tabla, DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = cadenaConexion1;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;

                adaptador.SelectCommand = comando;
                DataTable Ds = new DataTable();
                adaptador.Fill(Ds, "Libro");

                Grilla.DataSource = null;
                Grilla.DataSource = Ds.Tables[tabla];

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conexion.Close();
            }

        }
        public void Listar(DataGridView Grilla, String varInstruccionSQL)
        {
            try
            {
                conexion.ConnectionString = cadenaConexion1;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Resultado";

                adaptador.SelectCommand = comando;
                DataTable DS = new DataTable();
                adaptador.Fill(DS, "Resultado");

                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables["Resultado"];

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }



        }




    }

}
