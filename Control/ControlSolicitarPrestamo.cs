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

namespace ProyectoBDM.Control
{
    class ControlSolicitarPrestamo
    {
        MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");


        public void button3(DataGridView dgvPeliculas, ComboBox comboBoxCategoria)
        {
            conexion.Open();
            string categoriaQuery = "SELECT titulo as 'Titulo', fechaEstreno as 'Fecha de Estreno', duracion as 'Duracion', copiasDisponibles as 'Copias',  tipoGenero as 'Genero', sinopsis as 'Sinopsis' FROM peliculas left join peliculas_generos on peliculas.idPelicula = peliculas_generos.idPeliculaf3 left join generos on peliculas_generos.idGeneroF = generos.idGenero where generos.tipoGenero = '" + comboBoxCategoria.Text + "';";
            /*el adaptador se usa cuando se necesita visualizar la información de la bd en la aplicación*/

            DataTable tPeliculasCategoria = new DataTable();
            MySqlDataAdapter adapterC = new MySqlDataAdapter(categoriaQuery, conexion);
            adapterC.Fill(tPeliculasCategoria);
            dgvPeliculas.DataSource = tPeliculasCategoria;
            conexion.Close();
        }

        public void button6(DataGridView dgvPeliculas, DataGridView dgvCarrito, TextBox tbCantidadP, TextBox tbTotal)
        {
            int i = dgvPeliculas.CurrentRow.Index;
            DataGridViewRow row = dgvPeliculas.Rows[i];
            string titulo = row.Cells[0].Value.ToString();
            string duracion = row.Cells[2].Value.ToString();
            dgvCarrito.Rows.Add(titulo, duracion);


            int counter = dgvCarrito.Rows.Count;
            tbCantidadP.Text = counter.ToString();

            int total = counter * 20000;
            tbTotal.Text = total.ToString();
        }

        public void button7(DataGridView dgvCarrito, TextBox tbCantidadP, TextBox tbTotal)
        {
            int i = dgvCarrito.CurrentRow.Index;
            dgvCarrito.Rows.RemoveAt(i);

            int counter = dgvCarrito.Rows.Count;
            tbCantidadP.Text = counter.ToString();

            int total = counter * 20000;
            tbTotal.Text = total.ToString();
        }

        public void button5(DataGridView dgvPeliculas, DataGridView dgvCarrito, TextBox tbCantidadP, TextBox tbTotal, TextBox tbTituloP)
        {
            conexion.Open();
            string tituloQuery = "SELECT titulo as 'Titulo', fechaEstreno as 'Fecha de Estreno', duracion as 'Duracion', copiasDisponibles as 'Copias', CONCAT (nombreDirector1 , ' ' ,  nombreDirector2, ' ', apellidoDirector1 , ' ' , apellidoDirector2) as 'Director', sinopsis as 'Sinopsis' from peliculas inner join Directores on directores.idDirector = peliculas.idDirectorf where peliculas.titulo ='" + tbTituloP.Text + "';";
            DataTable tPeliculasTitulo = new DataTable();
            MySqlDataAdapter adapterT = new MySqlDataAdapter(tituloQuery, conexion);
            adapterT.Fill(tPeliculasTitulo);
            dgvPeliculas.DataSource = tPeliculasTitulo;
            conexion.Close();
        }

        public void button4(DataGridView dgvPeliculas, TextBox tbDirectorP, TextBox tbCantidadP, TextBox tbTotal)
        {
            MySqlCommand comando1 = new MySqlCommand("SELECT P.titulo, P.fechaEstreno as 'Fecha Estreno', P.duracion as Duracion, P.copiasDisponibles as 'Copias', CONCAT (nombreDirector1 , ' ' , nombreDirector2, ' ', apellidoDirector1 , ' ' , apellidoDirector2) as 'Director', sinopsis as 'Sinopsis' FROM Peliculas P, Directores D WHERE D.idDirector = P.idDirectorf  AND concat(D.nombreDirector1,' ',D.apellidoDirector1) LIKE @nombre ", conexion);
            conexion.Close();
            comando1.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = "%" + tbDirectorP.Text + "%";
            MySqlDataAdapter adapterD = new MySqlDataAdapter();
            adapterD.SelectCommand = comando1;
            DataTable tPeliculasDirector = new DataTable();
            adapterD.Fill(tPeliculasDirector);
            dgvPeliculas.DataSource = tPeliculasDirector;
            conexion.Close();
        }

        public void btPrestamo(DataGridView dgvPeliculas, DataGridView dgvID_P, DataGridView dgvCarrito, DataGridView dgvP_ID, TextBox tbDirectorP, TextBox tbCantidadP, TextBox tbTotal, DateTimePicker dateTimePicker1, DateTimePicker dateTimePicker2, string idUsersp)
        {
            conexion.Open();
            string PQuery = "INSERT INTO prestamos(fechaHoraIP, fechaHoraFP, peliculasSolicitadas, valorTotalP, idClientef) values ('" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + tbCantidadP.Text + "','" + tbTotal.Text + "','" + idUsersp + "');";
            MySqlCommand comandoP = new MySqlCommand(PQuery, conexion);
            comandoP.ExecuteNonQuery();
            conexion.Close();

            conexion.Open();
            string idPrQuery = "SELECT * from prestamos;";
            DataTable tPrestamoID = new DataTable();
            MySqlDataAdapter adapterP = new MySqlDataAdapter(idPrQuery, conexion);
            adapterP.Fill(tPrestamoID);
            dgvID_P.DataSource = tPrestamoID;
            conexion.Close();

            int CounterPr = (dgvID_P.Rows.Count) - 1;
            string idPr = dgvID_P.Rows[CounterPr].Cells[0].Value.ToString();

            foreach (DataGridViewRow item in dgvCarrito.Rows)
            {
                conexion.Open();
                string idPQuery = "SELECT idPelicula from peliculas where titulo ='" + item.Cells[0].Value.ToString() + "';";
                DataTable tPeliculasID = new DataTable();
                MySqlDataAdapter adapterT = new MySqlDataAdapter(idPQuery, conexion);
                adapterT.Fill(tPeliculasID);
                dgvP_ID.DataSource = tPeliculasID;
                conexion.Close();

                string idP = dgvP_ID.Rows[0].Cells[0].Value.ToString();

                conexion.Open();
                string FPQuery = "INSERT INTO facturas_prestamos(fechaHoraFM, valorFacturaM, idPrestamof, idPeliculaf) values ('" + dateTimePicker1.Text + "', 20000,'" + idPr + "','" + idP + "');";
                MySqlCommand comando = new MySqlCommand(FPQuery, conexion);
                comando.ExecuteNonQuery();
                conexion.Close();

                MessageBox.Show("¡Prestamo solicitado con éxito!");
                ReniciarPrestamo(dgvPeliculas, dgvCarrito, tbCantidadP, tbTotal);
            }
        }
        public void ReniciarPrestamo(DataGridView dgvPeliculas, DataGridView dgvCarrito, TextBox tbCantidadP, TextBox tbTotal)
        {
            conexion.Open();
            string allQuery = "SELECT titulo as 'Titulo', fechaEstreno as 'Fecha de Estreno', duracion as 'Duracion', copiasDisponibles as 'Copias', sinopsis as 'Sinopsis' from peliculas;";
            DataTable tPeliculasAll = new DataTable();
            MySqlDataAdapter adapterA = new MySqlDataAdapter(allQuery, conexion);
            adapterA.Fill(tPeliculasAll);
            dgvPeliculas.DataSource = tPeliculasAll;
            conexion.Close();

            foreach (DataGridViewRow item in dgvCarrito.Rows)
            {
                dgvCarrito.Rows.RemoveAt(0);
            }

            tbCantidadP.Clear();
            tbTotal.Clear();
        }
    }
}
