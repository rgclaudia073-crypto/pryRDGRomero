using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryRDGRomero
{
    internal class clsListaSimple
    {
        //Campos de clase
        private clsNodo pri;

        //Propiedades de clase
        public clsNodo Pri
        {
            get { return pri; }
            set { pri = value; }
        }


        public void Agregar(clsNodo Nuevo)
        {
            if (Pri == null)
            {
                Pri = Nuevo;
            }
            else
            {
                if (Nuevo.Código < Pri.Código)
                {
                    Nuevo.Sig = Pri;
                    Pri = Nuevo;
                }
                else
                {
                    clsNodo aux = pri;
                    clsNodo ant = Pri;
                    while (Nuevo.Código > aux.Código)
                    {
                        ant = aux;
                        aux = aux.Sig;
                    }
                    Nuevo.Sig = aux;
                    ant.Sig = Nuevo;
                }
            }

        }
    }
}
