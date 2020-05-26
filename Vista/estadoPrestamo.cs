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
        public string idP;
        public int selectedRow;
        public string idC;
        public estadoPrestamo()
        {
            InitializeComponent();
        }

        private void buttonBuscarP_Click(object sender, EventArgs e)                                                                                                                                                                                                                                                                
        {
            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
            conexion.Open();
            string prestamosQuery = "SELECT idPrestamo as 'ID', fechaHoraIP as 'Inicio del Prestamo', fechaHoraFP as 'Final del prestamo', peliculasSolicitadas as 'Peliculas Solicitadas', idClientef as 'ID Cliente', CONCAT (nombreCliente1 , ' ' ,  nombreCliente2, ' ', apellidoCliente1 , ' ' , apellidoCliente2) as 'Cliente', estadoPrestamo as 'Estado' from prestamos, clientes where clientes.idCliente = prestamos.idClientef AND prestamos.idPrestamo = '" + textBoxIdPrestamo.Text + "';";
            DataTable tPrestamos = new DataTable();
            MySqlDataAdapter adapterP = new MySqlDataAdapter(prestamosQuery, conexion);
            adapterP.Fill(tPrestamos);
            dgvEstado.DataSource = tPrestamos;
            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = dgvEstado.CurrentRow.Index;
            idP = dgvEstado.Rows[i].Cells[0].Value.ToString();
            idC = dgvEstado.Rows[i].Cells[4].Value.ToString();

            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
            conexion.Open();

            MySqlCommand idPQuery = new MySqlCommand();
            idPQuery.Connection = conexion;
            idPQuery.CommandText = ("UPDATE prestamos SET estadoPrestamo = 'Entregado' WHERE idPrestamo = " + idP + ";");
            MySqlDataReader leerIDP = idPQuery.ExecuteReader();
            conexion.Close();
            conexion.Open();
            string estadosQuery = "SELECT idPrestamo as 'ID', fechaHoraIP as 'Inicio del Prestamo', fechaHoraFP as 'Final del prestamo', peliculasSolicitadas as 'Peliculas Solicitadas', idClientef as 'ID Cliente', CONCAT (nombreCliente1 , ' ' ,  nombreCliente2, ' ', apellidoCliente1 , ' ' , apellidoCliente2) as 'Cliente', estadoPrestamo as 'Estado' from prestamos, clientes WHERE prestamos.idPrestamo = " + idP + " AND prestamos.idClientef = clientes.idCliente and prestamos.idClientef = " + idC + ";";

            DataTable tEstados = new DataTable();
            MySqlDataAdapter adapterE = new MySqlDataAdapter(estadosQuery, conexion);
           
            adapterE.Fill(tEstados);
            dgvEstado.DataSource = tEstados;
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = dgvEstado.CurrentRow.Index;
            idP = dgvEstado.Rows[i].Cells[0].Value.ToString();
            idC = dgvEstado.Rows[i].Cells[4].Value.ToString();

            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
            conexion.Open();

            MySqlCommand idPQuery = new MySqlCommand();
            idPQuery.Connection = conexion;
            idPQuery.CommandText = ("UPDATE prestamos SET estadoPrestamo = 'No entregado' WHERE idPrestamo = " + idP + ";");
            MySqlDataReader leerIDP = idPQuery.ExecuteReader();
            conexion.Close();
            conexion.Open();
            string estadosQuery = "SELECT idPrestamo as 'ID', fechaHoraIP as 'Inicio del Prestamo', fechaHoraFP as 'Final del prestamo', peliculasSolicitadas as 'Peliculas Solicitadas', idClientef as 'ID Cliente', CONCAT (nombreCliente1 , ' ' ,  nombreCliente2, ' ', apellidoCliente1 , ' ' , apellidoCliente2) as 'Cliente', estadoPrestamo as 'Estado' from prestamos, clientes WHERE prestamos.idPrestamo = " + idP + " AND prestamos.idClientef = clientes.idCliente and prestamos.idClientef = " + idC + ";";

            DataTable tEstados = new DataTable();
            MySqlDataAdapter adapterE = new MySqlDataAdapter(estadosQuery, conexion);

            adapterE.Fill(tEstados);
            dgvEstado.DataSource = tEstados;
            conexion.Close();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            int i = dgvEstado.CurrentRow.Index;
            idP = dgvEstado.Rows[i].Cells[0].Value.ToString();
            idC = dgvEstado.Rows[i].Cells[4].Value.ToString();

            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
            conexion.Open();

            MySqlCommand idPQuery = new MySqlCommand();
            idPQuery.Connection = conexion;
            idPQuery.CommandText = ("UPDATE prestamos SET estadoPrestamo = '' WHERE idPrestamo = " + idP + ";");
            MySqlDataReader leerIDP = idPQuery.ExecuteReader();
            conexion.Close();
            conexion.Open();
            string estadosQuery = "SELECT idPrestamo as 'ID', fechaHoraIP as 'Inicio del Prestamo', fechaHoraFP as 'Final del prestamo', peliculasSolicitadas as 'Peliculas Solicitadas', idClientef as 'ID Cliente', CONCAT (nombreCliente1 , ' ' ,  nombreCliente2, ' ', apellidoCliente1 , ' ' , apellidoCliente2) as 'Cliente', estadoPrestamo as 'Estado' from prestamos, clientes WHERE prestamos.idPrestamo = " + idP + " AND prestamos.idClientef = clientes.idCliente and prestamos.idClientef = " + idC + ";";

            DataTable tEstados = new DataTable();
            MySqlDataAdapter adapterE = new MySqlDataAdapter(estadosQuery, conexion);

            adapterE.Fill(tEstados);
            dgvEstado.DataSource = tEstados;
            conexion.Close();
        }
    }
}
