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
    public partial class MenuClientes : Form
    {
        Thread th;
        public MenuClientes()
        {
            InitializeComponent();
        }

        private void Abrir_BuscarPeliculas()
        {
            Application.Run(new BuscarPeliculas());
        }

        private void BtnVerPeliculas_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Abrir_BuscarPeliculas);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void BtnVerPeliculas_MouseMove(object sender, MouseEventArgs e)
        {
            BtnVerPeliculas.BackColor = Color.Silver;
        }

        private void BtnVerPeliculas_MouseLeave(object sender, EventArgs e)
        {
            BtnVerPeliculas.BackColor = Color.Lavender;
        }

        private void BtnSolPrestamo_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Abrir_SP);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Abrir_SP()
        {
            Application.Run(new SolicitarPrestamo());
        }

        private void BtnSolPrestamo_MouseMove(object sender, MouseEventArgs e)
        {
            BtnSolPrestamo.BackColor = Color.Silver;
        }

        private void BtnSolPrestamo_MouseLeave(object sender, EventArgs e)
        {
            BtnSolPrestamo.BackColor = Color.Lavender;
        }

        private void BtnVerPrestamos_Click(object sender, EventArgs e)
        {
            this.Close();
          
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

 

        private void BtnPagarMultas_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Abrir_PM);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Abrir_PM()
        {
            Application.Run(new CuentaCliente());
        }

        private void BtnPagarMultas_MouseMove(object sender, MouseEventArgs e)
        {
            BtnEstadoCuenta.BackColor = Color.Silver;
        }

        private void BtnPagarMultas_MouseLeave(object sender, EventArgs e)
        {
            BtnEstadoCuenta.BackColor = Color.Lavender;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalir_MouseMove(object sender, MouseEventArgs e)
        {
            BtnSalir.Text = "Salir";
            BtnSalir.BackColor = Color.DarkRed;
        }

        private void BtnSalir_MouseLeave(object sender, EventArgs e)
        {
            BtnSalir.Text = "X";
            BtnSalir.BackColor = Color.Red;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuClientes_Load(object sender, EventArgs e)
        {

        }

        private void LbMenuCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
