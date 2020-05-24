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
    class ControlDirecAdmi
    {
        MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");

        public void InsertarDirectores(TextBox nombre1, TextBox nombre2, TextBox apellido1, TextBox apellido2, TextBox correo, TextBox pais, byte[] imgDirector)
        {
            conexion.Open();
            string Query = "INSERT INTO DIRECTORES(nombreDirector1,nombreDirector2,apellidoDirector1,apellidoDirector2,correoDirector,paisDirector,fotoD)values('" + nombre1.Text + "','" + nombre2.Text + "','" + apellido1.Text + "','" + apellido2.Text + "','" + correo.Text + "','" + pais.Text + "','" + imgDirector + "');";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void ModificarDirectores(TextBox nombre1, TextBox nombre2, TextBox apellido1, TextBox apellido2, TextBox correo, TextBox pais, byte[] imgDirector, TextBox idDirector)
        {
            conexion.Open();
            string Query = "UPDATE  DIRECTORES SET nombreDirector1='" + nombre1.Text + "', nombreDirector2 ='" + nombre2.Text + "', apellidoDirector1='" + apellido1.Text + "', apellidoDirector2='" + apellido2.Text + "', correoDirector='" + correo.Text + "', paisDirector='" + pais.Text + "', fotoD='" + imgDirector + "' where idDirector ='" + idDirector.Text + "'";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarDirectores(TextBox idDirector)
        {
            conexion.Open();
            string Query = "DELETE FROM DIRECTORES where idDirector ='" + idDirector.Text + "'  ";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void MostrarDierctores(MySqlDataAdapter adaptador, DataGridView dataGridView1)
        {
            MySqlCommand comando = new MySqlCommand("SELECT D.idDirector, D.nombreDirector1 as Nombre1, D.nombreDirector2 as Nombre2, D.apellidoDirector1 as Apellido1, D.apellidoDirector2 as Apellido2, D.correoDirector as Correo, D.paisDirector as Pais  FROM DIRECTORES D", conexion);

            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }
    }
}
