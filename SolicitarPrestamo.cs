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
       
         string idUser;
        MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
        MySqlDataAdapter adaptador = new MySqlDataAdapter();

        Thread th;

        public SolicitarPrestamo(string idUser)
        {
            InitializeComponent();
            this.idUser = idUser;
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
            string tituloQuery = "SELECT titulo as 'Titulo', fechaEstreno as 'Fecha de Estreno', sinopsis as 'Sinopsis', duracion as 'Duracion', copiasDisponibles as 'Copias', CONCAT (nombreDirector1 , ' ' ,  nombreDirector2) as 'Nombre Director', CONCAT (apellidoDirector1 , ' ' , apellidoDirector2) as 'Apellido Director' from peliculas inner join Directores on directores.idDirector = peliculas.idDirectorf where peliculas.titulo ='" + tbTituloP.Text + "';";
            DataTable tPeliculasTitulo = new DataTable();
            MySqlDataAdapter adapterT = new MySqlDataAdapter(tituloQuery, conexion);
            adapterT.Fill(tPeliculasTitulo);
            dgvPeliculas.DataSource = tPeliculasTitulo;
            conexion.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            MySqlCommand comando1 = new MySqlCommand("SELECT P.titulo, P.fechaEstreno as 'Fecha Estreno', P.sinopsis as Sinopsis, P.duracion as Duracion, P.copiasDisponibles as 'Copias', D.nombreDirector1,D.nombreDirector2, D.apellidoDirector1,  D.apellidoDirector2 FROM Peliculas P, Directores D WHERE D.idDirector = P.idDirectorf  AND concat(D.nombreDirector1,' ',D.apellidoDirector1) LIKE @nombre ", conexion);
            comando1.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = "%" + tbDirectorP.Text + "%";

            MySqlDataAdapter adapterD = new MySqlDataAdapter();
            adapterD.SelectCommand = comando1;
            DataTable tPeliculasDirector = new DataTable();
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
            Application.Run(new MenuClientes( idUser));
        }

        private void SolicitarPrestamo_Load(object sender, EventArgs e)
        {
            
                 
            MySqlCommand cm = new MySqlCommand("Obtaingeneros", conexion);

                cm.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter da = new MySqlDataAdapter(cm);
                DataTable dt = new DataTable();

                //da.Fill(dt);

                comboBoxCategoria.ValueMember = "idGenero";
                comboBoxCategoria.DisplayMember = "tipoGenero";

                comboBoxCategoria.DataSource = dt;


            conexion.Open();
            string allQuery = "SELECT titulo as 'Titulo', fechaEstreno as 'Fecha de Estreno', sinopsis as 'Sinopsis', duracion as 'Duracion', copiasDisponibles as 'Copias' from peliculas;";
            DataTable tPeliculasAll = new DataTable();
            MySqlDataAdapter adapterA = new MySqlDataAdapter(allQuery, conexion);
            adapterA.Fill(tPeliculasAll);
            dgvPeliculas.DataSource = tPeliculasAll;
            conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
            conexion.Open();
            string categoriaQuery = "SELECT titulo as 'Titulo', fechaEstreno as 'Fecha de Estreno', sinopsis as 'Sinopsis', duracion as 'Duracion', copiasDisponibles as 'Copias',  tipoGenero as 'Genero' FROM peliculas left join peliculas_generos on peliculas.idPelicula = peliculas_generos.idPeliculaf3 left join generos on peliculas_generos.idGeneroF = generos.idGenero where generos.tipoGenero = '" + comboBoxCategoria.Text + "';";

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

        private void button6_Click(object sender, EventArgs e)
        {
            int i = dgvPeliculas.CurrentRow.Index;
            DataGridViewRow row = dgvPeliculas.Rows[i];
            string titulo = row.Cells[0].Value.ToString();
            string duracion = row.Cells[3].Value.ToString();
            dgvCarrito.Rows.Add(titulo, duracion);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int i = dgvCarrito.CurrentRow.Index;
            dgvCarrito.Rows.RemoveAt(i);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void tbDirectorP_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalir_MouseLeave(object sender, EventArgs e)
        {
            BtnSalir.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void BtnSalir_MouseMove(object sender, MouseEventArgs e)
        {
            BtnSalir.BackColor = Color.Gray;
        }
    }
    
}
