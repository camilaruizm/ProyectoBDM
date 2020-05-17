using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using ProyectoBDM.Control;
using ProyectoBDM.Modelo;

namespace ProyectoBDM
{
    public partial class RegistroClientes : Form
    {
        MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
        ControlRegistroClientes crc = new ControlRegistroClientes();
        Cliente cli = new Cliente();
        string imageUrl = null;

        public RegistroClientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image imaCli = pictureBox1.Image;
            byte[] fotoCliente;
            ImageConverter converter = new ImageConverter();
            fotoCliente = (byte[])converter.ConvertTo(imaCli, typeof(byte[]));

            cli.Nombre1 = TbNombre1.Text;
            cli.Nombre2 = TbNombre2.Text;
            cli.Apellido1 = TbApellido1.Text;
            cli.Apellido2 = TbApellido2.Text;
            cli.Telefono1 = TbTelefono1.Text;
            cli.Telefono2 = TbTelefono2.Text;
            cli.DireccionCliente = TbDireccion.Text;
            cli.UserCli = TbUsuarioC.Text;
            cli.PassCli = TbContrasenaC.Text;

           try
            {
                crc.RegistrarCliente(TbNombre1, TbNombre2, TbApellido1, TbApellido2, TbTelefono1, TbTelefono2, TbDireccion, TbUsuarioC, TbContrasenaC, fotoCliente);
                MessageBox.Show("¡Se ha registrado el cliente con exito!");
            }
           catch(Exception)
            {
                MessageBox.Show("¡Error en el registro!");
            }
            //conexion.Open();
            /*string Query =
            "INSERT INTO CLIENTES(nombreCliente1,nombreCliente2,apellidoCliente1,apellidoCliente2,telefonoCliente1,telefonoCliente2,direccionCliente,nombreUsuario,contrasena,rol) values ('" + TbNombre1.Text + "','" + TbNombre2.Text + "','" + TbApellido1.Text + "','" + TbApellido2.Text + "','" + TbTelefono1.Text + "','" + TbTelefono2.Text + "','" + TbDireccion.Text + "','" + TbUsuarioC.Text + "','" + TbContrasenaC.Text + "', 'Usuario');";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();*/
            //conexion.Close();
            
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            btCrearCliente.BackColor = Color.Silver;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btCrearCliente.BackColor = Color.Lavender;
        }

        private void BtnEscogerIma_Click(object sender, EventArgs e)
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
    }
}
