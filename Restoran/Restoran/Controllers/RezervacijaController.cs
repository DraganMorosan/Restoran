using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restoran.Controllers
{
    public class RezervacijaController : Controller
    {
        // GET: Rezervacija
        public ActionResult Index()
        {
            return View();
        }

        // GET: Rezervacija/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Rezervacija/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rezervacija/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Rezervacija/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Rezervacija/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Rezervacija/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Rezervacija/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
