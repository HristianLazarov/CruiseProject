using MySql.Data.MySqlClient;
using System;
using Cruise_manager.Components.Pages;
namespace Cruise_manager.Components.Data
{
    public class Database
    {
        public static void AddWorkerToDB(Workers worker) 
        {
            string connectionString = "Server=localhost;Database=cruise;User=root;Password=toor;Port=3306;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string querry = "INSERT INTO Users (username, password, email, first_name, last_name, egn, address, phone_number) VALUES (@username, @password, @email, @first_name, @last_name, @egn, @address, @phone_number)";
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(querry, connection))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@username", worker.UserName);
                        cmd.Parameters.AddWithValue("@password", worker.Password);
                        cmd.Parameters.AddWithValue("@email", worker.Email);
                        cmd.Parameters.AddWithValue("@first_name", worker.Fname);
                        cmd.Parameters.AddWithValue("@last_name", worker.Lname);
                        cmd.Parameters.AddWithValue("@egn", worker.EGN);
                        cmd.Parameters.AddWithValue("@address", worker.Address);
                        cmd.Parameters.AddWithValue("@phone_number", worker.Phone);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Show message
                        Console.WriteLine($"Rows affected: {rowsAffected}");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
