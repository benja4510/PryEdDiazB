using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEdDiazB
{
    internal class clsGrafo
    {
     
        private Decimal[,] Precio = new Decimal[5, 5];

       
        private String[] Ciudades = new String[5] { "Cordoba", "Mendoza", "Santa Fe", "Buenos Aires", "Salta" };

        public void MostrarCiudades(ComboBox Combo)
        {
            Combo.Items.Clear();
            for (Int32 i = 0; i < 5; i++)
            {
                Combo.Items.Add(Ciudades[i]);
            }
        }

       
        public void Agregar(Int32 f, Int32 c, Decimal p)
        {
            Precio[f, c] = p;
        }


        public Decimal Consultar(Int32 f, Int32 c)
        {
            return Precio[f, c];
        }

      
        public void Eliminar(Int32 f, Int32 c)
        {
            Precio[f, c] = 0;
        }


        public void BorrarTodo()
        {
            for (Int32 f = 0; f < 5; f++)
            {
                for (Int32 c = 0; c < 5; c++)
                {
                    Precio[f, c] = 0;
                }
            }
        }


        public void MostrarTodo(DataGridView Grilla)
        {
            Grilla.Rows.Clear();

            for (Int32 f = 0; f < 5; f++)
            {
        
                Int32 numeroFila = Grilla.Rows.Add();

                Grilla.Rows[numeroFila].Cells[0].Value = Ciudades[f];

               
                for (Int32 c = 0; c < 5; c++)
                {
                    Grilla.Rows[numeroFila].Cells[c + 1].Value = Precio[f, c];
                }
            }
        }

       
        public void MostrarDestinos(Int32 f, DataGridView Grilla)
        {
            Grilla.Rows.Clear();

            Int32 numeroFila = Grilla.Rows.Add();
            Grilla.Rows[numeroFila].Cells[0].Value = Ciudades[f];

            for (Int32 c = 0; c < 5; c++)
            {
                Grilla.Rows[numeroFila].Cells[c + 1].Value = Precio[f, c];
            }
        }

       
        public void MostrarOrigenes(Int32 c, DataGridView Grilla)
        {
            Grilla.Rows.Clear();

            for (Int32 f = 0; f < 5; f++)
            {
                Int32 numeroFila = Grilla.Rows.Add();
                Grilla.Rows[numeroFila].Cells[0].Value = Ciudades[f];

              
                Grilla.Rows[numeroFila].Cells[c + 1].Value = Precio[f, c];
            }
        }
    }
}