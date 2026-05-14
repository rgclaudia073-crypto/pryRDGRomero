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
    public partial class frmCarreras : Form
    {
        public frmCarreras()
        {
            InitializeComponent();
        }

        private void frmCarreras_Load(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivo objCarrera = new clsArchivo();
            objCarrera.NomArchi = "Carreras.csv";
            objCarrera.Grabar(txtCarreras.Text);
            objCarrera.Recorrer(lstCarrera);
            txtCarreras.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clsArchivo objCarrera = new clsArchivo();
            objCarrera.NomArchi = "Carreras.csv";
            objCarrera.BorrarTodo();
            objCarrera.Recorrer(lstCarrera);
            txtCarreras.Clear();
        }
    }
}
