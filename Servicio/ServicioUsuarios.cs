using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio;

namespace Servicio
{
    public class ServicioUsuarios
    {
        IRepositorioUsuarios Irepo ;

        public ServicioUsuarios(RepositorioUsuarios repo)
        {
            Irepo = repo;
        }

        public ServicioUsuarios()
        {
            // TODO: Complete member initialization
        }

        public IList<Modelo.usuarios> findAll()
        {
            return Irepo.findAll();
        }
    }
}
