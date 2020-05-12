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
                "values('" + textNombreAct + "','" + textNombreAct2 + "','" + textApeAct + "','" + textApeAct2 + "','" + textCorreoAct + "','" +textPaisAct + "','" + arr2 + "');";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("!Se ha registrado el actor con exito¡");
        }
    }
}
