using MySql.Data.MySqlClient;
using System;
namespace Cruise_manager.Components.Data
{
    public class Database
    {
        public static void DatabaseStart() 
        {
            string connectionString = "Server=localhost;Database=cruise;User=root;Password=toor;Port=3306;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM cruises";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader["column_name"]);
                    }
                }
            }
        }
    }
}
