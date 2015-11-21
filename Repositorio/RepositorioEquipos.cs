using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RepositorioEquipos : IRepositorioEquipos
    {
        livegameDataContext livegameDB = new livegameDataContext();

        public IList<Modelo.equipos> findAll()
        {

            try
            {
                var equipos = from p in livegameDB.Equipos //Products = nombre de la tabla de productos
                              select new Modelo.equipos
                                         {
                                             HT = p.ht,
                                             nombre = p.nombre,
                                             twitter = p.twitter,
                                             followers = (int) p.followers,
                                             conferencia = p.conferencia,
                                             estadio = p.estadio,
                                             entrenador = p.entrenador,
                                             ubicacion = p.ubicacion,
                                             fundacion  = (int) p.fundacion,
                                             activo = p.activo

                                             //Name = p.ProductName,
                                             //Price = new Model.Price(p.RPP, p.SellingPrice)
                                         };
                return equipos.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
