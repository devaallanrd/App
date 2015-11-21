using LiveGame.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class CreadorDataCenter
    {

        // Una instancia para el proveedor de servicios.
        ProveedorServicios servicios;

        public CreadorDataCenter(String name, String pass)
        {
            //Solicitamos crear la instancia con un nombre y contraseña
            servicios   = new ProveedorServicios(name, pass);

        }

        public IList<Modelo.jugadores> findAllJugadores()
        {
            ServicioJugadores servJug = servicios.getServicioJugadores();



            if (servJug != null)
            {
                IList<Modelo.jugadores> jugadores = servJug.requestAll();

                if (jugadores == null)
                {
                    return null;
                }
                else
                {
                    return jugadores;
                }
            }
            else
            {
                return null;
            }

        }


    }
}
