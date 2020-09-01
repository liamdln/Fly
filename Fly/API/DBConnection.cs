using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fly
{
    class DBConnection : IDBConnection
    {

        private const string DATABASE_URL = "127.0.0.1";
        private const string DATABASE_PORT = "3306";
        private const string DATABASE_NAME = "flyStore";
        private const string DATABASE_UID = "bahrain-api";
        private const string DATABASE_PWD = "&#7goJk#!34ep@";

        private string connectionString;
        MySqlConnection connection;

        public DBConnection()
        {
            //server=localhost;port=3306;database=BahrainAPI;uid=bahrain-api;pwd=&#7goJk#!34ep@;
            this.connectionString = String.Format("server={0};port={1};database={2};uid={3};pwd={4};", DATABASE_URL, DATABASE_PORT, DATABASE_NAME, DATABASE_UID, DATABASE_PWD);
            connection = new MySqlConnection(this.connectionString);
            OpenConnection();
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
            } catch (MySqlException exception)
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

        public string GetAllAreas()
        {
            throw new NotImplementedException();
        }

        public string GetAllFlights()
        {
            throw new NotImplementedException();
        }

        public string GetAllTickets()
        {
            throw new NotImplementedException();
        }

        public string GetFlightByID(int ID)
        {
            throw new NotImplementedException();
        }

        public string GetTicketByID(int ID)
        {
            throw new NotImplementedException();
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
