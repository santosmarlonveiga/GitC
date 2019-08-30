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
    public class MarcaVeiculoesController : ApiController
    {
        [Route("Api/Marcas/{CodigoMarca}/TiposDeTransportes")]
        [HttpGet]
        public IEnumerable<ModeloVeiculo> ObtemModelo(int CodigoMarca)
        {
            return db.ModelosVeiculos.Where(x => x.MarcaFK == CodigoMarca); 
        }

        private ContexDb db = new ContexDb();

        // GET: api/MarcaVeiculoes
        public IQueryable<MarcaVeiculo> GetMarcasVeiculos()
        {
            return db.MarcasVeiculos;
        }

        // GET: api/MarcaVeiculoes/5
        [ResponseType(typeof(MarcaVeiculo))]
        public async Task<IHttpActionResult> GetMarcaVeiculo(int id)
        {
            MarcaVeiculo marcaVeiculo = await db.MarcasVeiculos.FindAsync(id);
            if (marcaVeiculo == null)
            {
                return NotFound();
            }

            return Ok(marcaVeiculo);
        }

        // PUT: api/MarcaVeiculoes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutMarcaVeiculo(int id, MarcaVeiculo marcaVeiculo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != marcaVeiculo.Id)
            {
                return BadRequest();
            }

            db.Entry(marcaVeiculo).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MarcaVeiculoExists(id))
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

        // POST: api/MarcaVeiculoes
        [ResponseType(typeof(MarcaVeiculo))]
        public async Task<IHttpActionResult> PostMarcaVeiculo(MarcaVeiculo marcaVeiculo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.MarcasVeiculos.Add(marcaVeiculo);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = marcaVeiculo.Id }, marcaVeiculo);
        }

        // DELETE: api/MarcaVeiculoes/5
        [ResponseType(typeof(MarcaVeiculo))]
        public async Task<IHttpActionResult> DeleteMarcaVeiculo(int id)
        {
            MarcaVeiculo marcaVeiculo = await db.MarcasVeiculos.FindAsync(id);
            if (marcaVeiculo == null)
            {
                return NotFound();
            }

            db.MarcasVeiculos.Remove(marcaVeiculo);
            await db.SaveChangesAsync();

            return Ok(marcaVeiculo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MarcaVeiculoExists(int id)
        {
            return db.MarcasVeiculos.Count(e => e.Id == id) > 0;
        }
    }
}