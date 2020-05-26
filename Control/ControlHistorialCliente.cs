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
using System.Threading;

namespace ProyectoBDM.Control
{
    class ControlHistorialCliente
    {
        MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");

        public void showHistMult(MySqlDataAdapter adaptador, DataGridView dgvH)
        {
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("SELECT M.fechaGeneracionMulta, M.valorMulta, P.titulo FROM  Multas M, Facturas_prestamos FP, Peliculas P, Clientes C  WHERE P.idPelicula = FP.idPeliculaf and M.idClientef2 = C.idCliente and M.estadoMulta= 'Inactivo' ", conexion);
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvH.DataSource = tabla;
            conexion.Close();
        }

        public void showHistPel(MySqlDataAdapter adaptador, DataGridView dataGridView1)
        {
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("SELECT C.nombreCliente1, C.apellidoCliente1, P.titulo, P.duracion FROM  Peliculas P, Clientes C, facturas_prestamos FP, prestamos Pr  WHERE P.idPelicula = FP.idPeliculaf and Pr.idPrestamo = FP.idPrestamof and C.idCliente = Pr.idClientef; ", conexion);
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
        }
    }
}
