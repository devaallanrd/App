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
    public class JugadoresController : ControladorGeneral
    {


        public JsonResult FindAllJugadores()
        {

            IList<Modelo.jugadores> jugadores = creador.findAllJugadores();

            return new JsonResult
            {
                Data = jugadores,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };

            //return Json(fabrica.findAll("Jugadores"), JsonRequestBehavior.AllowGet);

        }
    }
}