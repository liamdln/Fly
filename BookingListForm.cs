using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Fly
{
    public partial class BookingListForm : Form
    {

        //declare variables for all methods
        MySqlConnection connectionString;
        string flightDate;
        string selectedOrigin;
        string selectedDest;
        string flightID = "";
        string seatsAvailable = "";
        string[] flightInfoArray;
        BookingForm BookingForm = new BookingForm(new MenuForm());
        string FlightConnections = "";

        public BookingListForm(MySqlConnection connection, string DateOfFlight, string origin, string destination, string connections)
        {
            InitializeComponent();

            //grab variables form the last form
            connectionString = connection;
            flightDate = DateOfFlight;
            selectedOrigin = origin;
            selectedDest = destination;
            FlightConnections = connections;

        }

        private void listingBookingForm_Load(object sender, EventArgs e)
        {

            //hide all the details for selected flight until a time is selected
            HideShow("hide");

            //query
            string query = ("SELECT * FROM flights");

            //declare reader
            MySqlCommand cmd = new MySqlCommand(query, connectionString);
            MySqlDataReader Reader = cmd.ExecuteReader();

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
            lbl_to.Text = ("Destination: " + selectedDest);

        }

        private void HideShow(string hideOrShow)
        {
            //hide the controls
            if (hideOrShow.Equals("hide"))
            {

                groupbox_flight.Hide();
                btn_book.Text = "Please select a time to book a flight.";
                btn_book.Enabled = false;

            }
            else if (hideOrShow.Equals("show"))//show the controls
            {

                groupbox_flight.Show();
                btn_book.Text = "Book selected flight";
                btn_book.Enabled = true;

            }

        }

        private void dropdown_times_SelectedIndexChanged(object sender, EventArgs e)
        {

            //show the controls
            HideShow("show");

            //get all the flight info from the db
            //query
            string query = ("SELECT * FROM flights");

            //connect to db
            BookingForm.DBConnect("*", "flights", false, "");

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

            Reader.Close();

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

            BookingForm.Show();
            Close();

        }

        private void btn_book_Click(object sender, EventArgs e)
        {

            SearchTicketForm details = new SearchTicketForm("listBookingForm", flightID, seatsAvailable, flightInfoArray);
            details.Show();
            Close();

        }
    }
}