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
    public partial class consultasAdmin : Form
    {
        public consultasAdmin()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void buttonEnPrestamo_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
            MySqlCommand comandoC = new MySqlCommand("SELECT idCliente as 'ID', CONCAT(C.nombreCliente1, ' ', C.nombreCliente2) as 'Nombre Cliente', CONCAT(C.apellidoCliente1, ' ',C.apellidoCliente2) as 'Apellidos Cliente' FROM Clientes C WHERE CONCAT(C.nombreCliente1,' ', C.apellidoCliente1) LIKE @nombreC and rol = 'Usuario'", conexion);
            comandoC.Parameters.Add("@nombreC", MySqlDbType.VarChar).Value = "%" + textBoxEnprestamo.Text + "%";

            MySqlDataAdapter adapterC = new MySqlDataAdapter();
            adapterC.SelectCommand = comandoC;
            DataTable tClientes = new DataTable();
            adapterC.Fill(tClientes);
            dgvEnPrestamo.DataSource = tClientes;
        }

        private void buttonHistorialCli_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
            MySqlCommand comandoC = new MySqlCommand("SELECT idCliente as 'ID', CONCAT(C.nombreCliente1, ' ', C.nombreCliente2) as 'Nombre Cliente', CONCAT(C.apellidoCliente1, ' ',C.apellidoCliente2) as 'Apellidos Cliente' FROM Clientes C WHERE CONCAT(C.nombreCliente1, ' ', C.apellidoCliente1) LIKE @nombreC and rol = 'Usuario'", conexion);
            comandoC.Parameters.Add("@nombreC", MySqlDbType.VarChar).Value = "%" + textBoxHistorialCli.Text + "%";

            MySqlDataAdapter adapterC = new MySqlDataAdapter();
            adapterC.SelectCommand = comandoC;
            DataTable tClientes = new DataTable();
            adapterC.Fill(tClientes);
            dgvHistorialCli.DataSource = tClientes;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongDateString();
            label6.Text = DateTime.Now.ToLongDateString();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void enPréstamoActualmenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelEnPrestamoCli.BringToFront();
        }

        private void historialDePréstamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelHistorialCli.BringToFront();
        }

        private void actualmenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pPrestamoVig.BringToFront();
        }

        private void porFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pFecha.BringToFront();
        }

        private void caducadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pCaducados.BringToFront();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
