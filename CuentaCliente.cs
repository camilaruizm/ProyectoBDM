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
    public partial class CuentaCliente : Form
    {
        public CuentaCliente()
        {
            InitializeComponent();
        }

        private void btHistorial_Click(object sender, EventArgs e)
        {

<<<<<<< HEAD
=======
            MySqlCommand comando = new MySqlCommand("SELECT P.idPrestamo,PL.titulo, D.apellidoDirector1,PL.duracion,P.fechaHoraFP FROM facturas_prestamos FP, clientes C, prestamos P, peliculas PL, Directores D WHERE   C.idCliente = P.idClientef and FP.idPrestamof = P.idPrestamo and FP.idPeliculaf = PL.idPelicula; ", conexion);

            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
>>>>>>> parent of 4fb0773... FUNCIONAMIENTO PRESTAMOS ACTIVOS CLIENTE
        }
    }
}
