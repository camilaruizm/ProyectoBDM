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
    public partial class Conexion : Form
    {
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
                ValidacionPersona validacion = new ValidacionPersona();
                validacion.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Conexion Fallida");
            }
        }
    }
}
