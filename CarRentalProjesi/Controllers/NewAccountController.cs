using CarRentalProjesi.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarRentalProjesi.Controllers
{
    public class NewAccountController : Controller
    {
        // GET: NewAccount    
        CarRentalDBEntities1 db = new CarRentalDBEntities1();
        //public ActionResult NewAccount()
        //{
        //    var values = db.tbl_Person.ToList();
        //    return View(values);
        //}

        [HttpGet]
        public ActionResult NewAccount()
        {

            return View();
        }
        [HttpPost]
        public ActionResult NewAccount(tbl_Person p3)
        {
            db.tbl_Person.Add(p3);
            db.SaveChanges();
            return RedirectToAction("Person","Person");
        }
    }
}