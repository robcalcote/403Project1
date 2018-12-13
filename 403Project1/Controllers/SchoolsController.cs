using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _403Project1.Models;

namespace _403Project1.Controllers
{
    public class SchoolsController : Controller
    {
        // GET: Schools
        public ActionResult Index()
        {
            // returns view
            return View();
        }

        // Will Return Lehi View
        public ActionResult Lehi(string respond)
        {

            ViewBag.School = "Lehi Leopards";
            ViewBag.Director = "John Smith";
            ViewBag.Address = "500 NW 340 SE";
            ViewBag.Enrollment = "100 Students";
            ViewBag.Respond = respond;
            return View();
        }

        // Will Return Riverton View
        public ActionResult Riverton(string respond)
        {
            ViewBag.School = "Riverton Rhinos";
            ViewBag.Director = "Jane Dough";
            ViewBag.Address = "100 N 300 E";
            ViewBag.Enrollment = "150 Students";
            ViewBag.Respond = respond;
            return View();
        }

        // Will Return Gilbert View
        public ActionResult Gilbert(string respond)
        {
            ViewBag.School = "Gilbert Giraffes";
            ViewBag.Director = "John Lant";
            ViewBag.Address = "1122 Cactus Cooler Ave.";
            ViewBag.Enrollment = "200 Students";
            ViewBag.Respond = respond;

            return View();
            
        }
    }
}