using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Donacion
    {
        public string Tipo { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaPago { get; set; }
        public double ValorDonado { get; set; }

    }
}
