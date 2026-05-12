using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryRDGRomero
{
    internal class clsEstructurasLineales
    {
        //Declaro los dos campos
        private clsNodos pri;

        //Propiedades de la clase
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
    }
}
