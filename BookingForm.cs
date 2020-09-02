using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Fly
{
    public partial class BookingForm : Form
    {

        //vars
        MySqlConnection connection;
        MySqlDataReader Reader;
        string DateOfFlight;
        string dateFromDB;
        bool roundTwo = false;
        int FlightFound = 0;
        bool badDB = false;
        List<string> destinationOfDestination = new List<string>();
        List<string> destinations = new List<string>();
        //List<string> flightIDs = new List<string>();
        string WinningDestination;
        bool FlightConnection = false;
        string dropdown_originText;
        string dropdown_destinationText;

        MenuForm menuForm;

        public BookingForm(MenuForm menuForm)
        {
            InitializeComponent();
            this.menuForm = menuForm;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.menuForm.Show();
            this.Close();


        }
        private void btn_search_Click(object sender, EventArgs e)
        {

            if (roundTwo == false)
            {

                dropdown_originText = dropdown_origin.Text;
                dropdown_destinationText = dropdown_destination.Text;

            }

            //set the date
            DateOfFlight = flightDate.Value.ToShortDateString();

            //set selection and table and reader
            string selection = "*";
            string selectedTable = "flights";

            //connect
            DBConnect(selection, selectedTable, false, "");

            bool killIf = false;

            while (Reader.Read())
            {

                if (dropdown_originText.Equals(Reader["origin"]))
                {

                    destinations.Add(Reader["destination"].ToString());

                }

                for (int i = 0; i <= destinations.Count - 1; i++)
                {

                    if (Reader["origin"].ToString().Equals(destinations[i]))
                    {

                        destinationOfDestination.Add(Reader["destination"].ToString());

                    }

                    if (destinationOfDestination.Contains(dropdown_destinationText))
                    {

                        WinningDestination = destinations[i];
                        FlightConnection = true;
                        i = destinations.Count - 1;

                    }

                }

                //check to see if there are any flights on this date form this origin to this destination
                if (Reader["origin"].Equals(dropdown_originText) && Reader["destination"].Equals(dropdown_destinationText) && Reader["dateOfFlight"].Equals(DateOfFlight))
                {

                    //add one to the number of flights found
                    FlightFound = FlightFound + 1;

                }

                if (DateOfFlight.Equals(Reader["dateOfFlight"]) && killIf == false)
                {

                    dateFromDB = Reader["dateOfFlight"].ToString();
                    killIf = true;

                }

                //testing
                //MessageBox.Show((Reader["flightID"].ToString() + Reader["from"] + Reader["to"] + Reader["airline"] + Reader["seatsAvailable"] + Reader["price"] + "   " + Reader["date"] + "   " + Reader["time"]));

            }

            //connection.Close();
            //we don't close the connection here because it it carried to the next form.

            //if there are no flights and all the data is filled in, display an error
            if (DateOfFlight.Equals(dateFromDB) == false && dropdown_originText.Equals("") == false && dropdown_destinationText.Equals("") == false && FlightConnection == false)
            {

                //create an error
                MessageBox.Show("There are no flights from your selected origin to your selected destination on this date.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            // if the info is filled in and there are flights on that date then open the form.
            else if (dropdown_originText.Equals("") == false && dropdown_destinationText.Equals("") == false)
            {

                //act if a flight was found, otherwise display an error
                if (FlightFound > 0)
                {

                    //open the new form
                    Reader.Close();
                    BookingListForm DBList = new BookingListForm(connection, DateOfFlight, dropdown_origin.Text, dropdown_destination.Text, "");
                    Hide();
                    DBList.Show();

                }
                else if (FlightConnection == true)
                {

                    //MessageBox.Show(WinningDestination);
                    //open the new form
                    Reader.Close();
                    BookingListForm DBList = new BookingListForm(connection, DateOfFlight, dropdown_origin.Text, dropdown_destination.Text, WinningDestination);
                    Hide();
                    DBList.Show();

                }
                else
                {

                    MessageBox.Show("There are no flights from your selected origin to your selected destination.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else //the info hasn't been fulled in
            {

                MessageBox.Show("Please full out all the requested information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void form_book_Load(object sender, EventArgs e)
        {

            //switch table
            DBConnect("*", "flights", false, "");
            GetFlightInfo();

        }

        public void DBConnect(string selectString, string tableString, bool customQuery, string otherQuery)
        {

            //set up database connection properties
            string server = "127.0.0.1"; //LOCAL SERVER, 127.0.0.1
            string database = "flydb"; //database name
            string uid = "flyProgram"; //uid for program
            string password = "local123!"; //password for program
            string ConnectionProperties = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";"; //set the properties
            string query = "";

            connection = new MySqlConnection(ConnectionProperties);
            OpenConnection(connection);

            if (!customQuery)
            {

                //query string 
                query = "SELECT " + selectString + " FROM " + tableString;
                MySqlCommand cmd = new MySqlCommand(query, connection);
                Reader = cmd.ExecuteReader();

            }
            else
            {

                query = otherQuery;
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();

            }

        }
        private bool OpenConnection(MySqlConnection connection)
        {
            try
            {

                connection.Open();
                return true;

            }
            catch (MySqlException exception)
            {

                //this shouldn't ever happen
                switch (exception.Number)
                {
                    case 1042: //server isn't talking to us
                        MessageBox.Show("Cannot contact database server. Please contact a member of staff.", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        badDB = true;
                        break;

                    case 1045: //wrong username or password
                        MessageBox.Show("The database credentials are incorrect. Please contact a member of staff.", "Credential error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        badDB = true;
                        break;

                    default: //we don't know what the error is
                        MessageBox.Show("An unknown error occurred. Please contact a member of staff.", "Unknown error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        badDB = true;
                        break;

                        //this is used to get the error codes.
                        //string code = exception.Number.ToString();
                        //MessageBox.Show(code);

                }

                while (badDB)
                {

                    MessageBox.Show("There is an error with this terminal. This error will persist until the terminal is fixed. Please use another terminal.", "Fatal Terminal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                return false;

            }

        }

        private void GetFlightInfo()
        {

            while (Reader.Read())
            {

                //get the origin and destination for the flights
                if (!dropdown_origin.Items.Contains(Reader["origin"]))
                {

                    dropdown_origin.Items.Add(Reader["origin"]);

                }
                if (!dropdown_destination.Items.Contains(Reader["destination"]))
                {

                    dropdown_destination.Items.Add(Reader["destination"]);

                }

            }

            connection.Close();
        }

    }
}