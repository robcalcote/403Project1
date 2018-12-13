using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _403Project1.Models;
using _403Project1.DAL;
using System.Web.Security;
using System.Data.Entity;

namespace _403Project1.Controllers
{
    public class HomeController : Controller
    {
        private LearningDynamicsContext db = new LearningDynamicsContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(FormCollection form, [Bind(Include = "PEmail,PLogin")] Parent newparent, bool rememberMe = false)
        {
            string password = newparent.PLogin;
            if (db.Parents.Find(newparent.PEmail) != null)
            {
                if (db.Parents.Find(newparent.PEmail).PLogin == password)
                {
                    FormsAuthentication.SetAuthCookie(newparent.PEmail, rememberMe);
                    return View("Index");
                }
            }

            return View();
        }

        
        
    }
}