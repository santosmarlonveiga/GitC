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
    public class PeriodoDeLocacaosController : ApiController
    {
        private ContexDb db = new ContexDb();

        // GET: api/PeriodoDeLocacaos
        public IQueryable<PeriodoDeLocacao> GetPeriodoDeLocacaos()
        {
            return db.PeriodoDeLocacaos;
        }

        // GET: api/PeriodoDeLocacaos/5
        [ResponseType(typeof(PeriodoDeLocacao))]
        public async Task<IHttpActionResult> GetPeriodoDeLocacao(int id)
        {
            PeriodoDeLocacao periodoDeLocacao = await db.PeriodoDeLocacaos.FindAsync(id);
            if (periodoDeLocacao == null)
            {
                return NotFound();
            }

            return Ok(periodoDeLocacao);
        }

        // PUT: api/PeriodoDeLocacaos/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPeriodoDeLocacao(int id, PeriodoDeLocacao periodoDeLocacao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != periodoDeLocacao.Id)
            {
                return BadRequest();
            }

            db.Entry(periodoDeLocacao).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PeriodoDeLocacaoExists(id))
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

        // POST: api/PeriodoDeLocacaos
        [ResponseType(typeof(PeriodoDeLocacao))]
        public async Task<IHttpActionResult> PostPeriodoDeLocacao(PeriodoDeLocacao periodoDeLocacao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PeriodoDeLocacaos.Add(periodoDeLocacao);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = periodoDeLocacao.Id }, periodoDeLocacao);
        }

        // DELETE: api/PeriodoDeLocacaos/5
        [ResponseType(typeof(PeriodoDeLocacao))]
        public async Task<IHttpActionResult> DeletePeriodoDeLocacao(int id)
        {
            PeriodoDeLocacao periodoDeLocacao = await db.PeriodoDeLocacaos.FindAsync(id);
            if (periodoDeLocacao == null)
            {
                return NotFound();
            }

            db.PeriodoDeLocacaos.Remove(periodoDeLocacao);
            await db.SaveChangesAsync();

            return Ok(periodoDeLocacao);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PeriodoDeLocacaoExists(int id)
        {
            return db.PeriodoDeLocacaos.Count(e => e.Id == id) > 0;
        }
    }
}