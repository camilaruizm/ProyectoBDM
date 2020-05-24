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
using System.Threading;


namespace ProyectoBDM
{
    public partial class direcAdmin : Form
    {
        Thread th;
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
            
   
        }

        private void direcAdmin_Load(object sender, EventArgs e)
        {
           
        }

        private void eliminarDirect_Click(object sender, EventArgs e)
        {
            try
            {
                cda.EliminarDirectores(idDirector);               
                MessageBox.Show("!Se ha eliminado al director con exito¡");
            }
            catch (Exception)
            {
                MessageBox.Show("!Error al eliminar");
            }
        
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
        }
    }
}
