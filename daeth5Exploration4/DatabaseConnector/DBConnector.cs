using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using MySql.Data.MySqlClient;


namespace daeth5Exploration4.DatabaseConnector
{
    public class DBConnector
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public DBConnector()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            uid = "stripessql";
            database = "expo";
            password = "stripessqldatabase";
            string connectionString = "SERVER=" + server + ";" +
                                      "uid=" + uid + ";" +
                                      "password=" + password + ";" +
                                      "database=" + database + ";";
            connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
        public void InsertNewName(string name)
        {
            OpenConnection();
            {
                try
                {
                    MySqlCommand comm = connection.CreateCommand();

                    comm.CommandText = $"INSERT INTO example (name, date) VALUES ({name}, NOW());";

                    comm.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            CloseConnection();
        } 
    }
}