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
    public class EquiposController : ControladorGeneral
    {
        

        public JsonResult FindAllEquipos()
        {

            IList<Modelo.equipos> equipos = creador.findAllEquipos();

            return new JsonResult
            {
                Data = equipos,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };

            //return Json(fabrica.findAll("Jugadores"), JsonRequestBehavior.AllowGet);

        }
    }
}