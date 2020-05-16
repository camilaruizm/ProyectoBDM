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
    public partial class actoresAdmin : Form
        
    {
        string imageUrl = null;
        int selectedRow;
        MySqlDataAdapter adaptador = new MySqlDataAdapter();
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
            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
            Image img = pictureBox1.Image;
            byte[] arr2;
            ImageConverter converter = new ImageConverter();
            arr2 = (byte[])converter.ConvertTo(img, typeof(byte[]));

            conexion.Open();
            string Query = "INSERT INTO ACTORES(nombreActor1,nombreActor2,ApellidoActor1,ApellidoActor2,correoActor,paisActor,fotoA) " +
                "values('" + textNombreAct.Text + "','" + textNombreAct2.Text + "','" + textApeAct.Text + "','" + textApeAct2.Text + "','" + textCorreoAct.Text + "','" +textPaisAct.Text + "','" + arr2 + "');";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("!Se ha registrado el actor con exito¡");
        }

        private void showActor_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");

            MySqlCommand comando = new MySqlCommand("SELECT * FROM ACTORES", conexion);

            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");

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
            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
            Image img = pictureBox1.Image;
            byte[] arr2;
            ImageConverter converter = new ImageConverter();
            arr2 = (byte[])converter.ConvertTo(img, typeof(byte[]));

            conexion.Open();
            string Query = "UPDATE  ACTORES SET nombreActor1='" + textNombreAct.Text + "', nombreActor2='" + textNombreAct2.Text + "',apellidoActor1='" + textApeAct.Text + "',apellidoActor2='" + textApeAct2.Text + "',correoActor='" + textCorreoAct.Text + "',paisActor='" + textPaisAct.Text + "',fotoA='" + arr2 + "' where idActor ='" + idActor.Text + "'  "; 
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("!Se ha modificado el actor con exito¡");

        }

        private void deleteActor_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
            Image img = pictureBox1.Image;
            byte[] arr2;
            ImageConverter converter = new ImageConverter();
            arr2 = (byte[])converter.ConvertTo(img, typeof(byte[]));

            conexion.Open();
            string Query = "DELETE FROM  ACTORES WHERE   idActor ='" + idActor.Text + "'  ";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("!Se ha Eliminado el actor con exito¡");
        }
    }
}
