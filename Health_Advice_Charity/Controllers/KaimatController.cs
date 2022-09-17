using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Health_Advice_Charity.Controllers
{
    public class KaimatController : Controller
    {
        // GET: KaimatController
        public ActionResult Index()
        {
            return View();
        }

        // GET: KaimatController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: KaimatController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KaimatController/Create
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

        // GET: KaimatController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: KaimatController/Edit/5
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

        // GET: KaimatController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: KaimatController/Delete/5
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
