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

namespace ProyectoBDM
{
    public partial class RelacionGeneroPelicula : Form
    {
        ControlRelacionGeneroPelicula crgp = new ControlRelacionGeneroPelicula();
        MySqlDataAdapter adaptador = new MySqlDataAdapter();
        public RelacionGeneroPelicula()
        {
            InitializeComponent();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                crgp.InsertarRelacionPG(comboBox1, comboBox2);
                MessageBox.Show("Se ha insertado con exito");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al insertar");
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                crgp.ModificarRelacionPG(comboBox1, comboBox2, tbidPeliGen);
                MessageBox.Show("Se ha modificado con exito");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al modificar");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                crgp.EliminarRelacionPG(tbidPeliGen);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void RelacionGeneroPelicula_Load(object sender, EventArgs e)
        {
            crgp.llenarComboboxGenero(comboBox2);
            crgp.llenarComboboxPelicula(comboBox1);
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            crgp.MostrarRelacionPG(dataGridView1, adaptador);
        }
    }
}
