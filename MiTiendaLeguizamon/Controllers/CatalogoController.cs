using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MiTiendaLeguizamon.Models;

namespace MiTiendaLeguizamon.Controllers
{
    public class CatalogoController : Controller
    {
        private DBTiendaLeguizamonEntities db = new DBTiendaLeguizamonEntities();

        // GET: Productos
        public ActionResult Hombres()
        {
            return View();
        }


        public ActionResult Mujeres()
        {
            return View();
        }

        public ActionResult Kids()
        {
            return View();
        }

        public ActionResult Carteras()
        {
            return View();
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
