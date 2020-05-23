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

namespace ProyectoBDM
{
    public partial class Multa : Form
    {
        int selectedRow;
        MySqlDataAdapter adaptador = new MySqlDataAdapter();
        ControlMulta cm = new ControlMulta();
        public Multa()
        {
            InitializeComponent();
        }

        private void showMultas_Click(object sender, EventArgs e)
        {
            try
            {
                cm.MostrarMultas(adaptador, dgvM);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            //MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");

            //conexion.Open();
            //MySqlCommand comando = new MySqlCommand("SELECT idMulta AS idMulta, fechaGeneracionMulta AS FechaGeneracion, fechaPagoMulta AS FechaPago, valorMulta AS ValorMulta, estadoMulta AS EstadoMulta, idPrestamof2 AS CodigoPrestamos, idClientef2 AS CodigoCliente FROM MULTAS ", conexion);
            //adaptador.SelectCommand = comando;
            //DataTable tabla = new DataTable();
            //adaptador.Fill(tabla);
            //dgvM.DataSource = tabla;
            //conexion.Close();
        }

        private void dgvM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dgvM.Rows[selectedRow];

            idMulta.Text = row.Cells[0].Value.ToString();
            dtpfechaGeneracion.Text = row.Cells[1].Value.ToString();
            dtpPago.Text = row.Cells[2].Value.ToString();
            valorMulta.Text = row.Cells[3].Value.ToString();
            comboBox1.Text = row.Cells[4].Value.ToString();
            codigoPrestamo.Text = row.Cells[5].Value.ToString();
            codigoCliente.Text = row.Cells[6].Value.ToString();
            
        }

        private void insertarMulta_Click(object sender, EventArgs e)
        {
            try
            {
                cm.InsertarMultas(dtpfechaGeneracion, dtpPago, valorMulta, comboBox1, codigoPrestamo, codigoCliente);
                MessageBox.Show("Multa insertada con exito");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al insertar");
            }
           //  MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");

           // conexion.Open();
           //string Query = "INSERT INTO MULTAS(fechaGeneracionMulta,fechaPagoMulta,valorMulta,estadoMulta,idPrestamof2 , idClientef2) " +
           //    "values('" + dtpfechaGeneracion.Text + "','" + dtpPago.Text + "','" + valorMulta.Text + "','" + comboBox1.Text + "','" + codigoPrestamo.Text + "','" + codigoCliente.Text + "');";
           // MySqlCommand comando = new MySqlCommand(Query, conexion);
           //comando.ExecuteNonQuery();
           //conexion.Close();
           //MessageBox.Show("!Se ha registrado la multa con exito¡");
        }

        private void modificarMulta_Click(object sender, EventArgs e)
        {
            try
            {
                cm.ModificarMultas(dtpfechaGeneracion, dtpPago, valorMulta, comboBox1, codigoPrestamo, codigoCliente, idMulta);
                MessageBox.Show("Modificado con exito");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al modificar");
            }
            //MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");

            //conexion.Open();
            //string Query = "UPDATE  Multas SET fechaGeneracionMulta = '" + dtpfechaGeneracion.Text + "', fechaPagoMulta= '" + dtpPago.Text + "', estadoMulta= '" + comboBox1.Text + "', idPrestamof2 = '" + codigoPrestamo.Text + "', idClientef2 = '" + codigoCliente.Text  + "' WHERE idMulta = '" + idMulta.Text + "'  ";
            //MySqlCommand comando = new MySqlCommand(Query, conexion);
            //comando.ExecuteNonQuery();
            //conexion.Close();
            //MessageBox.Show("!Se ha modificado la multa con exito¡");
            //conexion.Close();
        }

        private void eliminarMulta_Click(object sender, EventArgs e)
        {
            try
            {
                cm.EliminarMultas(idMulta);
                MessageBox.Show("Eliminado con exito");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar"); 
            }
            //MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");
            //conexion.Open();
            //string Query = "DELETE FROM MULTAS WHERE idMulta ='" + idMulta.Text + "'  ";
            //MySqlCommand comando = new MySqlCommand(Query, conexion);
            //comando.ExecuteNonQuery();
            //conexion.Close();
            //MessageBox.Show("!Se ha eliminado la multa con exito¡"); 
        }
    }
}
