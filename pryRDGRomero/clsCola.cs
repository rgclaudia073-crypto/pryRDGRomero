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
        //Campo de las clases
        private clsNodos pri;
        private clsNodos ult;

        //Propiedades de la clase
        public clsNodos Primero
        {
            get { return pri; }
            set { ult = value; }
        }


        public clsNodos Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }
        //Metodos de la clase
        public void Agregar(clsNodos Nuevo)
        {
            if (Primero == null)
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
        public void Recorrer(DataGridView Grilla)
        {
            clsNodos aux = pri;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Nombre, aux.Codigo, aux.Tramite);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(ListBox lista)
        {
            clsNodos aux = pri;
            lista.Items.Clear();
            while (aux != null)
            {
                lista.Items.Add(aux.Nombre + " " + aux.Codigo + " " + aux.Tramite);
                aux = aux.Siguiente;

            }
        }
        public void Recorrer()
        {
            clsNodos aux = pri;
            StreamWriter AD = new StreamWriter("Cola.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Codigo; Nomnbre; Tramite");
            while (aux != null)
            {
                AD.Write(aux.Codigo);
                AD.Write(",");
                AD.Write(aux.Nombre);
                AD.Write(",");
                AD.Write(aux.Tramite);
                aux = aux.Siguiente;
            }
            AD.Close();



        }
    }
}
