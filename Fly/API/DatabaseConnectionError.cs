using MySql.Data.MySqlClient;
using System;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace Fly
{
    [Serializable]
    internal class DatabaseConnectionError : Exception
    {
        public DatabaseConnectionError()
        {
        }

        public DatabaseConnectionError(int sqlErrorCode)
        {
            switch (sqlErrorCode)
            {
                case 1042: //no response from server
                    MessageBox.Show("Cannot contact database server. Please contact a member of staff.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case 1045: //incorrect creds
                    MessageBox.Show("The database credentials are incorrect. Please contact a member of staff.", "Credential Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                default: //any other errors
                    MessageBox.Show("An unknown error occurred.", "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

            }
        }

        public DatabaseConnectionError(MySqlException errorMessage)
        {
            Console.WriteLine(errorMessage);
        }

    }
}