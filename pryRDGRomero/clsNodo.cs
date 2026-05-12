using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryRDGRomero
{
    internal class clsNodo
    {
        //Campos del Nodo
        private int codigo;
        private string nombre;
        private clsNodo sig;
        private clsNodo ant;
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
        public clsNodo Sig
        {
            get { return sig; }
            set { sig = value; }
        }

        public clsNodo Ant
        {
            get { return ant; }
            set { ant = value; }
        }

        public clsNodo Siguiente { get; internal set; }
    }
}

