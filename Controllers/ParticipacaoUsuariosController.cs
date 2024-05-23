using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DisabledPeopleRegister;
using DisabledPeopleRegister.Models;

namespace DisabledPeopleRegister.Controllers
{
    public class ParticipacaoUsuariosController : Controller
    {
        private readonly DatabaseContext _context;

        public ParticipacaoUsuariosController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: ParticipacaoUsuarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserParticipation.ToListAsync());
        }

        // GET: ParticipacaoUsuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var participacaoUsuario = await _context.UserParticipation
                .FirstOrDefaultAsync(m => m.Id == id);
            if (participacaoUsuario == null)
            {
                return NotFound();
            }

            return View(participacaoUsuario);
        }

        // GET: ParticipacaoUsuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ParticipacaoUsuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,ActivityId")] ParticipacaoUsuario participacaoUsuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(participacaoUsuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(participacaoUsuario);
        }

        // GET: ParticipacaoUsuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var participacaoUsuario = await _context.UserParticipation.FindAsync(id);
            if (participacaoUsuario == null)
            {
                return NotFound();
            }
            return View(participacaoUsuario);
        }

        // POST: ParticipacaoUsuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,ActivityId")] ParticipacaoUsuario participacaoUsuario)
        {
            if (id != participacaoUsuario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(participacaoUsuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParticipacaoUsuarioExists(participacaoUsuario.Id))
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
            return View(participacaoUsuario);
        }

        // GET: ParticipacaoUsuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var participacaoUsuario = await _context.UserParticipation
                .FirstOrDefaultAsync(m => m.Id == id);
            if (participacaoUsuario == null)
            {
                return NotFound();
            }

            return View(participacaoUsuario);
        }

        // POST: ParticipacaoUsuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var participacaoUsuario = await _context.UserParticipation.FindAsync(id);
            if (participacaoUsuario != null)
            {
                _context.UserParticipation.Remove(participacaoUsuario);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParticipacaoUsuarioExists(int id)
        {
            return _context.UserParticipation.Any(e => e.Id == id);
        }
    }
}
