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

      

        
        


        
    }
}
