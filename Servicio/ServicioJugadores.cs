using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio;
using Modelo;

namespace Servicio
{
    public class ServicioJugadores
    {
        IRepositorioJugadores Irepo ;

        public ServicioJugadores(RepositorioJugadores repo)
        {
            Irepo = repo;
        }

        public ServicioJugadores()
        {
            // TODO: Complete member initialization
        }

        public IList<Modelo.jugadores> requestAll()
        {
            return Irepo.findAll();
        }



    }
}
