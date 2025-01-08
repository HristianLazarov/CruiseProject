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
        public static async Task<List<Cruises>> GetCruises()
        {
            string connectionString = "Server=localhost;Database=cruise;User=root;Password=toor;Port=3306;";
            List<Cruises> cruiseList = new List<Cruises>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT cruise_id, location_from, location_to, departure_datetime, arrival_datetime, cruise_type, unique_cruise_number, captain_name, passenger_capacity, business_class_capacity FROM Cruises";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = (MySqlDataReader)await command.ExecuteReaderAsync()) // Async reading
                    {
                        while (await reader.ReadAsync()) // Async read
                        {
                            var cruise = new Cruises(
                                reader["location_from"].ToString(),
                                reader["location_to"].ToString(),
                                Convert.ToDateTime(reader["departure_datetime"]),
                                Convert.ToDateTime(reader["arrival_datetime"]),
                                reader["cruise_type"].ToString(),
                                reader["unique_cruise_number"].ToString(),
                                reader["captain_name"].ToString(),
                                Convert.ToInt32(reader["passenger_capacity"]),
                                Convert.ToInt32(reader["business_class_capacity"])
                            );

                            cruiseList.Add(cruise);
                        }
                    }
                }
            }

            return cruiseList;
        }

    }
}
