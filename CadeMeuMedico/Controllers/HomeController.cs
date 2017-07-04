using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadeMeuMedico.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Home
        public ActionResult Login()
        {
            ViewBag.Title = "Seja Bem - Vindo(a)";
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}