using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelApproach1.Controllers
{
    public class studentController : Controller
    {
        // GET: student
        public ActionResult Index()
        {
            return View();
        }

        // GET: student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: student/Create
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

        // GET: student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: student/Edit/5
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

        // GET: student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: student/Delete/5
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
