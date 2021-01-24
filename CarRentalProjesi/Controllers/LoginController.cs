using CarRentalProjesi.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarRentalProjesi.Controllers
{
    public class LoginController : Controller
    {
        CarRentalDBEntities1 db = new CarRentalDBEntities1();
        // GET: Login
        public ActionResult Login()
        {
            var values = db.tbl_User.ToList();
            return View(values);
            
        }
    }
}