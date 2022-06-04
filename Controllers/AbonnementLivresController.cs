using App.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace App.Livres.Controllers
{
    public class AbonnementLivresController : Controller
    {
        private readonly dbContext _context;
        public AbonnementLivresController(dbContext context)
        {
            _context = context;
        }
        // GET: AbonnementLivresController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AbonnementLivresController/Details/5
        public ActionResult Details(int id)
        {
            var list = _context.AbonnementLivres.SingleOrDefault(a => a.Id == id);

            return View(list);
        }

        // GET: AbonnementLivresController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AbonnementLivresController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AbonnementLivres abonnementLivres)
        {
            try
            {
                _context.Add(abonnementLivres);
                _context.SaveChanges();
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: AbonnementLivresController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AbonnementLivresController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, AbonnementLivres abonnementLivres)
        {
            try
            {
                _context.Update(abonnementLivres);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AbonnementLivresController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AbonnementLivresController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id,AbonnementLivres abonnementLivres)
        {
            try
            {
                _context.Remove(abonnementLivres);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
