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
    public class LocacaosController : ApiController
    {
        private ContexDb db = new ContexDb();

        // GET: api/Locacaos
        public IQueryable<Locacao> GetLocacaos()
        {
            return db.Locacaos;
        }

        // GET: api/Locacaos/5
        [ResponseType(typeof(Locacao))]
        public async Task<IHttpActionResult> GetLocacao(int id)
        {
            Locacao locacao = await db.Locacaos.FindAsync(id);
            if (locacao == null)
            {
                return NotFound();
            }

            return Ok(locacao);
        }

        // PUT: api/Locacaos/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutLocacao(int id, Locacao locacao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != locacao.Id)
            {
                return BadRequest();
            }

            db.Entry(locacao).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocacaoExists(id))
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

        // POST: api/Locacaos
        [ResponseType(typeof(Locacao))]
        public async Task<IHttpActionResult> PostLocacao(Locacao locacao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
           
            var automovel = db.TiposDeTransportes;
            if (locacao.CodTipoDeVeiculo == automovel.FirstOrDefault(x => x.Descricao == "Automovel").Codigo)
            {
                var marcaVeiculo = db.MarcasVeiculos.FirstOrDefault(x => x.Codigo == locacao.CodMarca);
                if (marcaVeiculo == null)
                    return BadRequest("O campo Codigo da Marca está incorreto");

                var modeloVeiculo = db.ModelosVeiculos.FirstOrDefault(x => x.Id == locacao.CodModelo);
                if (modeloVeiculo == null)
                    return BadRequest("O campo Código do Modelo está incorreto");

                var cores = db.Cores.FirstOrDefault(x => x.Codigo == locacao.CodCor);
                if (cores == null)
                        return BadRequest("O campo Código da Cor está incorreto");

                var verificaPlaca = true;
                if (locacao.PlacaCarro == null)
                    verificaPlaca = false;

                if(!verificaPlaca)
                    return BadRequest("O campo Placa está vazio");

                var aceitaTermo = db.Locacaos.FirstOrDefault(x => x.AceitaTermo == true);
                if (locacao.AceitaTermo != true)
                    return BadRequest("Para realizar a locação, você deve aceitar os termos de uso");
            }
            

            var moto = db.TiposDeTransportes;
            if (locacao.CodTipoDeVeiculo == moto.FirstOrDefault(x => x.Descricao == "Moto").Codigo)
            {
                var marcaVeiculo = db.MarcasVeiculos.FirstOrDefault(x => x.Codigo == locacao.CodMarca);
                if (marcaVeiculo == null)
                    return BadRequest("O campo Codigo da Marca está incorreto");

                var modeloVeiculo = db.ModelosVeiculos.FirstOrDefault(x => x.Id == locacao.CodModelo);
                if (modeloVeiculo == null)
                    return BadRequest("O campo Código do Modelo está incorreto");

                var cores = db.Cores.FirstOrDefault(x => x.Codigo == locacao.CodCor);
                if (cores == null)
                    return BadRequest("O campo Código da Cor está incorreto");

                var verificaPlaca = true;
                if (locacao.PlacaCarro == null)
                    verificaPlaca = false;

                if (!verificaPlaca)
                    return BadRequest("O campo Placa está vazio");

                var aceitaTermo = db.Locacaos.FirstOrDefault(x => x.AceitaTermo == true);
                if (locacao.AceitaTermo != true)
                    return BadRequest("Para realizar a locação, você deve aceitar os termos de uso");

            }
           



            db.Locacaos.Add(locacao);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = locacao.Id }, locacao);
        }

        // DELETE: api/Locacaos/5
        [ResponseType(typeof(Locacao))]
        public async Task<IHttpActionResult> DeleteLocacao(int id)
        {
            Locacao locacao = await db.Locacaos.FindAsync(id);
            if (locacao == null)
            {
                return NotFound();
            }

            db.Locacaos.Remove(locacao);
            await db.SaveChangesAsync();

            return Ok(locacao);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LocacaoExists(int id)
        {
            return db.Locacaos.Count(e => e.Id == id) > 0;
        }
    }
}