using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDM.Modelo
{
    class Facturas_Prestamos
    {
        private DateTime fechaHoraFM;
        private double valorFacturaM;
        private int idPrestamof;
        private int idPeliculaf;

        public DateTime FechaHoraFM { get; set; }
        public double ValorFacturaM { get; set; }
        public int IdPrestamof { get; set; }
        public int IdPeliculaf { get; set; }
    }
}
