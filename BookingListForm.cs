using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Fly
{
    public partial class BookingListForm : Form
    {

        private bool _showDetails = true;
        private DBConnection _database = new DBConnection();
        private readonly List<Flight> _matchingFlights;
        private readonly BookingForm _bookingForm;
        private readonly string[] _userChoices;

        public BookingListForm(List<Flight> matchingFlights, BookingForm bookingForm, string[] userChoices)
        {
            InitializeComponent();
            _matchingFlights = matchingFlights;
            _bookingForm = bookingForm;
            _userChoices = userChoices;
        }


        private void ToggleDetails()
        {

            _showDetails = !_showDetails;
            //hide the controls
            if (_showDetails)
            {
                groupbox_flight.Show();
                btn_book.Text = "Book selected flight";
                btn_book.Enabled = true;
            }
            else
            {
                groupbox_flight.Hide();
                btn_book.Text = "Please select a time to book a flight.";
                btn_book.Enabled = false;
            }

        }

        private void listingBookingForm_Load(object sender, EventArgs e)
        {

            //hide all the details for selected flight until a time is selected
            ToggleDetails();

            foreach (var flight in _matchingFlights)
            {
                FlightTimesDropDown.Items.Add(flight.flightDateTime.TimeOfDay);
            }

            lbl_from.Text = $@"Origin: {_userChoices[0]}";
            lbl_to.Text = $@"Destination: {_userChoices[1]}";
            lbl_date.Text = $@"Date: {_userChoices[2]}";

/*
            //set all the data to the variables in th program
            while (Reader.Read())
            {

                if (!FlightConnections.Equals("") && Reader["origin"].ToString().Equals(selectedOrigin) && Reader["destination"].ToString().Equals(FlightConnections))
                {

                    dropdown_times.Items.Add("Time: " + Reader["time"] + ". Connection Required.");

                }

                //make sure we have the data for the date chosen
                if (Reader["dateOfFlight"].Equals(flightDate) && Reader["origin"].Equals(selectedOrigin) && Reader["destination"].Equals(selectedDest))
                {
                    //read the data and allocate it to the correct control on the form
                    dropdown_times.Items.Add("Time: " + Reader["time"] + " ID: " + Reader["flightID"]);
                }

            }

            Reader.Close();

            if (!FlightConnections.Equals(""))
            {

                lbl_airline.Text = ("Airline: Multiple");

            }
            else
            {

                lbl_airline.Text = ("Airline: <None Selected>");

            }

            lbl_date.Text = ("Date: " + flightDate);
            lbl_from.Text = ("Origin: " + selectedOrigin);
            lbl_to.Text = ("Destination: " + selectedDest);*/

        }


        private void dropdown_times_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //show the controls
            ToggleDetails();

            int flightIndex = FlightTimesDropDown.SelectedIndex;
            
            //change all the values in the info box
            //$ for string interpolation, @ to tell compiler to ignore escape characters (e.g. \n)
            lbl_flightno.Text = $@"Flight ID: #{_matchingFlights[flightIndex].flightID}";
            lbl_origin.Text = $@"Flight Origin: {_matchingFlights[flightIndex].origin}";
            lbl_destination.Text = $@"Flight destination: {_matchingFlights[flightIndex].destination}";
            lbl_seatsAvailable.Text = $@"Seats available: {_matchingFlights[flightIndex].seatsAvailable}" ;
            lbl_price.Text = $@"Price: £{_matchingFlights[flightIndex].price}";
            lbl_avAirline.Text = $@"Airline: {_matchingFlights[flightIndex].airline}";
            lbl_avDate.Text = $@"Date: {_matchingFlights[flightIndex].flightDateTime}";
            
            //user selected items
            // in future, selecting an airline on the booking form will be a feature so will be populated when
            // the user enters this form, like the user's desired origin, destination and time.
            lbl_airline.Text = $@"Airline: {_matchingFlights[flightIndex].airline}";



/*
            //show the controls
            ToggleDetails();

            //get all the flight info from the db
            //query
            string query = ("SELECT * FROM flights");

            //connect to db
*/ /*            BookingForm.DBConnect("*", "flights", false, "");*/ /*

            //declare reader
            MySqlCommand cmd = new MySqlCommand(query, connectionString);
            MySqlDataReader Reader = cmd.ExecuteReader();

            while (Reader.Read())
            {
                //if the right time and flightID is selected
                if (dropdown_times.Text.Equals("Time: " + Reader["time"] + " ID: " + Reader["flightID"]))
                {
                    //get the flight id
                    flightID = Reader["flightID"].ToString();
                    //get the seats available
                    seatsAvailable = Reader["seatsAvailable"].ToString();

                    //change all the values in the info box
                    lbl_flightno.Text = ("Flight ID: " + Reader["flightID"]);
                    lbl_origin.Text = ("Flight Origin: " + Reader["origin"]);
                    lbl_destination.Text = ("Flight destination: " + Reader["destination"]);
                    lbl_seatsAvailable.Text = ("Seats available: " + Reader["seatsAvailable"]);
                    lbl_price.Text = ("Price: £" + Reader["price"]);
                    lbl_avAirline.Text = ("Airline: " + Reader["airline"]);
                    lbl_avDate.Text = ("Date: " + Reader["dateOfFlight"]);
                    lbl_airline.Text = ("Airline: " + Reader["airline"]);


                    flightInfoArray = new string[] { Reader["flightID"].ToString(), Reader["origin"].ToString(), Reader["destination"].ToString(), Reader["airline"].ToString(), Reader["dateOfFlight"].ToString(), Reader["time"].ToString(), Reader["price"].ToString() };

                    if (Reader["seatsAvailable"].Equals("0"))
                    {

                        btn_book.Enabled = false;
                        btn_book.Text = "Flight is full!";

                    }

                }

                if (!FlightConnections.Equals(""))
                {

                    lbl_destination.Hide();

                    if (Reader["origin"].Equals(selectedOrigin) && Reader["destination"].Equals(FlightConnections))
                    {

                        flightID = flightID + Reader["flightID"].ToString() + ":";
                        lbl_flightno.Text = lbl_flightno.Text + Reader["flightID"].ToString() + ":";
                        lbl_price.Text = lbl_price.Text + Reader["price"].ToString() + ":";
                        lbl_avAirline.Text = lbl_avAirline.Text + Reader["airline"] + ":";
                        lbl_origin.Text = lbl_origin.Text + Reader["origin"].ToString() + "-->" + Reader["destination"].ToString() + ":";
                        lbl_seatsAvailable.Text = lbl_seatsAvailable.Text + Reader["seatsAvailable"].ToString() + ":";
                        lbl_avDate.Text = lbl_avDate.Text + Reader["dateOfFlight"].ToString() + ":";

                        if (Reader["seatsAvailable"].Equals("0"))
                        {

                            btn_book.Enabled = false;
                            btn_book.Text = "Flight is full!";

                        }

                    }

                    if (Reader["origin"].Equals(FlightConnections) && Reader["destination"].Equals(selectedDest))
                    {

                        flightID = flightID + Reader["flightID"] + ":";
                        lbl_flightno.Text = lbl_flightno.Text + Reader["flightID"].ToString() + ":";
                        lbl_price.Text = lbl_price.Text + Reader["price"].ToString() + ":";
                        lbl_avAirline.Text = lbl_avAirline.Text + Reader["airline"] + ":";
                        lbl_origin.Text = lbl_origin.Text + Reader["origin"].ToString() + "-->" + Reader["destination"].ToString() + ":";
                        lbl_seatsAvailable.Text = lbl_seatsAvailable.Text + Reader["seatsAvailable"].ToString() + ":";
                        lbl_avDate.Text = lbl_avDate.Text + Reader["dateOfFlight"].ToString() + ":";

                        if (Reader["seatsAvailable"].Equals("0"))
                        {

                            btn_book.Enabled = false;
                            btn_book.Text = "Flight is full!";

                        }

                    }

                }

            }

            Reader.Close();*/

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

            _bookingForm.Show();
            Close();

        }

        private void btn_book_Click(object sender, EventArgs e)
        {

/*            SearchTicketForm details = new SearchTicketForm("listBookingForm", flightID, seatsAvailable, flightInfoArray);
            details.Show();
            Close();*/

        }
    }
}