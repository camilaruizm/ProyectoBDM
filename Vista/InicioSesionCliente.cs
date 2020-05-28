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
        public string idUserinicio;
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

            usuarioCli = TbUsuarioIniCli.Text;
            contrasenaCli = TbContrasenaIniCli.Text;
            conexion.Open();
            MySqlCommand InicioSesionCli = new MySqlCommand();
            InicioSesionCli.Connection = conexion;
            InicioSesionCli.CommandText = ("select nombreUsuario, contrasena, rol from clientes where nombreUsuario = '" + usuarioCli + "'and contrasena = '" + contrasenaCli + "' and rol = 'Usuario'");

            MySqlDataReader leerCli = InicioSesionCli.ExecuteReader();


            if (leerCli.Read())
            {
                //this.Close();
                //th = new Thread(opennewform);
                //th.SetApartmentState(ApartmentState.STA);
                //th.Start();
            }
            conexion.Close();

            conexion.Open();
            string idQuery = "SELECT idCliente from clientes where clientes.nombreUsuario = '" + TbUsuarioIniCli.Text + "' AND clientes.contrasena='" + TbContrasenaIniCli.Text + "';";
            MySqlCommand comando = new MySqlCommand(idQuery, conexion);
            MySqlDataAdapter idAdapter = new MySqlDataAdapter();
            idAdapter.SelectCommand = comando;

            DataTable idTable = new DataTable();

            int nn = int.Parse(idAdapter.Fill(new DataSet()).ToString());
            // GetFillParameters().GetLength(0);
            if (nn == 0)
            {
                LbIniCliMal.Visible = true;
            }
            else
            {
                idAdapter.Fill(idTable);

                dataGridView1.DataSource = idTable;
                idUserinicio = dataGridView1.Rows[0].Cells[0].Value.ToString();
                MessageBox.Show(idUserinicio);
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
                //LbIniCliMal.Visible = true;
            }
            conexion.Close();
        }

        public void opennewform2()
        {
            
            Application.Run(new MenuAdmin());
        }

        public void opennewform()
        {
            MenuClientes objc = new MenuClientes();
            objc.setIdU(idUserinicio);
            Application.Run(objc); 
        }

        private void InicioSesionCliente_Load(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_MouseMove(object sender, MouseEventArgs e)
        {
            BtnIngresar.BackColor = Color.LightGray;
        }

        private void BtnIngresar_MouseLeave(object sender, EventArgs e)
        {
            BtnIngresar.BackColor = Color.FromArgb(224, 224, 224);
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
            BtnSalir.BackColor = Color.Gray;
        }

        private void BtnSalir_MouseLeave(object sender, EventArgs e)
        {
            BtnSalir.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void LbMensaje2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         /*   MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
            conexion.Open();
            string idQuery = "SELECT idCliente from clientes where clientes.nombreUsuario = '" + TbUsuarioIniCli.Text + "'AND clientes.contrasena='" + TbContrasenaIniCli.Text + "';";
            DataTable idTable = new DataTable();
            MySqlDataAdapter idAdapter = new MySqlDataAdapter(idQuery, conexion);
            idAdapter.Fill(idTable);
            dataGridView1.DataSource = idTable;

            textBox1.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            conexion.Close(); */
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
