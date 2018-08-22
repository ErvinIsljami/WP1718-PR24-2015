using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiSluzba.Models
{
    public class Automobile
    {
        public string Driver { get; set; }
        public string Year { get; set; }
        public string Registration { get; set; }
        public int TaxiNumber { get; set; }
        public CarType Type{ get; set; }

        public Automobile() { }

        public Automobile(string driver, string year, string registration, int taxiNumber, string type)
        {
            Driver = driver;
            Year = year;
            Registration = registration;
            TaxiNumber = taxiNumber;
            Type = type.ToLower() == "regular" ? CarType.Regular : CarType.Van;

        }
    }
}