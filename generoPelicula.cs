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
    public partial class generoPelicula : Form
    {
        int selectedRow;
        MySqlDataAdapter adaptador = new MySqlDataAdapter();
        public generoPelicula()
        {
            InitializeComponent();
        }

        private void insertarGenero_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");

            conexion.Open();
            string Query =
                "INSERT INTO GENEROS(tipoGenero) " +
                "values('"  + tipoGenero.Text  + "');";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("!Se ha registrado el género con exito¡");
        }

        private void modificarGenero_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");

            conexion.Open();

            string Query = "UPDATE  GENEROS SET  tipoGenero ='" + tipoGenero.Text + "' WHERE idGenero ='" + idGenero.Text + "'  ";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("!Se ha modificado al director con exito¡");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];

            idGenero.Text = row.Cells[0].Value.ToString();
            tipoGenero.Text = row.Cells[2].Value.ToString();
        }

        private void showGenero_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");

            MySqlCommand comando = new MySqlCommand("SELECT * FROM GENEROS", conexion);

            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void eliminarGenero_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");

            conexion.Open();

            string Query = "DELETE  FROM GENEROS   WHERE idGenero ='" + idGenero.Text + "'  ";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("!Se ha modificado al director con exito¡");
        }
    }
}
