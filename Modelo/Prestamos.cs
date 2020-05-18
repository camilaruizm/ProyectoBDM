using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDM.Modelo
{
    class Prestamos
    {
        private DateTime fechaHoraIP;
        private DateTime fechaHoraFP;
        private int peliculasSolicitadas;
        private string valorTotalP;
        private int idClientef;

        public DateTime FechaHoraIP { get; set; }
        public DateTime FechaHoraFP { get; set; }
        public int PeliculasSolicitadas { get; set; }
        public string ValorTotalP { get; set; }
        public int IdClientef { get; set; }
    }
}
