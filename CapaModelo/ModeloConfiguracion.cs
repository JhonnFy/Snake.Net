using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class ModeloConfiguracion
    {
        public int IdIdentity { get; set; }
        public int IdConfiguraciones { get; set; }
        public int IdJugador { get; set; }
        public int Ancho { get; set; }
        public int Alto { get; set; }
        public int Velocidad { get; set; }
        public DateTime FechaModificacion { get; set; }

        public ModeloConfiguracion()
        {
            IdIdentity = 0;
            IdConfiguraciones = 0;
            IdJugador = 0;
            Ancho = 800; 
            Alto = 600;  
            Velocidad = 5; 
            FechaModificacion = DateTime.Now;
        }

    }
}
