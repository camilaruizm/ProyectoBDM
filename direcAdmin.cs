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
    public partial class direcAdmin : Form
    {
        string imageUrl = null;
        public direcAdmin()
        {
            InitializeComponent();
        }

        private void imageDir_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imageUrl = ofd.FileName;
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void insertDir_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
            Image img = pictureBox1.Image;
            byte[] arr3;
            ImageConverter converter = new ImageConverter();
            arr3 = (byte[])converter.ConvertTo(img, typeof(byte[]));

            conexion.Open();
            string Query= "INSERT INTO DIRECTORES(nombreDirector1,nombreDirector2,apellidoDirector1,apellidoDirector2,correoDirector,paisDirector,fotoD)values('" + nombreDir.Text + "','" + nombreDir2.Text + "','" + apellidoDir.Text + "','" + apellidoDir2.Text + "','" + correoDir.Text + "','" + paisDir.Text + "','" + arr3 + "');";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("!Se ha registrado al director con exito¡");
        }

        private void showDirect_Click(object sender, EventArgs e)
        {

            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");

            MySqlCommand comando = new MySqlCommand("SELECT * FROM DIRECTORES", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }
    }
}
