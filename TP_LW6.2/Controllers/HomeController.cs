using System;
using System.Web.Mvc;

namespace TP_LW6._2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Index")]
        public ActionResult PostIndex(long depositAmount, DateTime birthday)
        {
            int? id = null;
            if (int.TryParse(HttpContext.Request.Form["id"] ?? string.Empty, out var value))
                id = value;
            

            if (id is null)
                return RedirectToAction(nameof(Index));

            ViewBag.Id = id;
            ViewBag.FirstName = HttpContext.Request.Form["firstName"];
            ViewBag.LastName = HttpContext.Request.Form["lastName"];
            ViewBag.Patronymic = HttpContext.Request.Form["patronymic"];
            ViewBag.DepositAmount = depositAmount;
            ViewBag.Birthday = birthday;

            return View("Display");
        }

    }
}