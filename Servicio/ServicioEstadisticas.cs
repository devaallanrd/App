using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio;

namespace Servicio
{
    public class ServicioEstadisticas
    {
        IRepositorioEstadisticas Irepo ;

        public ServicioEstadisticas(RepositorioEstadisticas repo)
        {
            Irepo = repo;
        }

        public ServicioEstadisticas()
        {
            // TODO: Complete member initialization
        }

        public IList<Modelo.estadistica> findAll()
        {
            return Irepo.findAll();
        }


    }
}
