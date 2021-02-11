using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemoApp.Controllers
{
    public class Example : Controller
    {
        // GET: Example
        public ActionResult Index()
        {
            return View();
        }

        // GET: Example/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Example/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Example/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: Example/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Example/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: Example/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Example/Delete/5
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
