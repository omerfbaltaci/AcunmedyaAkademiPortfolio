using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AcunmedyaAkademiPortfolio.Models;

namespace AcunmedyaAkademiPortfolio.Controllers
{
    public class ProjectController : Controller
    {
        private DbAcunmedyaAkademi1Entities db = new DbAcunmedyaAkademi1Entities();

        // GET: Project
        public ActionResult Index()
        {
            var tblProject = db.TblProject.Include(t => t.TblCategory);
            return View(tblProject.ToList());
        }

        // GET: Project/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblProject tblProject = db.TblProject.Find(id);
            if (tblProject == null)
            {
                return HttpNotFound();
            }
            return View(tblProject);
        }

        // GET: Project/Create
        public ActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(db.TblCategory, "CategoryID", "CategoryName");
            return View();
        }

        // POST: Project/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProjectID,ProjectTitle,Description,ImageURL,CategoryID")] TblProject tblProject)
        {
            if (ModelState.IsValid)
            {
                db.TblProject.Add(tblProject);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryID = new SelectList(db.TblCategory, "CategoryID", "CategoryName", tblProject.CategoryID);
            return View(tblProject);
        }

        // GET: Project/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblProject tblProject = db.TblProject.Find(id);
            if (tblProject == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryID = new SelectList(db.TblCategory, "CategoryID", "CategoryName", tblProject.CategoryID);
            return View(tblProject);
        }

        // POST: Project/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProjectID,ProjectTitle,Description,ImageURL,CategoryID")] TblProject tblProject)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblProject).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryID = new SelectList(db.TblCategory, "CategoryID", "CategoryName", tblProject.CategoryID);
            return View(tblProject);
        }

        // GET: Project/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblProject tblProject = db.TblProject.Find(id);
            if (tblProject == null)
            {
                return HttpNotFound();
            }
            return View(tblProject);
        }

        // POST: Project/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TblProject tblProject = db.TblProject.Find(id);
            db.TblProject.Remove(tblProject);
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
