using DailyMoodTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using static DataLibrary.BusinessLogic.UserProcessor;

namespace DailyMoodTracker.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SignUp()
        {
            ViewBag.Message = "User Sign Up";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(UserModel model)
        {
            // Ensure Data input is valid on the backend
            if (ModelState.IsValid)
            {
                int records = CreateUser(model.UserId,
                    model.FirstName,
                    model.LastName,
                    model.EmailAddress);
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}