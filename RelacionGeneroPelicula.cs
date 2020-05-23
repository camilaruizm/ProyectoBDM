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
        public RelacionGeneroPelicula()
        {
            InitializeComponent();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                crgp.InsertarRelacionPG(tbidPelicula, tbidGenero);
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
                crgp.ModificarRelacionPG(tbidPelicula, tbidGenero, tbidPeliGen);
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
    }
}
