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

namespace ProyectoBDM
{
    public partial class estadoCuenta : Form
    {
        MySqlDataAdapter adaptador = new MySqlDataAdapter();
        public estadoCuenta()
        {
            InitializeComponent();
        }

        private void showPeliculaCliente_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");

            MySqlCommand comando = new MySqlCommand("SELECT P.idPrestamo,PL.titulo, D.apellidoDirector1,PL.duracion,P.fechaHoraFP FROM facturas_prestamos FP, clientes C, prestamos P, peliculas PL, Directores D WHERE  C.idCliente = P.idClientef and FP.idPrestamof = P.idPrestamo and FP.idPeliculaf = PL.idPelicula; ", conexion);
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvP.DataSource = tabla;
        }

        private void showMultas_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");

            MySqlCommand comando = new MySqlCommand("SELECT M.fechaGeneracionMulta, M.valorMulta, P.titulo FROM  Multas M, Facturas_prestamos FP, Peliculas P, Clientes C  WHERE P.idPelicula = FP.idPeliculaf and M.idClientef2 = C.idCliente; ", conexion);
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvM.DataSource = tabla;
        }
    }
}
