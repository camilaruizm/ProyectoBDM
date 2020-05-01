using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBDM
{
    public partial class InicioSesionCliente : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost; Database=proyectobdm; user=root; password=root;");
        public InicioSesionCliente()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistroClientes aqui = new RegistroClientes();
            aqui.Show();
        }

        protected void BtnIngresar_Click(object sender, EventArgs e)
        {
            string usuarioCli, contrasenaCli;

            usuarioCli = TbUsuarioIniCli.Text;
            contrasenaCli = TbContrasenaIniCli.Text;

            conexion.Open();
            MySqlCommand InicioSesion = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            InicioSesion.Connection = conexion;

            InicioSesion.CommandText = ("select nombreUsuario, contrasena from clientes where nombreUsuario = '" + usuarioCli + "'and contrasena = '" + contrasenaCli + "' ");
            MySqlDataReader leer = InicioSesion.ExecuteReader();
            if (leer.Read())
            {
                MenuClientes menuCli = new MenuClientes();
                menuCli.Show();
            }
            else
            {
                LbIniCliMal.Visible = true;
            }
            conexion.Close();
        }

        private void InicioSesionCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
