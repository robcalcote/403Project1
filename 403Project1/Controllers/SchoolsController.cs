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
            var schoolsList = new SelectList(new[]
            {
                new { ID = "1", Name = "Orem" },
                new { ID = "2", Name = "Riverton" },
                new { ID = "3", Name = "Gilbert" },
            }, "ID", "Name", 1);

            ViewData["list"] = schoolsList;


            // returns view
            return View();
        }
    }
}