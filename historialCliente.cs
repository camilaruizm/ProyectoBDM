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
        int idUser;
        Thread th;
        MySqlDataAdapter adaptador = new MySqlDataAdapter();
        ControlHistorialCliente chc = new ControlHistorialCliente();

       
        public historialCliente(int idUser)
        {
            InitializeComponent();
            this.idUser = idUser;
        }

        private void showMultasHist_Click(object sender, EventArgs e)
        {
            try
            {
                chc.showHistMult(adaptador, dgvH, idUser);
            }
            catch (MySqlException)
            {
                MessageBox.Show("No se encontraron Multas");
            }
            //MySqlCommand comando = new MySqlCommand("SELECT M.fechaGeneracionMulta, M.valorMulta, P.titulo FROM  Multas M, Facturas_prestamos FP, Peliculas P, Clientes C  WHERE P.idPelicula = FP.idPeliculaf and M.idClientef2 = C.idCliente and M.estadoMulta= 'Inactivo' ", conexion);
            //adaptador.SelectCommand = comando;
            //DataTable tabla = new DataTable();
            //adaptador.Fill(tabla);
            //dgvH.DataSource = tabla;
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
            Application.Run(new estadoCuenta(idUser));
        }

        private void showPeliculas_Click(object sender, EventArgs e)
        {
            try
            {
                chc.showHistPel(adaptador, dataGridView1, idUser);
            }
            catch (MySqlException)
            {
                MessageBox.Show("No se encontraron Peliculas");
            }
            //MySqlCommand comando = new MySqlCommand("SELECT C.nombreCliente1, C.apellidoCliente1, P.titulo, P.duracion FROM  Peliculas P, Clientes C, facturas_prestamos FP, prestamos Pr  WHERE P.idPelicula = FP.idPeliculaf and Pr.idPrestamo = FP.idPrestamof and C.idCliente = Pr.idClientef; ", conexion);
            //adaptador.SelectCommand = comando;
            //DataTable tabla = new DataTable();
            //adaptador.Fill(tabla);
            //dataGridView1.DataSource = tabla;
        }

        private void historialCliente_Load(object sender, EventArgs e)
        {

        }
    }

}

