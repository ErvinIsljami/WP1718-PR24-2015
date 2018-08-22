using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiSluzba.Models
{
    public class Dispatcher : User
    {
        public Dispatcher() : base() { }

        public Dispatcher(int id, string username, string password, string name, string surname, string gender, string jmbg, string phone, string email, string role) : base(id, username, password, name, surname, gender, jmbg, phone, email, role) { }
    }
}