using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonationPortal.Controllers
{
    public class DonorMvcController : Controller
    {
        // GET: DonorMvcController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DonorMvcController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DonorMvcController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DonorMvcController/Create
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

        // GET: DonorMvcController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DonorMvcController/Edit/5
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

        // GET: DonorMvcController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DonorMvcController/Delete/5
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
