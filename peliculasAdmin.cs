using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
        Thread th;
        int selectedRow;
        MySqlDataAdapter adaptador = new MySqlDataAdapter();

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

            try
            {
                cpa.InsertarPeliculas(textTitulo, dateTimePicker1, textSinopsis, textDuracion, arr, textCantCopis, TbDirectoresid);
                MessageBox.Show("Se inserto con exito");
                this.Close();
                th = new Thread(Abrir_RGN);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al insertar la pelicula");
            }

            //conexion.Open();
            //string Query =
            //    "INSERT INTO PELICULAS(titulo,fechaEstreno,sinopsis,duracion,posterPelicula,copiasDisponibles,idDirectorf) " +
            //    "values('" + textTitulo.Text + "','" + dateTimePicker1.Text + "','" + textSinopsis.Text + "','" + textDuracion.Text + "','" + arr + "','" + textCantCopis.Text +"','"+ TbDirectoresid.Text +"');";
            //MySqlCommand comando = new MySqlCommand(Query, conexion);
            //comando.ExecuteNonQuery();
            //conexion.Close();
            //MessageBox.Show("!Se ha registrado la pelicula con exito¡");
        }

        private void Abrir_RGN()
        {
            Application.Run(new RelacionGeneroPelicula());
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

        private void actualizarAdmin_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
            Image img = pictureBox1.Image;
            byte[] arrImg;
            ImageConverter converter = new ImageConverter();
            arrImg = (byte[])converter.ConvertTo(img, typeof(byte[]));

            try
            {
                cpa.ModificarPeliculas(textTitulo, dateTimePicker1, textSinopsis, textDuracion, arrImg, textCantCopis, TbDirectoresid, textBoxidPelicula);
                MessageBox.Show("Modificado con exito");
            }
            catch (Exception)
            {

                MessageBox.Show("Error al modificar");
            }
            //conexion.Open();
            //string Query = "UPDATE  peliculas SET titulo = '"+textTitulo.Text+"', fechaEstreno= '"+dateTimePicker1+"', sinopsis= '"+textSinopsis.Text+"', duracion = '"+textDuracion.Text+"', posterPelicula = '"+arrImg+"', copiasDisponibles = '"+textCantCopis.Text+"', idDirectorf = '"+comboBox2.ValueMember+"'";
            //MySqlCommand comando = new MySqlCommand(Query, conexion);
            //comando.ExecuteNonQuery();
            //conexion.Close();
            //MessageBox.Show("!Se ha modificado al director con exito¡");
            //conexion.Close();

        }

        private void deleteAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                cpa.EliminarPelicula(textBoxidPelicula);
                MessageBox.Show("Pelicula eliminada con exito");
            }
            catch (Exception)
            {
                MessageBox.Show("Error a eliminar");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                cpa.MostrarPelicula(dataGridView2, adaptador);
                MessageBox.Show("si necesita modificar o eliminar primero de click en el dato deseado");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al mostrar");
            }
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            try
            {
                cpa.BuscarDirector(dgvD, adaptador, buscarD);
               
            }
            catch (Exception)
            {
                MessageBox.Show("Error al mostrar");
            }
        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView2.Rows[selectedRow];

            textBoxidPelicula.Text = row.Cells[0].Value.ToString();
            textTitulo.Text = row.Cells[1].Value.ToString();
            dateTimePicker1.Text = row.Cells[2].Value.ToString();
            textSinopsis.Text = row.Cells[3].Value.ToString();
            textDuracion.Text = row.Cells[4].Value.ToString();
            textCantCopis.Text = row.Cells[5].Value.ToString();
            TbDirectoresid.Text = row.Cells[6].Value.ToString();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(volverMenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void volverMenu()
        {
            Application.Run(new MenuAdmin());
        }

        private void peliculasAdmin_Load(object sender, EventArgs e)
        {

        }
    }

}
        
           
    
