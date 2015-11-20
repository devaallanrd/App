using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RepositorioJugadores: IRepositorioJugadores
    {
        livegameDataContext livegameDB = new livegameDataContext();

        public IList<Modelo.jugadores> findAll()
        {

          try{
                var jugadores = from p in  livegameDB.Jugadores //Products = nombre de la tabla de productos
                select new Modelo.jugadores
                           {
                               ID = (int)p.id,
                               Nombre = p.nombre,
                               Dorsal = (int)p.dorsal,
                               Equipo = p.equipo,
                               Pos = p.pos,
                               Edad = (int)p.edad,
                               Salario = (double)p.salario,
                               Twitter = p.twitter,
                               //TFollows = (int) p.tfollows,
                               Activo = p.activo

                               //Name = p.ProductName,
                               //Price = new Model.Price(p.RPP, p.SellingPrice)
                           };
                return jugadores.ToList();
                        }
            catch(Exception e){
                return null;
            }
                             
            
           
        }
    }
}
