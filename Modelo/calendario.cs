using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class calendario
    {
        public int ID { get; set; }
        public string Temporada { get; set; }
        public DateTime Fecha { get; set; }
        public string Local { get; set; }
        public string Visita { get; set; }
        public int pts_local { get; set; }
        public int pts_visita { get; set; }
        public string W { get; set; }
        public string L { get; set; }
        public string finalizado { get; set; }
    }
}
