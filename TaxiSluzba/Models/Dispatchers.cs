using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace TaxiSluzba.Models
{
    public class Dispatchers
    {
        public List<Dispatcher> dispatchers { get; set; }

        public Dispatchers()
        {
            dispatchers = new List<Dispatcher>();
        }

        public Dispatchers(string path)
        {
            dispatchers = new List<Dispatcher>();
            string uri = HostingEnvironment.MapPath(path);
            FileStream stream = new FileStream(uri, FileMode.Open);
            StreamReader sr = new StreamReader(stream);
            string line = "";
            while((line = sr.ReadLine()) != null)
            {
                if (line == null || line == null)
                    break;

                string[] elements = line.Split('|');
                dispatchers.Add(new Dispatcher(Int32.Parse(elements[0]), elements[1], elements[2], elements[3], elements[4], elements[5], elements[6], elements[7], elements[8], elements[9]));
            }

            sr.Close();
            stream.Close();
        }
    }
}