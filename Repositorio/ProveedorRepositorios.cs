using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiveGame.Providers
{
    public class ProveedorRepositorios
    {

        public RepositorioJugadores repoJugadores { get; set; }
        public RepositorioEquipos repoEquipos { get; set; }
        public RepositorioUsuarios repoUsuarios { get; set; }
        public RepositorioCalendario repoCalendario { get; set; }
        public RepositorioEstadisticas repoEstadisticas { get; set; }
    

        public ProveedorRepositorios()
        {
            repoJugadores = new RepositorioJugadores();

            repoUsuarios = new RepositorioUsuarios();

            repoCalendario = new RepositorioCalendario();

            repoEquipos = new RepositorioEquipos();

            repoEstadisticas = new RepositorioEstadisticas();

        }
    }
}