using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AGOKnights.Controllers
{
    public class TreasuryController : Controller
    {
        // GET: Treasury
        public ActionResult Index()
        {
            return View();
        }

        // GET: Treasury/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Treasury/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Treasury/Create
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

        // GET: Treasury/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Treasury/Edit/5
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

        // GET: Treasury/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Treasury/Delete/5
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
