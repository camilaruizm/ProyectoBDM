using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;


namespace ProyectoBDM.Control
{
    class ControlInicioSesionClientes
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost; Database=proyectobdm; user=root; password=root;");

        public void InicioSesionUsuario(TextBox user, TextBox pass)
        {
            conexion.Open();
            MySqlCommand InicioSesionCli = new MySqlCommand();
            InicioSesionCli.Connection = conexion;
            /*CommandText: se indica que inicioSesionCli es un command*/
            InicioSesionCli.CommandText = ("select nombreUsuario, contrasena, rol from clientes where nombreUsuario = '" + user.Text + "'and contrasena = '" + pass.Text + "' and rol = 'Usuario'");

            MySqlDataReader leerCli = InicioSesionCli.ExecuteReader();
            conexion.Close();
        }

        public void InicioSesionAdmi(TextBox user, TextBox pass)
        {
            conexion.Open();
            MySqlCommand InicioSesionCli = new MySqlCommand();
            InicioSesionCli.Connection = conexion;
            InicioSesionCli.CommandText = ("select nombreUsuario, contrasena, rol from clientes where nombreUsuario = '" + user.Text + "'and contrasena = '" + pass.Text + "' and rol = 'Administrador'");

            MySqlDataReader leerCli = InicioSesionCli.ExecuteReader();
            conexion.Close();
        }
    }
}
