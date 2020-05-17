using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDM.Modelo
{
    public class Cliente
    {
        private string nombre1;
        private string nombre2;
        private string apellido1;
        private string apellido2;
        private string telefono1;
        private string telefono2;
        private string direccionCliente;
        private string nombreUsuario;
        private string contrasena;

        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string DireccionCliente { get; set; }
        public string UserCli { get; set; }
        public string PassCli { get; set; }


    }
}
