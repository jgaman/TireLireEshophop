using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TireLireEshop.Repository;

namespace TireLireEshop.Controllers
{
    public class CommandesController : Controller
    {
        //création d'un constructeur

        IRepository<Commandes> repoCommande;
        dbtirelireshopContext ctx;

        // GET: CommandesController
        public CommandesController()
        {
            ctx = new dbtirelireshopContext();
            repoCommande = new Repository<Commandes>(ctx);
        }
        
        // GET: Commandes
        public ActionResult Index()
        {
            return View(repoCommande.GetAll());
        }

        // GET: CommandesController/Details/5
        public ActionResult Details(int id)
        {
            return View(repoCommande.GetItem(id));
        }

        // GET: CommandesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CommandesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Commandes commande)
        {
            try
            {
                repoCommande.InsertItem(commande);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CommandesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CommandesController/Edit/5
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

        // GET: CommandesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CommandesController/Delete/5
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
