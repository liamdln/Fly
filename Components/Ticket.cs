namespace Fly
{
    public class Ticket
    {
        public Ticket(int ticketID, string firstName, string lastName, string hashedCardNumber, bool collected, int flightID, int bookedSeats)
        {
            this.ticketID = ticketID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.hashedCardNumber = hashedCardNumber;
            this.collected = collected;
            this.flightID = flightID;
            this.bookedSeats = bookedSeats;
        }

        public int ticketID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string hashedCardNumber { get; set; }
        public bool collected { get; set; }
        public int flightID { get; set; }
        public int bookedSeats { get; set; }

    }
}
