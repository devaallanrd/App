using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public interface IRepositorioEstadisticas
    {
         IList<Modelo.estadistica> findAll();
       
    }
}
