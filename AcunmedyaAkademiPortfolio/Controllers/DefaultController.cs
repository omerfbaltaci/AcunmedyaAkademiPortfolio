using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunmedyaAkademiPortfolio.Models;
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json.Linq;

namespace AcunmedyaAkademiPortfolio.Controllers
{
    public class DefaultController : Controller
    {

        DbAcunmedyaAkademi1Entities db = new DbAcunmedyaAkademi1Entities();

        [HttpPost]
        public ActionResult SubmitContactForm(TblContactForm message)
        {
            db.TblContactForm.Add(message);
            db.SaveChanges();

            return RedirectToAction("#");
        }

        public PartialViewResult PartialResume()
        {
            var values = db.TblResume.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialService()
        {
            var values = db.TblService.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialContact()
        {
            var values = db.TblContact.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialTestimonial()
        {
            var values = db.TblTestimonial.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialPortfolio()
        {
            var values = db.TblProject.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialEducation()
        {
            var values = db.TblEducation.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialExperience()
        {
            var values = db.TblExperience.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialSkill()
        {
            var values = db.TblSkill.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialAbout()
        {
            var values = db.TblAbout.ToList();
            return PartialView(values);
        }

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }

        public PartialViewResult PartialSidebar()
        {
            return PartialView();
        }

        public PartialViewResult PartialHeroSection()
        {
            return PartialView();
        }
    }
}