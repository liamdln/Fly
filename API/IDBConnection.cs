using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fly
{
    interface IDBConnection
    {

        string GetAllTickets();
        string GetAllFlights();
        string GetAllAreas();
        string GetAllAirlines();

        string GetTicketByID(int ID);
        string GetFlightByID(int ID);

        void UpdateSeatsAvailable(int flightID);
        void UpdateTicketCollectionStatus(int ticketID);

        void CreateTicket(Dictionary<string, string> ticketInformation);

    }
}
