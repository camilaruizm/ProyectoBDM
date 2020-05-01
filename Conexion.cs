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
using System.Reflection;

namespace ProyectoBDM
{
    public partial class Conexion : Form
    {
        Thread th;
        public Conexion()
        {
            InitializeComponent();
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            string servidor, BaseDatos;

            servidor = TbServidor.Text;
            BaseDatos = TbBaseDatos.Text;

            MySqlConnection conexion = new MySqlConnection("server = '"+servidor+"'; Database = '"+BaseDatos+"'; user = root; password = root;");

            try
            {
                conexion.Open();
                MessageBox.Show("Conexion Exitosa");
                conexion.Close();
                this.Close();
                th = new Thread(opennewform);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Conexion Fallida");
            }          
        }

        private void opennewform()
        {
            Application.Run(new ValidacionPersona());
        }

        private void TbServidor_Click(object sender, EventArgs e)
        {
            TbServidor.Clear();
            TbServidor.ForeColor = Color.Black;
        }

        private void TbBaseDatos_Click(object sender, EventArgs e)
        {
            TbBaseDatos.Clear();
            TbBaseDatos.ForeColor = Color.Black;
        }

        private void BtnConectar_MouseMove(object sender, MouseEventArgs e)
        {
            BtnConectar.BackColor = Color.Silver;
        }

        private void BtnConectar_MouseLeave(object sender, EventArgs e)
        {
            BtnConectar.BackColor = Color.Lavender;
        }
    }
}
