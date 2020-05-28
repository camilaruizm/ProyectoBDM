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

namespace ProyectoBDM.Control
{
    class ControlPerfil
    {
        MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");

        public void mostrarPerfil(string idUserPerfil, DataGridView dgvIdUSER)
        {
            conexion.Open();
            string idUQuery = "SELECT * FROM Clientes WHERE idCliente ='" + idUserPerfil + "';";

            DataTable tidU = new DataTable();
            MySqlDataAdapter adapterU = new MySqlDataAdapter(idUQuery, conexion);
            adapterU.Fill(tidU);
            dgvIdUSER.DataSource = tidU;
            conexion.Close();
        }

        public void modificarPerfil(TextBox n1, TextBox n2, TextBox a1, TextBox a2, TextBox t1, TextBox t2, TextBox direc, TextBox user, TextBox pass, String idUserPerfil)
        {
            conexion.Open();
            string Query =
            "UPDATE CLIENTES SET nombreCliente1='"+n1.Text+"',nombreCliente2='"+n2.Text+"',apellidoCliente1='"+a1.Text+"',apellidoCliente2='"+a2.Text+"',telefonoCliente1='"+t1+"',telefonoCliente2='"+t2.Text+"',direccionCliente='"+direc.Text+"', nombreUsuario='"+user.Text+"',contrasena='"+pass.Text+"' WHERE idCliente= '"+idUserPerfil+"';";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
