using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InformationAndTechnologyCollege.Models;

namespace InformationAndTechnologyCollege.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            NewStoryModel newStory = new NewStoryModel()
            {
                Headline = "Phew what a scorcher",
                ByLine = "Ron Journo",
                Content = "British people are obsessed with the weather"
            };

            return View(newStory);
        }
    }
}