using CarRentalProjesi.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarRentalProjesi.Controllers
{
    public class PersonLoginController : Controller
    {
        CarRentalDBEntities1 db = new CarRentalDBEntities1();
        // GET: PersonLogin
        public ActionResult PersonLogin()
        {
            var values = db.tbl_Person.ToList();
            return View(values);

        }
    }
}