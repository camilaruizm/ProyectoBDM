using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProyectoBDM.Control;
using ProyectoBDM.Modelo;
using System.Threading;

namespace ProyectoBDM.Vista
{
    public partial class estadoPrestamo : Form
    {
        public estadoPrestamo()
        {
            InitializeComponent();
        }

        private void buttonBuscarP_Click(object sender, EventArgs e)                                                                                                                                                                                                                                                                
        {
            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
            conexion.Open();
            string prestamosQuery = "SELECT idPrestamo as 'ID', fechaHoraIP as 'Inicio del Prestamo', fechaHoraFP as 'Final del prestamo', peliculasSolicitadas as 'Peliculas Solicitadas', idClientef as 'ID Cliente',  estadoPrestamo as 'Estado' from prestamos where idPrestamo = '" + textBoxIdPrestamo.Text + "'";
            DataTable tPrestamos = new DataTable();
            MySqlDataAdapter adapterP = new MySqlDataAdapter(prestamosQuery, conexion);
            adapterP.Fill(tPrestamos);
            dgvEstado.DataSource = tPrestamos;
            conexion.Close();
        }
    }
}
