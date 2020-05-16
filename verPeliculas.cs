using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBDM
{
    public partial class verPeliculas : Form
    {
        public verPeliculas()
        {
            InitializeComponent();
        }

        private void BtnBuscarPelicular_Click(object sender, EventArgs e)
        {
            string buscar = TbBuscarPelicula.Text;

            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");

            conexion.Open();
            MySqlCommand busca = new MySqlCommand();
            busca.Connection = conexion;
            busca.CommandText = ("select * from peliculas where titulo = '"+buscar+"'");

            adaptador.SelectCommand = busca;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
