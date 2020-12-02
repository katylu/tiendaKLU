using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using MiTiendaLeguizamon.Models;

namespace MiTiendaLeguizamon.Controllers
{
    public class TipoMaterialController : ApiController
    {
        private DBTiendaLeguizamonEntities db = new DBTiendaLeguizamonEntities();

        // GET: api/TipoMaterial
        public IQueryable<Tipo_Material> GetTipo_Material()
        {
            return db.Tipo_Material;
        }

        // GET: api/TipoMaterial/5
        [ResponseType(typeof(Tipo_Material))]
        public IHttpActionResult GetTipo_Material(int id)
        {
            Tipo_Material tipo_Material = db.Tipo_Material.Find(id);
            if (tipo_Material == null)
            {
                return NotFound();
            }

            return Ok(tipo_Material);
        }

        // PUT: api/TipoMaterial/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTipo_Material(int id, Tipo_Material tipo_Material)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tipo_Material.Id)
            {
                return BadRequest();
            }

            db.Entry(tipo_Material).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Tipo_MaterialExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/TipoMaterial
        [ResponseType(typeof(Tipo_Material))]
        public IHttpActionResult PostTipo_Material(Tipo_Material tipo_Material)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Tipo_Material.Add(tipo_Material);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tipo_Material.Id }, tipo_Material);
        }

        // DELETE: api/TipoMaterial/5
        [ResponseType(typeof(Tipo_Material))]
        public IHttpActionResult DeleteTipo_Material(int id)
        {
            Tipo_Material tipo_Material = db.Tipo_Material.Find(id);
            if (tipo_Material == null)
            {
                return NotFound();
            }

            db.Tipo_Material.Remove(tipo_Material);
            db.SaveChanges();

            return Ok(tipo_Material);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Tipo_MaterialExists(int id)
        {
            return db.Tipo_Material.Count(e => e.Id == id) > 0;
        }
    }
}