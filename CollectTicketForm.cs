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
using System.Security.Cryptography;
using System.IO;

namespace Fly
{
    public partial class CollectTicketForm : Form
    {

        //vars
        MySqlDataReader Reader;
        string seatsAvailable;
        string flightID;
        string[] flightInfoArray;
        string seatsOnBook;
        bool badDB = false;

        //encryption strings, used in Encryption class
        static readonly string PasswordHash = "f1yPr0gr@m!";
        static readonly string SaltKey = "sEEs@1t!";
        static readonly string VIKey = "J0nV1nd1ct1v3009";

        MenuForm menuForm;

        public CollectTicketForm(MenuForm menuForm)
        {
            InitializeComponent();
            this.menuForm = menuForm;
        }

        private void form_collectTicker_Load(object sender, EventArgs e)
        {

            lbl_firstName.Hide();
            lbl_lastName.Hide();
            lbl_cardNo.Hide();
            txt_firstName.Hide();
            txt_lastName.Hide();
            txt_cardNo.Hide();

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

            this.menuForm.Show();
            Close();

        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            //vars
            List<string> tickets = new List<string>();

            DBConnect("ticketID", "tickets", false, null);

            while (Reader.Read())
            {

                tickets.Add(Reader["ticketID"].ToString());

            }

            if (!tickets.Contains(txt_ticketID.Text))
            {

                MessageBox.Show("Invalid Ticket ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                lbl_firstName.Show();
                lbl_lastName.Show();
                lbl_cardNo.Show();
                txt_firstName.Show();
                txt_lastName.Show();
                txt_cardNo.Show();

            }

        }

        //THIS IS COPIED FROM FORM_BOOK, WE WILL RE WRITE IT IN THE MENU SO IT DOESN'T APPEAR TWICE

        public void DBConnect(string selectString, string tableString, bool customQuery, string otherQuery)
        {

            //set up database connection properties
            string server = "127.0.0.1"; //LOCAL SERVER, 127.0.0.1
            string database = "flydb"; //database name
            string uid = "flyProgram"; //uid for program
            string password = "local123!"; //password for program
            string ConnectionProperties = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";"; //set the properties
            string query = "";

            MySqlConnection connection = new MySqlConnection(ConnectionProperties);
            OpenConnection(connection);

            if (!customQuery)
            {

                //query string 
                query = "SELECT " + selectString + " FROM " + tableString;
                MySqlCommand cmd = new MySqlCommand(query, connection);
                Reader = cmd.ExecuteReader();

            }
            else
            {

                query = otherQuery;
                MySqlCommand cmd = new MySqlCommand(query, connection);
                Reader = cmd.ExecuteReader();

            }

        }
        private bool OpenConnection(MySqlConnection connection)
        {
            try
            {

                connection.Open();
                return true;

            }
            catch (MySqlException exception)
            {

                //this shouldn't ever happen
                switch (exception.Number)
                {
                    case 1042: //server isn't talking to us
                        MessageBox.Show("Cannot contact database server. Please contact a member of staff.", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        badDB = true;
                        break;

                    case 1045: //wrong username or password
                        MessageBox.Show("The database credentials are incorrect. Please contact a member of staff.", "Credential error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        badDB = true;
                        break;

                    default: //we don't know what the error is
                        MessageBox.Show("An unknown error occurred. Please contact a member of staff.", "Unknown error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        badDB = true;
                        break;

                        //this is used to get the error codes.
                        //string code = exception.Number.ToString();
                        //MessageBox.Show(code);

                }

                while (badDB)
                {

                    MessageBox.Show("There is an error with this terminal. This error will persist until the terminal is fixed. Please use another terminal.", "Fatal Terminal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                return false;

            }

        }

        private void btn_collect_Click(object sender, EventArgs e)
        {

            string cardNo = "";

            if (!txt_cardNo.Text.Length.Equals(16))
            {

                MessageBox.Show("Invalid card number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                DBConnect("", "", true, "SELECT * FROM tickets WHERE ticketID = '" + txt_ticketID.Text + "'");

                while (Reader.Read())
                {

                    cardNo = Decrypt(Reader["cardNumber"].ToString());
                    seatsOnBook = Reader["seatsOnBook"].ToString();

                    if (Reader["firstName"].ToString().Equals(txt_firstName.Text) && Reader["lastName"].ToString().Equals(txt_lastName.Text) && cardNo.Equals(txt_cardNo.Text))
                    {

                        if (Reader["collected"].ToString().Equals("0"))
                        {

                            Random rnd = new Random();
                            int randomNumber = rnd.Next(1, 1000000);

                            string copyFile = "data/FlyTicket" + cardNo + randomNumber + ".txt";

                            //System.IO.File.Create(copyFile);
                            System.IO.File.Copy("data/FlyTicket.txt", copyFile, false);

                            string ticketFile = System.IO.File.ReadAllText(copyFile);

                            //get all data

                            string[] itemsToEdit = { "$name", "$surname", "$cardnumber", "$ticketid", "$flightid", "$origin", "$destination", "$airline", "$date", "$time", "$price" };

                            string hashedCard = "**** **** **** " + cardNo.Substring(12, cardNo.Length - 12);

                            DBConnect("", "", true, "SELECT * FROM flights WHERE flightID = '" + txt_ticketID.Text.Substring(0, 5) + "'");

                            while (Reader.Read())
                            {

                                seatsAvailable = Reader["seatsAvailable"].ToString();
                                flightID = Reader["flightID"].ToString();

                                flightInfoArray = new string[] { Reader["flightID"].ToString(), Reader["origin"].ToString(), Reader["destination"].ToString(), Reader["airline"].ToString(), Reader["dateOfFlight"].ToString(), Reader["time"].ToString(), Reader["price"].ToString() };

                            }

                            ticketFile = ticketFile.Replace(itemsToEdit[0], txt_firstName.Text);
                            ticketFile = ticketFile.Replace(itemsToEdit[1], txt_lastName.Text);
                            ticketFile = ticketFile.Replace(itemsToEdit[2], hashedCard);
                            ticketFile = ticketFile.Replace(itemsToEdit[3], flightID + seatsOnBook);

                            for (int alpha = 4; alpha <= 10; alpha++)
                            {

                                ticketFile = ticketFile.Replace(itemsToEdit[alpha], flightInfoArray[alpha - 4]);

                            }

                            System.IO.File.WriteAllText(copyFile, ticketFile);

                            //send the data to the database
                            string query = "UPDATE tickets SET collected = 1 WHERE ticketID = '" + txt_ticketID.Text + "'";
                            DBConnect("", "", true, query);

                            MessageBox.Show("Your ticket is being printed, please take it to the check in desk to pay.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MenuForm menu = new Fly.MenuForm();
                            menu.Show();
                            Close();

                        }
                        else
                        {

                            MessageBox.Show("This ticket has been collected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {

                        MessageBox.Show("The details you have entered do not match the details associated with that ticket.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }

            }

        }

        private static string Decrypt(string EncTxt)
        {

            //script from https://social.msdn.microsoft.com/Forums/vstudio/en-US/d6a2836a-d587-4068-8630-94f4fb2a2aeb/encrypt-and-decrypt-a-string-in-c?forum=csharpgeneral 

            byte[] cipherTextBytes = Convert.FromBase64String(EncTxt);
            byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.None };

            var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));
            var memoryStream = new MemoryStream(cipherTextBytes);
            var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];

            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount).TrimEnd("\0".ToCharArray());

        }

    }
}