using Fly.Components;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Fly
{

    public partial class SearchTicketForm : Form
    {

        //variables
        string setting = "";
        string flightNo;
        string seatsAvailable;
        string[] FlightInfo;

        //encryption strings, used in Encryption class
        static readonly string PasswordHash = "f1yPr0gr@m!";
        static readonly string SaltKey = "sEEs@1t!";
        static readonly string VIKey = "J0nV1nd1ct1v3009";

        // rremove above

        private readonly BookingListForm _bookingListForm;
        private readonly Flight _selectedFlight;
        private const bool DEFAULT_COLLECTED_VALUE = false;

        public SearchTicketForm(BookingListForm bookingListForm, Flight selectedFlight)
        {

            InitializeComponent();
            _bookingListForm = bookingListForm;
            _selectedFlight = selectedFlight;

        }

        private void form_details_Load(object sender, EventArgs e)
        {
            // will do something here
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            _bookingListForm.Show();
            Close();
        }

        private void btn_saveTicket_Click(object sender, EventArgs e)
        {

            UserCard card = new UserCard(txtBox_cardNumber.Text);

            if (!card.IsValid)
            {
                MessageBox.Show("Card number is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                //encrypt the card number and pass it onto the updatedb sub
                Ticket newTicket = new Ticket(txtBox_firstName.Text, txtBox_lastName.Text, Cipher.Encrypt(txtBox_cardNumber.Text), DEFAULT_COLLECTED_VALUE, _selectedFlight.FlightId, _selectedFlight.SeatsAvailable);
                int ticketId = DBConnection.CreateTicket(newTicket);

                DisplayId displayId = new DisplayId(ticketId);
                displayId.Show();

                // move below msgbox to the display thing
                //MessageBox.Show("Your ticket was saved. To collect your ticket, click 'Collect Ticket' on the menu and follow the instructions.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MenuForm menu = new Fly.MenuForm();
                menu.Show();
                Close();

            }
        }

        private void btn_printTicket_Click(object sender, EventArgs e)
        {

            //check the card number is valid
            if (txtBox_cardNumber.TextLength != 16)
            {
                MessageBox.Show("That is not a valid card number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Random rnd = new Random();
                int randomNumber = rnd.Next(1, 1000000);

                string copyFile = "data/FlyTicket" + txtBox_cardNumber.Text + randomNumber + ".txt";

                //System.IO.File.Create(copyFile);
                System.IO.File.Copy("data/FlyTicket.txt", copyFile, false);

                string ticketFile = System.IO.File.ReadAllText(copyFile);

                //get all data
                string name = txtBox_firstName.Text;
                string surname = txtBox_lastName.Text;
                string cardnumber = txtBox_cardNumber.Text;

                string[] itemsToEdit = { "$name", "$surname", "$cardnumber", "$ticketid", "$flightid", "$origin", "$destination", "$airline", "$date", "$time", "$price" };

                string hashedCard = "**** **** **** " + cardnumber.Substring(12, cardnumber.Length - 12);

                ticketFile = ticketFile.Replace(itemsToEdit[0], name);
                ticketFile = ticketFile.Replace(itemsToEdit[1], surname);
                ticketFile = ticketFile.Replace(itemsToEdit[2], hashedCard);
                ticketFile = ticketFile.Replace(itemsToEdit[3], flightNo + seatsAvailable);

                for (int alpha = 4; alpha <= 10; alpha++)
                {

                    ticketFile = ticketFile.Replace(itemsToEdit[alpha], FlightInfo[alpha - 4]);

                }

                System.IO.File.WriteAllText(copyFile, ticketFile);

                //updateDB("print", Encrypt(txtBox_cardNumber.Text));

                MessageBox.Show("Your ticket is being printed, please take it to the check in desk to pay.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MenuForm menu = new Fly.MenuForm();
                menu.Show();
                Close();

            }
        }

        private void updateDB(string sender, string encryptedCardNo)
        {

            string collected;
            string secretCardNo;
            secretCardNo = encryptedCardNo;

            if (sender.Equals("print"))
            {

                collected = "1";

            }
            else
            {

                collected = "0";

            }

            //send the data to the database
            //string query = "INSERT INTO tickets (ticketID, firstName, lastName, cardNumber, collected, flightID, seatsOnBook) VALUES ('" + txtBox_ticketNumber.Text + "', '" + txtBox_firstName.Text + "', '" + txtBox_lastName.Text + "', '" + encryptedCardNo + "', '" + collected + "', '" + flightNo + "', '" + seatsAvailable + "')";
            BookingForm bookForm = new BookingForm(new MenuForm());
/*            bookForm.DBConnect("", "", true, query);*/

            int numSeats = Convert.ToInt32(seatsAvailable);

            //query = "UPDATE flights SET seatsAvailable = '" + (numSeats - 1).ToString() + "' WHERE flightID = '" + flightNo + "'";
/*            bookForm.DBConnect("", "", true, query);*/

        }
    }
}
