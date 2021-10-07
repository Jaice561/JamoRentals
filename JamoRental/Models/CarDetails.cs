using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JamoRental.Models
{
    // The details of the cars
    public class CarDetails
    {
        public int Id { get; set; }
        public Double CarMileage { get; set; }
        public string CarDiscription { get; set; }
        public string CarColor { get; set; }
    }
}