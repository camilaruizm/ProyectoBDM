using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDM.Modelo
{
    class Prestamos
    {
        private string fechaHoraIP;
        private string fechaHoraFP;
        private int peliculasSolicitadas;
        private string valorTotalP;
        private int idClientef;

        public string FechaHoraIP { get; set; }
        public string FechaHoraFP { get; set; }
        public int PeliculasSolicitadas { get; set; }
        public string ValorTotalP { get; set; }
        public int IdClientef { get; set; }
    }
}
