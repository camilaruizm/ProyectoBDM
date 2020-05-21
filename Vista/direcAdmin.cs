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

namespace ProyectoBDM
{
    public partial class direcAdmin : Form
    {
        string imageUrl = null;
        int selectedRow;
        MySqlDataAdapter adaptador = new MySqlDataAdapter();
        ControlDirecAdmi cda = new ControlDirecAdmi();

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

            try
            {
                cda.InsertarDirectores(nombreDir, nombreDir2, apellidoDir, apellidoDir2, correoDir, paisDir, arr3);
                MessageBox.Show("!Se ha registrado al director con exito¡");
            }
            catch (Exception)
            {
                MessageBox.Show("!Error al registrar¡");
            }
            /*conexion.Open();
            string Query= "INSERT INTO DIRECTORES(nombreDirector1,nombreDirector2,apellidoDirector1,apellidoDirector2,correoDirector,paisDirector,fotoD)values('" + nombreDir.Text + "','" + nombreDir2.Text + "','" + apellidoDir.Text + "','" + apellidoDir2.Text + "','" + correoDir.Text + "','" + paisDir.Text + "','" + arr3 + "');";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("!Se ha registrado al director con exito¡");*/
        }

        private void showDirect_Click(object sender, EventArgs e)
        {

            try
            {
                cda.MostrarDierctores(adaptador, dataGridView1);
                MessageBox.Show("!Si desea modificar o eliminar un actor recuerde usar el idActor asociado¡");
            }
            catch (Exception)
            {
                MessageBox.Show("!Error al mostrar¡");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];

            idDirector.Text = row.Cells[0].Value.ToString();
            nombreDir.Text = row.Cells[1].Value.ToString();
            nombreDir2.Text = row.Cells[2].Value.ToString();
            apellidoDir.Text = row.Cells[3].Value.ToString();
            apellidoDir2.Text = row.Cells[4].Value.ToString();
            correoDir.Text = row.Cells[5].Value.ToString();
            paisDir.Text = row.Cells[6].Value.ToString();
          

        }

        private void modificarDirector_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
            Image img = pictureBox1.Image;
            byte[] arr3;
            ImageConverter converter = new ImageConverter();
            arr3 = (byte[])converter.ConvertTo(img, typeof(byte[]));

            try
            {
                cda.ModificarDirectores(nombreDir, nombreDir2, apellidoDir, apellidoDir2, correoDir, paisDir, arr3, idDirector);
                MessageBox.Show("!Se ha modificado al director con exito¡");
            }
            catch (Exception)
            {
                MessageBox.Show("!Error al modificar¡");
            }
            
            /*conexion.Open();
            
            string Query = "UPDATE  DIRECTORES SET nombreDirector1='" + nombreDir.Text + "', nombreDirector2 ='" + nombreDir2.Text + "', apellidoDirector1='" + apellidoDir.Text + "', apellidoDirector2='" + apellidoDir2.Text + "', correoDirector='" + correoDir.Text + "', paisDirector='" + paisDir.Text + "', fotoD='" + arr3 + "' where idDirector ='" + idDirector.Text + "'  ";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("!Se ha modificado al director con exito¡");*/
        }

        private void direcAdmin_Load(object sender, EventArgs e)
        {
           
        }

        private void eliminarDirect_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
            Image img = pictureBox1.Image;
            byte[] arr3;
            ImageConverter converter = new ImageConverter();
            arr3 = (byte[])converter.ConvertTo(img, typeof(byte[]));

            try
            {
                cda.EliminarDirectores(idDirector);               
                MessageBox.Show("!Se ha modificado al director con exito¡");
            }
            catch (Exception)
            {
                MessageBox.Show("!Error al eliminar");
            }
            /*conexion.Open();
            string Query = "DELETE FROM DIRECTORES where idDirector ='" + idDirector.Text + "'  ";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("!Se ha eliminado al director con exito¡");*/
        }
    }
}
