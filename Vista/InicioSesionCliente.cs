using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ProyectoBDM
{
    public partial class InicioSesionCliente : Form
    {
       string idUser;
        Thread th;
        MySqlConnection conexion = new MySqlConnection("server=localhost; Database=proyectobdm; user=root; password=root;");
        public InicioSesionCliente()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            th = new Thread(opennewform3);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void opennewform3()
        {
            Application.Run(new RegistroClientes());
        }

        public void BtnIngresar_Click(object sender, EventArgs e)
        {
            string usuarioCli, contrasenaCli;
            idUser = dataGridView1.Rows[0].Cells[0].Value.ToString();
            usuarioCli = TbUsuarioIniCli.Text;
            contrasenaCli = TbContrasenaIniCli.Text;
            conexion.Open();
            
            MySqlCommand InicioSesionCli = new MySqlCommand();
            InicioSesionCli.Connection = conexion;
            InicioSesionCli.CommandText = ("select nombreUsuario, contrasena, rol from clientes where nombreUsuario = '" + usuarioCli + "'and contrasena = '" + contrasenaCli + "' and rol = 'Usuario'");

            MySqlDataReader leerCli = InicioSesionCli.ExecuteReader();

            
            if (leerCli.Read())
                {
                    this.Close();
                    th = new Thread(opennewform);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
            conexion.Close();
            conexion.Open();

            MySqlCommand InicioSesionAdm = new MySqlCommand();
            InicioSesionAdm.Connection = conexion;
            InicioSesionAdm.CommandText = ("select nombreUsuario, contrasena, rol from clientes where nombreUsuario = '" + usuarioCli + "'and contrasena = '" + contrasenaCli + "' and rol = 'Administrador' ");

            MySqlDataReader leerAdm = InicioSesionAdm.ExecuteReader();

            if (leerAdm.Read())
            {
                this.Close();
                th = new Thread(opennewform2);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
                {
                    LbIniCliMal.Visible = true;
                }

            conexion.Close();


            
            

        }

        public void opennewform2()
        {
            Application.Run(new MenuAdmin());
        }

        public void opennewform()
        {
            Application.Run(new MenuClientes(idUser)); 
        }

        private void InicioSesionCliente_Load(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_MouseMove(object sender, MouseEventArgs e)
        {
            BtnIngresar.BackColor = Color.Silver;
        }

        private void BtnIngresar_MouseLeave(object sender, EventArgs e)
        {
            BtnIngresar.BackColor = Color.Lavender;
        }

        private void TbUsuarioIniCli_Click(object sender, EventArgs e)
        {
                TbUsuarioIniCli.Clear();
                TbUsuarioIniCli.ForeColor = Color.Black;
        }

        private void TbContrasenaIniCli_Click(object sender, EventArgs e)
        {
            TbContrasenaIniCli.Clear();
            TbContrasenaIniCli.PasswordChar = '*';
            TbContrasenaIniCli.ForeColor = Color.Black;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalir_MouseMove(object sender, MouseEventArgs e)
        {
            BtnSalir.Text = "Salir";
            BtnSalir.BackColor = Color.DarkRed;
        }

        private void BtnSalir_MouseLeave(object sender, EventArgs e)
        {
            BtnSalir.Text = "X";
            BtnSalir.BackColor = Color.Red;
        }

        private void LbMensaje2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
            conexion.Open();
            string idQuery = "SELECT idCliente from clientes where clientes.nombreUsuario = '" + TbUsuarioIniCli.Text + "'AND clientes.contrasena='" + TbContrasenaIniCli.Text + "';";
            DataTable idTable = new DataTable();
            MySqlDataAdapter idAdapter = new MySqlDataAdapter(idQuery, conexion);
            idAdapter.Fill(idTable);
            dataGridView1.DataSource = idTable;

            textBox1.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            conexion.Close();
        }
    }
}
