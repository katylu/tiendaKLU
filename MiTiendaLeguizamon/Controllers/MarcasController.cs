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
    public class MarcasController : Controller
    {
        private DBTiendaLeguizamonEntities db = new DBTiendaLeguizamonEntities();

        // GET: Marcas
        public ActionResult Index()
        {
            return View(db.Marcas.ToList());
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
