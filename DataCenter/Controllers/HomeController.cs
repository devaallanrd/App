using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataCenter.Controllers
{
    public class HomeController : Controller
    {
        Servicio.CreadorDataCenter datacenter = new Servicio.CreadorDataCenter("jose","4321");
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            
            return View();
        }

        public JsonResult FindAllJugadores()
        {

            IList<Modelo.jugadores> jugadores = datacenter.findAllJugadores();

            return new JsonResult
            {
                Data = jugadores,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };

            //return Json(fabrica.findAll("Jugadores"), JsonRequestBehavior.AllowGet);

        }


    }
}
