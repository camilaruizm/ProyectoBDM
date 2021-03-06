﻿using System;
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
    class ControlHistorialCliente
    {
        MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");

        public void showHistMult(MySqlDataAdapter adaptador, DataGridView dgvH, string idUsuario)
        {
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("SELECT fechaGeneracionMulta, valorMulta, estadoMulta, titulo  FROM  multas M, facturas_prestamos FP,peliculas PL, prestamos P, clientes C WHERE M.estadoMulta = 'Inactivo' AND C.idCliente = M.idClientef2 AND C.idCliente = P.idClientef AND M.idPrestamof2 = P.idPrestamo AND P.idPrestamo = FP.idPrestamof AND PL.idPelicula = FP.idPeliculaf  AND C.idCliente = '" + idUsuario + "'; ", conexion);
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvH.DataSource = tabla;
            conexion.Close();
        }

        public void showHistPel(MySqlDataAdapter adaptador, DataGridView dataGridView1, string idUsuario)
        {
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("SELECT C.nombreCliente1, C.apellidoCliente1, P.titulo, P.duracion FROM  Peliculas P, Clientes C, facturas_prestamos FP, prestamos Pr  WHERE P.idPelicula = FP.idPeliculaf and Pr.idPrestamo = FP.idPrestamof and C.idCliente = Pr.idClientef and C.idCliente = '" + idUsuario + "'; ", conexion);
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexion.Close();
        }
    }
}
