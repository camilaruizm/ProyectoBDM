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
    class ControlRelacionGeneroPelicula
    {
        MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");

        public void InsertarRelacionPG(TextBox idPelicula, TextBox idGenero)
        {
            conexion.Open();
            string Query =
                "INSERT INTO peliculas_generos(idPeliculaf3, idGenerof) " +
                "values('" + idPelicula.Text + "','" + idGenero.Text + "');";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void ModificarRelacionPG(TextBox idPelicula, TextBox idGenero, TextBox idPeliculaGenero)
        {
            conexion.Open();
            string Query =
                "UPDATE  peliculas_generos SET idPeliculaf3 = '" + idPelicula.Text + "', idGenerof= '" + idGenero.Text+"' where '"+idPeliculaGenero+"';";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarRelacionPG(TextBox idPeliculaGenero)
        {
            conexion.Open();
            string Query =
                "DELETE FROM peliculas_genero WHERE idMulta ='" + idPeliculaGenero.Text + "'  ";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
