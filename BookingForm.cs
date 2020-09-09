using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Fly
{
    public partial class BookingForm : Form
    {

/*        //vars
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
        string dropdown_destinationText;*/


        private readonly MenuForm _menuForm;
        private readonly DBConnection _database = new DBConnection();
        private readonly List<string> _originList;
        private readonly List<string> _destList;

        public BookingForm(MenuForm menuForm)
        {
            InitializeComponent();
            _menuForm = menuForm;

            _destList = new List<string>();
            _originList = new List<string>();
        }

        private void form_book_Load(object sender, EventArgs e)
        {
            PopulateSourceLists();
            DestinationDropDown.DataSource = _destList;
            OriginDropDown.DataSource = _originList;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            _menuForm.Show();
            Close();
        }

        private void PopulateSourceLists()
        {

            var areas = _database.GetAllAreas();

            foreach (var kvp in areas)
            {
                foreach (var city in kvp.Value.Split(','))
                {

                    _originList.Add($"{city}, {kvp.Key}");
                    _destList.Add($"{city}, {kvp.Key}");

                }
            }

        }

        private void OriginDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            //remove the item selected from the other list, we don't want people to book from London to London
        }

        private void DestinationDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            //same as above
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            //can clean this up, or make a method to get just the city.
            var origin = OriginDropDown.Text.Split(',')[0].Replace(" ", "");
            var destination = DestinationDropDown.Text.Split(',')[0].Replace(" ", "");
            var date = flightDate.Value.Date;

            if (!origin.Equals(destination))
            {
                var matchingFlights = _database.GetMatchingFlights(origin, destination, date);

                if (matchingFlights.Count != 0)
                {

                    string[] userChoices = {origin, destination, date.ToString("dd-MM-yyyy")};
                    var listFlights = new BookingListForm(matchingFlights, this, userChoices);
                    listFlights.Show();
                    Hide();

                }
                else
                {
                    //matchingFlights list has no values
                    MessageBox.Show($@"No flights found from {origin} to {destination} on {date.ToString("dd MMMM yyyy")}.", @"No Flights", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            } 
            else
            {
                //origin == destination
                MessageBox.Show(@"The origin and destination cannot be the same.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

/*
            if (roundTwo == false)
            {

                dropdown_originText = OriginDropDown.Text;
                dropdown_destinationText = DestinationDropDown.Text;

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
                    BookingListForm DBList = new BookingListForm(connection, DateOfFlight, OriginDropDown.Text, DestinationDropDown.Text, "");
                    Hide();
                    DBList.Show();

                }
                else if (FlightConnection == true)
                {

                    //MessageBox.Show(WinningDestination);
                    //open the new form
                    Reader.Close();
                    BookingListForm DBList = new BookingListForm(connection, DateOfFlight, OriginDropDown.Text, DestinationDropDown.Text, WinningDestination);
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

            }*/
        }
    }
}