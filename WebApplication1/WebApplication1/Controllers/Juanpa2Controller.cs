using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class Juanpa2Controller : Controller
    {
        // GET: Juanpa2Controller
        public ActionResult Index()
        {
            return View();
        }

        // GET: Juanpa2Controller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Juanpa2Controller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Juanpa2Controller/Create
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

        // GET: Juanpa2Controller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Juanpa2Controller/Edit/5
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

        // GET: Juanpa2Controller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Juanpa2Controller/Delete/5
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
