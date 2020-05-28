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

/*  el MODELO VISTA CONTROL es un tipo de organizacioón del manejo de datos de un aplicativo, en donde los 3 modulos están relacionados entre si
 CONTROL: van todos los métodos relacionados con el funcionamiento de las interfaces (consultas, calculos)
 VISTA: corresponde a las interfaces, posee los métodos para navegar entre interfaces. Aquí se llaman los métodos del control para los procesos principales
 MODELO: Van las entidades creadas en em MER y MRD con sus respectivos atributos y constructores*/ 

    //Primero se instaló la librería de Mysql para que se pudiese usar en el proyecto

namespace ProyectoBDM.Control
{
    class ControlActoresAdmi
    {
        // Se crea una nueva conexion donde se especifica el servido, la bd , usuario y contraseña. Si el user y password fuera diferente a root 
        //estos datos debían cambiarse por el de c/u
        MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");


        /*se le define que atributos va a recibir, se les da un nombre a las variables para el método, pero al usarlo en la vista se cambian por el texbox designado
         * se deben poner en el orden correspondiente para que sean relacionados correctamente */
        public void InsertarActores(TextBox nombre1, TextBox nombre2, TextBox apellido1, TextBox apellido2, TextBox correo, TextBox pais, byte[] imgActor)
        {
            /*se cierra y abre la conexión para evitar entradas malintencionadas*/
            conexion.Open();
            string Query = "INSERT INTO ACTORES(nombreActor1,nombreActor2,ApellidoActor1,ApellidoActor2,correoActor,paisActor,fotoA) " +
                "values('" + nombre1.Text + "','" + nombre2.Text + "','" + apellido1.Text + "','" + apellido2.Text + "','" + correo.Text + "','" + pais.Text + "','" + imgActor + "');";
            /*se crea un comando que ejecuta, el cual recibe nuestro query con la conexión donde ese query va a funcionar*/
            /*el MysqlCommand se usa cuando se va a sobreescribir, escribir o eliminar en la bd*/
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            /*Ejecuta el query */
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