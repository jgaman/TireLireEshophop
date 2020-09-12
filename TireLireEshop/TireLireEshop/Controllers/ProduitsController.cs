using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TireLireEshop.Repository;

namespace TireLireEshop.Controllers
{
    public class ProduitsController : Controller
    {
        //création d'un constructeur

        IRepository<Produits> repoProduit;
        dbtirelireshopContext ctx;

        // GET: ProduitController

        public ProduitsController()
        {
            ctx = new dbtirelireshopContext();
            repoProduit = new Repository<Produits>(ctx);
        }

        // GET: Produit
        public ActionResult Index()
        {
            return View(repoProduit.GetAll());
        }

        // GET: ProduitController/Details/5
        public ActionResult Details(int id)
        {
            return View(repoProduit.GetItem(id));
        }

        // GET: ProduitController/Create
        public ActionResult Create()
        {
            ViewBag.couleur = new Repository<Couleur>(ctx).GetAll().Select(c => new SelectListItem { Text = c.Nom, Value = c.PkIdCouleur.ToString()});
            ViewBag.fabricant = new Repository<Fabricant>(ctx).GetAll().Select(f => new SelectListItem { Text = f.Nom, Value = f.PkIdFabricant.ToString()});
            return View();
        }

        // POST: ProduitController/Create
        [HttpPost]
        [ValidateAntiForgeryToken] 
        public ActionResult Create(Produits produit)
        {
            try
            {
                repoProduit.InsertItem(produit);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProduitController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.couleur = new Repository<Couleur>(ctx).GetAll().Select(c => new SelectListItem { Text = c.Nom, Value = c.PkIdCouleur.ToString() });
            ViewBag.fabricant = new Repository<Fabricant>(ctx).GetAll().Select(f => new SelectListItem { Text = f.Nom, Value = f.PkIdFabricant.ToString() });
            return View(repoProduit.GetItem(id));
        }

        // POST: ProduitController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Produits produit)
        {
            try
            {
                repoProduit.UpdateItem(produit);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProduitController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(repoProduit.GetItem(id));
        }

        // POST: ProduitController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                repoProduit.DeleteItem(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
