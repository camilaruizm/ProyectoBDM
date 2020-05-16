using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoBDM.Control
{
    class ControlPeliculasAdmi
    {
        MySqlConnection conexion = new MySqlConnection("server = localhost; Database = proyectobdm; user = root; password = root;");

        public void llenarComboBox(ComboBox combo)
        {
            MySqlCommand cm = new MySqlCommand("Obtaingeneros", conexion);
            
            cm.CommandType = CommandType.StoredProcedure;

            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();

            da.Fill(dt);

            combo.ValueMember = "idGenero";
            combo.DisplayMember = "tipoGenero";

            combo.DataSource = dt;
        }

        public void llenarComboBoxDirectores(ComboBox combo)
        {
            MySqlCommand cm = new MySqlCommand("ObtainDirectores", conexion);

            cm.CommandType = CommandType.StoredProcedure;

            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();

            da.Fill(dt);

            combo.ValueMember = "idDirector";
            combo.DisplayMember = "apellidoDirector1";

            combo.DataSource = dt;
        }
    }
}
