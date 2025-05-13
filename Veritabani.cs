using MySql.Data.MySqlClient;

namespace FilmArsiviOtomasyonu
{
    public static class Veritabani
    {
        private static string connectionString = "Server=localhost;Database=FilmArsivi;Uid=root;Pwd=your_password;";

        private static MySqlConnection connection;

        public static void Baglan()
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        public static void Kapat()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public static MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
