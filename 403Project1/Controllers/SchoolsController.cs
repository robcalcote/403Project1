using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
        public ActionResult Lehi()
        {
            return View();
        }

        // Will Return Riverton View
        public ActionResult Riverton()
        {
            return View();
        }

        // Will Return Gilbert View
        public ActionResult Gilbert()
        {
            return View();
        }
    }
}