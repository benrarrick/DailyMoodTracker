using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DailyMoodTracker.Models;

namespace DailyMoodTracker.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();
            people.Add(new PersonModel { FirstName = "Ben", LastName = "Rarrick", Age = 23, IsAlive = true });
            people.Add(new PersonModel { FirstName = "Time", LastName = "dsa", Age = 23, IsAlive = true });
            people.Add(new PersonModel { FirstName = "Bends", LastName = "Ragdrrick", Age = 23, IsAlive = true });

            return View(people);
        }
    }
}