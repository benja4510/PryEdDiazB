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
    internal class clsBaseDatos
    {

        
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

                
                Grilla.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la consulta SQL:\n" + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        
        public void EjecutarConsultaSQL(String sql)
        {
            try
            {
                conexion = new OleDbConnection(CadenaConexion);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;

                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();

                MessageBox.Show("Comando ejecutado con éxito en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar comando:\n" + ex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
    }
}