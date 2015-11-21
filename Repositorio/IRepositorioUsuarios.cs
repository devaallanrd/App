using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public interface IRepositorioUsuarios
    {
        IList<Modelo.usuarios> findAll();

        bool validate(string name, string pass);

        //Buscar fanaticos

        //Editar fanatico

        //Eliminar Fanatico
    }
}
