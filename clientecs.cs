using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ProyectoBDM
{
    public partial class clientecs : Form
    {
       MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
        public clientecs()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            conexion.Open();
            string Query =
            "INSERT INTO CLIENTES(nombreCliente1,nombreCliente2,apellidoCliente1,apellidoCliente2,telefonoCliente1,telefonoCliente2,direccionCliente,fotoC,nombreUsuario,contraseña) values ('" + textBox1.Text + "','" + textBox2  + "','" + textBox3 + "','" + textBox4 + "','" + textBox5 + "','" + textBox6 + "','" + textBox7 + "','" + textBox8 + "','" + textBox9 + "');";
            MySqlCommand comando = new MySqlCommand(Query,conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("!Se ha registrado el cliente con exito¡" );
               

        
             
                


        }
    }
}
