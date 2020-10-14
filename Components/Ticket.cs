namespace Fly
{
    public class Ticket
    {
        public Ticket(int ticketID, string firstName, string lastName, string hashedCardNumber, bool collected, int flightID, int bookedSeats)
        {
            this.TicketID = ticketID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.HashedCardNumber = hashedCardNumber;
            this.Collected = collected;
            this.FlightID = flightID;
            this.BookedSeats = bookedSeats;
        }

        public int TicketID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HashedCardNumber { get; set; }
        public bool Collected { get; set; }
        public int FlightID { get; set; }
        public int BookedSeats { get; set; }

    }
}
