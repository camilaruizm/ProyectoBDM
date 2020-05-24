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
using ProyectoBDM.Control;
using ProyectoBDM.Modelo;
using System.Threading;


namespace ProyectoBDM
{
    public partial class SolicitarPrestamo : Form
    {
        
        MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
        MySqlDataAdapter adaptador = new MySqlDataAdapter();

        Thread th;
        public SolicitarPrestamo()
        {
            InitializeComponent();
        }

        private void btBuscarM_Click(object sender, EventArgs e)
        {
           /* foreach row As DataGridViewRow In dgvPeliculas.SelectedRows;

             dgvPrestamo.Rows.Add(row.AccessibilityObject.Value)
                Next*/
        }


        private void tITULOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelTitulo.BringToFront();
        }

        private void cATEGORIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelCategoria.BringToFront();
        }

        private void dIRECTORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelDirector.BringToFront();
        }

        private void panelDirector_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
            conexion.Open();
            string tituloQuery = "SELECT titulo as 'Titulo', fechaEstreno as 'Fecha de Estreno', sinopsis as 'Sinopsis', duracion as 'Duracion', copiasDisponibles as 'Copias Disponibles', CONCAT (nombreDirector1 , ' ' ,  nombreDirector2) as 'Nombre Director', CONCAT (apellidoDirector1 , ' ' , apellidoDirector2) as 'Apellido Director' from peliculas inner join Directores on directores.idDirector = peliculas.idDirectorf where peliculas.titulo ='" + tbTituloP.Text + "';";
            DataTable tPeliculasTitulo = new DataTable();
            MySqlDataAdapter adapterT = new MySqlDataAdapter(tituloQuery, conexion);
            adapterT.Fill(tPeliculasTitulo);
            dgvPeliculas.DataSource = tPeliculasTitulo;
            conexion.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
            conexion.Open();

            string directorQuery = "SELECT titulo as 'Titulo', fechaEstreno as 'Fecha de Estreno', sinopsis as 'Sinopsis', duracion as 'Duracion', copiasDisponibles as 'Copias Disponibles', CONCAT (nombreDirector1 , ' ' ,  nombreDirector2) as 'Nombre Director', CONCAT (apellidoDirector1 , ' ' , apellidoDirector2) as 'Apellido Director' from directores inner join Peliculas on peliculas.idDirectorf = directores.idDirector where directores.nombreDirector1 ='" + tbDirectorP.Text + "'AND apellidoDirector1='" + textBox1.Text + "';";
            DataTable tPeliculasDirector = new DataTable();
            MySqlDataAdapter adapterD = new MySqlDataAdapter(directorQuery, conexion);
            adapterD.Fill(tPeliculasDirector);
            dgvPeliculas.DataSource = tPeliculasDirector;

            int counter = dgvPeliculas.Rows.Count;
            textBox2.Text = counter.ToString();

            int total = counter * 20000;
            textBox3.Text = total.ToString();
            conexion.Close();
        }   

        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvPrestamo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btPrestamo_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(volverMenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void volverMenu()
        {
            Application.Run(new MenuClientes());
        }

        private void SolicitarPrestamo_Load(object sender, EventArgs e)
        {
            
                 
            MySqlCommand cm = new MySqlCommand("Obtaingeneros", conexion);

                cm.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter da = new MySqlDataAdapter(cm);
                DataTable dt = new DataTable();

                da.Fill(dt);

                comboBoxCategoria.ValueMember = "idGenero";
                comboBoxCategoria.DisplayMember = "tipoGenero";

                comboBoxCategoria.DataSource = dt;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
            conexion.Open();
            string categoriaQuery = "SELECT titulo as 'Titulo', fechaEstreno as 'Fecha de Estreno', sinopsis as 'Sinopsis', duracion as 'Duracion', copiasDisponibles as 'Copias Disponibles',  tipoGenero as 'Genero' FROM peliculas left join peliculas_generos on peliculas.idPelicula = peliculas_generos.idPeliculaf3 left join generos on peliculas_generos.idGeneroF = generos.idGenero where generos.tipoGenero = '" + comboBoxCategoria.Text + "';";

            DataTable tPeliculasCategoria = new DataTable();
            MySqlDataAdapter adapterC = new MySqlDataAdapter(categoriaQuery, conexion);
            adapterC.Fill(tPeliculasCategoria);
            dgvPeliculas.DataSource = tPeliculasCategoria;
            conexion.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
