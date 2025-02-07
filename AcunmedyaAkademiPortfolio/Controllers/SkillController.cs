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
    public class SkillController : Controller
    {
        private DbAcunmedyaAkademi1Entities db = new DbAcunmedyaAkademi1Entities();

        // GET: Skill
        public ActionResult Index()
        {
            return View(db.TblSkill.ToList());
        }

        // GET: Skill/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblSkill tblSkill = db.TblSkill.Find(id);
            if (tblSkill == null)
            {
                return HttpNotFound();
            }
            return View(tblSkill);
        }

        // GET: Skill/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Skill/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SkillID,SkillTitle,SkillValue")] TblSkill tblSkill)
        {
            if (ModelState.IsValid)
            {
                db.TblSkill.Add(tblSkill);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblSkill);
        }

        // GET: Skill/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblSkill tblSkill = db.TblSkill.Find(id);
            if (tblSkill == null)
            {
                return HttpNotFound();
            }
            return View(tblSkill);
        }

        // POST: Skill/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SkillID,SkillTitle,SkillValue")] TblSkill tblSkill)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblSkill).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblSkill);
        }

        // GET: Skill/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblSkill tblSkill = db.TblSkill.Find(id);
            if (tblSkill == null)
            {
                return HttpNotFound();
            }
            return View(tblSkill);
        }

        // POST: Skill/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TblSkill tblSkill = db.TblSkill.Find(id);
            db.TblSkill.Remove(tblSkill);
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
