using CarRentalProjesi.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarRentalProjesi.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars
        CarRentalDBEntities1 db = new CarRentalDBEntities1();

        public ActionResult Cars()
        {
            var values = db.tbl_Car.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult NewCar()
        {          
            return View();
        }
        [HttpPost]
        public ActionResult NewCar(tbl_Car p1)
        {
            db.tbl_Car.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Cars");
        }
        public ActionResult DeleteCar(int id)
        {
            var car = db.tbl_Car.Find(id);
            db.tbl_Car.Remove(car);
            db.SaveChanges();
            return RedirectToAction("Cars");
        }
    }
}