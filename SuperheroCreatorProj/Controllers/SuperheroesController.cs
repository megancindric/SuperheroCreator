﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperheroCreatorProj.Models;
using SuperheroCreatorProj.Data;

namespace SuperheroCreatorProj.Controllers
{
    public class SuperheroesController : Controller
    {
        private ApplicationDbContext _context;

        public SuperheroesController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: SuperheroesController
        public ActionResult Index()
        {
            return View(_context.Superheroes);
        }

        // GET: SuperheroesController/Details/5
        public ActionResult Details(int id)
        {
            return View(_context.Superheroes.Where(m => m.Id == id).Single());
        }

        // GET: SuperheroesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuperheroesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Superhero superhero)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    _context.Superheroes.Add(superhero);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
            else
            {
                return View(superhero);
            }
            
        }

        // GET: SuperheroesController/Edit/5
        public ActionResult Edit(int id)
        {
            
                return View(_context.Superheroes.Where(m => m.Id == id).Single());
        }

        // POST: SuperheroesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Superhero superhero)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Superheroes.Update(superhero);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
            else
            {
                return View(superhero);
            }
        }

        // GET: SuperheroesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_context.Superheroes.Where(m => m.Id == id).Single());
        }

        // POST: SuperheroesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Superhero superhero)
        {

            _context.Superheroes.Remove(superhero);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}
