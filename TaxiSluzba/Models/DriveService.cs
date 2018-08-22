using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiSluzba.Models
{
    public class DriveService
    {
        public int Id { get; set; }
        public DateTime OrderTime { get; set; }
        public Location StartingPoint { get; set; }
        public Location Destination { get; set; }
        public CarType Car { get; set; }
        public string Customer { get; set; }
        public string Dispatcher { get; set; }
        public string Driver { get; set; }
        public double Price { get; set; }
        public Status Status { get; set; }

        public DriveService() { }

        public DriveService(int id, DateTime orderTime, Location startingPoint, Location destination, CarType car, string customer, string dispatcher, string driver, double price, Status status)
        {
            Id = id;
            OrderTime = orderTime;
            StartingPoint = startingPoint;
            Destination = destination;
            Car = car;
            Customer = customer;
            Dispatcher = dispatcher;
            Driver = driver;
            Price = price;
            Status = status;
        }
    }
}