using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoBDM.Control
{
    class ControlGeneroPelicula
    {
        MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");

        public void InsertarGenero(TextBox tipoGenero)
        {
            conexion.Open();
            string Query =
                "INSERT INTO GENEROS(tipoGenero) " +
                "values('" + tipoGenero.Text + "');";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void ModificarGenero(TextBox tipoGenero, TextBox idGenero)
        {
            conexion.Open();
            string Query = "UPDATE  GENEROS SET  tipoGenero ='" + tipoGenero.Text + "' WHERE idGenero ='" + idGenero.Text + "'  ";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarGenero(TextBox idGenero)
        {
            conexion.Open();
            string Query = "DELETE  FROM GENEROS   WHERE idGenero ='" + idGenero.Text + "'  ";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void MostrarGenero(MySqlDataAdapter adaptador, DataGridView dataGridView1)
        {
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("SELECT * FROM GENEROS", conexion);

            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
        }
    }
}
