using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SimuladorDeNegocios.Models;

namespace SimuladorDeNegocios.Controllers
{
    public class estimacion_serviciosController : Controller
    {
        private readonly SimuladorDeNegociosContext _context;

        public estimacion_serviciosController(SimuladorDeNegociosContext context)
        {
            _context = context;
        }

        // GET: estimacion_servicios
        public async Task<IActionResult> Index()
        {
            return View(await _context.estimacion_servicios.ToListAsync());
        }

        // GET: estimacion_servicios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estimacion_servicios = await _context.estimacion_servicios
                .SingleOrDefaultAsync(m => m.id_suscripcion == id);
            if (estimacion_servicios == null)
            {
                return NotFound();
            }

            return View(estimacion_servicios);
        }

        // GET: estimacion_servicios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: estimacion_servicios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id_suscripcion,unidad_produccion,total_suscripciones,total_mensual,producto_servicios_id_producto")] estimacion_servicios estimacion_servicios)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estimacion_servicios);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estimacion_servicios);
        }

        // GET: estimacion_servicios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estimacion_servicios = await _context.estimacion_servicios.SingleOrDefaultAsync(m => m.id_suscripcion == id);
            if (estimacion_servicios == null)
            {
                return NotFound();
            }
            return View(estimacion_servicios);
        }

        // POST: estimacion_servicios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id_suscripcion,unidad_produccion,total_suscripciones,total_mensual,producto_servicios_id_producto")] estimacion_servicios estimacion_servicios)
        {
            if (id != estimacion_servicios.id_suscripcion)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estimacion_servicios);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!estimacion_serviciosExists(estimacion_servicios.id_suscripcion))
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
            return View(estimacion_servicios);
        }

        // GET: estimacion_servicios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estimacion_servicios = await _context.estimacion_servicios
                .SingleOrDefaultAsync(m => m.id_suscripcion == id);
            if (estimacion_servicios == null)
            {
                return NotFound();
            }

            return View(estimacion_servicios);
        }

        // POST: estimacion_servicios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var estimacion_servicios = await _context.estimacion_servicios.SingleOrDefaultAsync(m => m.id_suscripcion == id);
            _context.estimacion_servicios.Remove(estimacion_servicios);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool estimacion_serviciosExists(int id)
        {
            return _context.estimacion_servicios.Any(e => e.id_suscripcion == id);
        }
    }
}
