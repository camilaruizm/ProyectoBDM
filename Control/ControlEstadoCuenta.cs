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

namespace ProyectoBDM.Control
{
    class ControlEstadoCuenta
    {
     
        MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
        string idUsuario = "a";
        public void showPeliculaCli(MySqlDataAdapter adaptador, DataGridView dgvP, string idUsuario)
        {
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("Select idPrestamo, titulo, fechaHoraFP as 'Fecha Final' FROM prestamos P, peliculas PL, clientes C, facturas_prestamos FP where C.idCliente = '" + idUsuario + "' and P.idClientef= '" + idUsuario + "'  and FP.idPeliculaf = PL.idPelicula and FP.idPrestamof = P.idPrestamo AND P.estadoPrestamo IS NULL;", conexion);
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvP.DataSource = tabla;
            conexion.Close();
        }

        public void showMultaCli(MySqlDataAdapter adaptador, DataGridView dgvM, string idUsuario)
        {
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("SELECT fechaGeneracionMulta, valorMulta, estadoMulta, titulo  FROM  multas M, facturas_prestamos FP, peliculas PL, prestamos P ,  clientes C WHERE M.estadoMulta = 'Activo' AND C.idCliente = M.idClientef2 AND C.idCliente = P.idClientef AND M.idPrestamof2 = P.idPrestamo AND P.idPrestamo = FP.idPrestamof AND PL.idPelicula = FP.idPeliculaf AND C.idCliente= '" + idUsuario + "'; ", conexion);
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvM.DataSource = tabla;
            conexion.Close();
        }
    }
}
