using CarRentalProjesi.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarRentalProjesi.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        CarRentalDBEntities1 db = new CarRentalDBEntities1();

        public ActionResult Person()
        {
            var values = db.tbl_Person.ToList(); 
            return View(values);
        }
    }
}