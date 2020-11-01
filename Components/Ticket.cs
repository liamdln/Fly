namespace Fly
{
    public class Ticket
    {
        public Ticket(string firstName, string lastName, string encryptedCardNumber, bool collected, int flightId, int bookedSeats, int id = 0)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            EncryptedCardNumber = encryptedCardNumber;
            Collected = collected;
            FlightId = flightId;
            BookedSeats = bookedSeats;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EncryptedCardNumber { get; set; }
        public bool Collected { get; set; }
        public int FlightId { get; set; }
        public int BookedSeats { get; set; }

    }
}
