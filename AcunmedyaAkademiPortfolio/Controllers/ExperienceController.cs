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
    public class ExperienceController : Controller
    {
        private DbAcunmedyaAkademi1Entities db = new DbAcunmedyaAkademi1Entities();

        // GET: Experience
        public ActionResult Index()
        {
            return View(db.TblExperience.ToList());
        }

        // GET: Experience/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblExperience tblExperience = db.TblExperience.Find(id);
            if (tblExperience == null)
            {
                return HttpNotFound();
            }
            return View(tblExperience);
        }

        // GET: Experience/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Experience/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ExperienceID,Title,Period,Description")] TblExperience tblExperience)
        {
            if (ModelState.IsValid)
            {
                db.TblExperience.Add(tblExperience);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblExperience);
        }

        // GET: Experience/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblExperience tblExperience = db.TblExperience.Find(id);
            if (tblExperience == null)
            {
                return HttpNotFound();
            }
            return View(tblExperience);
        }

        // POST: Experience/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ExperienceID,Title,Period,Description")] TblExperience tblExperience)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblExperience).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblExperience);
        }

        // GET: Experience/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblExperience tblExperience = db.TblExperience.Find(id);
            if (tblExperience == null)
            {
                return HttpNotFound();
            }
            return View(tblExperience);
        }

        // POST: Experience/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TblExperience tblExperience = db.TblExperience.Find(id);
            db.TblExperience.Remove(tblExperience);
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
