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
            
            return View(Alumno.Listar());
        }
        public ActionResult Ver(int id) {
            return View(Alumno.Obtener(id));
        }


        public ActionResult Crud(int id = 0)
        {
            return View(
                id==0 ? new Alumno() :Alumno.Obtener(id)
                );
        }
        public ActionResult Guardar(Alumno model)
        {
            model.Guardar();
            return Redirect("~/home");
        }
        public ActionResult Eliminar()
        {
            return Redirect("~/home");
        }
    }
}