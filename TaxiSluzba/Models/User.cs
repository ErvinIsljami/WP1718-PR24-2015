using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiSluzba.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public GENDER Gender { get; set; }
        public string JMBG { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public ROLE Role { get; set; }

        public User() { }

        public User(int id, string userName, string password, string name, string surname, string gender, string jMBG, string phone, string email, string role)
        {
            Id = id;
            UserName = userName;
            Password = password;
            Name = name;
            Surname = surname;
            JMBG = jMBG;
            Phone = phone;
            Email = email;

            if (gender.ToUpper() == "M")
                this.Gender = GENDER.M;
            else
                this.Gender = GENDER.F;
            this.Gender = gender.ToUpper() == "M" ? GENDER.M : GENDER.F;

            if (role.ToLower() == "driver")
                this.Role = ROLE.Driver;
            else if (role.ToLower() == "dispatcher")
                this.Role = ROLE.Dispatcher;
            else
                this.Role = ROLE.Customer;
        }
    }
}