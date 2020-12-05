using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiTiendaLeguizamon.Models;

namespace MiTiendaLeguizamon.Controllers
{
    public class HomeController : Controller
    {
        private DBTiendaLeguizamonEntities db = new DBTiendaLeguizamonEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact([Bind(Include = "Id,Nombre,Apellido,Email,Sujeto,Mensaje")] Contacto contacto)
        {
            if (ModelState.IsValid)
            {
                db.Contactoes.Add(contacto);
                db.SaveChanges();
                return RedirectToAction("Contact");
            }

            return View();
        }
    }
}