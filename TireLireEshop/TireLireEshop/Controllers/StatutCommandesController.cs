using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TireLireEshop.Repository;

namespace TireLireEshop.Controllers
{
    public class StatutCommandesController : Controller
    {
        //création d'un constructeur

        IRepository<StatutCommande> repoStatutCommande;
        dbtirelireshopContext ctx;

        // GET: CommandesController
        public StatutCommandesController()
        {
            ctx = new dbtirelireshopContext();
            repoStatutCommande = new Repository<StatutCommande>(ctx);
        }

        // GET: StatutCommandesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: StatutCommandesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StatutCommandesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StatutCommandesController/Create
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

        // GET: StatutCommandesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StatutCommandesController/Edit/5
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

        // GET: StatutCommandesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StatutCommandesController/Delete/5
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
