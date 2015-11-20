using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataCenter.Controllers
{
    public class HomeController : Controller
    {
        Servicio.FabricaDataCenter fabrica ;
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
