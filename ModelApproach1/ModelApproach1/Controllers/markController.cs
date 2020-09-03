using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelApproach1.Controllers
{
    public class markController : Controller
    {
        // GET: mark
        public ActionResult Index()
        {
            return View();
        }

        // GET: mark/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: mark/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: mark/Create
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

        // GET: mark/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: mark/Edit/5
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

        // GET: mark/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: mark/Delete/5
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
