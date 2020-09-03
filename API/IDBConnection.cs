using System;
using System.Collections.Generic;

namespace Fly
{
    interface IDBConnection
    {

        List<Ticket> GetAllTickets();
        List<Flight> GetAllFlights();
        Dictionary<string, string> GetAllAreas();
        List<string> GetAllAirlines();

        List<Flight> GetMatchingFlights(string origin, string destination, DateTime date);

        Ticket GetTicketByID(int ID);
        Flight GetFlightByID(int ID);

        void UpdateSeatsAvailable(int flightID);
        void UpdateTicketCollectionStatus(int ticketID);

        void CreateTicket(Dictionary<string, string> ticketInformation);

    }
}
