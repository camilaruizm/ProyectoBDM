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
using ProyectoBDM.Modelo;

namespace ProyectoBDM.Control
{

    class ControlRegistroClientes
    {
        MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");

        public void RegistrarCliente(TextBox n1, TextBox n2, TextBox a1, TextBox a2, TextBox t1, TextBox t2, TextBox d, TextBox user, TextBox pass, byte[] fotoCli)
        {
            conexion.Open();
            string Query =
            "INSERT INTO CLIENTES(nombreCliente1,nombreCliente2,apellidoCliente1,apellidoCliente2,telefonoCliente1,telefonoCliente2,direccionCliente,fotoC,nombreUsuario,contrasena,rol) values ('" + n1.Text + "','" + n2.Text + "','" + a1.Text + "','" + a2.Text + "','" + t1.Text + "','" + t2.Text + "','" + d.Text + "','"+fotoCli+"','" + user.Text + "','" + pass.Text + "', 'Usuario');";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
