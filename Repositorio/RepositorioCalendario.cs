using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RepositorioCalendario : IRepositorioCalendario
    {
        livegameDataContext livegameDB = new livegameDataContext();

        public IList<Modelo.calendario> findAll()
        {

            try
            {
                var partidas = from p in livegameDB.Calendarios //Products = nombre de la tabla de productos
                               select new Modelo.calendario
                                          {
                                             ID = p.id ,
                                             Temporada = p.temporada,

                                          };
                return partidas.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
