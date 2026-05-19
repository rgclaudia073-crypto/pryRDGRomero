using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRDGRomero
{
    internal class clsArbolBinario
    {
        //Crear el campo inicial del arbol
        private clsNodos PrimerNodo;

        //Se crean las propiedades del campo
        public clsNodos Raiz
        {
            get { return PrimerNodo; }
            set { PrimerNodo = value; }
        }

        public void Agregar(clsNodos Nuevo)
        {
            if (Raiz == null)
            {
                Raiz = Nuevo;
            }
            else
            {
                clsNodos Ant = Raiz; //ant
                clsNodos Aux = Raiz;
                while (Aux != null)
                {
                    Ant = Aux;
                    if (Nuevo.Codigo < Aux.Codigo) Aux = Aux.Izquierda;
                    else Ant = Aux;
                }
                //Afuera del while
                if (Nuevo.Codigo < Ant.Codigo) Ant = Ant.Izquierda = Nuevo;
                else Ant.Derecha = Nuevo;
                {

                }
            }
        }


        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }
        private void InOrdenAsc(DataGridView Dgv, clsNodos R)
        {
                if (Raiz != null) InOrdenAsc(Dgv, R.Izquierda);
                Dgv.Rows.Add(R.Nombre, R.Codigo, R.Tramite);
                if (R.Derecha != null) InOrdenAsc(Dgv, R.Derecha);
            
        }
    }
}

    
