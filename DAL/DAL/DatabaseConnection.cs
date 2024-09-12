using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL
{
    public class DatabaseConnection
    {
        public MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;


        public DatabaseConnection()
        {
            Initialize();
        }


        private void Initialize()
        {
            string connectionString;
            connectionString = $"SERVER=127.0.0.1;DATABASE=reminder;UID=root;PASSWORD=Cilio0410;";

            connection = new MySqlConnection(connectionString);
        }

        // Open connection to database
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {

                return false;
            }
        }

        // Close connection to database
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {

                return false;
            }
        }
    }
}
