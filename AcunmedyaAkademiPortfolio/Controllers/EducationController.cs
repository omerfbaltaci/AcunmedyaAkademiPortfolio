using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunmedyaAkademiPortfolio.Models;

namespace AcunmedyaAkademiPortfolio.Controllers
{
    public class EducationController : Controller
    {

        DbAcunmedyaAkademi1Entities db = new DbAcunmedyaAkademi1Entities();

        public ActionResult EducationList()
        {
            var values = db.TblEducation.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateEducation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateEducation(TblEducation education)
        {
            db.TblEducation.Add(education);
            db.SaveChanges();
            return RedirectToAction("EducationList");
        }

        [HttpGet]
        public ActionResult UpdateEducation(int id)
        {
            var value = db.TblEducation.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateEducation(TblEducation p)
        {
            var value = db.TblEducation.Find(p.EducationID);
            value.Title = p.Title;
            value.SubTitle = p.SubTitle;
            value.Period = p.Period;
            value.Description = p.Description;
            db.SaveChanges();
            return RedirectToAction("EducationList");
        }

        public ActionResult DeleteEducation(int id)
        {
            var value = db.TblEducation.Find(id);
            db.TblEducation.Remove(value);
            db.SaveChanges();
            return RedirectToAction("EducationList");
        }
    }
}