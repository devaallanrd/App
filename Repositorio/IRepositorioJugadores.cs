﻿using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public interface IRepositorioJugadores
    {
         IList<Modelo.jugadores> findAll();

        //Jugador Especifico

        //Jugadores por equipo
    }
}
