﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TireLireEshop.Repository;

namespace TireLireEshop.Controllers
{
    public class CouleursController : Controller 
    {
        //création d'un constructeur

        IRepository<Couleur> repoCouleur;
        dbtirelireshopContext ctx;
        
        // GET: CouleurController
        
        public CouleursController()
        {
            ctx = new dbtirelireshopContext();
            repoCouleur = new Repository<Couleur>(ctx);
        }

        // GET: Couleurs
        public ActionResult Index()
        {
            
            return View(repoCouleur.GetAll());              
            
        }

        // GET: Couleurs/Details/5
        public ActionResult Details(int id)
        {
             
            return View(repoCouleur.GetItem(id));
        }

        // GET: Couleurs/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Couleurs/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Couleur couleur)
        {
            try
            {
                repoCouleur.InsertItem(couleur);
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Couleurs/Edit/5
        public ActionResult Edit(int id)
        {
            return View(repoCouleur.GetItem(id));
        }

        // POST: Couleurs/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Couleur couleur)
        {
            try
            {
                repoCouleur.UpdateItem(couleur);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Couleurs/Delete/5
        public ActionResult Delete(int id)
        {
            return View(repoCouleur.GetItem(id));
        }

        // POST: Couleurs/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                repoCouleur.DeleteItem(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
