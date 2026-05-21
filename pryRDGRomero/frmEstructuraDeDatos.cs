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
    public partial class frmEstructuraDeDatos : Form
    {
        public frmEstructuraDeDatos()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.Close();
        }

        private void tstProgramaOO_Click(object sender, EventArgs e)
        {

        }

        private void coloresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColores v = new frmColores();
            v.ShowDialog();
        }

        private void frmEstructuraDeDatos_Load(object sender, EventArgs e)
        {

        }

        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarreras x = new frmCarreras();
            x.ShowDialog();
        }

        private void datosDeDesarrolloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosDelDesarrollo v = new frmDatosDelDesarrollo();
            v.ShowDialog();
        }
    }
}
