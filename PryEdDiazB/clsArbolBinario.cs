using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEdDiazB
{
    internal class clsArbolBinario
    {
        private clsNodo Pri;

        public clsNodo Raiz
        {
            get { return Pri; }
            set { Pri = value; }
        }


        public void Agregar(clsNodo Nvo)
        {
            if (Raiz == null)
                Raiz = Nvo;

            else
            {
                clsNodo P = Raiz;
                clsNodo Aux = Raiz;
                while (Aux != null)
                {
                    P = Aux;
                    if (Nvo.Codigo < Aux.Codigo) Aux = Aux.Izquierdo;
                    else Aux = Aux.Derecho;
                }
                if (Nvo.Codigo < P.Codigo) P.Izquierdo = Nvo;
                else P.Derecho = Nvo;


            }
        }
        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);

        }

        private void InOrdenAsc(DataGridView Dgv, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Dgv, R.Izquierdo);
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null) InOrdenAsc(Dgv, R.Derecho);
        }

        public void Recorrer(ComboBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);

        }
        public void InOrdenAsc(ComboBox Lst, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Lst, R.Izquierdo);
            Lst.Items.Add(R.Codigo);
            if (R.Derecho != null) InOrdenAsc(Lst, R.Derecho);
        }

        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode NodoPadre = new TreeNode("Arbol");
            tree.Nodes.Add(NodoPadre);
            PreOrden(Raiz, NodoPadre);
            tree.ExpandAll();
        }

        private void PreOrden(clsNodo R, TreeNode NodoTreeView)
        {
            TreeNode NodoPadre = new TreeNode(R.Codigo.ToString());
            if (R.Izquierdo != null)
            {
                PreOrden(R.Izquierdo, NodoPadre);
            }
            if (R.Derecho != null)
            {
                PreOrden(R.Derecho, NodoPadre);
            }



        }

        public void Recorrer(List<clsNodo> Vector)
        {
            Vector.Clear();
            InOrdenAsc(Vector, Raiz);
        }

        private void InOrdenAsc(List<clsNodo> Vec, clsNodo R)
        {
            if (R == null) return;
            InOrdenAsc(Vec, R.Izquierdo);
            Vec.Add(R);
            InOrdenAsc(Vec, R.Derecho);


        }

        public void RecorrerPreOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrden(Grilla, Raiz);
        }

        private void PreOrden(DataGridView Dgv, clsNodo R)
        {
            if (R == null) return;
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            PreOrden(Dgv, R.Izquierdo);
            PreOrden(Dgv, R.Derecho);

        }
        public void RecorrerPostOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrden(Grilla, Raiz);
        }

        private void PostOrden(DataGridView Dgv, clsNodo R)
        {
            if (R == null) return;
            PostOrden(Dgv, R.Izquierdo);
            PostOrden(Dgv, R.Derecho);
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }

    }
}




