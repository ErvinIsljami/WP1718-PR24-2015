using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiSluzba.Models
{
    public class Address
    {
        public string StreetName { get; set; }
        public string Town { get; set; }
        public int CityNumber { get; set; }

        public Address() { }

        public Address(string streetName, string town, int cityNumber)
        {
            StreetName = streetName;
            Town = town;
            CityNumber = cityNumber;
        }
    }
}