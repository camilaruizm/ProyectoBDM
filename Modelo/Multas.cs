using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDM.Modelo
{
    class Multas
    {
        private string fechaGeneracionMulta;
        private string fechaPagoMulta;
        private double valorMulta;
        private bool estadoMulta;
        private int idPrestamof2;
        private int idClientef2;

        //public Date FechaGeneracionMulta { get; set; }
        //public Date FechaPagoMulta { get; set; }
        public double ValorMulta { get; set; }
        public double EstadoMulta { get; set; }
        public int IdPrestamof2 { get; set; }
        public int IdClientef2 { get; set; }
    }
}
