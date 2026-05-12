using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryRDGRomero
{
    internal class clsListaDoble
    {
        internal class clsListaDole
        {
            public clsListaDole() { }
            //Declaro los dos campos
            private clsNodos pri;
            private clsNodos ult;

            //Declaro las dos propiedades
            public clsNodos Primero
            {
                get { return pri; }
                set { pri = value; }
            }
            public clsNodos Ultimo
            {
                get { return ult; }
                set { ult = value; }
            }

            public void Agregar(clsNodos Nuevo)
            {
                if (Primero == null)
                {
                    Primero = Nuevo;
                    Ultimo = Nuevo;
                }
                else
                {
                    Ultimo.Sig = Nuevo;
                    Nuevo.Ant = Ultimo;
                    Ultimo = Nuevo;
                }
            }
        }
    }
}
