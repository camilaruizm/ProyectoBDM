using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDM.Modelo
{
    class Peliculas
    {
        private string titulo;
        private string fechaEstreno;
        private string sinopsis;
        private string duracion;
        private int copiasDisponibles;
        private int idDirectorf;

        public string Titulo { get; set; }
        public string FechaEstreno { get; set; }
        public string Sinopsis { get; set; }
        public string Duracion { get; set; }
        public int CopiasDisponibles { get; set; }
        private int IdDirectorf { get; set; }
    }
}
