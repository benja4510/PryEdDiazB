using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PryEdDiazB
{
    internal class clsBaseDeDatos
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string cadenaConexion1 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Libreria.mdb";
        private string cadenaConexion2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Libreria.mdb";

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
                adaptador.Fill(Ds); 

                Grilla.DataSource = null;
                Grilla.DataSource = Ds; 
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            finally
            {
                conexion.Close(); 
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
                adaptador.Fill(Ds);

                Grilla.DataSource = null;
                Grilla.DataSource = Ds; 
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            finally
            {
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
                comando.CommandType = CommandType.Text;
                comando.CommandText = varInstruccionSQL;

                adaptador.SelectCommand = comando;
                DataTable DS = new DataTable();
                adaptador.Fill(DS);

                Grilla.DataSource = null;
                Grilla.DataSource = DS; 
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}

    