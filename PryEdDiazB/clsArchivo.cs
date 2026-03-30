using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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


    }



}   

