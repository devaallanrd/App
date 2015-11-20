using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RepositorioEstadisticas : IRepositorioEstadisticas
    {
        livegameDataContext livegameDB = new livegameDataContext();

        public IList<Modelo.estadistica> findAll()
        {

            try
            {
                var estadisticas = from p in livegameDB.Estadisticas //Products = nombre de la tabla de productos
                                   select new Modelo.estadistica
                                              {


                                                  //Name = p.ProductName,
                                                  //Price = new Model.Price(p.RPP, p.SellingPrice)
                                              };
                return estadisticas.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}