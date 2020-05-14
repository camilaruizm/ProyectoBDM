using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ProyectoBDM
{
    public partial class peliculasAdmin : Form
    {
        string imageUrl = null;

        public peliculasAdmin()

        {
            InitializeComponent();
        }

        private void buttonInsertPelicula_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
            Image img = pictureBox1.Image;
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

            conexion.Open();
            string Query =
                "INSERT INTO PELICULAS(titulo,fechaEstreno,sinopsis,duracion,posterPelicula,copiasDisponibles,idDirectorf) " +
                "values('" + textTitulo.Text + "','" + dateTimePicker1 + "','" + textSinopsis.Text + "','" + textDuracion.Text + "','" + arr + "','" + cantCopias.Text + comboBox2 + "');";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("!Se ha registrado la pelicula con exito¡");
        }





        private void buttonImagePelicula_Click(object sender, EventArgs e)
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


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void peliculasAdmin_Load(object sender, EventArgs e)
        {
          
            {
                try
                {
                    MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");

                    string selectQuery = " SELECT nombreDirector1, apellidoDirector1  From Directores";
                    conexion.Open();
                    MySqlCommand command = new MySqlCommand(selectQuery, conexion);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBox2.Refresh();
                        comboBox2.Items.Add(reader.GetValue(0).ToString());
                    }
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void actualizarAdmin_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
            conexion.Open();
            string Query ="UPDATE PELICULAS SET ID="

        }
    }

}
        
           
    
