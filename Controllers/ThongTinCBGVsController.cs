using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOAN52.Controllers
{
    public class ThongTinCBGVController : Controller
    {
        // GET: ThongTinCBGVController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ThongTinCBGVController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ThongTinCBGVController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ThongTinCBGVController/Create
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

        // GET: ThongTinCBGVController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ThongTinCBGVController/Edit/5
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

        // GET: ThongTinCBGVController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ThongTinCBGVController/Delete/5
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
