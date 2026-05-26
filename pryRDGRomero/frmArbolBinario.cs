using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRDGRomero
{
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }
        clsArbolBinario ObjArbol = new clsArbolBinario();
        private void frmArbolBinario_Load(object sender, EventArgs e)
        {
            clsNodos Persona = new clsNodos();
            Persona.Codigo = Convert.ToInt32(txtCódigo.Text);
            Persona.Nombre = txtNombre.Text;
            Persona.Tramite = Convert.ToChar(txtTramite.Text);

            ObjArbol.Agregar(Persona);
            ObjArbol.Recorrer(dgvLDatos);
            ObjArbol.Recorrer(trvArbol);
        }
    }
}
