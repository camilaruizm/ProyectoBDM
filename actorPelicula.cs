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
using ProyectoBDM.Control;
using MySql.Data.MySqlClient;

namespace ProyectoBDM
{
    public partial class actorPelicula : Form
    {
        Thread th;
        ControlActorPelicula cap = new ControlActorPelicula();
        MySqlDataAdapter adaptador = new MySqlDataAdapter();
        public actorPelicula()
        {
            InitializeComponent();
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
            Application.Run(new MenuAdmin());
        }

        private void insertarAP_Click(object sender, EventArgs e)
        {
            try
            {
                cap.InsertarParticipacion(comboBox1, comboBox2);
                MessageBox.Show("Insertado con exito");
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error al insertar");
            }
            
        }

        private void actorPelicula_Load(object sender, EventArgs e)
        {
            cap.llenarComboboxActores(comboBox2);
            cap.llenarComboboxPeliculas(comboBox1);
        }

        private void modificarAP_Click(object sender, EventArgs e)
        {
            try
            {
                cap.ModificarParticipacion(comboBox1, comboBox2, idParticipacion);
                MessageBox.Show("Modificado con exito");
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error al modificar");
            }
        }

        private void eliminarAP_Click(object sender, EventArgs e)
        {
            try
            {
                cap.EliminarParticipacion(idParticipacion);
                MessageBox.Show("Eliminado con exito");
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error al eliminar");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cap.MostrarParticipacion(dataGridView1, adaptador);
        }
    }
}
