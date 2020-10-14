using System;

namespace Fly
{
    public class Flight
    {
        public Flight(int flightID, string origin, string destination, string airline, int seatsAvailable, double price, DateTime flightDateTime)
        {
            this.FlightID = flightID;
            this.Origin = origin;
            this.Destination = destination;
            this.Airline = airline;
            this.SeatsAvailable = seatsAvailable;
            this.Price = price;
            this.FlightDateTime = flightDateTime;
        }

        public int FlightID { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string Airline { get; set; }
        public int SeatsAvailable { get; set; }
        public double Price { get; set; }
        public DateTime FlightDateTime { get; set; }

    }
}
