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
                "values('" + textTitulo.Text + "','" + textEstreno.Text + "','" + textSinopsis.Text + "','" + textDuracion.Text + "','" + arr + "','" + cantCopias.Text + "');";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("!Se ha registrado la pelicula con exito¡");
        }





        private void buttonImagePelicula_Click(object sender, EventArgs e)
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

    }
}
        
           
    
