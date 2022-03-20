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
        public string Course()
        {
            return "Courses Page";
        }
        //Error #16
        //public string Course(int id)
        //{
        //    return "Course: Id = " + id.ToString();
        //}

    }
}