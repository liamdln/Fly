using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Fly
{
    public partial class BookingListForm : Form
    {

        private bool _showDetails = true;
        private readonly List<Flight> _matchingFlights;
        private readonly BookingForm _bookingForm;
        private readonly string[] _userChoices;
        private Flight _selectedFlight;

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
                FlightTimesDropDown.Items.Add(flight.FlightDateTime.TimeOfDay);
            }

            lbl_from.Text = $"Origin: {_userChoices[0]}";
            lbl_to.Text = $"Destination: {_userChoices[1]}";
            lbl_date.Text = $"Date: {_userChoices[2]}";


        }


        private void dropdown_times_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //show the controls
            ToggleDetails();

            _selectedFlight = (Flight)FlightTimesDropDown.SelectedItem;
            
            //change all the values in the info box
            //$ for string interpolation, @ to tell compiler to ignore escape characters (e.g. \n)
            lbl_flightno.Text = $@"Flight ID: #{_selectedFlight.FlightID}";
            lbl_origin.Text = $@"Flight Origin: {_selectedFlight.Origin}";
            lbl_destination.Text = $@"Flight destination: {_selectedFlight.Destination}";
            lbl_seatsAvailable.Text = $@"Seats available: {_selectedFlight.SeatsAvailable}" ;
            lbl_price.Text = $@"Price: £{_selectedFlight.Price}";
            lbl_avAirline.Text = $@"Airline: {_selectedFlight.Airline}";
            lbl_avDate.Text = $@"Date: {_selectedFlight.FlightDateTime}";
            
            //user selected items
            // in future, selecting an airline on the booking form will be a feature so will be populated when
            // the user enters this form, like the user's desired origin, destination and time.
            lbl_airline.Text = $@"Airline: {_selectedFlight.Airline}";


        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

            _bookingForm.Show();
            Close();

        }

        private void btn_book_Click(object sender, EventArgs e)
        {

            var searchTicketForm = new SearchTicketForm(this, _selectedFlight);
            searchTicketForm.Show();
            Close();

/*            SearchTicketForm details = new SearchTicketForm("listBookingForm", flightID, seatsAvailable, flightInfoArray);
            details.Show();
            Close();*/

        }
    }
}