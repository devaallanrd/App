using LiveGame.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{

    //En la fabrica tengo la coleccion de mis servicios 
    //Pero necesitan las credenciales de alguien registrado
    //asi que primero vamos a por ellos.

   public class CreadorLiveGame
    {
       // Una instancia para el proveedor de servicios.
        ProveedorServicios servicios;

        public CreadorLiveGame(String name, String pass)
        {
            //Solicitamos crear la instancia con un nombre y contraseña
            servicios   = new ProveedorServicios(name, pass);

        }
    
        public IList<Modelo.jugadores> findAllJugadores( )
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

        public IList<Modelo.equipos> findAllEquipos()
        {
            ServicioEquipos servEqu = servicios.getServicioEquipos();

            if (servEqu != null)
            {
                IList<Modelo.equipos> equipos = servEqu.requestAll();

                if (equipos == null)
                {
                    return null;
                }
                else
                {
                    return equipos;
                }
            }
            else
            {
                return null;
            }

        }


        public IList<Modelo.calendario> findAllPartidas()
        {
            ServicioCalendario servCal = servicios.getServicioCalendario();

            if (servCal != null)
            {
                IList<Modelo.calendario> calendar = servCal.requestAll();

                if (calendar == null)
                {
                    return null;
                }
                else
                {
                    return calendar;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
