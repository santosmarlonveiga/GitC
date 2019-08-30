using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ProjetoFinalTCC.Models;

namespace ProjetoFinalTCC.Controllers
{
    public class ColaboradorsController : ApiController
    {
        private ContexDb db = new ContexDb();

        // GET: api/Colaboradors
        public IQueryable<Colaborador> GetColaboradors()
        {
            return db.Colaboradors;
        }

        // GET: api/Colaboradors/5
        [ResponseType(typeof(Colaborador))]
        public async Task<IHttpActionResult> GetColaborador(int id)
        {
            Colaborador colaborador = await db.Colaboradors.FindAsync(id);
            if (colaborador == null)
            {
                return NotFound();
            }

            return Ok(colaborador);
        }

        // PUT: api/Colaboradors/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutColaborador(int id, Colaborador colaborador)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != colaborador.Id)
            {
                return BadRequest();
            }

            db.Entry(colaborador).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ColaboradorExists(id))
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

        // POST: api/Colaboradors
        [ResponseType(typeof(Colaborador))]
        public async Task<IHttpActionResult> PostColaborador(Colaborador colaborador)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Colaboradors.Add(colaborador);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = colaborador.Id }, colaborador);
        }

        // DELETE: api/Colaboradors/5
        [ResponseType(typeof(Colaborador))]
        public async Task<IHttpActionResult> DeleteColaborador(int id)
        {
            Colaborador colaborador = await db.Colaboradors.FindAsync(id);
            if (colaborador == null)
            {
                return NotFound();
            }

            db.Colaboradors.Remove(colaborador);
            await db.SaveChangesAsync();

            return Ok(colaborador);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ColaboradorExists(int id)
        {
            return db.Colaboradors.Count(e => e.Id == id) > 0;
        }
    }
}