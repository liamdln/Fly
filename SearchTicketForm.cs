﻿using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

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

        public SearchTicketForm(string formSender, string flightID, string Seats, string[] flightInfoArray)
        {

            InitializeComponent();
            setting = formSender;
            flightNo = flightID;
            seatsAvailable = Seats;
            FlightInfo = flightInfoArray;

        }

        private void form_details_Load(object sender, EventArgs e)
        {

            //disable the ticked ID box if the person is booking the ticket because it is generated for them
            if (setting.Equals("listBookingForm"))
            {

                txtBox_ticketNumber.Enabled = false;
                txtBox_ticketNumber.Text = flightNo + seatsAvailable;

            }
            else
            {

                //enable it so people can input their ticket number if collecting a ticket
                txtBox_ticketNumber.Enabled = true;
                btn_saveTicket.Enabled = false;

            }

        }

        private void btn_saveTicket_Click(object sender, EventArgs e)
        {

            //check the card number is valid
            if (txtBox_cardNumber.TextLength != 16)
            {

                MessageBox.Show("That is not a valid card number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                //encrypt the card number and pass it onto the updatedb sub
                updateDB("save", Encrypt(txtBox_cardNumber.Text));

                MessageBox.Show("Your ticket was saved. To collect your ticket, click 'Collect Ticket' on the menu and follow the instructions.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MenuForm menu = new Fly.MenuForm();
                menu.Show();
                Close();

            }
        }

        public static string Encrypt(string plainText)
        {

            //script from https://social.msdn.microsoft.com/Forums/vstudio/en-US/d6a2836a-d587-4068-8630-94f4fb2a2aeb/encrypt-and-decrypt-a-string-in-c?forum=csharpgeneral 

            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
            var encryptor = symmetricKey.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));

            byte[] cipherTextBytes;

            using (var memoryStream = new System.IO.MemoryStream())
            {

                using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {

                    cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                    cryptoStream.FlushFinalBlock();
                    cipherTextBytes = memoryStream.ToArray();
                    cryptoStream.Close();

                }

                memoryStream.Close();

            }

            return Convert.ToBase64String(cipherTextBytes);

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

                updateDB("print", Encrypt(txtBox_cardNumber.Text));

                MessageBox.Show("Your ticket is being printed, please take it to the check in desk to pay.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MenuForm menu = new Fly.MenuForm();
                menu.Show();
                Close();

                //test 1:
                //couldnt find the file, even though we told it to copy :/
                //test 2:
                //fixed, there was an issue with the file path
                //test 3:
                //mysql is having a go at me now
                //test 4
                //mysql has been put in it's place.
                //test 5
                //The text just isn't changing now...
                //test 6
                //working perfectly

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
            string query = "INSERT INTO tickets (ticketID, firstName, lastName, cardNumber, collected, flightID, seatsOnBook) VALUES ('" + txtBox_ticketNumber.Text + "', '" + txtBox_firstName.Text + "', '" + txtBox_lastName.Text + "', '" + encryptedCardNo + "', '" + collected + "', '" + flightNo + "', '" + seatsAvailable + "')";
            BookingForm bookForm = new BookingForm(new MenuForm());
            bookForm.DBConnect("", "", true, query);

            int numSeats = Convert.ToInt32(seatsAvailable);

            query = "UPDATE flights SET seatsAvailable = '" + (numSeats - 1).ToString() + "' WHERE flightID = '" + flightNo + "'";
            bookForm.DBConnect("", "", true, query);

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

            MenuForm menu = new Fly.MenuForm();
            menu.Show();
            Close();

        }
    }
}