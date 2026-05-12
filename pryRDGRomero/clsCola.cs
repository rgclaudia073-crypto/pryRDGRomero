using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace pryRDGRomero
{
    internal class clsCola
    {
        private clsNodos ult;

        //Propiedades de la clase
        public clsNodos Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }
        //Metodos de la clase
        public void Agregar(clsNodos Nuevo)
        {
            if (Primero = null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                Ultimo.Siguiente = Nuevo;
                Ultimo = Nuevo;
            }
        }
        public void Eliminar()
        {
            if (Primero == Ultimo)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                Primero = Primero.Siguiente;
            }
        }
    }
}
