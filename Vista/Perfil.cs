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

namespace ProyectoBDM.Vista
{
    public partial class Perfil : Form
    {
        ControlPerfil cp = new ControlPerfil();
        string idUserPerfil;        
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
    }
}
