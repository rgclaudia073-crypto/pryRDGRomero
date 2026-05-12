using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryRDGRomero
{
    internal class clsListaDoble
    {
        internal class clsListaDole
        {
            public clsListaDole() { }
            //Declaro los dos campos
            private clsNodo pri;
            private clsNodo ult;

            //Declaro las dos propiedades
            public clsNodo Primero
            {
                get { return pri; }
                set { pri = value; }
            }
            public clsNodo Ultimo
            {
                get { return ult; }
                set { ult = value; }
            }
        }
    }
}
