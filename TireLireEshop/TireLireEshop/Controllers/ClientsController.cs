using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TireLireEshop.Repository;

namespace TireLireEshop.Controllers
{
    public class ClientsController : Controller
    {
        //création d'un constructeur

        IRepository<Clients> repoClient;
        dbtirelireshopContext ctx;

        // GET: ClientController

        public ClientsController()
        {
            ctx = new dbtirelireshopContext();
            repoClient = new Repository<Clients>(ctx);
        }

        // GET: ClientsController

        public ActionResult Index()
        {
            return View(repoClient.GetAll());
        }

        // GET: ClientController/Details/5
        public ActionResult Details(int id)
        {
            return View(repoClient.GetItem(id));
        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Clients client)
        {
            try
            {
                repoClient.InsertItem(client);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View(repoClient.GetItem(id));
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Clients client)
        {
            try
            {
                repoClient.UpdateItem(client);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController1/Delete/5
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
