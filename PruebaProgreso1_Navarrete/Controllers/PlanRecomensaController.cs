using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PruebaProgreso1_Navarrete.Controllers
{
    public class PlanRecomensaController : Controller
    {
        // GET: PlanRecomensaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PlanRecomensaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PlanRecomensaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlanRecomensaController/Create
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

        // GET: PlanRecomensaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PlanRecomensaController/Edit/5
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

        // GET: PlanRecomensaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PlanRecomensaController/Delete/5
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
