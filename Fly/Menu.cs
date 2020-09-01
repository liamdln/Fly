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
    public partial class Menu : Form
    {

        //vars
        private bool BookClicked = false; //check if a button is clicked once. This is so that the text is displayed after one click
        private bool CollectClicked = false; //same as above but for the other button.

        public Menu()
        {
            InitializeComponent();
        }

        public void Menu_Load(object sender, EventArgs e)
        {

            //set the logo in the picture box
            pb_logo.ImageLocation = "data/images/fly_logo_transparent.png";
            pb_logo.SizeMode = PictureBoxSizeMode.CenterImage;
            pb_logo.SizeMode = PictureBoxSizeMode.Zoom;

            //set the pictures
            clearText();

        }

        private void pb_book_Click(object sender, EventArgs e)
        {

            CollectClicked = false;

            if (BookClicked == false)
            {

                //clear the pictures
                clearText();

                //change the picture
                pb_book.ImageLocation = "data/images/book_ticketTXT.png";
                pb_book.SizeMode = PictureBoxSizeMode.CenterImage;
                pb_book.SizeMode = PictureBoxSizeMode.Zoom;

                BookClicked = true;

            }
            else
            {

                form_book book = new form_book();
                book.Show();
                Hide();

            }

        }

        public void clearText()
        {

            //changes all the photos to show no text when one is clicked and when the form is loaded

            //set the picture for the ticket collection
            pb_ticket_collect.ImageLocation = "data/images/collect_ticket.png";
            pb_ticket_collect.SizeMode = PictureBoxSizeMode.CenterImage;
            pb_ticket_collect.SizeMode = PictureBoxSizeMode.Zoom;

            //picture for booking
            pb_book.ImageLocation = "data/images/book_ticket.png";
            pb_book.SizeMode = PictureBoxSizeMode.CenterImage;
            pb_book.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void pb_ticket_collect_Click(object sender, EventArgs e)
        {

            BookClicked = false;

            if (CollectClicked == false)
            {

                //clear the pictures
                clearText();

                //change the picture
                pb_ticket_collect.ImageLocation = "data/images/collect_ticketTXT.png";
                pb_ticket_collect.SizeMode = PictureBoxSizeMode.CenterImage;
                pb_ticket_collect.SizeMode = PictureBoxSizeMode.Zoom;

                CollectClicked = true;

            }
            else
            {

                //form_book book = new form_book();

                //OKAY SO LISTEN UP:
                //this is from the "form_book" form 
                //it was moved here to supply the collection form with DB connection details
                //in future maybe move the db connection to this form so there isnt a duplicate

                //at this point the form "form_collectTicker" (nice spelling) was created 

                //the database stuff was moved to collectTicker form

                form_collectTicker collect = new form_collectTicker();
                collect.Show();
                Hide();

            }
        }
    }
}