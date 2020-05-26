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
        ControlConsultasAdmi cca = new ControlConsultasAdmi();
        public consultasAdmin()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void buttonEnPrestamo_Click(object sender, EventArgs e)
        {
            try
            {
                cca.consultarPrestamoCli(textBoxEnprestamo, dgvEnPrestamo);
                MessageBox.Show("Cliente encontrado!");
            }
            catch (Exception)
            {
                MessageBox.Show("Cliente no encontrado!");
            }
            //MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
            //MySqlCommand comandoC = new MySqlCommand("SELECT idCliente as 'ID', CONCAT(C.nombreCliente1, ' ', C.nombreCliente2) as 'Nombre Cliente', CONCAT(C.apellidoCliente1, ' ',C.apellidoCliente2) as 'Apellidos Cliente' FROM Clientes C WHERE CONCAT(C.nombreCliente1,' ', C.apellidoCliente1) LIKE @nombreC and rol = 'Usuario'", conexion);
            //comandoC.Parameters.Add("@nombreC", MySqlDbType.VarChar).Value = "%" + textBoxEnprestamo.Text + "%";

            //MySqlDataAdapter adapterC = new MySqlDataAdapter();
            //adapterC.SelectCommand = comandoC;
            //DataTable tClientes = new DataTable();
            //adapterC.Fill(tClientes);
            //dgvEnPrestamo.DataSource = tClientes;
        }

        private void buttonHistorialCli_Click(object sender, EventArgs e)
        {
            try
            {
                cca.consultarHistorialCli(textBoxHistorialCli, dgvHistorialCli);
                MessageBox.Show("Historial encontrado");
            }
            catch (Exception)
            {
                MessageBox.Show("Historial no encontrado");
            }
            //MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
            //MySqlCommand comandoC = new MySqlCommand("SELECT idCliente as 'ID', CONCAT(C.nombreCliente1, ' ', C.nombreCliente2) as 'Nombre Cliente', CONCAT(C.apellidoCliente1, ' ',C.apellidoCliente2) as 'Apellidos Cliente' FROM Clientes C WHERE CONCAT(C.nombreCliente1, ' ', C.apellidoCliente1) LIKE @nombreC and rol = 'Usuario'", conexion);
            //comandoC.Parameters.Add("@nombreC", MySqlDbType.VarChar).Value = "%" + textBoxHistorialCli.Text + "%";

            //MySqlDataAdapter adapterC = new MySqlDataAdapter();
            //adapterC.SelectCommand = comandoC;
            //DataTable tClientes = new DataTable();
            //adapterC.Fill(tClientes);
            //dgvHistorialCli.DataSource = tClientes;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongDateString();
            label6.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                cca.consultarPrestamosCad(label6, dataGridView1);
                MessageBox.Show("Prestamos vencidos encontrados");
            }
            catch (MySqlException)
            {
                MessageBox.Show("No se encontraron prestamos vencidos");
            }
            //MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");

            //conexion.Open();
            //MySqlCommand comando = new MySqlCommand("SELECT C.nombreCliente1 as Nombre, C.apellidoCliente1 as Apellido, PL.titulo as 'Titulo Película', FP.fechaHoraFM as 'Fecha Final' FROM Clientes C, peliculas PL, facturas_prestamos FP, prestamos P WHERE P.idClientef = C.idCliente and  P.fechaHoraFP >= '"+ label6.Text + "' and FP.idPrestamof = P.idPrestamo and FP.idPeliculaf = PL.idPelicula; ", conexion);
            //MySqlDataAdapter adaptador = new MySqlDataAdapter();
            //adaptador.SelectCommand = comando;
            //DataTable tabla = new DataTable();
            //adaptador.Fill(tabla);
            //dataGridView1.DataSource = tabla;
            //conexion.Close();
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cca.consultarPrestamosFec(dateTimePicker2, dataGridView1);
                MessageBox.Show("Prestamos encontrados");
            }
            catch (MySqlException)
            {
                MessageBox.Show("Prestamos no encontrados");
            }
            //MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");

            //conexion.Open();
            //MySqlCommand comando = new MySqlCommand("SELECT C.nombreCliente1 as Nombre , C.apellidoCliente1 as Apellido ,PL.titulo, FP.fechaHoraFM as 'Fecha Factura' FROM  Clientes C, peliculas PL, facturas_prestamos FP, prestamos P WHERE P.idClientef = C.idCliente and  P.fechaHoraIP = '" + dateTimePicker2.Text + "' and FP.idPrestamof = P.idPrestamo and FP.idPeliculaf = PL.idPelicula; ", conexion);
            //MySqlDataAdapter adaptador = new MySqlDataAdapter();
            //adaptador.SelectCommand = comando;
            //DataTable tabla = new DataTable();
            //adaptador.Fill(tabla);
            //dataGridView1.DataSource = tabla;
            //conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cca.consultarPrestamosVijentes(label4, dataGridView1);
                MessageBox.Show("Prestamos encontrados");
            }
            catch (MySqlException)
            {
                MessageBox.Show("No se encontraron prestamos");
            }
            //MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");

            //conexion.Open();
            //MySqlCommand comando = new MySqlCommand("SELECT C.nombreCliente1 as Nombre , C.apellidoCliente1 as Apellido, PL.titulo, FP.fechaHoraFM as 'Fecha Factura'  FROM   Clientes C, peliculas PL, facturas_prestamos FP, prestamos P WHERE P.idClientef = C.idCliente and  P.fechaHoraFP <= '" + label4.Text + "' and FP.idPrestamof = P.idPrestamo and FP.idPeliculaf = PL.idPelicula; ", conexion);
            //MySqlDataAdapter adaptador = new MySqlDataAdapter();
            //adaptador.SelectCommand = comando;
            //DataTable tabla = new DataTable();
            //adaptador.Fill(tabla);
            //dataGridView1.DataSource = tabla;
            //conexion.Close();
        }
    }
}
