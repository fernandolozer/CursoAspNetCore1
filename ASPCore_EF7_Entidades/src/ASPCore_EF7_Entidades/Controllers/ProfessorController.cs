using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using ASPCore_EF7_Entidades.Models;

namespace ASPCore_EF7_Entidades.Controllers
{
    public class ProfessorController : Controller
    {
        private DbContexto _context;

        public ProfessorController(DbContexto context)
        {
            _context = context;    
        }

        // GET: Professor
        public async Task<IActionResult> Index()
        {
            return View(await _context.Professor.ToListAsync());
        }

        // GET: Professor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Professor professor = await _context.Professor.SingleAsync(m => m.ID == id);
            if (professor == null)
            {
                return HttpNotFound();
            }

            return View(professor);
        }

        // GET: Professor/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Professor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Professor professor)
        {
            if (ModelState.IsValid)
            {
                _context.Professor.Add(professor);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(professor);
        }

        // GET: Professor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Professor professor = await _context.Professor.SingleAsync(m => m.ID == id);
            if (professor == null)
            {
                return HttpNotFound();
            }
            return View(professor);
        }

        // POST: Professor/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Professor professor)
        {
            if (ModelState.IsValid)
            {
                _context.Update(professor);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(professor);
        }

        // GET: Professor/Delete/5
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Professor professor = await _context.Professor.SingleAsync(m => m.ID == id);
            if (professor == null)
            {
                return HttpNotFound();
            }

            return View(professor);
        }

        // POST: Professor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Professor professor = await _context.Professor.SingleAsync(m => m.ID == id);
            _context.Professor.Remove(professor);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
