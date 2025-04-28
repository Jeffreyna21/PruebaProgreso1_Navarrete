using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PruebaProgreso1_Navarrete.Models;

namespace PruebaProgreso1_Navarrete.Controllers
{
    public class ClienteController : Controller
    {
        private readonly PruebaProgreso1_NavarreteContextSQLServer _context;

        public ClienteController(PruebaProgreso1_NavarreteContextSQLServer context)
        {
            _context = context;
        }
        // GET: Cliente
        public async Task<IActionResult> Index()
        {
            var PruebaProgreso1_NavarreteContextSQLServer = _context.Cliente.Include(e => e.planRecompensa);
            return View(await PruebaProgreso1_NavarreteContextSQLServer.ToListAsync());
        }

        // GET: Cliente/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Cliente
                .Include(e => e.planRecompensa)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }


        // GET: Cliente/Create
        public IActionResult Create()
        {
            ViewData["Reserva"] = new SelectList(_context.Set<Reserva>(), "Id", "Nombre");
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Apellido,FechaNacimiento,Saldo,EsVIP")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CarreraId"] = new SelectList(_context.Set<Reserva>(), "Id", "Nombre", cliente.planRecompensa);
            return View(cliente);
        }


        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cliente/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Cliente.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            ViewData["PlanRecompensa"] = new SelectList(_context.Set<Reserva>(), "Id", "Id", cliente.planRecompensa);
            return View(cliente);
        }
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Apellido,FechaNacimiento,Saldo,PlanRecompensa")] Cliente cliente)
        {
            if (id != cliente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteExists(cliente.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CarreraId"] = new SelectList(_context.Set<Reserva>(), "Id", "Id", cliente.planRecompensa);
            return View(cliente);
        }
        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cliente/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
