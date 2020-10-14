using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Fly
{
    public partial class BookingForm : Form
    {


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
                    MessageBox.Show($@"No flights found from {origin} to {destination} on {date:dd MMMM yyyy}.", @"No Flights", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            } 
            else
            {
                //origin == destination
                MessageBox.Show(@"The origin and destination cannot be the same.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}