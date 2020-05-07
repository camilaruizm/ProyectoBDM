﻿using System;
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

        private void BtnVerPeliculas_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Abrir_VP);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Abrir_VP()
        {
            Application.Run(new VerPeliculas());
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
            th = new Thread(Abrir_VPrest);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Abrir_VPrest()
        {
            Application.Run(new PrestamosActivos());
        }

        private void BtnVerPrestamos_MouseMove(object sender, MouseEventArgs e)
        {
            BtnVerPrestamos.BackColor = Color.Silver;
        }

        private void BtnVerPrestamos_MouseLeave(object sender, EventArgs e)
        {
            BtnVerPrestamos.BackColor = Color.Lavender;
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
            Application.Run(new PagarMultas());
        }

        private void BtnPagarMultas_MouseMove(object sender, MouseEventArgs e)
        {
            BtnPagarMultas.BackColor = Color.Silver;
        }

        private void BtnPagarMultas_MouseLeave(object sender, EventArgs e)
        {
            BtnPagarMultas.BackColor = Color.Lavender;
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
    }
}