using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
////////////////////////////
using System.IO;
using System.Windows.Forms;
////////////////////////////
namespace pryRDGRomero
{
    internal class clsArchivo
    {
        //Crear un campo
        public string NomArchi = "colores.txt";


        public void Grabar()
        {
            //Abrir archivo para la escritura 
            StreamWriter AD = new StreamWriter(NomArchi);
            AD.WriteLine("Hola");
            AD.Close();

        }
   

    }

}   
