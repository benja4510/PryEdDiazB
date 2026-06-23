using System;
using System.Collections.Generic;
using System.Linq;
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

        // Método para insertar un nodo de forma iterativa
        public void Agregar(clsNodo Nvo)
        {
            if (Raiz == null)
            {
                Raiz = Nvo;
            }
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

        // Método de eliminación mediante reconstrucción con Vector/Lista
        public void Eliminar(Int32 CodigoAEliminar)
        {
            List<clsNodo> ListaTemporal = new List<clsNodo>();

            // Pasamos todos los nodos actuales a la lista
            Recorrer(ListaTemporal);

            // Vaciamos el árbol
            Raiz = null;

            // Volvemos a insertar todos menos el que queremos borrar
            foreach (clsNodo nodo in ListaTemporal)
            {
                if (nodo.Codigo != CodigoAEliminar)
                {
                    clsNodo nodoNuevo = new clsNodo();
                    nodoNuevo.Codigo = nodo.Codigo;
                    nodoNuevo.Nombre = nodo.Nombre;
                    nodoNuevo.Tramite = nodo.Tramite;

                    Agregar(nodoNuevo);
                }
            }
        }

        // RECORRIDOS: IN-ORDEN (Para DataGridView)
        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }

        private void InOrdenAsc(DataGridView Dgv, clsNodo R)
        {
            if (R == null) return;
            if (R.Izquierdo != null) InOrdenAsc(Dgv, R.Izquierdo);
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null) InOrdenAsc(Dgv, R.Derecho);
        }

        // RECORRIDOS: IN-ORDEN (Para ComboBox)
        public void Recorrer(ComboBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }

        public void InOrdenAsc(ComboBox Lst, clsNodo R)
        {
            if (R == null) return;
            if (R.Izquierdo != null) InOrdenAsc(Lst, R.Izquierdo);
            Lst.Items.Add(R.Codigo);
            if (R.Derecho != null) InOrdenAsc(Lst, R.Derecho);
        }

        // RECORRIDOS: IN-ORDEN (Para Lista Temporal de Nodos / Eliminación)
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

        // RECORRIDOS: PRE-ORDEN (Para DataGridView)
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

        // RECORRIDOS: POST-ORDEN (Para DataGridView)
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

        // RECORRIDOS: PRE-ORDEN GRÁFICO (Para TreeView Ramificado)
        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode NodoRaizVisual = new TreeNode("Arbol");
            tree.Nodes.Add(NodoRaizVisual);

            if (Raiz != null)
            {
                PreOrden(Raiz, NodoRaizVisual);
            }
            tree.ExpandAll();
        }

        private void PreOrden(clsNodo R, TreeNode NodoTreeView)
        {
            TreeNode NuevoNodoVisual = new TreeNode(R.Codigo.ToString());
            NodoTreeView.Nodes.Add(NuevoNodoVisual);

            if (R.Izquierdo != null)
            {
                PreOrden(R.Izquierdo, NuevoNodoVisual);
            }
            if (R.Derecho != null)
            {
                PreOrden(R.Derecho, NuevoNodoVisual);
            }
        }
    }
}