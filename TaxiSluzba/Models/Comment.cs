using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiSluzba.Models
{
    public class Comment
    {
        public string Destricption { get; set; }
        public DateTime Date { get; set; }
        public string UserName { get; set; }
        public int Rating { get; set; }
        public int DriveId { get; set; }

        public Comment() { }

        public Comment(string destricption, DateTime date, string userName, int rating, int driveId)
        {
            Destricption = destricption;
            Date = date;
            UserName = userName;
            Rating = rating;
            DriveId = driveId;
        }
    }
}