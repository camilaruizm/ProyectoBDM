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
    public partial class MenuAdmin : Form
    {
        Thread th;
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void bApelicula_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Abrir_PELICULAS);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Abrir_PELICULAS()
        {
            Application.Run(new peliculasAdmin());
        }

        private void bAdir_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Abrir_DIRECTORES);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Abrir_DIRECTORES()
        {
            Application.Run(new direcAdmin());
        }

        private void bA_act_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Abrir_ACTORES);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Abrir_ACTORES()
        {
            Application.Run(new actoresAdmin());
        }

        private void generoPelicula_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Abrir_GENEROS);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Abrir_GENEROS()
        {
            Application.Run(new generoPelicula());
        }
    }
}
