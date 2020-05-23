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
using ProyectoBDM.Control;
using ProyectoBDM.Modelo;
using System.Threading;

namespace ProyectoBDM
{
    public partial class actoresAdmin : Form
        
    {
        Thread th;
        string imageUrl = null;
        int selectedRow;
        MySqlDataAdapter adaptador = new MySqlDataAdapter();
        ControlActoresAdmi caa = new ControlActoresAdmi();
        Actores Act = new Actores();

        public actoresAdmin()
        {
            InitializeComponent();
        }

        private void buttonImageAct_Click(object sender, EventArgs e)
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

        private void insertarActor_Click(object sender, EventArgs e)
        {
            Image img = pictureBox1.Image;
            byte[] arr2;
            ImageConverter converter = new ImageConverter();
            arr2 = (byte[])converter.ConvertTo(img, typeof(byte[]));

            Act.NombreActor1 = textNombreAct.Text;
            Act.NombreActor2 = textNombreAct2.Text;
            Act.ApellidoActor1 = textApeAct.Text;
            Act.ApellidoActor2 = textApeAct2.Text;
            Act.CorreoActor = textCorreoAct.Text;
            Act.PaisActor = textPaisAct.Text;

            try
            {
                caa.InsertarActores(textNombreAct, textNombreAct2, textApeAct, textApeAct2, textCorreoAct, textPaisAct, arr2);
                MessageBox.Show("!Se ha registrado el actor con exito¡");
            }
            catch (Exception)
            {
                MessageBox.Show("!Error en el registro¡");
            }
            /*conexion.Open();
            string Query = "INSERT INTO ACTORES(nombreActor1,nombreActor2,ApellidoActor1,ApellidoActor2,correoActor,paisActor,fotoA) " +
                "values('" + textNombreAct.Text + "','" + textNombreAct2.Text + "','" + textApeAct.Text + "','" + textApeAct2.Text + "','" + textCorreoAct.Text + "','" +textPaisAct.Text + "','" + arr2 + "');";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("!Se ha registrado el actor con exito¡");*/
        }

        private void showActor_Click(object sender, EventArgs e)
        {
            try
            {
                caa.MostrarActores(adaptador, dataGridView1);
                MessageBox.Show("Si solicita hacer una modificacion o eliminacion de un actor recuerde usar el idActor que le corresponde");
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo mostrar");
            }
            /*MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");

            MySqlCommand comando = new MySqlCommand("SELECT * FROM ACTORES", conexion);

            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;*/           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");

            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];

            idActor.Text = row.Cells[0].Value.ToString();
            textNombreAct.Text = row.Cells[1].Value.ToString();
            textNombreAct2.Text = row.Cells[2].Value.ToString();
            textApeAct.Text = row.Cells[3].Value.ToString();
            textApeAct2.Text = row.Cells[4].Value.ToString();
            textCorreoAct.Text = row.Cells[5].Value.ToString();
            textPaisAct.Text = row.Cells[6].Value.ToString();
        }

        private void modificarActor_Click(object sender, EventArgs e)
        {
            Act.NombreActor1 = textNombreAct.Text;
            Act.NombreActor2 = textNombreAct2.Text;
            Act.ApellidoActor1 = textApeAct.Text;
            Act.ApellidoActor2 = textApeAct2.Text;
            Act.CorreoActor = textCorreoAct.Text;
            Act.PaisActor = textPaisAct.Text;

            //MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
            Image img = pictureBox1.Image;
            byte[] arr2;
            ImageConverter converter = new ImageConverter();
            arr2 = (byte[])converter.ConvertTo(img, typeof(byte[]));

            try
            {
                caa.ModificarActores(textNombreAct, textNombreAct2, textApeAct, textApeAct2, textCorreoAct, textPaisAct, arr2, idActor);
                MessageBox.Show("!Modificacion exitosa¡");
            }
            catch (Exception)
            {
                MessageBox.Show("!Error en la modificacion¡");
            }

            /*conexion.Open();
            string Query = "UPDATE  ACTORES SET nombreActor1='" + textNombreAct.Text + "', nombreActor2='" + textNombreAct2.Text + "',apellidoActor1='" + textApeAct.Text + "',apellidoActor2='" + textApeAct2.Text + "',correoActor='" + textCorreoAct.Text + "',paisActor='" + textPaisAct.Text + "',fotoA='" + arr2 + "' where idActor ='" + idActor.Text + "'  "; 
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("!Se ha modificado el actor con exito¡");*/
        }

        private void deleteActor_Click(object sender, EventArgs e)
        {
            try
            {
                caa.BorrarActores(idActor);
                MessageBox.Show("!Eliminacion exitosa¡");
            }
            catch (Exception)
            {
                MessageBox.Show("!Eliminacion fallida¡");
            }

            //MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
            /*Image img = pictureBox1.Image;
            byte[] arr2;
            ImageConverter converter = new ImageConverter();
            arr2 = (byte[])converter.ConvertTo(img, typeof(byte[]));

            conexion.Open();
            string Query = "DELETE FROM  ACTORES WHERE   idActor ='" + idActor.Text + "'  ";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
<<<<<<< HEAD:Vista/actoresAdmin.cs
            MessageBox.Show("!Se ha Eliminado el actor con exito¡");
=======
            MessageBox.Show("!Se ha Eliminado el actor con exito¡");
>>>>>>> parent of 4fb0773... FUNCIONAMIENTO PRESTAMOS ACTIVOS CLIENTE:actoresAdmin.cs*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
    
}
