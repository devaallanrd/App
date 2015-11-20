using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class jugadores
    {
       // id , nombre , dorsal , equipo, pos , edad,salario , twitter , tfollows , activo 
        public jugadores()
        {

        }

        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Dorsal { get; set; }
        public string Equipo { get; set; }
        public string Pos { get; set; }
        public int Edad { get; set; }
        public double Salario { get; set; }
        public string Twitter { get; set; }
        public string TFollows { get; set; }
        public string Activo { get; set; }

    }
}
