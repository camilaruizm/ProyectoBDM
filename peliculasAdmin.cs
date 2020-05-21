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
using ProyectoBDM.Control;

namespace ProyectoBDM
{
    public partial class peliculasAdmin : Form
    {
        ControlPeliculasAdmi cpa = new ControlPeliculasAdmi();
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
                "values('" + textTitulo.Text + "','" + dateTimePicker1.Text + "','" + textSinopsis.Text + "','" + textDuracion.Text + "','" + arr + "','" + cantCopias.Text +"','"+ comboBox2.ValueMember +"');";
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
                /*try
                {
                    MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");

                    string selectQuery = " SELECT nombreDirector1, apellidoDirector1  From Directores";                  
                    conexion.Open();
                    MySqlCommand command = new MySqlCommand(selectQuery,conexion);
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
                }*/

            cpa.llenarComboBox(comboBox1);
            cpa.llenarComboBoxDirectores(comboBox2);

        }

        private void actualizarAdmin_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
            Image img = pictureBox1.Image;
            byte[] arrImg;
            ImageConverter converter = new ImageConverter();
            arrImg = (byte[])converter.ConvertTo(img, typeof(byte[]));

            conexion.Open();
            string Query = "UPDATE  peliculas SET titulo = '"+textTitulo.Text+"', fechaEstreno= '"+dateTimePicker1+"', sinopsis= '"+textSinopsis.Text+"', duracion = '"+textDuracion.Text+"', posterPelicula = '"+arrImg+"', copiasDisponibles = '"+textCantCopis.Text+"', idDirectorf = '"+comboBox2.ValueMember+"'";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("!Se ha modificado al director con exito¡");
            conexion.Close();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }

}
        
           
    
