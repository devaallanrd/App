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
    public class CalendarioController : ControladorGeneral
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Calendar Page";

            return View();
        }
        // Centralizacion de los servicios 
        // Provee Acceso a todos los servicios del sistema.

        public JsonResult FindAllPartidos()
        {

            IList<Modelo.calendario> calendar = creador.findAllPartidas();

            return new JsonResult
            {
                Data = calendar,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };

            //return Json(fabrica.findAll("Jugadores"), JsonRequestBehavior.AllowGet);

        }


    }
}
