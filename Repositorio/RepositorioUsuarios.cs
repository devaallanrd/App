using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RepositorioUsuarios : IRepositorioUsuarios
    {
        livegameDataContext livegameDB = new livegameDataContext();

        public IList<Modelo.usuarios> findAll()
        {
            var usuarios = from u in livegameDB.Usuarios //Products = nombre de la tabla de productos
                            select new Modelo.usuarios
                            {
                                nombre_usuario = u.nombre_usuario,
                                ID = (int) u.id,
                                Tipo = u.tipo,
                                Contrasena = u.contraseña,
                                Correo = u.correo,
                                Nombre = u.nombre
                         

                                //Name = p.ProductName,
                                //Price = new Model.Price(p.RPP, p.SellingPrice)
                            };

            return usuarios.ToList();
        }

        public bool validate(string name, string pass)
        {
            bool ret = false;
            IList<Modelo.usuarios> all = findAll();
            foreach (Modelo.usuarios u in all){
                if ((u.nombre_usuario == name)&&(u.Contrasena==pass))
                {
                    return true;
                }
            }
            return ret;
        }
    }
}
