using System;
using System.Windows.Forms;

namespace Fly
{
    public partial class MenuForm : Form
    {

        private bool _bookClicked;
        private bool _collectClicked;

        public MenuForm()
        {
            InitializeComponent();
            //check if a button is clicked once. This is so that the text is displayed after one click
            _bookClicked = false;
            _collectClicked = false;
        }

        private void ClearText()
        {

            //set the picture for the ticket collection
            ResetImage("data/images/collect_ticket.png");

            //picture for booking
            ResetImage("data/images/book_ticket.png");

            //make sure none of the buttons are active
            _bookClicked = false;
            _collectClicked = false;

        }

        private void ResetImage(string imageUrl)
        {

            PictureBox picboxReference;

            if (imageUrl.ToLower().Contains("book"))
            {
                picboxReference = btnBookTicket;
            }
            else if (imageUrl.ToLower().Contains("collect"))
            {
                picboxReference = btnCollectTicket;
            }
            else
            {
                picboxReference = picboxLogo;
            }

            picboxReference.ImageLocation = imageUrl;
            picboxReference.SizeMode = PictureBoxSizeMode.CenterImage;
            picboxReference.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void Menu_Load(object sender, EventArgs e)
        {

            //set the logo in the picture box
            ResetImage("data/images/fly_logo_transparent.png");

            //set the pictures
            ClearText();

        }

        private void pb_book_Click(object sender, EventArgs e)
        {

            _collectClicked = false;

            if (_bookClicked == false)
            {

                //clear the pictures
                ClearText();

                //change the picture
                ResetImage("data/images/book_ticketTXT.png");
                _bookClicked = true;

            }
            else
            {

                var bookingForm = new BookingForm(this);
                bookingForm.Show();
                ClearText();
                this.Hide();

            }

        }

        private void pb_ticket_collect_Click(object sender, EventArgs e)
        {

            _bookClicked = false;

            if (_collectClicked == false)
            {

                //clear the pictures
                ClearText();

                //change the picture
                ResetImage("data/images/collect_ticketTXT.png");
                _collectClicked = true;

            }
            else
            {

                var collectTicket = new CollectTicketForm(this);
                collectTicket.Show();
                ClearText();
                this.Hide();

            }
        }
    }
}