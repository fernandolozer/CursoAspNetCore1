using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using ASPCore_EF7.Models;

namespace ASPCore_EF7.Controllers
{
    public class ProdutosController : Controller
    {
        private DbContexto _context;

        public ProdutosController(DbContexto context)
        {
            _context = context;    
        }

        // GET: Produtos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Produto.ToListAsync());
        }

        // GET: Produtos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Produto produto = await _context.Produto.SingleAsync(m => m.ID == id);
            if (produto == null)
            {
                return HttpNotFound();
            }

            return View(produto);
        }

        // GET: Produtos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Produtos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Produto produto)
        {
            if (ModelState.IsValid)
            {
                _context.Produto.Add(produto);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(produto);
        }

        // GET: Produtos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Produto produto = await _context.Produto.SingleAsync(m => m.ID == id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        // POST: Produtos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Produto produto)
        {
            if (ModelState.IsValid)
            {
                _context.Update(produto);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(produto);
        }

        // GET: Produtos/Delete/5
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Produto produto = await _context.Produto.SingleAsync(m => m.ID == id);
            if (produto == null)
            {
                return HttpNotFound();
            }

            return View(produto);
        }

        // POST: Produtos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Produto produto = await _context.Produto.SingleAsync(m => m.ID == id);
            _context.Produto.Remove(produto);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
