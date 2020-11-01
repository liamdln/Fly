using System;

namespace Fly
{
    public class Flight
    {
        public Flight(int flightId, string origin, string destination, string airline, int seatsAvailable, double price, DateTime flightDateTime)
        {
            FlightId = flightId;
            Origin = origin;
            Destination = destination;
            Airline = airline;
            SeatsAvailable = seatsAvailable;
            Price = price;
            FlightDateTime = flightDateTime;
        }

        public int FlightId { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string Airline { get; set; }
        public int SeatsAvailable { get; set; }
        public double Price { get; set; }
        public DateTime FlightDateTime { get; set; }

    }
}
