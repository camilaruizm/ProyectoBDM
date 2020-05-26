using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProyectoBDM.Control;
using ProyectoBDM.Modelo;
using System.Threading;

namespace ProyectoBDM.Control
{
    class ControlConsultasAdmi
    {
        MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");

        public void consultarPrestamoCli(TextBox textBoxEnprestamo, DataGridView dgvEnPrestamo)
        {
            conexion.Open();
            MySqlCommand comandoC = new MySqlCommand("SELECT idCliente as 'ID', CONCAT(C.nombreCliente1, ' ', C.nombreCliente2) as 'Nombre Cliente', CONCAT(C.apellidoCliente1, ' ',C.apellidoCliente2) as 'Apellidos Cliente' FROM Clientes C WHERE CONCAT(C.nombreCliente1,' ', C.apellidoCliente1) LIKE @nombreC and rol = 'Usuario'", conexion);
            comandoC.Parameters.Add("@nombreC", MySqlDbType.VarChar).Value = "%" + textBoxEnprestamo.Text + "%";

            MySqlDataAdapter adapterC = new MySqlDataAdapter();
            adapterC.SelectCommand = comandoC;
            DataTable tClientes = new DataTable();
            adapterC.Fill(tClientes);
            dgvEnPrestamo.DataSource = tClientes;
            conexion.Close();
        }

        public void consultarHistorialCli(TextBox textBoxHistorialCli, DataGridView dgvHistorialCli)
        {
            conexion.Open();
            MySqlCommand comandoC = new MySqlCommand("SELECT idCliente as 'ID', CONCAT(C.nombreCliente1, ' ', C.nombreCliente2) as 'Nombre Cliente', CONCAT(C.apellidoCliente1, ' ',C.apellidoCliente2) as 'Apellidos Cliente' FROM Clientes C WHERE CONCAT(C.nombreCliente1, ' ', C.apellidoCliente1) LIKE @nombreC and rol = 'Usuario'", conexion);
            comandoC.Parameters.Add("@nombreC", MySqlDbType.VarChar).Value = "%" + textBoxHistorialCli.Text + "%";

            MySqlDataAdapter adapterC = new MySqlDataAdapter();
            adapterC.SelectCommand = comandoC;
            DataTable tClientes = new DataTable();
            adapterC.Fill(tClientes);
            dgvHistorialCli.DataSource = tClientes;
            conexion.Close();
        }

        public void consultarPrestamosCad(Label label6, DataGridView dataGridView1)
        {
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("SELECT C.nombreCliente1 as Nombre, C.apellidoCliente1 as Apellido, PL.titulo as 'Titulo Película', FP.fechaHoraFM as 'Fecha Final' FROM Clientes C, peliculas PL, facturas_prestamos FP, prestamos P WHERE P.idClientef = C.idCliente and  P.fechaHoraFP >= '" + label6.Text + "' and FP.idPrestamof = P.idPrestamo and FP.idPeliculaf = PL.idPelicula; ", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
        }

        public void consultarPrestamosFec(DateTimePicker dateTimePicker2, DataGridView dataGridView1)
        {
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("SELECT C.nombreCliente1 as Nombre , C.apellidoCliente1 as Apellido ,PL.titulo, FP.fechaHoraFM as 'Fecha Factura' FROM  Clientes C, peliculas PL, facturas_prestamos FP, prestamos P WHERE P.idClientef = C.idCliente and  P.fechaHoraIP = '" + dateTimePicker2.Text + "' and FP.idPrestamof = P.idPrestamo and FP.idPeliculaf = PL.idPelicula; ", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
        }

        public void consultarPrestamosVijentes(Label label4, DataGridView dataGridView1)
        {
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("SELECT C.nombreCliente1 as Nombre , C.apellidoCliente1 as Apellido, PL.titulo, FP.fechaHoraFM as 'Fecha Factura'  FROM   Clientes C, peliculas PL, facturas_prestamos FP, prestamos P WHERE P.idClientef = C.idCliente and  P.fechaHoraFP >= '" + label4.Text + "' and FP.idPrestamof = P.idPrestamo and FP.idPeliculaf = PL.idPelicula; ", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
        }
    }
}
