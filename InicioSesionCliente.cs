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
using System.Threading;

namespace ProyectoBDM
{
    public partial class InicioSesionCliente : Form
    {
        Thread th;
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
                this.Close();
                th = new Thread(opennewform);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {
                LbIniCliMal.Visible = true;
            }
            conexion.Close();
        }

        private void opennewform()
        {
            Application.Run(new MenuClientes());
        }

        private void InicioSesionCliente_Load(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_MouseMove(object sender, MouseEventArgs e)
        {
            BtnIngresar.BackColor = Color.Silver;
        }

        private void BtnIngresar_MouseLeave(object sender, EventArgs e)
        {
            BtnIngresar.BackColor = Color.Lavender;
        }

        private void TbUsuarioIniCli_Click(object sender, EventArgs e)
        {
                TbUsuarioIniCli.Clear();
                TbUsuarioIniCli.ForeColor = Color.Black;
        }

        private void TbContrasenaIniCli_Click(object sender, EventArgs e)
        {
            TbContrasenaIniCli.Clear();
            TbContrasenaIniCli.PasswordChar = '*';
            TbContrasenaIniCli.ForeColor = Color.Black;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalir_MouseMove(object sender, MouseEventArgs e)
        {
            BtnSalir.Text = "Salir";
            BtnSalir.BackColor = Color.DarkRed;
        }

        private void BtnSalir_MouseLeave(object sender, EventArgs e)
        {
            BtnSalir.Text = "X";
            BtnSalir.BackColor = Color.Red;
        }

    }
}
