using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Fly
{
    public partial class MenuForm : Form
    {

        private bool bookClicked;
        private bool collectClicked;

        //testing:
        DBConnection connection = new DBConnection();
        //end testing

        public MenuForm()
        {
            InitializeComponent();
            //check if a button is clicked once. This is so that the text is displayed after one click
            this.bookClicked = false; 
            this.collectClicked = false;
        }

        public void ClearText()
        {

            //set the picture for the ticket collection
            ResetImage("data/images/collect_ticket.png");

            //picture for booking
            ResetImage("data/images/book_ticket.png");

            //make sure none of the buttons are active
            this.bookClicked = false;
            this.collectClicked = false;

        }

        private void ResetImage(string imageURL)
        {

            PictureBox picboxReference;

            if (imageURL.ToLower().Contains("book"))
            {
                picboxReference = btnBookTicket;
            } 
            else if (imageURL.ToLower().Contains("collect"))
            {
                picboxReference = btnCollectTicket;
            } else
            {
                picboxReference = picboxLogo;
            }

            picboxReference.ImageLocation = imageURL;
            picboxReference.SizeMode = PictureBoxSizeMode.CenterImage;
            picboxReference.SizeMode = PictureBoxSizeMode.Zoom;

        }

        public void Menu_Load(object sender, EventArgs e)
        {

            //set the logo in the picture box
            ResetImage("data/images/fly_logo_transparent.png");

            //set the pictures
            ClearText();

        }

        private void pb_book_Click(object sender, EventArgs e)
        {

            collectClicked = false;

            if (bookClicked == false)
            {

                //clear the pictures
                ClearText();

                //change the picture
                ResetImage("data/images/book_ticketTXT.png");
                bookClicked = true;

            }
            else
            {

                BookingForm bookingForm = new BookingForm(this);
                bookingForm.Show();
                ClearText();
                this.Hide();

            }

        }

        private void pb_ticket_collect_Click(object sender, EventArgs e)
        {

            bookClicked = false;

            if (collectClicked == false)
            {

                //clear the pictures
                ClearText();

                //change the picture
                ResetImage("data/images/collect_ticketTXT.png");
                collectClicked = true;

            }
            else
            {

                CollectTicketForm collectTicket = new CollectTicketForm(this);
                collectTicket.Show();
                ClearText();
                this.Hide();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Dictionary<string, string> areas = connection.GetAllAreas();

            foreach (KeyValuePair<string, string> kvp in areas)
            {
                MessageBox.Show(String.Format("Key = {0}, Value = {1}", kvp.Key, kvp.Value));
            }

        }
    }
}