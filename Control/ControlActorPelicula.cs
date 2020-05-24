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

namespace ProyectoBDM.Control
{
    class ControlActorPelicula
    {
        MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");

        public void InsertarParticipacion(ComboBox combo1, ComboBox combo2)
        {
            conexion.Open();
            string Query =
                "INSERT INTO participaciones(idPeliculaf2, idActorf) " +
                "values('" + combo1.SelectedValue + "','" + combo2.SelectedValue + "');";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void ModificarParticipacion(ComboBox combo1, ComboBox combo2, TextBox idParticipacion)
        {
            conexion.Open();
            string Query =
                "UPDATE  participaciones SET idPeliculaf2 = '" + combo1.SelectedValue + "', idActorf= '" + combo2.SelectedValue + "' where idParticipacion = '" + idParticipacion.Text + "';";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarParticipacion(TextBox idParticipacion) 
        {
            conexion.Open();
            string Query =
                "DELETE FROM participaciones WHERE idParticipacion ='" + idParticipacion.Text + "'";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void MostrarParticipacion(DataGridView dgvP, MySqlDataAdapter adaptador)
        {
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("SELECT idPeliculaf2, idActorf from participaciones", conexion);

            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvP.DataSource = tabla;
            conexion.Close();
        }

        public void llenarComboboxPeliculas(ComboBox comboBoxPelicula)
        {
            MySqlCommand cm = new MySqlCommand("ObtainPeliculas", conexion);

            cm.CommandType = CommandType.StoredProcedure;

            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();

            da.Fill(dt);

            comboBoxPelicula.ValueMember = "idPelicula";
            comboBoxPelicula.DisplayMember = "titulo";

            comboBoxPelicula.DataSource = dt;
        }

        public void llenarComboboxActores(ComboBox comboBoxActores)
        {
            MySqlCommand cm = new MySqlCommand("ObtainActores", conexion);

            cm.CommandType = CommandType.StoredProcedure;

            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();

            da.Fill(dt);

            comboBoxActores.ValueMember = "idActor";
            comboBoxActores.DisplayMember = "nombreActor1";

            comboBoxActores.DataSource = dt;
        }
    }
}
