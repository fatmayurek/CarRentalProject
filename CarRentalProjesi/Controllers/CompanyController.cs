using CarRentalProjesi.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarRentalProjesi.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        CarRentalDBEntities1 db = new CarRentalDBEntities1();
      
        public ActionResult Company()
        {
            var values = db.tbl_Company.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult NewCompany()
        {

            return View();
        }
        [HttpPost]
        public ActionResult NewCompany(tbl_Company p2)
        {
            db.tbl_Company.Add(p2);
            db.SaveChanges();
            return RedirectToAction("Company");
        }
    }
}