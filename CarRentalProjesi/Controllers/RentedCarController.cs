using CarRentalProjesi.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarRentalProjesi.Controllers
{
    public class RentedCarController : Controller
    {
        CarRentalDBEntities1 db = new CarRentalDBEntities1();
        // GET: RentedCar
        public ActionResult RentedCar()
        {
            var values = db.tbl_RentedCar.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult NewRentedCar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewRentedCar(tbl_RentedCar p4)
        {
            db.tbl_RentedCar.Add(p4);
            db.SaveChanges();
            return View();
        }
    }
}