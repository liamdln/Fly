using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Fly
{
    class DBConnection : IDBConnection
    {

        private const string DATABASE_URL = "127.0.0.1";
        private const string DATABASE_PORT = "3306";
        private const string DATABASE_NAME = "flydb";
        private const string DATABASE_UID = "bahrain-api";
        private const string DATABASE_PWD = "&#7goJk#!34ep@";

        private string connectionString;
        MySqlConnection connection;

        public DBConnection()
        {
            //server=localhost;port=3306;database=BahrainAPI;uid=bahrain-api;pwd=password;
            this.connectionString = String.Format("server={0};port={1};database={2};uid={3};pwd={4};", DATABASE_URL, DATABASE_PORT, DATABASE_NAME, DATABASE_UID, DATABASE_PWD);
            connection = new MySqlConnection(this.connectionString);
        }

        private MySqlDataReader pingDatabase(string query)
        {
            MySqlCommand getData = new MySqlCommand(query, this.connection);
            MySqlDataReader incomingDataReader = getData.ExecuteReader();

            return incomingDataReader;
        }

        private bool OpenConnection()
        {
            try
            {

                this.connection.Open();
                return true;

            }
            catch (MySqlException exception)
            {

                throw new DatabaseConnectionError(exception.Number);

            }
        }

        public bool CloseConnection()
        {
            try
            {
                this.connection.Close();
                return true;
            }
            catch (MySqlException exception)
            {
                throw new DatabaseConnectionError(exception);
            }
        }

        public void CreateTicket(Dictionary<string, string> ticketInformation)
        {
            throw new NotImplementedException();
        }

        public string GetAllAirlines()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, string> GetAllAreas()
        {

            OpenConnection();
            Dictionary<string, string> areas = new Dictionary<string, string>();

            //SELECT country,cities FROM areas;
            const string DB_SELECTION = "country, cities";
            const string DB_TABLE_NAME = "areas";

            string query = String.Format("SELECT {0} FROM {1}", DB_SELECTION, DB_TABLE_NAME);
            MySqlDataReader returnedData = pingDatabase(query);

            while (returnedData.Read())
            {
                areas.Add(returnedData["country"].ToString(), returnedData["cities"].ToString());
            }

            CloseConnection();
            return areas;

        }

        public Flight GetAllFlights()
        {
            throw new NotImplementedException();
        }

        public Ticket GetAllTickets()
        {
            throw new NotImplementedException();
        }

        public Flight GetFlightByID(int ID)
        {
            OpenConnection();
            Flight flightByID = null;

            //SELECT * FROM flights WHERE flightID = ID;
            const string DB_SELECTION = "flightID, origin, destination, airline, seatsAvailable, price, dateTime";
            const string DB_TABLE_NAME = "flights";
            string DB_WHERE_CONDITION = String.Format("flightID = {0}", ID);

            string query = String.Format("SELECT {0} FROM {1} WHERE {2}", DB_SELECTION, DB_TABLE_NAME, DB_WHERE_CONDITION);
            MySqlDataReader returnedData = pingDatabase(query);

            while (returnedData.Read())
            {

                flightByID = new Flight(
                    (int) returnedData["flightID"],
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

        public Ticket GetTicketByID(int ID)
        {
            OpenConnection();
            Ticket ticketByID = null;

            //SELECT * FROM flights WHERE flightID = ID;
            const string DB_SELECTION = "ticketID, firstName, lastName, cardNumber, collected, flightID, seatsOnBook";
            const string DB_TABLE_NAME = "tickets";
            string DB_WHERE_CONDITION = String.Format("ticketID = {0}", ID);

            string query = String.Format("SELECT {0} FROM {1} WHERE {2}", DB_SELECTION, DB_TABLE_NAME, DB_WHERE_CONDITION);
            MySqlDataReader returnedData = pingDatabase(query);

            while (returnedData.Read())
            {
                ticketByID = new Ticket(
                    (int) returnedData["ticketID"],
                    (string) returnedData["firstName"],
                    (string) returnedData["lastName"],
                    (string) returnedData["cardNumber"],
                    (int) returnedData["collected"] == 1, //1 = true, 0 = false so if db val = 1 then it has been collected.
                    (int) returnedData["flightID"],
                    (int) returnedData["seatsOnBook"]
                    );
            }

            CloseConnection();
            return ticketByID;
        }

        public void UpdateSeatsAvailable(int flightID)
        {
            throw new NotImplementedException();
        }

        public void UpdateTicketCollectionStatus(int ticketID)
        {
            throw new NotImplementedException();
        }
    }
}