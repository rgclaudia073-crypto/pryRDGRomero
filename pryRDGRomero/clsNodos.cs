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
        private int codigo;
        private string nombre;
        private clsNodos sig;
        private clsNodos ant;

        //Propiedades del nodo
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nombre
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
    }
}

