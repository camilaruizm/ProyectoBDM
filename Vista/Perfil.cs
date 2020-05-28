using MySql.Data.MySqlClient;
using ProyectoBDM.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProyectoBDM.Vista
{
    public partial class Perfil : Form
    {
        ControlPerfil cp = new ControlPerfil();
        string idUserPerfil;
        Thread th;
        public Perfil(string idUser)
        {
            InitializeComponent();
            this.idUserPerfil = idUser;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btModificarP_Click(object sender, EventArgs e)
        {
            tbNombre1.Enabled = true;
            tbNombre2.Enabled = true;
            tbApellido1.Enabled = true;
            tbApellido2.Enabled = true;
            tbDireccion.Enabled = true;
            tbTel1.Enabled = true;
            tbTel2.Enabled = true;
            tbUsuario.Enabled = true;
            tbContra.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cp.modificarPerfil(tbNombre1, tbNombre2, tbApellido1, tbApellido2, tbTel1, tbTel2, tbDireccion, tbUsuario, tbContra, idUserPerfil);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            try
            {
                cp.mostrarPerfil(idUserPerfil, dgvIdUSER);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }

            tbNombre1.Enabled = false;
            tbNombre2.Enabled = false;
            tbApellido1.Enabled = false;
            tbApellido2.Enabled = false;
            tbDireccion.Enabled = false;
            tbTel1.Enabled = false;
            tbTel2.Enabled = false;
            tbUsuario.Enabled = false;
            tbContra.Enabled = false;

            //MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
            //conexion.Open();
            //string idUQuery = "SELECT * FROM Clientes WHERE idCliente ='" + idUserPerfil + "';";

            //DataTable tidU = new DataTable();
            //MySqlDataAdapter adapterU = new MySqlDataAdapter(idUQuery, conexion);
            //adapterU.Fill(tidU);
            //dgvIdUSER.DataSource = tidU;
            //conexion.Close();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
            Application.Run(new MenuClientes(idUserPerfil));
        }
    
    }
}
