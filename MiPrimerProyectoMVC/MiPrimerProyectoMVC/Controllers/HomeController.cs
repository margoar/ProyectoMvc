using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiPrimerProyectoMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
          //  ViewBag.Alumnos = Alumno.Listar();
            return View(Alumno.Listar());
        }
        public ActionResult Ver(int id =0) {
            ViewBag.id = id;
            return View();
        }

    }
}