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
    public partial class generoPelicula : Form
    {
        public generoPelicula()
        {
            InitializeComponent();
        }

        private void insertarGenero_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");

            conexion.Open();
            string Query =
                "INSERT INTO GENEROS(clasificacion,tipoGenero) " +
                "values('" + clasificacionGenero.Text + "','"  + tipoGenero.Text  + "');";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("!Se ha registrado el género con exito¡");
        }
    }
}
