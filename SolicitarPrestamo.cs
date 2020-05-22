using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBDM
{
    public partial class SolicitarPrestamo : Form
    {
        public SolicitarPrestamo()
        {
            InitializeComponent();
        }

        private void btBuscarM_Click(object sender, EventArgs e)
        {

        }

        private void tITULOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelTitulo.BringToFront();
        }

        private void cATEGORIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelCategoria.BringToFront();
        }

        private void dIRECTORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelDirector.BringToFront();
        }
    }
}
