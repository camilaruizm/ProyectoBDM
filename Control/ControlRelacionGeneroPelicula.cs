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

        public void InsertarRelacionPG(ComboBox idPelicula, ComboBox idGenero)
        {
            conexion.Open();
            string Query =
                "INSERT INTO peliculas_generos(idPeliculaf3, idGenerof) " +
                "values('" + idPelicula.SelectedValue + "','" + idGenero.SelectedValue + "');";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void ModificarRelacionPG(ComboBox idPelicula, ComboBox idGenero, TextBox idPeliculaGenero)
        {
            conexion.Open();
            string Query =
                "UPDATE  peliculas_generos SET idPeliculaf3 = '" + idPelicula.SelectedValue + "', idGenerof= '" + idGenero.SelectedValue+"' where idPeliculaGenero = '"+idPeliculaGenero.Text+"';";
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

        public void MostrarRelacionPG(DataGridView dgvP, MySqlDataAdapter adaptador)
        {
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("SELECT idPeliculaf3, idGenerof from peliculas_generos", conexion);

            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvP.DataSource = tabla;
            conexion.Close();
        }

        public void llenarComboboxGenero(ComboBox comboBoxGenero)
        {/*el MysqlCommand se usa cuando se va a sobreescribir, escribir o eliminar en la bd*/

            /*PARA USAR STOREPROCEDURE: mysqlcommand llama el storeP. Le especifico que tipo de comando es, en este caso es un tipo sp. 
             * El adaptador llena la tabla creada (dataTable) */
            MySqlCommand cm = new MySqlCommand("Obtaingeneros", conexion);

            cm.CommandType = CommandType.StoredProcedure;

            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();

            da.Fill(dt);

            comboBoxGenero.ValueMember = "idGenero";
            comboBoxGenero.DisplayMember = "tipoGenero";

            comboBoxGenero.DataSource = dt;
        }

        public void llenarComboboxPelicula(ComboBox comboBoxGenero)
        {
            MySqlCommand cm = new MySqlCommand("ObtainPeliculas", conexion);

            cm.CommandType = CommandType.StoredProcedure;

            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();

            da.Fill(dt);

            comboBoxGenero.ValueMember = "idPelicula";
            comboBoxGenero.DisplayMember = "titulo";

            comboBoxGenero.DataSource = dt;
        }
    }
}
