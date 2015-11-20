using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio;

namespace Servicio
{
    public class ServicioEquipos
    {
         IRepositorioEquipos Irepo ;

        public ServicioEquipos(RepositorioEquipos repo)
        {
            Irepo = repo;
        }

        public ServicioEquipos()
        {
            // TODO: Complete member initialization
        }

        public IList<Modelo.equipos> requestAll()
        {
            return Irepo.findAll();
        }
    }
}
