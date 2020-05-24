using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoBDM.Control
{
    class ControlMulta
    {
        MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");

        public void MostrarMultas(MySqlDataAdapter adaptador, DataGridView dgvM)
        {
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("SELECT idMulta AS idMulta, fechaGeneracionMulta AS FechaGeneracion, fechaPagoMulta AS FechaPago, valorMulta AS ValorMulta, estadoMulta AS EstadoMulta, idPrestamof2 AS CodigoPrestamos, idClientef2 AS CodigoCliente FROM MULTAS ", conexion);
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvM.DataSource = tabla;
            conexion.Close();
        }

        public void InsertarMultas(DateTimePicker dtpfechaGeneracion, DateTimePicker dtpPago, TextBox valorMulta, ComboBox comboBox1, TextBox codigoPrestamo, TextBox codigoCliente)
        {
            conexion.Open();
            string Query = "INSERT INTO MULTAS(fechaGeneracionMulta,fechaPagoMulta,valorMulta,estadoMulta,idPrestamof2 , idClientef2) " +
                "values('" + dtpfechaGeneracion.Text + "','" + dtpPago.Text + "','" + valorMulta.Text + "','" + comboBox1.Text + "','" + codigoPrestamo.Text + "','" + codigoCliente.Text + "');";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void ModificarMultas(DateTimePicker dtpfechaGeneracion, DateTimePicker dtpPago, TextBox valorMulta, ComboBox comboBox1, TextBox codigoPrestamo, TextBox codigoCliente, TextBox idMulta)
        {
            conexion.Open();
            string Query = "UPDATE  Multas SET fechaGeneracionMulta = '" + dtpfechaGeneracion.Text + "', fechaPagoMulta= '" + dtpPago.Text + "', estadoMulta= '" + comboBox1.Text + "', idPrestamof2 = '" + codigoPrestamo.Text + "', idClientef2 = '" + codigoCliente.Text + "' WHERE idMulta = '" + idMulta.Text + "'  ";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarMultas(TextBox idMulta)
        {
            conexion.Open();
            string Query = "DELETE FROM MULTAS WHERE idMulta ='" + idMulta.Text + "'  ";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void buscarCliente(DataGridView dgvC, MySqlDataAdapter adaptador, TextBox buscarC)
        {
            conexion.Open();
            MySqlCommand comando = new MySqlCommand("SELECT P.idClientef, P.idPrestamo FROM prestamos P, Clientes C  Where C.idCliente= P.idClientef and concat(C.nombreCliente1, ' ', C.apellidoCliente1)LIKE @nombre ", conexion);
            comando.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = "%" + buscarC.Text + "%";

            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvC.DataSource = tabla;
            conexion.Close();


        }
    }
}