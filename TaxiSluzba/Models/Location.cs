using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiSluzba.Models
{
    public class Location
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Address Address { get; set; }
        public Location() { }
        
        public Location(string x, string y, string streetName, string town,string cityNumber)
        {
            X = double.Parse(x);
            Y = double.Parse(y);
            Address = new Address(streetName, town, Int32.Parse(cityNumber));
        }
    }
}