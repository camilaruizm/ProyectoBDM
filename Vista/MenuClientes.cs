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
using ProyectoBDM.Vista;

namespace ProyectoBDM
{
    
    public partial class MenuClientes : Form
    {
        public string idUsern;
        Thread th;
        public MenuClientes(string idUser)
        {
            InitializeComponent();
            this.idUsern = idUser;

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
            Application.Run(new SolicitarPrestamo(idUsern));
        }

        private void BtnSolPrestamo_MouseMove(object sender, MouseEventArgs e)
        {
            BtnSolPrestamo.BackColor = Color.LightGray;
        }

        private void BtnSolPrestamo_MouseLeave(object sender, EventArgs e)
        {
            BtnSolPrestamo.BackColor = Color.FromArgb(224, 224, 224);
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
            Application.Run(new estadoCuenta(idUsern));
        }

        private void BtnPagarMultas_MouseMove(object sender, MouseEventArgs e)
        {
            BtnEstadoCuenta.BackColor = Color.LightGray;
        }

        private void BtnPagarMultas_MouseLeave(object sender, EventArgs e)
        {
            BtnEstadoCuenta.BackColor = Color.FromArgb(224, 224, 224);
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

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalir_MouseLeave(object sender, EventArgs e)
        {
            BtnSalir.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void BtnSalir_MouseMove(object sender, MouseEventArgs e)
        {
            BtnSalir.BackColor = Color.Gray;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Abrir_MP);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Abrir_MP()
        {
            Application.Run(new Perfil(idUsern));
        }
    }
}
