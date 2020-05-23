using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProyectoBDM
{
    public partial class BuscarPeliculas : Form
    {
        Thread th;
        public BuscarPeliculas()
        {
            InitializeComponent();
        }

        private void BuscarPeliculas_Load(object sender, EventArgs e)
        {

        }

        private void btPrestamo_Click(object sender, EventArgs e)
        {

        }

        private void lbPeliculas_Click(object sender, EventArgs e)
        {

        }

        private void dgvBuscarPeliculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btAtrasPeliculas_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(volverMenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void volverMenu()
        {
            Application.Run(new MenuClientes());
        }
    }
    }

