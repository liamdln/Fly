using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fly
{
    static class DBConnection
    {

        private const string DATABASE_URL = "127.0.0.1";
        private const string DATABASE_PORT = "3306";
        private const string DATABASE_NAME = "flydb";
        private const string DATABASE_UID = "bahrain-api";
        private const string DATABASE_PWD = "&#7goJk#!34ep@";

        private static string _connectionString = String.Format("server={0};port={1};database={2};uid={3};pwd={4};", DATABASE_URL, DATABASE_PORT, DATABASE_NAME, DATABASE_UID, DATABASE_PWD);
        private static MySqlConnection _connection = new MySqlConnection(_connectionString);

        private static MySqlDataReader ReadDatabase(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, _connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        private static long InsertIntoDatabase(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, _connection);
            cmd.ExecuteNonQuery();

            return cmd.LastInsertedId;
        }

        private static bool OpenConnection()
        {
            try
            {

                // create a connection pool instead of opening and closing connections.
                _connection.Open();
                return true;

            }
            catch (MySqlException exception)
            {

                throw new DatabaseConnectionError(exception.Number);

            }
        }

        private static bool CloseConnection()
        {
            try
            {
                _connection.Close();
                return true;
            }
            catch (MySqlException exception)
            {
                throw new DatabaseConnectionError(exception);
            }
        }

        public static int CreateTicket(Ticket newTicket)
        {
            OpenConnection();
            const string TABLE = "tickets";
            const string COLUMN_NAMES = "firstName, lastName, cardNumber, collected, flightId, seatsOnBook";

            int ticketCollected = newTicket.Collected ? 1 : 0;

            string query = String.Format($"INSERT INTO {TABLE} ({COLUMN_NAMES}) VALUES ('{newTicket.FirstName}', '{newTicket.LastName}', '{newTicket.EncryptedCardNumber}', {ticketCollected}, {newTicket.FlightId}, {newTicket.BookedSeats});");
            int ticketId = (int)InsertIntoDatabase(query);

            CloseConnection();

            return ticketId;

        }

        public static List<string> GetAllAirlines()
        {
            OpenConnection();
            List<string> airlines = new List<string>();

            const string DB_SELECTION = "name";
            const string DB_TABLE_NAME = "airlines";

            string query = String.Format("SELECT {0} FROM {1}", DB_SELECTION, DB_TABLE_NAME);
            MySqlDataReader returnedData = ReadDatabase(query);

            while (returnedData.Read())
            {
                airlines.Add((string)returnedData["name"]);
            }

            CloseConnection();
            return airlines;
        }

        public static Dictionary<string, string> GetAllAreas()
        {

            OpenConnection();
            Dictionary<string, string> areas = new Dictionary<string, string>();

            const string DB_SELECTION = "country, cities";
            const string DB_TABLE_NAME = "areas";

            string query = String.Format("SELECT {0} FROM {1}", DB_SELECTION, DB_TABLE_NAME);
            MySqlDataReader returnedData = ReadDatabase(query);

            while (returnedData.Read())
            {
                areas.Add(returnedData["country"].ToString(), returnedData["cities"].ToString());
            }

            CloseConnection();
            return areas;

        }

        public static List<Flight> GetAllFlights()
        {
            OpenConnection();
            List<Flight> flights = new List<Flight>();

            const string DB_SELECTION = "flightId, origin, destination, airline, seatsAvailable, price, dateTime";
            const string DB_TABLE_NAME = "flights";

            string query = String.Format("SELECT {0} FROM {1}", DB_SELECTION, DB_TABLE_NAME);
            MySqlDataReader returnedData = ReadDatabase(query);

            while (returnedData.Read())
            {

                flights.Add(new Flight(
                    (int)returnedData["flightId"],
                    (string)returnedData["origin"],
                    (string)returnedData["destination"],
                    (string)returnedData["airline"],
                    (int)returnedData["seatsAvailable"],
                    (double)returnedData["price"],
                    (DateTime)returnedData["dateTime"]
                    ));
            }

            CloseConnection();
            return flights;
        }

        public static List<Ticket> GetAllTickets()
        {
            OpenConnection();
            List<Ticket> tickets = new List<Ticket>();

            const string DB_SELECTION = "firstName, lastName, cardNumber, collected, flightId, seatsOnBook";
            const string DB_TABLE_NAME = "tickets";

            string query = String.Format("SELECT {0} FROM {1}", DB_SELECTION, DB_TABLE_NAME);
            MySqlDataReader returnedData = ReadDatabase(query);

            while (returnedData.Read())
            {
                tickets.Add(new Ticket(
                    (string)returnedData["firstName"],
                    (string)returnedData["lastName"],
                    (string)returnedData["cardNumber"],
                    (int)returnedData["collected"] == 1, //1 = true, 0 = false so if db val = 1 then it has been collected.
                    (int)returnedData["flightId"],
                    (int)returnedData["seatsOnBook"]
                    ));
            }

            CloseConnection();
            return tickets;
        }

        public static Flight GetFlightById(int ID)
        {
            OpenConnection();
            Flight flightByID = null;

            const string DB_SELECTION = "flightId, origin, destination, airline, seatsAvailable, price, dateTime";
            const string DB_TABLE_NAME = "flights";
            string DB_WHERE_CONDITION = String.Format("flightId = {0}", ID);

            string query = String.Format("SELECT {0} FROM {1} WHERE {2}", DB_SELECTION, DB_TABLE_NAME, DB_WHERE_CONDITION);
            MySqlDataReader returnedData = ReadDatabase(query);

            while (returnedData.Read())
            {

                flightByID = new Flight(
                    (int) returnedData["flightId"],
                    (string) returnedData["origin"],
                    (string) returnedData["destination"],
                    (string) returnedData["airline"],
                    (int) returnedData["seatsAvailable"],
                    (double) returnedData["price"],
                    (DateTime) returnedData["dateTime"]
                    );
            }

            CloseConnection();
            return flightByID;

        }

        public static Ticket GetTicketById(int Id)
        {
            OpenConnection();
            Ticket ticketByID = null;

            const string DB_SELECTION = "firstName, lastName, cardNumber, collected, flightId, seatsOnBook";
            const string DB_TABLE_NAME = "tickets";
            string DB_WHERE_CONDITION = String.Format("ticketId = {0}", Id);

            string query = String.Format("SELECT {0} FROM {1} WHERE {2}", DB_SELECTION, DB_TABLE_NAME, DB_WHERE_CONDITION);
            MySqlDataReader returnedData = ReadDatabase(query);

            while (returnedData.Read())
            {
                ticketByID = new Ticket(
                    (string) returnedData["firstName"],
                    (string) returnedData["lastName"],
                    (string) returnedData["cardNumber"],
                    (int) returnedData["collected"] == 1, //1 = true, 0 = false so if db val = 1 then it has been collected.
                    (int) returnedData["flightId"],
                    (int) returnedData["seatsOnBook"]
                    );
            }

            CloseConnection();
            return ticketByID;
        }

        public static void UpdateSeatsAvailable(int flightId)
        {
            throw new NotImplementedException();
        }

        public static void UpdateTicketCollectionStatus(int ticketId)
        {
            throw new NotImplementedException();
        }

        public static List<Flight> GetMatchingFlights(string origin, string destination, DateTime date)
        {
            OpenConnection();
            List<Flight> flights = new List<Flight>();

            const string DB_SELECTION = "flightId, origin, destination, airline, seatsAvailable, price, dateTime";
            const string DB_TABLE_NAME = "flights";
            string DB_WHERE_CONDITION = String.Format("origin='{0}' AND destination='{1}' AND CAST(dateTime AS DATE) = '{2}'", origin, destination, date.ToString("yyyy-MM-dd"));

            string query = String.Format("SELECT {0} FROM {1} WHERE {2}", DB_SELECTION, DB_TABLE_NAME, DB_WHERE_CONDITION);
            MySqlDataReader returnedData = ReadDatabase(query);

            while (returnedData.Read())
            {

                flights.Add(new Flight(
                    (int)returnedData["flightId"],
                    (string)returnedData["origin"],
                    (string)returnedData["destination"],
                    (string)returnedData["airline"],
                    (int)returnedData["seatsAvailable"],
                    (double)returnedData["price"],
                    (DateTime)returnedData["dateTime"]
                    ));
            }

            CloseConnection();
            return flights;
        }
    }
}