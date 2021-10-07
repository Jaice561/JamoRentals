using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JamoRental.Models;

namespace JamoRental.Controllers
{
    public class CarDetailsController : Controller
    {
        private ApplicationDbContext _context;

        public CarDetailsController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();    
        }


        // GET: CarDetails
        public ActionResult Index()
        {
            var carDetail = _context.CarDetails.ToList();

            return View("CarDetails", carDetail);
        }
    }
}