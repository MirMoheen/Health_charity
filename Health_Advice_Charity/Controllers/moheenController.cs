using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Health_Advice_Charity.Controllers
{
    public class moheenController : Controller
    {
        // GET: moheenController
        public ActionResult Index()
        {
            return View();
        }

        // GET: moheenController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: moheenController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: moheenController/Create
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

        // GET: moheenController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: moheenController/Edit/5
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

        // GET: moheenController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: moheenController/Delete/5
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
