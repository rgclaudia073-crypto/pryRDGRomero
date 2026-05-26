using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryRDGRomero
{
    internal class clsNodos
    {
        internal char Tramite;

        //Campos del Nodo
        private Int32 codigo;
        private string nombre;
        private clsNodos sig;
        private clsNodos ant;
        private string tramite;

        //Propiedades del nodo
        public Int32 Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public clsNodos Sig
        {
            get { return sig; }
            set { sig = value; }
        }

        public clsNodos Ant
        {
            get { return ant; }
            set { ant = value; }
        }

        public clsNodos Siguiente
        {
            get { return sig; }
            set { sig = value; }
        }

        public clsNodos Izquierda
            {
            get { return ant; }
            set { ant = value; }
        }
        public clsNodos Derecha
        {
            get { return sig; }
            set { sig = value; }

        }

    }
}

