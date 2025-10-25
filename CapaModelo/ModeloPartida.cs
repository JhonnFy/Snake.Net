using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class ModeloPartida
    {
        public int IdIdentity  {get; set; }
        public int IdPartidas { get; set; }
        public int IdJugador { get; set; }
        public int Puntaje { get; set; }
        public int DuracionSegundos { get; set; }
        public DateTime Fecha { get; set; }

        public ModeloPartida()
        {
            IdIdentity = 0;
            IdPartidas = 0;
            IdJugador = 0;
            Puntaje = 0;
            DuracionSegundos = 0;
            Fecha = DateTime.MinValue;
        }   

    }
}
