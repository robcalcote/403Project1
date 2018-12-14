using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _403Project1.Models;
using _403Project1.DAL;
using System.Web.Security;
using System.Data.Entity;

/********************************************************************************************************
 * 
 *          Project:        Project 2
 *          Date:           12/13/2018
 *          Team:           2-13
 *          Members:        Nate Flanagan, Rob Calcote, Jon Facer, Matt Lant
 *          Description:    This is a school website where parents can ask eachother questions about
 *                          The different preschools
 * 
 ********************************************************************************************************/

namespace _403Project1.Controllers
{
    public class HomeController : Controller
    {
        LearningDynamicsContext db = new LearningDynamicsContext();

        public ActionResult Index()
        {
            return View();
        }

        // Blocked unless logged in
        [Authorize]
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

        // Login page
        public ActionResult Login()
        {
            return View();
        }

        // Sends information to Database that is passed from the login view
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(FormCollection form, [Bind(Include = "ParentID,PEmail,PLogin")] Parent newparent, bool rememberMe = false)
        {
            Parent parent = db.Parents.SingleOrDefault(i => i.PEmail == newparent.PEmail);

            string password = newparent.PLogin;
            if (parent != null)
            {
                if (parent.PLogin == newparent.PLogin)
                {
                    FormsAuthentication.SetAuthCookie(newparent.PEmail, rememberMe);
                    return View("Index");
                }
            }
            ViewBag.Error = "Sorry your Username or Password was incorrect.";
            return View();
        }
        

    }
}