using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class estadistica
    {
        public int ID { get; set; }
        public string temporada { get; set; }
        public string Equipo { get; set; }
        public string Jugador { get; set; }
        public int Partidas { get; set; }
        public int Puntos { get; set; }
        public int Rebotes { get; set; }
        public int PGoldeCampo { get; set; }
        public int PTiroLibre { get; set; }
        public int Asistencias { get; set; }
        public int Robos { get; set; }
        public int Bloqueos { get; set; }
    
    }
}
