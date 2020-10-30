namespace Fly
{
    public class Ticket
    {
        public Ticket(string ticketId, string firstName, string lastName, string hashedCardNumber, bool collected, int flightID, int bookedSeats)
        {
            TicketId = ticketId;
            FirstName = firstName;
            LastName = lastName;
            HashedCardNumber = hashedCardNumber;
            Collected = collected;
            FlightID = flightID;
            BookedSeats = bookedSeats;
        }

        public string TicketId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HashedCardNumber { get; set; }
        public bool Collected { get; set; }
        public int FlightID { get; set; }
        public int BookedSeats { get; set; }

    }
}
