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
    public class ModeloVeiculoesController : ApiController
    {
        private ContexDb db = new ContexDb();

        // GET: api/ModeloVeiculoes
        public IQueryable<ModeloVeiculo> GetModelosVeiculos()
        {
            return db.ModelosVeiculos;
        }

        // GET: api/ModeloVeiculoes/5
        [ResponseType(typeof(ModeloVeiculo))]
        public async Task<IHttpActionResult> GetModeloVeiculo(int id)
        {
            ModeloVeiculo modeloVeiculo = await db.ModelosVeiculos.FindAsync(id);
            if (modeloVeiculo == null)
            {
                return NotFound();
            }

            return Ok(modeloVeiculo);
        }

        // PUT: api/ModeloVeiculoes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutModeloVeiculo(int id, ModeloVeiculo modeloVeiculo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != modeloVeiculo.Id)
            {
                return BadRequest();
            }

            db.Entry(modeloVeiculo).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ModeloVeiculoExists(id))
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

        // POST: api/ModeloVeiculoes
        [ResponseType(typeof(ModeloVeiculo))]
        public async Task<IHttpActionResult> PostModeloVeiculo(ModeloVeiculo modeloVeiculo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ModelosVeiculos.Add(modeloVeiculo);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = modeloVeiculo.Id }, modeloVeiculo);
        }

        // DELETE: api/ModeloVeiculoes/5
        [ResponseType(typeof(ModeloVeiculo))]
        public async Task<IHttpActionResult> DeleteModeloVeiculo(int id)
        {
            ModeloVeiculo modeloVeiculo = await db.ModelosVeiculos.FindAsync(id);
            if (modeloVeiculo == null)
            {
                return NotFound();
            }

            db.ModelosVeiculos.Remove(modeloVeiculo);
            await db.SaveChangesAsync();

            return Ok(modeloVeiculo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ModeloVeiculoExists(int id)
        {
            return db.ModelosVeiculos.Count(e => e.Id == id) > 0;
        }
    }
}