﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using appWeb1._2.Models;

namespace appWeb1._2.Controllers
{
    public class TrabajoesController : Controller
    {
        private readonly pruebadbContext _context;

        public TrabajoesController(pruebadbContext context)
        {
            _context = context;
        }

        // GET: Trabajoes
        public async Task<IActionResult> Index()
        {
            var nivelexp = (from m in _context.Trabajo
                            select m.nivelexperiencia).ToList();
            ViewData["nivelexp"] = new SelectList(nivelexp, "nivelexperiencia");

            var sectorlab = (from m in _context.Trabajo
                            select m.sectorlaboral).ToList();
            ViewData["sectorlab"] = new SelectList(sectorlab, "sectorlaboral");

            var tContrato = (from m in _context.Trabajo
                             select m.tipocontrato).ToList();
            ViewData["tContrato"] = new SelectList(tContrato, "tipocontrato");
            var ubica = (from m in _context.Trabajo
                             select m.ubicacion).ToList();
            ViewData["ubica"] = new SelectList(ubica, "ubicacion");
            var tipoTrabajo = (from m in _context.Trabajo
                         select m.tipotrabajo).ToList();
            ViewData["tipoTrabajo"] = new SelectList(tipoTrabajo, "tipotrabajo");

            var salari = (from m in _context.Trabajo
                         select m.salario).ToList();
            ViewData["salari"] = new SelectList(salari, "salario");

            var mostrardatos = (from c in _context.Trabajo
                                 select new
                                 {
                                     titulotrabajo = c.titulotrabajo,
                                     nombreempresa = c.nombreempresa,
                                     ubicacion = c.ubicacion,
                                     trabajo=c.tipotrabajo,
                                     fecha=c.fechapublicacion

                                 }).ToList();
            ViewData["listadodatos"] = mostrardatos;
            return View();


        }

        // GET: Trabajoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Trabajo == null)
            {
                return NotFound();
            }

            var trabajo = await _context.Trabajo
                .FirstOrDefaultAsync(m => m.idtrabajo == id);
            if (trabajo == null)
            {
                return NotFound();
            }

            return View(trabajo);
        }

        // GET: Trabajoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Trabajoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idtrabajo,titulotrabajo,nombreempresa,ubicacion,tipotrabajo,fechapublicacion,salario,nivelexperiencia,sectorlaboral,tipocontrato")] Trabajo trabajo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(trabajo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(trabajo);
        }

        // GET: Trabajoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Trabajo == null)
            {
                return NotFound();
            }

            var trabajo = await _context.Trabajo.FindAsync(id);
            if (trabajo == null)
            {
                return NotFound();
            }
            return View(trabajo);
        }

        // POST: Trabajoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idtrabajo,titulotrabajo,nombreempresa,ubicacion,tipotrabajo,fechapublicacion,salario,nivelexperiencia,sectorlaboral,tipocontrato")] Trabajo trabajo)
        {
            if (id != trabajo.idtrabajo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trabajo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrabajoExists(trabajo.idtrabajo))
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
            return View(trabajo);
        }

        // GET: Trabajoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Trabajo == null)
            {
                return NotFound();
            }

            var trabajo = await _context.Trabajo
                .FirstOrDefaultAsync(m => m.idtrabajo == id);
            if (trabajo == null)
            {
                return NotFound();
            }

            return View(trabajo);
        }

        // POST: Trabajoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Trabajo == null)
            {
                return Problem("Entity set 'pruebadbContext.Trabajo'  is null.");
            }
            var trabajo = await _context.Trabajo.FindAsync(id);
            if (trabajo != null)
            {
                _context.Trabajo.Remove(trabajo);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrabajoExists(int id)
        {
            return (_context.Trabajo?.Any(e => e.idtrabajo == id)).GetValueOrDefault();
        }


        



       }


    
}
