using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Brello.Controllers
{
    public class BoardController : Controller
    {
        // GET: Board
        public ActionResult Index()
        {
            // We inserted view name here to get second test to pass
            ViewBag.Message = "My Boards"; // Then added this for third test
            return View("Index");
        }

        // GET: Board/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Board/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Board/Create
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

        // GET: Board/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Attempt2/Edit/5
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

        // GET: Attempt2/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Attempt2/Delete/5
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
