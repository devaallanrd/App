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
    public class AdminController : ControladorGeneral
    {
        // Centralizacion de los servicios 
        // Provee Acceso a todos los servicios del sistema.


        
  
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

   
      

        
        


        
    }
}
