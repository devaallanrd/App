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
    public class HomeController : Controller
    {
        // Centralizacion de los servicios 
        // Provee Acceso a todos los servicios del sistema.


        CreadorLiveGame fabrica = new CreadorLiveGame("Allan", "1234");
  
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Registrar()
        {
            ViewBag.Title = "Register Page";
            //Comunicar con BD por User Service
            return View();
        }

        public ActionResult Autenticar()
        {
            ViewBag.Title = "Register Page";
            //Redirect Admin Page or Fan Page 
           
            return View();
        }

        public JsonResult FindAllJugadores()
        {
          
            IList<Modelo.jugadores> jugadores = fabrica.findAllJugadores();

            return new JsonResult
            {
                Data = jugadores,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };

            //return Json(fabrica.findAll("Jugadores"), JsonRequestBehavior.AllowGet);

        }

        public JsonResult FindAllEquipos()
        {
            
            IList<Modelo.equipos> equipos = fabrica.findAllEquipos();

            return new JsonResult
            {
                Data = equipos,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };

            //return Json(fabrica.findAll("Jugadores"), JsonRequestBehavior.AllowGet);

        }

        public JsonResult FindAllPartidos()
        {

            IList<Modelo.calendario> calendar = fabrica.findAllPartidas();

            return new JsonResult
            {
                Data = calendar,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };

            //return Json(fabrica.findAll("Jugadores"), JsonRequestBehavior.AllowGet);

        }


        
    }
}
