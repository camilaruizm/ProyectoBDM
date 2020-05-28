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
using System.Threading;
using ProyectoBDM.Control;

namespace ProyectoBDM
{
    public partial class historialCliente : Form
    {
        string idUserh;
        Thread th;
        MySqlDataAdapter adaptador = new MySqlDataAdapter();
        ControlHistorialCliente chc = new ControlHistorialCliente();
        MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");



        public historialCliente(string idUser)
        {
            InitializeComponent();
           this.idUserh = idUser;
        }

        private void showMultasHist_Click(object sender, EventArgs e)
        {
            try
            {
                chc.showHistMult(adaptador, dgvH,idUserh);
            }
            catch (MySqlException)
            {
                MessageBox.Show("No se encontraron Multas");
            }

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
            Application.Run(new estadoCuenta(idUserh));
        }

        private void showPeliculas_Click(object sender, EventArgs e)
        {
            try
            {
                chc.showHistPel(adaptador, dataGridView1,idUserh);
            }
            catch (MySqlException)
            {
                MessageBox.Show("No se encontraron Peliculas");
            }
        }

        private void historialCliente_Load(object sender, EventArgs e)
        {

        }
    }

}

