using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using ASPCore_EF7_Entidades.Models;

namespace ASPCore_EF7_Entidades.Controllers
{
    public class AlunoController : Controller
    {
        private DbContexto _context;

        public AlunoController(DbContexto context)
        {
            _context = context;    
        }

        // GET: Aluno
        public async Task<IActionResult> Index()
        {
            var dbContexto = _context.Aluno.Include(a => a.Professor);
            return View(await dbContexto.ToListAsync());
        }

        // GET: Aluno/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Aluno aluno = await _context.Aluno.SingleAsync(m => m.ID == id);
            if (aluno == null)
            {
                return HttpNotFound();
            }

            return View(aluno);
        }

        // GET: Aluno/Create
        public IActionResult Create()
        {
            ViewData["ProfessorID"] = new SelectList(_context.Professor, "ID", "Professor");
            return View();
        }

        // POST: Aluno/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                _context.Aluno.Add(aluno);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["ProfessorID"] = new SelectList(_context.Professor, "ID", "Professor", aluno.ProfessorID);
            return View(aluno);
        }

        // GET: Aluno/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Aluno aluno = await _context.Aluno.SingleAsync(m => m.ID == id);
            if (aluno == null)
            {
                return HttpNotFound();
            }
            ViewData["ProfessorID"] = new SelectList(_context.Professor, "ID", "Professor", aluno.ProfessorID);
            return View(aluno);
        }

        // POST: Aluno/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                _context.Update(aluno);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["ProfessorID"] = new SelectList(_context.Professor, "ID", "Professor", aluno.ProfessorID);
            return View(aluno);
        }

        // GET: Aluno/Delete/5
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Aluno aluno = await _context.Aluno.SingleAsync(m => m.ID == id);
            if (aluno == null)
            {
                return HttpNotFound();
            }

            return View(aluno);
        }

        // POST: Aluno/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Aluno aluno = await _context.Aluno.SingleAsync(m => m.ID == id);
            _context.Aluno.Remove(aluno);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
