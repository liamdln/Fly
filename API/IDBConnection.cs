using System.Collections.Generic;

namespace Fly
{
    interface IDBConnection
    {

        Ticket GetAllTickets();
        Flight GetAllFlights();
        Dictionary<string, string> GetAllAreas();
        string GetAllAirlines();

        Ticket GetTicketByID(int ID);
        Flight GetFlightByID(int ID);

        void UpdateSeatsAvailable(int flightID);
        void UpdateTicketCollectionStatus(int ticketID);

        void CreateTicket(Dictionary<string, string> ticketInformation);

    }
}
