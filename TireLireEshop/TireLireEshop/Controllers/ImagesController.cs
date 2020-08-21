using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TireLireEshop.Repository;

namespace TireLireEshop.Controllers
{
    public class ImagesController : Controller
    {
        //création d'un constructeur

        IRepository<Image> repoImage;
        dbtirelireshopContext ctx;

        // GET: ProduitController

        public ImagesController()
        {
            ctx = new dbtirelireshopContext();
            repoImage = new Repository<Image>(ctx);
        }

        // GET: Images
        public ActionResult Index()
        {
            return View(repoImage.GetAll());
        }

        // GET: Images/Details/5
        public ActionResult Details(int id)
        {
            return View(repoImage.GetItem(id));
        }

        // GET: Images/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Images/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Image image)
        {
            try
            {
                repoImage.InsertItem(image);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Images/Edit/5
        public ActionResult Edit(int id)
        {
            return View(repoImage.GetItem(id));
        }

        // POST: Images/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Image image)
        {
            try
            {
                repoImage.UpdateItem(image);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Images/Delete/5
        public ActionResult Delete(int id)
        {
            return View(repoImage.GetItem(id));
        }

        // POST: Images/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                repoImage.DeleteItem(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
