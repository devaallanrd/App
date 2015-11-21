using LiveGame.Providers;
using Repositorio;
using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LiveGame.Controllers
{
    public class ControladorGeneral :Controller
    {
       public static CreadorLiveGame creador = new CreadorLiveGame("jose", "4321");
    }
}