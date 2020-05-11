using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace ProyectoBDM
{
    public partial class RegistroClientes : Form
    {
        
        public RegistroClientes()
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
            "INSERT INTO CLIENTES(nombreCliente1,nombreCliente2,apellidoCliente1,apellidoCliente2,telefonoCliente1,telefonoCliente2,direccionCliente,nombreUsuario,contrasena,rol) values ('" + TbNombre1.Text + "','" + TbNombre2.Text + "','" + TbApellido1.Text + "','" + TbApellido2.Text + "','" + TbTelefono1.Text + "','" + TbTelefono2.Text + "','" + TbDireccion.Text + "','" + TbUsuarioC.Text + "','" + TbContrasenaC.Text + "', 'Usuario');";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("!Se ha registrado el cliente con exito¡");
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            btCrearCliente.BackColor = Color.Silver;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btCrearCliente.BackColor = Color.Lavender;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
