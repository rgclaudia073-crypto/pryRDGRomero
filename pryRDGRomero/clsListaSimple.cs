using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pryRDGRomero
{
    internal class clsListaSimple
    {
        //Campos de clase
        private clsNodos pri;

        //Propiedades de clase
        public clsNodos Pri
        {
            get { return pri; }
            set { pri = value; }
        }


        public void Agregar(clsNodos Nuevo)
        {
            if (Pri == null)
            {
                Pri = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo < Pri.Codigo)
                {
                    Nuevo.Sig = Pri;
                    Pri = Nuevo;
                }
                else
                {
                    clsNodos aux = pri;
                    clsNodos ant = Pri;
                    while (Nuevo.Codigo > aux.Codigo)
                    {
                        ant = aux;
                        aux = aux.Sig;
                    }
                    Nuevo.Sig = aux;
                    ant.Sig = Nuevo;
                }
            }
        }

        public void Eliminar(clsNodos Nodo)
        {
            if (Pri != null)
            {
                if (Pri.Codigo == Nodo.Codigo)
                {
                    Pri = Pri.Sig;
                }
                else
                {
                    clsNodos aux = Pri;
                    clsNodos ant = Pri;
                    while (aux != null && aux.Codigo != Nodo.Codigo)
                    {
                        ant = aux;
                        aux = aux.Sig;
                    }
                    if (aux != null)
                    {
                        ant.Sig = aux.Sig;
                    }
                    else
                    {
                        MessageBox.Show("El nodo no existe en la lista.");
                    }
                }
            }
        }
    }
}
