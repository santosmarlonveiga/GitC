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
    public class TiposDeTransportesController : ApiController
    {
        [Route("Api/TiposDeTransportes/{CodigoVeiculo}/MarcasVeiculos")]
        [HttpGet]
        public IEnumerable<MarcaVeiculo> ObtemModelo(int CodigoVeiculo)
        {
            return db.MarcasVeiculos.Where(x => x.TipoVeiculoFK == CodigoVeiculo);
        }

        private ContexDb db = new ContexDb();

        // GET: api/TiposDeTransportes
        public IQueryable<TiposDeTransporte> GetTiposDeTransportes()
        {
            return db.TiposDeTransportes;
        }

        // GET: api/TiposDeTransportes/5
        [ResponseType(typeof(TiposDeTransporte))]
        public async Task<IHttpActionResult> GetTiposDeTransporte(int id)
        {
            TiposDeTransporte tiposDeTransporte = await db.TiposDeTransportes.FindAsync(id);
            if (tiposDeTransporte == null)
            {
                return NotFound();
            }

            return Ok(tiposDeTransporte);
        }

        // PUT: api/TiposDeTransportes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTiposDeTransporte(int id, TiposDeTransporte tiposDeTransporte)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tiposDeTransporte.Id)
            {
                return BadRequest();
            }

            db.Entry(tiposDeTransporte).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TiposDeTransporteExists(id))
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

        // POST: api/TiposDeTransportes
        [ResponseType(typeof(TiposDeTransporte))]
        public async Task<IHttpActionResult> PostTiposDeTransporte(TiposDeTransporte tiposDeTransporte)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TiposDeTransportes.Add(tiposDeTransporte);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = tiposDeTransporte.Id }, tiposDeTransporte);
        }

        // DELETE: api/TiposDeTransportes/5
        [ResponseType(typeof(TiposDeTransporte))]
        public async Task<IHttpActionResult> DeleteTiposDeTransporte(int id)
        {
            TiposDeTransporte tiposDeTransporte = await db.TiposDeTransportes.FindAsync(id);
            if (tiposDeTransporte == null)
            {
                return NotFound();
            }

            db.TiposDeTransportes.Remove(tiposDeTransporte);
            await db.SaveChangesAsync();

            return Ok(tiposDeTransporte);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TiposDeTransporteExists(int id)
        {
            return db.TiposDeTransportes.Count(e => e.Id == id) > 0;
        }
    }
}