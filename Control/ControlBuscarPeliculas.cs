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
    class ControlBuscarPeliculas
    {
        MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");

        public void BuscarPeliculas(TextBox tbDirectorPelicula, DomainUpDown dudCategorias, TextBox tbTituloPelicula)
        {
            conexion.Open();
            string Query =
            "SELECT * FROM PELICULAS WHERE nombrePelicula = ('" + tbDirectorPelicula.Text + "');";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
