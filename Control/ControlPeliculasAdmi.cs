using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProyectoBDM.Control;

namespace ProyectoBDM.Control
{
    class ControlPeliculasAdmi
    {
        MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");

        public void InsertarPeliculas(TextBox textTitulo, DateTimePicker dateTimePicker1, TextBox textSinopsis, TextBox textDuracion, byte[] arr, TextBox textCantCopis, TextBox TbDirectoresid)
        {
            conexion.Open();
            string Query =
                "INSERT INTO PELICULAS(titulo,fechaEstreno,sinopsis,duracion,posterPelicula,copiasDisponibles,idDirectorf) " +
                "values('" + textTitulo.Text + "','" + dateTimePicker1.Text + "','" + textSinopsis.Text + "','" + textDuracion.Text + "','" + arr + "','" + textCantCopis.Text + "','" + TbDirectoresid.Text + "');";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void ModificarPeliculas(TextBox textTitulo, DateTimePicker dateTimePicker1, TextBox textSinopsis, TextBox textDuracion, byte[] arr, TextBox textCantCopis, TextBox TbDirectoresid, TextBox idPelicula)
        {
            conexion.Open();
            string Query = "UPDATE  peliculas SET titulo = '" + textTitulo.Text + "', fechaEstreno= '" + dateTimePicker1.Text + "', sinopsis= '" + textSinopsis.Text + "', duracion = '" + textDuracion.Text + "', posterPelicula = '" + arr + "', copiasDisponibles = '" + textCantCopis.Text + "', idDirectorf = '" + TbDirectoresid.Text + "' where idPelicula = '"+idPelicula.Text+"'";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        
        public void EliminarPelicula(TextBox idPelicula)
        {
            conexion.Open();
            string Query = "DELETE FROM  PELICULAS WHERE   idActor ='" + idPelicula.Text + "'";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void MostrarPelicula(DataGridView dgvP, MySqlDataAdapter adaptador)
        {
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("SELECT idPelicula, titulo,fechaEstreno,sinopsis,duracion, copiasDisponibles,idDirectorf FROM PELICULAS", conexion);

            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvP.DataSource = tabla;
            conexion.Close();
        }

        public void BuscarDirector(DataGridView dgvD, MySqlDataAdapter adaptador, TextBox buscarD)
        {
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("SELECT idDirector FROM Directores WHERE  concat(Directores.nombreDirector1,' ',Directores.apellidoDirector1)LIKE @nombre ", conexion);
            comando.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = "%" + buscarD.Text + "%";

            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvD.DataSource = tabla;
            conexion.Close();
        }





    }
}
