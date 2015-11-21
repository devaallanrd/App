using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Servicio;

namespace LiveGame.Providers
{

    
    public class ProveedorServicios
    {
        //Estos servicios primero son indexados por los controladores para
        //saber si se pueden utilizar.
        private ServicioJugadores servicioJugadores;
        private ServicioEquipos servicioEquipos;
        private ServicioUsuarios  servicioUsuarios;
        private ServicioCalendario servicioCalendario;
        private ServicioEstadisticas servicioEstadisticas;


        //Contiene los repositorios que vamos a utilizar.
        private ProveedorRepositorios repositorios;

        //Validar si el cliente puede utilizar un servicio.
        private bool clientValidated;


        public ProveedorServicios(String nombre, String pass)
        {
            this.clientValidated = true;
            repositorios = new ProveedorRepositorios();


            servicioUsuarios = new ServicioUsuarios(repositorios.repoUsuarios);
            servicioEquipos = new ServicioEquipos(repositorios.repoEquipos);        
            servicioJugadores = new ServicioJugadores(repositorios.repoJugadores);
            servicioCalendario = new ServicioCalendario(repositorios.repoCalendario);
            servicioEstadisticas = new ServicioEstadisticas(repositorios.repoEstadisticas);
      
        }


        public ServicioJugadores getServicioJugadores()
        {
            if (clientValidated == true)
            {
                return this.servicioJugadores;
            }
            else
            {
                return null;
            }
        }

        public ServicioEquipos getServicioEquipos()
        {
            if (clientValidated == true)
            {
                return this.servicioEquipos;
            }
            else
            {
                return null;
            }
        }

        public ServicioCalendario getServicioCalendario()
        {
            if (clientValidated == true)
            {
                return this.servicioCalendario;
            }
            else
            {
                return null;
            }
        }


      


    }
}