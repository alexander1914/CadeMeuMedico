using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadeMeuMedico.Controllers
{
    public class MensagensController : Controller
    {
        public ActionResult Bomdia()
        {
            return Content("Bom dia... hoje você acordou cedo!!!");
        }

        public ActionResult BoaTarde()
        {
            return Content("Boa tarde ... não desista de programar sem luta não estive Sucesso!");
        }
    }
}