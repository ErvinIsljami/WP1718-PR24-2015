using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace TaxiSluzba.Models
{
    public class Users
    {
        public List<User> users { get; set; }
        public Users(string path)
        {
            string uri = HostingEnvironment.MapPath(path);
            users = new List<User>();
            FileStream stream = new FileStream(uri, FileMode.Open);
            StreamReader sr = new StreamReader(stream);
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                if (line == null || line == "")
                    break;

                string[] tokens = line.Split('|');
                users.Add(new User(users.Count, tokens[0], tokens[1], tokens[2], tokens[3], tokens[4], tokens[5], tokens[6], tokens[7], tokens[8]));
            }
            sr.Close();
            stream.Close();
        }
    }
}