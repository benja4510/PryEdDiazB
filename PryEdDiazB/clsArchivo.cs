using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEdDiazB
{
    internal class clsArchivo
    {
        //Campo
        public String NomArchi="colores.txt";

        public void Grabar()
        {
            StreamWriter AD = new StreamWriter(NomArchi);
            AD.WriteLine("Hola!!!");
            AD.Close();

        }

        public void Grabar(String Dato)
        {

            StreamWriter AD = new StreamWriter(NomArchi,true);
            AD.WriteLine(Dato);
            AD.Close();

        }

        public void Recorrer(ListBox lstDatos)
        {

            lstDatos.Items.Clear();
            String DatoLeido = "";
            StreamReader AD = new StreamReader(NomArchi);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                // Agregar el dato leído al ListBox
                lstDatos.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }

        public void Recorrer(ComboBox cmbDatos)
        {
            cmbDatos.Items.Clear();
            String DatoLeido = "";
            StreamReader AD = new StreamReader(NomArchi);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                // Agregar el dato leído al ComboBox
                cmbDatos.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }

        public void Recorrer(DataGridView dgvDatos)
        {
            dgvDatos.Rows.Clear();
            String DatoLeido = "";
            StreamReader AD = new StreamReader(NomArchi);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                // Agregar el dato leído al DataGridView
                string[] datos = DatoLeido.Split(','); // Suponiendo que los datos están separados por comas
                dgvDatos.Rows.Add(datos); // Agregar una nueva fila con los datos
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }


    }



}   

