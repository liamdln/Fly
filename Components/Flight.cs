using System;

namespace Fly
{
    public class Flight
    {
        public Flight(int flightID, string origin, string destination, string airline, int seatsAvailable, double price, DateTime flightDateTime)
        {
            this.flightID = flightID;
            this.origin = origin;
            this.destination = destination;
            this.airline = airline;
            this.seatsAvailable = seatsAvailable;
            this.price = price;
            this.flightDateTime = flightDateTime;
        }

        public int flightID { get; set; }
        public string origin { get; set; }
        public string destination { get; set; }
        public string airline { get; set; }
        public int seatsAvailable { get; set; }
        public double price { get; set; }
        public DateTime flightDateTime { get; set; }

    }
}
