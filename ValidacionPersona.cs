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

namespace ProyectoBDM
{
    public partial class ValidacionPersona : Form
    {
        Thread th;
        public ValidacionPersona()
        {
            InitializeComponent();
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void opennewform()
        {
            Application.Run(new InicioSesionCliente());
        }

        private void BtnAdministrador_Click(object sender, EventArgs e)
        {

        }

        private void BtnCliente_MouseMove(object sender, MouseEventArgs e)
        {
            BtnCliente.BackColor = Color.Silver;
        }

        private void BtnCliente_MouseLeave(object sender, EventArgs e)
        {
            BtnCliente.BackColor = Color.Lavender;
        }

        private void BtnAdministrador_MouseMove(object sender, MouseEventArgs e)
        {
            BtnAdministrador.BackColor = Color.Silver;
        }

        private void BtnAdministrador_MouseLeave(object sender, EventArgs e)
        {
            BtnAdministrador.BackColor = Color.Lavender;
        }
    }
}
