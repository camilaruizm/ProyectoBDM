﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;
using ProyectoBDM.Control;

namespace ProyectoBDM
{
    public partial class estadoCuenta : Form
    {
        string idUserc;
        Thread th;
        MySqlDataAdapter adaptador = new MySqlDataAdapter();
        ControlEstadoCuenta cec = new ControlEstadoCuenta();
        public estadoCuenta(string idUser)
        {
            InitializeComponent();
            this.idUserc = idUser;
        }

        private void showPeliculaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                cec.showPeliculaCli(adaptador, dgvP, idUserc);
            }
            catch (MySqlException)
            {
                MessageBox.Show("No se encontraron peliculas");
            }
         
        }

        private void showMultas_Click(object sender, EventArgs e)
        {
            try
            {
                cec.showMultaCli(adaptador, dgvM, idUserc);
            }
            catch (MySqlException)
            {
                MessageBox.Show("No se encontraron multas");
            }
            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");

            MySqlCommand comando = new MySqlCommand("SELECT M.fechaGeneracionMulta, M.valorMulta, P.titulo FROM  Multas M, Facturas_prestamos FP, Peliculas P, Clientes C WHERE C.idCliente = '" + idUserc + "' and P.idPelicula = FP.idPeliculaf and M.idClientef2 = C.idCliente and M.estadoMulta = 'Activo'; ", conexion);
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvM.DataSource = tabla;
        }

        private void verHistorial_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Abrir_Historial);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void Abrir_Historial()
        {
            Application.Run(new historialCliente(idUserc));
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(volverMenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void volverMenu()
        {
            Application.Run(new MenuClientes(idUserc));
        }

        private void estadoCuenta_Load(object sender, EventArgs e)
        {

        }
    }
}
