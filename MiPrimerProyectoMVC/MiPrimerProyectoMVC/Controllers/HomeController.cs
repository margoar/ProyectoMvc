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
        private Alumno alumno = new Alumno();
        public ActionResult Index()
        {
            
            return View(alumno.Listar());
        }
        public ActionResult Ver(int id) {
            return View(alumno.Obtener(id));
        }


        public ActionResult Crud(int id = 0)
        {
            return View(
                id==0 ? new Alumno() : alumno.Obtener(id)
                );
        }
        public ActionResult Guardar(Alumno model)
        {
            model.Guardar();
            return Redirect("~/home");
        }
        public ActionResult Eliminar(int id)
        {
            alumno.id = id;
            alumno.Eliminar();
            return Redirect("~/home");
        }
    }
}