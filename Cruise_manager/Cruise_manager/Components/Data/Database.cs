using MySql.Data.MySqlClient;
using System;
namespace Cruise_manager.Components.Data
{
    public class Database
    {
        static void DatabaseStart() 
        {
            string connectiontring = "Server=Cruise;Database=cruise;User ID=root;Password=toor;";
            using (MySqlConnection connection = new MySqlConnection(connectiontring))
            {
            }
        }
    }
}
