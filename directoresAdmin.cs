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

namespace ProyectoBDM
{
    public partial class directoresAdmin : Form
    {
        string imageUrl = null;
        public directoresAdmin()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void imagenDir_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imageUrl = ofd.FileName;
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void insertarDir_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
            Image img = pictureBox1.Image;
            byte[] arr3;
            ImageConverter converter = new ImageConverter();
            arr3 = (byte[])converter.ConvertTo(img, typeof(byte[]));
            conexion.Open();
            string Query= "INSERT INTO DIRECTORES(nombreDirector1,nombreDirector2,apellidoDirector1,apellidoDirector2,correoDirector,paisDirector,fotoD) values('" + nombreDir + "','" + nombreDir2 + "','" + apellidoDir + "','" + apellido2Dir + "','" + correoDir + "','" + paisDir + "','" + arr3 + "');";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("!Se ha registrado el director con exito¡");
        }
    }
}
