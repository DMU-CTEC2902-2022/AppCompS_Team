using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InformationAndTechnologyCollege.Controllers
{
    public class CollegeController : Controller
    {
        // GET: College
        public string Index()
        {
            return "College Index";
        }

        public string Course(string Type, string Colour)

        {
            return String.Format("Product Type = {0}, Colour={1}", Type, Colour);
        }

    }
}