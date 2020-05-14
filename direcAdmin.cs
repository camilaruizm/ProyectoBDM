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
        int selectedRow;
        MySqlDataAdapter adaptador = new MySqlDataAdapter();

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
            
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];

            nombreDir.Text = row.Cells[1].Value.ToString();
            nombreDir2.Text = row.Cells[2].Value.ToString();
            apellidoDir.Text = row.Cells[3].Value.ToString();
            nombreDir2.Text = row.Cells[4].Value.ToString();
            correoDir.Text = row.Cells[5].Value.ToString();
            paisDir.Text = row.Cells[6].Value.ToString();
        }

        private void modificarDirector_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = dataGridView1.Rows[selectedRow];
            newDataRow.Cells[1].Value = nombreDir.Text;
            newDataRow.Cells[2].Value = nombreDir2.Text;
            newDataRow.Cells[3].Value = apellidoDir.Text;
            newDataRow.Cells[4].Value = apellidoDir2.Text;
            newDataRow.Cells[5].Value = correoDir.Text;
            newDataRow.Cells[6].Value = paisDir.Text;
        }

        private void direcAdmin_Load(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
           
        }
    }
}
