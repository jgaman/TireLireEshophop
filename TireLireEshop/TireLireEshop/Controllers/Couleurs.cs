using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TireLireEshop.Controllers
{
    public class Couleurs : Controller
    {
        // GET: Couleurs
        public ActionResult Index()
        {
            dbtirelireshopContext cxt = new dbtirelireshopContext();
            return View(cxt.Couleur);
        }

        // GET: Couleurs/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Couleurs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Couleurs/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: Couleurs/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Couleurs/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: Couleurs/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Couleurs/Delete/5
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
