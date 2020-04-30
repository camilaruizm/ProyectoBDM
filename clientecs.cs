using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
namespace ProyectoBDM
{
    public partial class clientecs : Form
    {
        
        public clientecs()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
            conexion.Open();
            string Query =
            "INSERT INTO CLIENTES(nombreCliente1,nombreCliente2,apellidoCliente1,apellidoCliente2,telefonoCliente1,telefonoCliente2,direccionCliente,nombreUsuario,contrasena) values ('" + TbNombre1.Text + "','" + TbNombre2.Text + "','" + TbApellido1.Text + "','" + TbApellido2.Text + "','" + TbTelefono1.Text + "','" + TbTelefono2.Text + "','" + TbDireccion.Text + "','" + TbUsuarioC.Text + "','" + TbContrasenaC.Text + "');";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("!Se ha registrado el cliente con exito¡");







        }
    }
}
