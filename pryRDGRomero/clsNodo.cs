using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryRDGRomero
{
    internal class clsNodo
    {
        public int Código { get; internal set; }
        public clsNodo Sig { get; internal set; }
    }
}
