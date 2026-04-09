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

        public void Borrar()
        {
            StreamWriter AD = new StreamWriter(NomArchi);
            AD.WriteLine("");
            AD.Close();
        }

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

        public void Grabar (String cod, String nom,String deu)
        {
            StreamWriter AD = new StreamWriter(NomArchi, true);
            AD.Write(cod); // El método Write() se utiliza para escribir el valor de la variable cod en el archivo sin agregar un salto de línea al final. Esto permite que el siguiente dato (nom) se escriba en la misma línea, separado por una coma u otro delimitador si es necesario.
            AD.Write(";");
            AD.Write(nom);// El método Write() se utiliza nuevamente para escribir el valor de la variable nom en el archivo, también sin agregar un salto de línea al final. Esto permite que el siguiente dato (deu) se escriba en la misma línea, separado por una coma u otro delimitador si es necesario.
            AD.Write(";");
            AD.WriteLine(deu); // El método WriteLine() se utiliza para escribir el valor de la variable deu en el archivo y agregar un salto de línea al final. Esto significa que después de escribir deu, el cursor se moverá a la siguiente línea, lo que permite que el próximo conjunto de datos (cod, nom, deu) se escriba en una nueva línea.
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

