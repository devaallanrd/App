using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio;

namespace Servicio
{
    public class ServicioCalendario
    {

        IRepositorioCalendario Irepo ;

        public ServicioCalendario(RepositorioCalendario repo)
        {
            Irepo = repo;
        }

        public ServicioCalendario()
        {
            // TODO: Complete member initialization
        }

        public IList<Modelo.calendario> findAll()
        {
            return Irepo.findAll();
        }
    }
}
