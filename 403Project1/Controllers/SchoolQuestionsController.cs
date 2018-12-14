using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _403Project1.DAL;
using _403Project1.Models;

namespace _403Project1.Controllers
{

    // EVERYTHING TO DO WITH ASKING QUESTIONS ABOUT THE SCHOOLS
    public class SchoolQuestionsController : Controller
    {
        private LearningDynamicsContext db = new LearningDynamicsContext();

        // GET: SchoolQuestions
        [Authorize]
        public ActionResult Index()
        {
            var schoolQuestions = db.SchoolQuestions.Include(s => s.parent).Include(s => s.school);
            return View(schoolQuestions.ToList());
        }

        // GET: SchoolQuestions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SchoolQuestion schoolQuestion = db.SchoolQuestions.Find(id);
            if (schoolQuestion == null)
            {
                return HttpNotFound();
            }
            return View(schoolQuestion);
        }

        // GET: SchoolQuestions/Create
        public ActionResult Create()
        {
            ViewBag.ParentID = new SelectList(db.Parents, "ParentID", "PFirstName");
            ViewBag.SchoolID = new SelectList(db.Schools, "SchoolID", "SchoolName");
            return View();
        }

        // POST: SchoolQuestions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "QuestionID,SchoolID,ParentID,Question,Answer")] SchoolQuestion schoolQuestion)
        {
            if (ModelState.IsValid)
            {
                db.SchoolQuestions.Add(schoolQuestion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ParentID = new SelectList(db.Parents, "ParentID", "PFirstName", schoolQuestion.ParentID);
            ViewBag.SchoolID = new SelectList(db.Schools, "SchoolID", "SchoolName", schoolQuestion.SchoolID);
            return View(schoolQuestion);
        }

        // GET: SchoolQuestions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SchoolQuestion schoolQuestion = db.SchoolQuestions.Find(id);
            if (schoolQuestion == null)
            {
                return HttpNotFound();
            }
            ViewBag.ParentID = new SelectList(db.Parents, "ParentID", "PFirstName", schoolQuestion.ParentID);
            ViewBag.SchoolID = new SelectList(db.Schools, "SchoolID", "SchoolName", schoolQuestion.SchoolID);
            return View(schoolQuestion);
        }

        // POST: SchoolQuestions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "QuestionID,SchoolID,ParentID,Question,Answer")] SchoolQuestion schoolQuestion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(schoolQuestion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ParentID = new SelectList(db.Parents, "ParentID", "PFirstName", schoolQuestion.ParentID);
            ViewBag.SchoolID = new SelectList(db.Schools, "SchoolID", "SchoolName", schoolQuestion.SchoolID);
            return View(schoolQuestion);
        }

        // GET: SchoolQuestions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SchoolQuestion schoolQuestion = db.SchoolQuestions.Find(id);
            if (schoolQuestion == null)
            {
                return HttpNotFound();
            }
            return View(schoolQuestion);
        }

        // POST: SchoolQuestions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SchoolQuestion schoolQuestion = db.SchoolQuestions.Find(id);
            db.SchoolQuestions.Remove(schoolQuestion);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
