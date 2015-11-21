using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public interface IRepositorioEquipos
    {
        IList<Modelo.equipos> findAll();

        //Agregar Equipo

        //Remover un Equipo

        //Modificar Equipo
    }
}
