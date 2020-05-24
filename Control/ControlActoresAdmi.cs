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
    class ControlActoresAdmi
    {
        MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");

        public void InsertarActores(TextBox nombre1, TextBox nombre2, TextBox apellido1, TextBox apellido2, TextBox correo, TextBox pais, byte[] imgActor)
        {
            conexion.Open();
            string Query = "INSERT INTO ACTORES(nombreActor1,nombreActor2,ApellidoActor1,ApellidoActor2,correoActor,paisActor,fotoA) " +
                "values('" + nombre1.Text + "','" + nombre2.Text + "','" + apellido1.Text + "','" + apellido2.Text + "','" + correo.Text + "','" + pais.Text + "','" + imgActor + "');";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void BorrarActores(TextBox idActor)
        {
            conexion.Open();
            string Query = "DELETE FROM  ACTORES WHERE   idActor ='" + idActor.Text + "'";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void ModificarActores(TextBox nombre1, TextBox nombre2, TextBox apellido1, TextBox apellido2, TextBox correo, TextBox pais, byte[] imgActor, TextBox idActor)
        {
            conexion.Open();
            string Query = "UPDATE  ACTORES SET nombreActor1='" + nombre1.Text + "', nombreActor2='" + nombre2.Text + "',apellidoActor1='" + apellido1.Text + "',apellidoActor2='" + apellido2.Text + "',correoActor='" + correo.Text + "',paisActor='" + pais.Text + "',fotoA='" + imgActor + "' where idActor ='" + idActor.Text + "'";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void MostrarActores(MySqlDataAdapter adaptador, DataGridView dataGridView1)
        {
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("SELECT idActor, nombreActor1 as Nombre1, nombreActor2 as Nombre2, ApellidoActor1 as Apellido1,apellidoActor2 as Apellido2,correoActor as Correo,paisActor as Pais FROM ACTORES", conexion);

            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
        }
    }
}