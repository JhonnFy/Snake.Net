using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class ModeloJugador
    {
        public int IdIdentity { get; set; }
        public int IdJugador { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaRegistro { get; set;  }

        public ModeloJugador()
        {
            IdIdentity = 0;
            IdJugador = 0;
            Nombre = string.Empty;
            FechaRegistro = DateTime.MinValue;
        }

    }
}
