using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using ASPCore_EF7.Models;

namespace ASPCore_EF7.Controllers
{
    [Produces("application/json")]
    [Route("api/ProdutosAPI")]
    public class ProdutosAPIController : Controller
    {
        private DbContexto _context;

        public ProdutosAPIController(DbContexto context)
        {
            _context = context;
        }

        // GET: api/ProdutosAPI
        [HttpGet]
        public IEnumerable<Produto> GetProduto()
        {
            return _context.Produto;
        }

        // GET: api/ProdutosAPI/5
        [HttpGet("{id}", Name = "GetProduto")]
        public async Task<IActionResult> GetProduto([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            Produto produto = await _context.Produto.SingleAsync(m => m.ID == id);

            if (produto == null)
            {
                return HttpNotFound();
            }

            return Ok(produto);
        }

        // PUT: api/ProdutosAPI/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduto([FromRoute] int id, [FromBody] Produto produto)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            if (id != produto.ID)
            {
                return HttpBadRequest();
            }

            _context.Entry(produto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProdutoExists(id))
                {
                    return HttpNotFound();
                }
                else
                {
                    throw;
                }
            }

            return new HttpStatusCodeResult(StatusCodes.Status204NoContent);
        }

        // POST: api/ProdutosAPI
        [HttpPost]
        public async Task<IActionResult> PostProduto([FromBody] Produto produto)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            _context.Produto.Add(produto);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ProdutoExists(produto.ID))
                {
                    return new HttpStatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("GetProduto", new { id = produto.ID }, produto);
        }

        // DELETE: api/ProdutosAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduto([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            Produto produto = await _context.Produto.SingleAsync(m => m.ID == id);
            if (produto == null)
            {
                return HttpNotFound();
            }

            _context.Produto.Remove(produto);
            await _context.SaveChangesAsync();

            return Ok(produto);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProdutoExists(int id)
        {
            return _context.Produto.Count(e => e.ID == id) > 0;
        }
    }
}