using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiSluzba.Models
{
    public class Driver : User
    {
        public Location Location { get; set; }

        public Automobile Car {get;set;}

        public bool Available { get; set; }

        public Driver() : base()
        {
            Available = true;
        }

        public Driver(int id, string userName, string password, string name, string surname, string gender, string jMBG, string phone, string email, string role, string year, string registration, int taxiNumber, string type, string x, string y, string streetName, string town, string cityNumber) : base(id, userName, password, name, surname, gender, jMBG, phone, email, role)
        {
            Available = true;
            Location = new Location(x, y, streetName, town, cityNumber);
            Car = new Automobile(userName, year, registration, taxiNumber, type);
        }
    }
}