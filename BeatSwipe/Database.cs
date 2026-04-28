using MySql.Data.MySqlClient;

namespace BeatSwipe
{
    public static class Database
    {
        private static string connStr = "server=localhost;user=root;password=;database=beatswipe;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connStr);
        }
    }
}