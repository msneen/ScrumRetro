using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ScrumRetro.Models;

namespace ScrumRetro.Controllers
{
    public class RetrospectController : Controller
    {
        //
        // GET: /Retrospect/

        public ActionResult Index()
        {
            List<RetrospectModels> model = new List<RetrospectModels>();
            return View(model);
        }

        //
        // GET: /Retrospect/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Retrospect/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Retrospect/Create

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

        //
        // GET: /Retrospect/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Retrospect/Edit/5

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

        //
        // GET: /Retrospect/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Retrospect/Delete/5

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
