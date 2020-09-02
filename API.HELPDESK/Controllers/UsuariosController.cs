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
using API.HELPDESK.Models;

namespace API.HELPDESK.Controllers
{
    //[Route("api/Usuarios")]
    public class UsuariosController : ApiController
    {
        private BDDUIOHELPDESK01Entities db = new BDDUIOHELPDESK01Entities();

        // GET: api/Usuarios
        [HttpGet]
        public IQueryable<TBL_USUARIO> GetTBL_USUARIO()
        {
            return db.TBL_USUARIO;
        }

        // GET: api/Usuarios/5
        [ResponseType(typeof(TBL_USUARIO))]
        public IHttpActionResult GetTBL_USUARIO(int id)
        {
            TBL_USUARIO tBL_USUARIO = db.TBL_USUARIO.Where(data=>data.usu_id.Equals(id)).FirstOrDefault();
            if (tBL_USUARIO == null)
            {
                return NotFound();
            }

            return Ok(tBL_USUARIO);
        }


        // PUT: api/Usuarios/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTBL_USUARIO(int id, TBL_USUARIO tBL_USUARIO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tBL_USUARIO.usu_id)
            {
                return BadRequest();
            }

            db.Entry(tBL_USUARIO).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!TBL_USUARIOExists(id))
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

        // POST: api/Usuarios
        [ResponseType(typeof(TBL_USUARIO))]
        public IHttpActionResult PostTBL_USUARIO(TBL_USUARIO tBL_USUARIO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TBL_USUARIO.Add(tBL_USUARIO);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tBL_USUARIO.usu_id }, tBL_USUARIO);
        }

        // DELETE: api/Usuarios/5
        [ResponseType(typeof(TBL_USUARIO))]
        public IHttpActionResult DeleteTBL_USUARIO(int id)
        {
            TBL_USUARIO tBL_USUARIO = db.TBL_USUARIO.Where(data=>data.usu_id.Equals(id)).FirstOrDefault();
            if (tBL_USUARIO == null)
            {
                return NotFound();
            }

            db.TBL_USUARIO.Remove(tBL_USUARIO);
            db.SaveChanges();

            return Ok(tBL_USUARIO);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TBL_USUARIOExists(int id)
        {
            return db.TBL_USUARIO.Count(e => e.usu_id == id) > 0;
        }
    }
}