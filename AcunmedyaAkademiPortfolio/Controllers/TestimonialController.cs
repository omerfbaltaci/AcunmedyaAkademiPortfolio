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
    public class TestimonialController : Controller
    {
        private DbAcunmedyaAkademi1Entities db = new DbAcunmedyaAkademi1Entities();

        // GET: Testimonial
        public ActionResult Index()
        {
            return View(db.TblTestimonial.ToList());
        }

        // GET: Testimonial/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblTestimonial tblTestimonial = db.TblTestimonial.Find(id);
            if (tblTestimonial == null)
            {
                return HttpNotFound();
            }
            return View(tblTestimonial);
        }

        // GET: Testimonial/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Testimonial/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TestimonialID,NameSurname,Title,CommentDetail,ImageURL")] TblTestimonial tblTestimonial)
        {
            if (ModelState.IsValid)
            {
                db.TblTestimonial.Add(tblTestimonial);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblTestimonial);
        }

        // GET: Testimonial/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblTestimonial tblTestimonial = db.TblTestimonial.Find(id);
            if (tblTestimonial == null)
            {
                return HttpNotFound();
            }
            return View(tblTestimonial);
        }

        // POST: Testimonial/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TestimonialID,NameSurname,Title,CommentDetail,ImageURL")] TblTestimonial tblTestimonial)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblTestimonial).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblTestimonial);
        }

        // GET: Testimonial/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblTestimonial tblTestimonial = db.TblTestimonial.Find(id);
            if (tblTestimonial == null)
            {
                return HttpNotFound();
            }
            return View(tblTestimonial);
        }

        // POST: Testimonial/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TblTestimonial tblTestimonial = db.TblTestimonial.Find(id);
            db.TblTestimonial.Remove(tblTestimonial);
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
